using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace SemiFit
{
    public partial class fSemiFit : Form
    {
		private DataPoint m_dataPoint = null;
		double m_boundX, m_boundY;
        public fSemiFit()
        {
            InitializeComponent();
			Assembly a = Assembly.GetAssembly(typeof(FitFunctions.FitFunction));
			foreach (Type t in a.GetTypes())
				if (t.BaseType == typeof(FitFunctions.FitFunction))
				{
					tvFunctions.Nodes[0].Nodes.Add(t.Name.Remove(0, 2));
					tvFunctions.Nodes[0].Nodes[tvFunctions.Nodes[0].Nodes.Count - 1].Tag = Activator.CreateInstance(t);
				}


			string[] str = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath), "appr_*.dll", SearchOption.TopDirectoryOnly);
			cbAlgorithm.Items.Clear();
			foreach (string s in str)
				cbAlgorithm.Items.Add(Path.GetFileName(s).Remove(0, 5).Replace(".dll", ""));
			if (cbAlgorithm.Items.Count != 0)
				cbAlgorithm.SelectedIndex = 0;

        }

        private void pgDataSet_SelectedObjectsChanged(object sender, EventArgs e)
        {
			if (!(pgDataSet.SelectedObject is FitDataSet))
			{
				cDataSet.Series[0].Points.Clear();
				dgvDataSet.Rows.Clear();
				dgvDataSet.Columns.Clear();
				return;
			}
            ((FitDataSet)pgDataSet.SelectedObject).FillDataGrid(dgvDataSet);
			((FitDataSet)pgDataSet.SelectedObject).UpdateBounds();
			((FitDataSet)pgDataSet.SelectedObject).DrawChart(cDataSet.Series[0], cDataSet.Series[1], true);
        }

        private void miCreate2D_Click(object sender, EventArgs e)
        {
            FitDataSet fds = new FitDataSet2D();
			clbDataSet.Items.Add(fds);
			clbDataSet.SelectedItem = fds;
        }

        private void miCreate3D_Click(object sender, EventArgs e)
        {

        }

        private void miCreateSurface_Click(object sender, EventArgs e)
        {

        }

		
		private void clbDataSet_SelectedIndexChanged(object sender, EventArgs e)
		{
			pgDataSet.SelectedObject = clbDataSet.SelectedItem;
		}

		
		private void miPaste2D_Click(object sender, EventArgs e) //Paste grad as new 2D dataset
		{
			char[] sep = { '\n', '\t', ' ', '\r' };
			string[] data = Clipboard.GetText().Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Split(sep, StringSplitOptions.RemoveEmptyEntries);
			FitDataSet ds = new FitDataSet2D();
			double x,y;
			for (int i = 0; (i + 1) < data.Length; i += 2)
			{
				if (!double.TryParse(data[i], out x))
					x = 0;
				ds.Data[0].Add(x);
				if (!double.TryParse(data[i + 1], out y))
					y = 0;
				ds.Data[1].Add(y);
			}
			if (((ArrayList)ds.Data[0]).Count > 1)
			{
				clbDataSet.Items.Add(ds);
				clbDataSet.SelectedItem = ds;
			}
		}

		private void dgvDataSet_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.Control) && (e.KeyCode == Keys.V))  //Paste grad to current position in the grid
			{
				char[] sep = { '\n', '\t', ' ', '\r' };
				string[] data = Clipboard.GetText().Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Split(sep, StringSplitOptions.RemoveEmptyEntries);
				int selected = dgvDataSet.SelectedCells[0].RowIndex;
				dgvDataSet.Rows.Add(selected + data.Length/2 - dgvDataSet.RowCount + 1);
				for (int i = 0; (i + 1) < data.Length; i += 2)
				{
					dgvDataSet.Rows[selected + i / 2].Cells[0].Value = data[i];
					dgvDataSet.Rows[selected + i / 2].Cells[1].Value = data[i + 1];
				}
				((FitDataSet)pgDataSet.SelectedObject).ReadDataGrid(dgvDataSet);
				((FitDataSet)pgDataSet.SelectedObject).DrawChart(cDataSet.Series[0], cDataSet.Series[1], true);
			}
			else if (e.KeyCode == Keys.Delete) //Clear selected values
			{
				foreach (DataGridViewCell cell in dgvDataSet.SelectedCells)
					cell.Value = null;
				((FitDataSet)pgDataSet.SelectedObject).ReadDataGrid(dgvDataSet);
				((FitDataSet)pgDataSet.SelectedObject).DrawChart(cDataSet.Series[0], cDataSet.Series[1], true);
			}
		}

		private void dgvDataSet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			((FitDataSet)pgDataSet.SelectedObject).ReadDataGrid(dgvDataSet);
			if (cFit.Series.Count > 0)
				((FitDataSet)pgDataSet.SelectedObject).DrawChart(cFit.Series[0], cDataSet.Series[1], true);
		}

		private void lbFunctions_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				lbFunctions.Items.Remove(lbFunctions.SelectedItem);
			}
		}

		private void clbDataSet_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
			{
				cbDataSet.Items.Add(clbDataSet.Items[e.Index]);
				if (cbDataSet.Items.Count == 1)
					cbDataSet.SelectedItem = clbDataSet.Items[e.Index];
			}
			else
				cbDataSet.Items.Remove(clbDataSet.Items[e.Index]);
		}

		private void dgvDataSet_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			double res;
			if (double.TryParse(e.FormattedValue.ToString(), out res))
			{
				e.Cancel = false;
				lFitStatus.Text = "OK";
			}
			else
			{
				lFitStatus.Text = "Cell value is not a decimal!";
				e.Cancel = true;
			}
		}

		private void cDataSet_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button == System.Windows.Forms.MouseButtons.Left) || (e.Button == System.Windows.Forms.MouseButtons.Right))
			{
				HitTestResult ht = cDataSet.HitTest(e.X, e.Y + YHitOffset, ChartElementType.DataPoint);
				if ((ht.Object != null) && (((DataPoint)ht.Object).Tag is FitDataSet))
				{
					m_dataPoint = ((DataPoint)ht.Object);
					m_boundX = cDataSet.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
					m_boundY = cDataSet.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
				}
			}
		}

		private void cDataSet_MouseUp(object sender, MouseEventArgs e)
		{
			m_dataPoint = null;
		}

		private void cDataSet_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.X < cDataSet.ClientSize.Width) && (e.Y < cDataSet.ClientSize.Height) && (e.X > 0) && (e.Y > 0) && (m_dataPoint != null))
			{
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					double x = cDataSet.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
					if (Math.Abs(((FitDataSet)m_dataPoint.Tag).LeftBound-x) <= Math.Abs(((FitDataSet)m_dataPoint.Tag).RightBound-x))
						((FitDataSet)m_dataPoint.Tag).LeftBound += x - m_boundX;
					else
						((FitDataSet)m_dataPoint.Tag).RightBound += x - m_boundX;
				}
				else return;
				((FitDataSet)m_dataPoint.Tag).DrawChart(cDataSet.Series[0], cDataSet.Series[1], true);
				m_boundX = cDataSet.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
				m_boundY = cDataSet.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
			}
		}

		private void mqiImportFile_Click(object sender, EventArgs e)
		{
			fFileImport ffi = new fFileImport();
			ffi.Show();
		}

		public void AddDataSets(FitDataSet [] dss)
		{
			foreach (FitDataSet ds in dss)
				if (ds != null)
					clbDataSet.Items.Add(ds);
		}

		private void miDeleteDataSet_Click(object sender, EventArgs e)
		{
			pgDataSet.SelectedObject = null;
			clbDataSet.Items.RemoveAt(clbDataSet.SelectedIndex);
		}

		private void tsmLogScale_CheckedChanged(object sender, EventArgs e)
		{
			SetFitWindow();
			cFit.ChartAreas[0].AxisY.IsLogarithmic = tsmLogScale.Checked; 
		}
																								
    }
}
