using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Reflection;
using DotNetMatrix;
using ApproximationEngine;

namespace PLQuench
{
	public partial class fPLFitter : Form
	{
		bool m_lineClicked = false;

		public fPLFitter()
		{
			InitializeComponent();

			if (cbFitEngine.Items.Count == 0)
			{
				string[] str = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath), "appr_*.dll", SearchOption.TopDirectoryOnly);
				cbFitEngine.Items.Clear();
				foreach (string s in str)
					cbFitEngine.Items.Add(Path.GetFileName(s).Remove(0, 5).Replace(".dll", ""));
				if (cbFitEngine.Items.Count != 0)
					cbFitEngine.SelectedIndex = 0;
			}
			tcQuenching.Series[0].Add(0, -10);
			tcQuenching.Series[0].Add(5, 50);
			tcQuenching.Series[0].Add(10, 120);
			SetBorder(50, 50);
		}

		private void cbDataSelected_SelectedIndexChanged(object sender, EventArgs e)
		{
			pgDataFitParameters.SelectedObject = cbDataSelected.SelectedItem;
		}

		private void miPaste_Click(object sender, EventArgs e)
		{
			char[] sep = {'\n', '\t', ' '};
			string[] data = Clipboard.GetText().Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Split(sep, StringSplitOptions.RemoveEmptyEntries);
			PLQData dataobj = new PLQData(dgvData, tcQuenching, tcDistribution);
			for (int i = 0; (i + 1) < data.Length; i += 2)
				dataobj.AddPoint(double.Parse(data[i]), double.Parse(data[i + 1]));
			dataobj.RefreshInput();
			dataobj.RefreshQuenchingGraph(miNormQuenching.Checked);
			dataobj.RefreshDistributionGraph();
			dataobj.RefreshApproximation(miNormQuenching.Checked);
			cbDataSelected.Items.Add(dataobj);
			cbDataSelected.SelectedIndex = cbDataSelected.Items.Count - 1;

		}

		private void miImport_Click(object sender, EventArgs e)
		{
			if (ofdImport.ShowDialog() != DialogResult.OK) return;
			char[] sep = { ' ', '\t', '\n'};
			StreamReader sr = File.OpenText(ofdImport.FileName);
			string[] data = sr.ReadToEnd().Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Split(sep, StringSplitOptions.RemoveEmptyEntries);
			sr.Close();
			PLQData dataobj = new PLQData(dgvData, tcQuenching, tcDistribution);
			for (int i = 0; (i + 1) < data.Length; i += 2)
				dataobj.AddPoint(double.Parse(data[i]), double.Parse(data[i + 1]));
			dataobj.RefreshInput();
			dataobj.RefreshQuenchingGraph(miNormQuenching.Checked);
			dataobj.RefreshDistributionGraph();
			dataobj.RefreshApproximation(miNormQuenching.Checked);
			cbDataSelected.Items.Add(dataobj);
			cbDataSelected.SelectedIndex = cbDataSelected.Items.Count - 1;
		}

		private void miFit_Click(object sender, EventArgs e)
		{
			Assembly a = Assembly.LoadFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "appr_" + cbFitEngine.Text + ".dll"));
			object engine = null;
			foreach (Type t in a.GetTypes())
				if (t.GetInterface("IApprEngine") != null)
					engine = Activator.CreateInstance(t);
			if (engine == null) return;
			PLQData dataobj = (PLQData)cbDataSelected.SelectedItem;
			((IApprEngine)engine).FitFunction = FitFunction;
			((IApprEngine)engine).ProgressFunction = ShowProgressFunc;
			double[] parameters = dataobj.FitParameters;
			string s = ((IApprEngine)engine).Fit(PLQData.ParametersCount, dataobj.PointsCount - dataobj.PointsCount * int.Parse(tbTailPercent.Text) / 100 - 1, ref parameters, double.Parse(tbAccuracy.Text), int.Parse(tbIterations.Text), dataobj.GetMinValues(), dataobj.GetMaxValues());
			dataobj.FitParameters = parameters;
			dataobj.RefreshDistributionGraph();
			dataobj.RefreshApproximation(miNormQuenching.Checked);
			char[] sep = { ' ' };
			lStatus.Text = "SD = " + lStatus.Text.Split(sep)[2] + " " + s;
			pbFitProgress.Value = 100;
			pgDataFitParameters.Refresh();
		}

		void FitFunction(ref double[] x, ref double[] fvec, ref double[,] fjac, ref int iflag)
		{
			double[] grad = new double[PLQData.ParametersCount + 1];
			PLQData dataobj = (PLQData)cbDataSelected.SelectedItem;
			GeneralMatrix distribution = dataobj.CalculateDistribution(x[1], x[2]);
			if (iflag == 1)
				for (int j = 0; j < dataobj.PointsCount - dataobj.PointsCount * int.Parse(tbTailPercent.Text) / 100 - 1; j++)
				{
					fvec[j + 1] = 0;
					for (int i = dataobj.PointsCount * int.Parse(tbTailPercent.Text) / 100; i < dataobj.PointsCount; i++)
						fvec[j + 1] += (dataobj.Data.GetElement(i, 1) - dataobj.GetApproximationPoint(distribution, dataobj.Data.GetElement(i, 0), x[1]));
				}
			else if (iflag == 2)
			{
				/*for (int j = 0; j < tcUrbach.Series.Groups[0].Series.Count; j++)
				{
					T = double.Parse(tcUrbach.Series.Groups[0].Series[j].Title.Remove(0, 4).Replace(" K", ""));
					for (int k = 0; k < tcUrbach.Series.Groups[0].Series[j].Count; k++)
					{
						urb.GetGradient(x, tcUrbach.Series.Groups[0].Series[j].XValues[k], T, ref grad);
						expr = (tcUrbach.Series.Groups[0].Series[j].YValues[k] - Math.Log(urb.GetUrbach(tcUrbach.Series.Groups[0].Series[j].XValues[k], T)));
						for (int i = 1; i <= Urbach.ParametersCount; i++)
							fjac[i, j + 1] = -2 * expr / (-expr + tcUrbach.Series.Groups[0].Series[j].YValues[k]) * grad[j + 1];
					}
				}*/
			}
		}

		void ShowProgressFunc(ref double[] x, double f,	ref double[] g)
		{
			lStatus.Text = "SD = " + f.ToString();
			if (pbFitProgress.Value == 100)
				pbFitProgress.Value = 0;
			pbFitProgress.Value = pbFitProgress.Value + 5;
		}

		void SetBorder(double Xp, double Yp)
		{
			double min = tcQuenching.Axes.Bottom.MinXValue;
			double width = tcQuenching.Axes.Bottom.MaxXValue - min;
			tcQuenching.Series[0].XValues[0] = min + (1 - Xp / 100) * width;
			tcQuenching.Series[0].XValues[1] = min + (1 - Xp / 100) * width;
			tcQuenching.Series[0].XValues[2] = min + (1 - Xp / 100) * width;
			tcQuenching.Series[0].YValues[1] = Yp;
			tcQuenching.Series[0].Repaint();
		}

		private void line1_Click(object sender, MouseEventArgs e)
		{
			m_lineClicked = true;
		}

		private void tcQuenching_MouseUp(object sender, MouseEventArgs e)
		{
			m_lineClicked = false;
		}

		private void tcQuenching_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) 
				if (m_lineClicked)
				{
					double Xp = 100 - e.X * 100 / tcQuenching.Width;
					SetBorder(Xp, 100 - e.Y * 100 / tcQuenching.ClientRectangle.Height - 5);
					tbTailPercent.Text = Xp.ToString();
				}
		}

		private void tcQuenching_MouseDown(object sender, MouseEventArgs e)
		{
			
		}

		private void line1_MouseLeave(object sender, EventArgs e)
		{
			//m_lineClicked = false;
		}

		private void miCopyData_Click(object sender, EventArgs e)
		{
			string s = "";
			Steema.TeeChart.TChart tc = tcDistribution;
			if (tcQuenching.Focused) tc = tcQuenching;
			int i, j, max = 0;
			for (i = 1; i < tc.Series.Count; i++)
				if (tc.Series[i].Count > max) max = tc.Series[i].Count;
			for (i = 0; i < max; i++)
			{
				for (j = 1; j < tc.Series.Count; j++)
					if (i < tc.Series[j].Count) s += tc.Series[j][i].X.ToString() + "\t" + tc.Series[j][i].Y.ToString() + "\t";
					else s += "\t\t";
				s += "\n";
			}
			Clipboard.Clear();
			Clipboard.SetText(s.Replace("\t\n", "\n"));
		}

		private void copyBitmapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Steema.TeeChart.TChart tc = tcDistribution;
			if (tcQuenching.Focused) tc = tcQuenching;
			Bitmap b = new Bitmap(tc.Width, tc.Height);
			tc.Parent.DrawToBitmap(b, tc.ClientRectangle);
			//tcOneAtom.DrawToBitmap(b, tcOneAtom.ClientRectangle); // does not work in TeeChart Lite
			Clipboard.SetImage(Image.FromHbitmap(b.GetHbitmap()));
		}

		private void miCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(dgvData.GetClipboardContent());
		}

	}
}