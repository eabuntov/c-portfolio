using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FitFunctions;
using System.Drawing;
using System.Reflection;

namespace SemiFit
{
	public partial class fSemiFit
	{
		DataPoint m_functionMarker;
		int m_functionX, m_functionY;

		private void tvFunctions_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Tag is FitFunction)
			{
				pbExpression.Image = ((FitFunction)e.Node.Tag).Picture;
				rtbParameters.Text = ((FitFunction)e.Node.Tag).Description;
				((FitFunction)e.Node.Tag).DrawDemo(cFunction.Series[0], cFunction.Series[1]);
			}
		}

		private void cFunction_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button == System.Windows.Forms.MouseButtons.Left)||(e.Button == System.Windows.Forms.MouseButtons.Right))
			{
				HitTestResult ht = cFunction.HitTest(e.X, e.Y + YHitOffset, ChartElementType.DataPoint);
				if ((ht.Object != null) && (((DataPoint)ht.Object).Tag is FitFunctionMarker))
				{
					m_functionMarker = ((DataPoint)ht.Object);
					m_functionX = e.X;
					m_functionY = e.Y;
				}
			}
		}

		private void cFunction_MouseMove(object sender, MouseEventArgs e)
		{
			if ((e.X < cFunction.ClientSize.Width) && (e.Y < cFunction.ClientSize.Height) && (e.X > 0) && (e.Y > 0) && (m_functionMarker != null))
			{
				if ((e.Button == System.Windows.Forms.MouseButtons.Left) && ((FitFunctionMarker)m_functionMarker.Tag).CanMove)
					((FitFunctionMarker)m_functionMarker.Tag).Move(cFunction.ChartAreas[0].AxisX.PixelPositionToValue(e.X) - cFunction.ChartAreas[0].AxisX.PixelPositionToValue(m_functionX), cFunction.ChartAreas[0].AxisY.PixelPositionToValue(e.Y) - cFunction.ChartAreas[0].AxisY.PixelPositionToValue(m_functionY));
				else if ((e.Button == System.Windows.Forms.MouseButtons.Right)&&((FitFunctionMarker)m_functionMarker.Tag).CanRotate)
					((FitFunctionMarker)m_functionMarker.Tag).Rotate(Math.Atan((cFunction.ChartAreas[0].AxisY.PixelPositionToValue(e.Y) - m_functionMarker.YValues[0]) / (cFunction.ChartAreas[0].AxisX.PixelPositionToValue(e.X) - m_functionMarker.XValue)));
				else return;
				((FitFunction)tvFunctions.SelectedNode.Tag).DrawDemo(cFunction.Series[0],cFunction.Series[1]);
				m_functionX = e.X;
				m_functionY = e.Y;
			}
		}

		private void cFunction_MouseUp(object sender, MouseEventArgs e)
		{
			m_functionMarker = null;
		}

		private void cFunction_MouseLeave(object sender, EventArgs e)
		{
			m_functionMarker = null;
		}

		private void tvFunctions_ItemDrag(object sender, ItemDragEventArgs e)
		{
			if ((e.Item != null)&&(e.Item is TreeNode))
				tvFunctions.DoDragDrop(((TreeNode)e.Item).Tag.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
		}

		private void lbFunctions_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void lbFunctions_DragDrop(object sender, DragEventArgs e)
		{
			cmsFunctions.Tag = e.Data.GetData(DataFormats.Text).ToString();
			cmsFunctions.Show(new Point(e.X, e.Y));
		}

		private void lbFunctions_AddFunction(string action)
		{
			string name = "";
			if (cmsFunctions.Tag != null)
			{
				name = (string)cmsFunctions.Tag;
				cmsFunctions.Tag = null;
				if ((lbFunctions.Items.Count > 0) && (lbFunctions.Items[lbFunctions.Items.Count - 1].ToString().Length > 1))
				{
					lbFunctions.Items.Add(action);
				}
				m_needFitRefresh = true;
				Assembly a = Assembly.GetAssembly(typeof(FitFunctions.FitFunction));
				foreach (Type t in a.GetTypes())
					if ((t.BaseType == typeof(FitFunctions.FitFunction)) && name.StartsWith(t.Name.Remove(0, 2)))
					{
						lbFunctions.Items.Add(Activator.CreateInstance(t));
						break;
					}
			} else	if ((lbFunctions.Items.Count > 0)&&(lbFunctions.Items[lbFunctions.Items.Count - 1].ToString().Length > 1))
			{
				lbFunctions.Items.Add(action);
				m_needFitRefresh = true;
			}
			
		}

		private void miAdd_Click(object sender, EventArgs e)
		{
			lbFunctions_AddFunction("+");
		}

		private void miSubtract_Click(object sender, EventArgs e)
		{
			lbFunctions_AddFunction("-");
		}

		private void miMultiply_Click(object sender, EventArgs e)
		{
			lbFunctions_AddFunction("*");
		}

		private void miDivide_Click(object sender, EventArgs e)
		{
			lbFunctions_AddFunction("/");
		}

		private void miLeftBracket_Click(object sender, EventArgs e)
		{
			lbFunctions.Items.Add("(");
		}

		private void miRightBracket_Click(object sender, EventArgs e)
		{
			if ((lbFunctions.Items.Count > 0)&&(lbFunctions.Items[lbFunctions.Items.Count - 1].ToString() != "("))
				lbFunctions.Items.Add(")");
		}

		private void miClear_Click(object sender, EventArgs e)
		{
			lbFunctions.Items.Clear();
			FFLine.ResetCounter();
			FFGauss.ResetCounter();
			m_needFitRefresh = true;
		}

		private void lbFunctions_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '+':
					miAdd_Click(this, null);
					break;
				case '-':
					miSubtract_Click(this, null);
					break;
				case '*':
					miMultiply_Click(this, null);
					break;
				case '/':
					miDivide_Click(this, null);
					break;
				case '(':
					miLeftBracket_Click(this, null);
					break;
				case ')':
					miRightBracket_Click(this, null);
					break;
			}
		}

	}
}