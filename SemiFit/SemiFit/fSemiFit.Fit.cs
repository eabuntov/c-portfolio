using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FitFunctions;
using System.Drawing;
using System.Reflection;
using System.IO;
using ApproximationEngine;
using System.Linq.Expressions;
using System.Globalization;

namespace SemiFit
{
	public partial class fSemiFit
	{
		DataPoint m_fitMarker;
		double m_fitX, m_fitY;
		RectangleF m_fitWindow;
		FitFunction m_sum;
		bool m_needFitRefresh = true;

		private int GetOperationPriority(string op)
		{
			switch (op)
			{
				case "*":
				case "/":
					return 3;

				case "-":
				case "+":
					return 2;

				case "(":
					return 1;
				default:
					return 0;
			}
		}

		private void tcMain_TabIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((tcMain.SelectedIndex == 2) && (lbFunctions.Items.Count > 0) && m_needFitRefresh)
			{
				m_needFitRefresh = false;
				ArrayList f = new ArrayList();
				Stack st = new Stack();
				foreach (object obj in lbFunctions.Items)	// Converting our expression (lbFunctions.Items) to Reverse Polish Notation
				{
					if (obj is FitFunction)
						f.Add(obj);
					else if (obj is string)
					{
						if ((st.Count == 0) || (String.Equals((string)obj, "(")))
							st.Push(obj);
						else if (String.Equals((string)obj, ")"))
						{
							while (!String.Equals((string)st.Peek(), "("))
								f.Add(st.Pop());
							st.Pop();
						}
						else 
						{
							while ((st.Count > 0)&&(GetOperationPriority((string)obj) <= GetOperationPriority((string)st.Peek())))
								f.Add(st.Pop());
							st.Push(obj);
						}
					}
					
				}
				while (st.Count > 0)
					f.Add(st.Pop());

				clbFitFunctions.Items.Clear();
				dgvParameters.Rows.Clear();

				foreach (object obj in f)
					if (obj is FitFunction)
					{
						clbFitFunctions.Items.Add(obj);
						clbFitFunctions.SetItemChecked(clbFitFunctions.Items.Count - 1, ((FitFunction)obj).Enabled);
					}

				ParameterExpression X = Expression.Parameter(typeof(double), "x");
				Queue m_calculation = new Queue();
				foreach (object obj in f)
					if (obj is FitFunction)
						if (((FitFunction)obj).Enabled)
							m_calculation.Enqueue(Expression.Call(Expression.Constant((FitFunction)obj), typeof(FitFunction).GetMethod("GetGradient", new Type[] { typeof(double) }), X));
						else
							m_calculation.Enqueue(Expression.Constant(0.0));
					else if (obj is string)
						m_calculation.Enqueue(MakeOperation((string)obj, m_calculation));

				m_sum = new FFRPNSumm(Expression.Lambda<Func<double, Gradient>>(((Expression)m_calculation.Dequeue()), X).Compile());

				DrawFitFunctions();
				foreach (object obj in clbFitFunctions.Items)
					foreach (FitFunctionParameter par in ((FitFunction)obj).Parameters)
						{
							dgvParameters.Rows.Add(par.Name, par.Active, par.Value, par.Min, par.Max);
							dgvParameters.Rows[dgvParameters.Rows.Count - 1].Tag = par;
							par.Tag = dgvParameters.Rows[dgvParameters.Rows.Count - 1];
						}
			}
			else if ((tcMain.SelectedIndex == 3)&&(clbFitFunctions.Items.Count > 0))
			{
				pgOutput.SelectedObject = new FitOutput((FitDataSet)cbDataSet.SelectedItem);
			}
		}

		private void cbDataSet_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcMain.SelectedIndex == 2)
				DrawFitFunctions();
		}

		private BinaryExpression MakeOperation(string op, Queue args)
		{
			Expression tmp;
			switch (op)
			{
				case "+":
					return Expression.Add((Expression)args.Dequeue(), (Expression)args.Dequeue());
				case "-":
					tmp = (Expression)args.Dequeue();
					return Expression.Subtract(tmp, (Expression)args.Dequeue());
				case "*":
					tmp = (Expression)args.Dequeue();
					return Expression.Multiply((Expression)args.Dequeue(), tmp);
				case "/":
					tmp = (Expression)args.Dequeue();
					return Expression.Divide((Expression)args.Dequeue(), tmp);
				default:
					return null;
			}
		}

		private void clbFitFunctions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			((FitFunction)clbFitFunctions.Items[e.Index]).Enabled = e.NewValue == CheckState.Checked;
			ReDraw((FitFunction)clbFitFunctions.Items[e.Index]);
		}

		private void DrawFitFunctions()
		{
			cFit.Series.Clear();
			cFit.Series.Add(new Series("ExpData"));								//Data to fit
			cFit.Series[0].ChartType = SeriesChartType.FastPoint;
			((FitDataSet)cbDataSet.SelectedItem).DrawChart(cFit.Series[0], null, false);
			cFit.Series[0].Color = ((FitDataSet)cbDataSet.SelectedItem).Color;
			cFit.Series[0].Tag = cbDataSet.SelectedItem;
			cFit.Series[0].MarkerSize = 5;

			SetFitWindow();

			foreach (FitFunction ff in clbFitFunctions.Items)
				if (ff.Enabled)
			{
				cFit.Series.Add(new Series(ff.Name));
				cFit.Series[cFit.Series.Count - 1].ChartType = SeriesChartType.Spline;
				cFit.Series[cFit.Series.Count - 1].Tag = ff;
				
				cFit.Series.Add(new Series(ff.Name + " markers"));
				cFit.Series[cFit.Series.Count - 1].ChartType = SeriesChartType.Point;
				cFit.Series[cFit.Series.Count - 1].Tag = ff;
				cFit.Series[cFit.Series.Count - 1].MarkerStyle = MarkerStyle.Square;
				cFit.Series[cFit.Series.Count - 1].MarkerSize = 10;

				ff.InitializeParams(m_fitWindow);
				ff.DrawFit(cFit.Series[cFit.Series.Count - 2], cFit.Series[cFit.Series.Count - 1], m_fitWindow);
			}

			cFit.Series.Add(new Series("Summ"));								//Data to fit
			cFit.Series[cFit.Series.Count - 1].ChartType = SeriesChartType.Spline;
			m_sum.DrawFit(cFit.Series[cFit.Series.Count - 1], null, m_fitWindow);
			cFit.Series[cFit.Series.Count - 1].Tag = m_sum;

		}

		private void SetFitWindow()
		{
			double xmin = 1E300, xmax = -1E300, ymin = 1E300, ymax = -1E300;
			foreach (DataPoint pt in cFit.Series[0].Points)
			{
				if (pt.XValue > xmax)
					xmax = pt.XValue;
				if (pt.XValue < xmin)
					xmin = pt.XValue;
				if (pt.YValues[0] > ymax)
					ymax = pt.YValues[0];
				if (pt.YValues[0] < ymin)
					ymin = pt.YValues[0];
			}

			cFit.ChartAreas[0].AxisX.Maximum = xmax + 0.05 * (xmax - xmin);
			cFit.ChartAreas[0].AxisY.Maximum = ymax + 0.05 * (ymax - ymin);
			cFit.ChartAreas[0].AxisX.Minimum = xmin - 0.05 * (xmax - xmin);
			if ((ymin > 0) && ((ymax - ymin) > 0.5 * ymin)) //If positive function is not too flat, show zero level for convenience
				cFit.ChartAreas[0].AxisY.Minimum = 0;
			else
				cFit.ChartAreas[0].AxisY.Minimum = ymin - 0.05 * (ymax - ymin);
			if ((tsmLogScale.Checked) && (cFit.ChartAreas[0].AxisY.Minimum <= 0))
				if (ymin > 0) cFit.ChartAreas[0].AxisY.Minimum = 0.5 * ymin;
				else cFit.ChartAreas[0].AxisY.Minimum = 1E-3 * Math.Abs(ymax);
			m_fitWindow.X = (float)cFit.ChartAreas[0].AxisX.Minimum;
			m_fitWindow.Y = (float)cFit.ChartAreas[0].AxisY.Minimum;
			m_fitWindow.Width = (float)cFit.ChartAreas[0].AxisX.Maximum - m_fitWindow.X;
			m_fitWindow.Height = (float)cFit.ChartAreas[0].AxisY.Maximum - (float)cFit.ChartAreas[0].AxisY.Minimum;
		}

		private const int YHitOffset = 3; // Pixel hit offset

		private void cFit_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button == System.Windows.Forms.MouseButtons.Left)||(e.Button == System.Windows.Forms.MouseButtons.Right))
			{
				HitTestResult ht = cFit.HitTest(e.X, e.Y + YHitOffset, ChartElementType.DataPoint);
				if ((ht.Object != null) && (((DataPoint)ht.Object).Tag is FitFunctionMarker))
				{
					m_fitMarker = ((DataPoint)ht.Object);
					m_fitX = cFit.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
					m_fitY = cFit.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
				}
			}
		}

		private void cFit_MouseUp(object sender, MouseEventArgs e)
		{
			m_fitMarker = null;
		}

		private void cFit_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.X < cFit.ClientSize.Width) && (e.Y < cFit.ClientSize.Height) && (e.X > 0) && (e.Y > 0) &&  (m_fitMarker != null))
			{
				if ((e.Button == System.Windows.Forms.MouseButtons.Left)&&(((FitFunctionMarker)m_fitMarker.Tag).CanMove))
					((FitFunctionMarker)m_fitMarker.Tag).Move(cFit.ChartAreas[0].AxisX.PixelPositionToValue(e.X) - m_fitX, cFit.ChartAreas[0].AxisY.PixelPositionToValue(e.Y) - m_fitY);
				else if ((e.Button == System.Windows.Forms.MouseButtons.Right)&&(((FitFunctionMarker)m_fitMarker.Tag).CanRotate))
					((FitFunctionMarker)m_fitMarker.Tag).Rotate(Math.Atan((cFit.ChartAreas[0].AxisY.PixelPositionToValue(e.Y) - m_fitMarker.YValues[0]) / (cFit.ChartAreas[0].AxisX.PixelPositionToValue(e.X) - m_fitMarker.XValue)));
				else return;
				ReDraw(((FitFunctionMarker)m_fitMarker.Tag).ParentFunction);
				foreach (FitFunctionParameter par in ((FitFunctionMarker)m_fitMarker.Tag).ParentFunction.Parameters)
					((DataGridViewRow)par.Tag).Cells[2].Value = par.Value;
				m_fitX = cFit.ChartAreas[0].AxisX.PixelPositionToValue(e.X);
				m_fitY = cFit.ChartAreas[0].AxisY.PixelPositionToValue(e.Y);
			}
		}

		private void cFit_MouseLeave(object sender, EventArgs e)
		{
			m_fitMarker = null;
		}

		private void ReDraw(FitFunction func)
		{
			m_fitWindow.X = (float)cFit.ChartAreas[0].AxisX.Minimum;
			m_fitWindow.Y = (float)cFit.ChartAreas[0].AxisY.Minimum;
			m_fitWindow.Width = (float)cFit.ChartAreas[0].AxisX.Maximum - m_fitWindow.X;
			m_fitWindow.Height = (float)cFit.ChartAreas[0].AxisY.Maximum - (float)cFit.ChartAreas[0].AxisY.Minimum;
			if ((func.LineSeries == null) || (func.MarkerSeries == null))
				return;
			func.DrawFit(func.LineSeries, func.MarkerSeries, m_fitWindow);
			((FitFunction)cFit.Series[cFit.Series.Count - 1].Tag).DrawFit(cFit.Series[cFit.Series.Count - 1], null, m_fitWindow);
		}

		private void dgvParameters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvParameters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
				return;
			switch (e.ColumnIndex)
			{
				case 1:
					((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Active = (bool)dgvParameters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
					break;
				case 2:
					((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Value = double.Parse((string)dgvParameters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Parent.UpdateMarkers(m_fitWindow);
					ReDraw(((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Parent);
					break;
				case 3:
					((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Min = double.Parse((string)dgvParameters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
				case 4:
					((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Max = double.Parse((string)dgvParameters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
					break;
			}
		}

		private void dgvParameters_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			double res; 
			switch (e.ColumnIndex)
			{
				case 2:
					if (!double.TryParse((string)e.FormattedValue, out res))
					{ e.Cancel = true; return; }
					res = double.Parse((string)e.FormattedValue);
					if ((res < ((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Min) || (res > ((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Max))
						e.Cancel = true;
					return;
				case 3:
					if (!double.TryParse((string)e.FormattedValue, out res))
					{ e.Cancel = true; return; }
					res = double.Parse((string)e.FormattedValue);
					if ((res > ((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Value) || (res > ((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Max))
						e.Cancel = true;
					return;
				case 4:
					if (!double.TryParse((string)e.FormattedValue, out res))
					{ e.Cancel = true; return; }
					res = double.Parse((string)e.FormattedValue);
					if ((res < ((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Value) || (res < ((FitFunctionParameter)dgvParameters.Rows[e.RowIndex].Tag).Min))
						e.Cancel = true;
					return;
			}
			e.Cancel = false;
		}

		private void miFit_Click(object sender, EventArgs e)
		{
			Assembly a = Assembly.LoadFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "appr_" + cbAlgorithm.Text + ".dll"));
			object engine = null;
			foreach (Type t in a.GetTypes())
				if (t.GetInterface("IApprEngine") != null)
					engine = Activator.CreateInstance(t);
			if (engine == null) return;
			((IApprEngine)engine).FitFunction = FitFunc;
			((IApprEngine)engine).ProgressFunction = ShowProgressFunc;
			double[] parameters = new double[dgvParameters.RowCount];
			double[] minValues = new double[dgvParameters.RowCount];
			double[] maxValues = new double[dgvParameters.RowCount];
			for (int i = 0; i < dgvParameters.RowCount; i++)
			{
				parameters[i] = ((FitFunctionParameter)dgvParameters.Rows[i].Tag).Value;
				if ((((FitFunctionParameter)dgvParameters.Rows[i].Tag).Parent.Enabled) && (((FitFunctionParameter)dgvParameters.Rows[i].Tag).Active == true))
				{
					minValues[i] = ((FitFunctionParameter)dgvParameters.Rows[i].Tag).Min;
					maxValues[i] = ((FitFunctionParameter)dgvParameters.Rows[i].Tag).Max;
				}
				else
				{
					minValues[i] = 0;
					maxValues[i] = 0;
				}
			}
			lFitStatus.Text = "Please wait... Fitting...";
			ddbFit.Enabled = false;
			string s = ((IApprEngine)engine).Fit(dgvParameters.RowCount - 1, 1, ref parameters, double.Parse(tbFitAccuracy.Text.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)), int.Parse(cbIterations.Text), minValues, maxValues);
			for (int i = 0; i < dgvParameters.RowCount; i++)
				dgvParameters.Rows[i].Cells[2].Value = parameters[i].ToString();
			char[] sep = { ' ' };
			lFitStatus.Text = "Done";
			ddbFit.Enabled = true;
			pbFit.Value = 100;
			foreach (object obj in clbFitFunctions.Items)
				if (obj is FitFunction)
				{
					((FitFunction)obj).UpdateMarkers(m_fitWindow);
					ReDraw((FitFunction)obj);
				}
		}

		private void FitFunc(ref double[] x, ref double func, ref double [] grad)
		{
			double y = 0;
			for (int i = 0; i < dgvParameters.RowCount; i++)
				((FitFunctionParameter)dgvParameters.Rows[i].Tag).Value = x[i];
				func = 0;
				for (int i = 0; i < dgvParameters.RowCount; i++)
					grad[i] = 0;
				for (int j = 0; j < cFit.Series[0].Points.Count; j++)
				{
					y = cFit.Series[0].Points[j].YValues[0] - ((FitFunction)cFit.Series[cFit.Series.Count - 1].Tag).GetValue(cFit.Series[0].Points[j].XValue);
					for (int t = 0; t < dgvParameters.RowCount; t++)
						grad[t] -= 2 * ((FitFunction)cFit.Series[cFit.Series.Count - 1].Tag).GetGradient(cFit.Series[0].Points[j].XValue).Grad[dgvParameters.Rows[t].Cells[0].Value.ToString()] * y;
					func += y * y;
				}
				Application.DoEvents();
		}

		private void ShowProgressFunc(ref double[] x, double f, ref double g)
		{
			lFitStatus.Text = "SD = " + f.ToString();
			if (pbFit.Value == 100)
				pbFit.Value = 0;
			pbFit.Value = pbFit.Value + 5;
		}


	}
}