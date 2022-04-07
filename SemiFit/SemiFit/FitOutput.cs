using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FitFunctions;

namespace SemiFit
{
	public class FitOutput
	{
		double m_from, m_to, m_step;
		int m_digits;
		FitDataSet m_dataset;

		public double From
		{
			get { return m_from; }
			set { m_from = value; }
		}

		public double To
		{
			get { return m_to; }
			set { m_to = value; }
		}

		public double Step
		{
			get { return m_step; }
			set { m_step = value; }
		}

		public int Digits
		{
			get { return m_digits; }
			set { m_digits = value; }
		}

		public int Points
		{
			get { return (int)Math.Abs((m_to - m_from)/m_step); }
			set { m_step = (m_to - m_from) / value; }
		}

		public FitDataSet DataSet
		{
			get { return m_dataset; }
		}

		public FitOutput(FitDataSet ds)
		{
			m_dataset = ds;
			m_from = ds.LeftBound;
			m_to = ds.RightBound;
			m_step = (m_to - m_from) / 100;
			m_digits = 5;
		}

		public void Calculate(FitDataSet ds, FitFunction sum, System.Collections.IEnumerable functions, DataGridView parameters, DataGridView output)
		{
			string fs = "0.";
			int i;
			for (i = 0; i < m_digits; i++)
				fs += "#";
			fs += "E-000";
				parameters.Columns.Clear();
			output.Columns.Clear();
			output.Columns.Add(new DataGridViewTextBoxColumn());
			output.Columns[0].HeaderText = "X";
			output.Columns.Add(new DataGridViewTextBoxColumn());
			output.Columns[1].HeaderText = "Summ";
			foreach (object f in functions)
			{
				output.Columns.Add(new DataGridViewTextBoxColumn());
				output.Columns[output.Columns.Count - 1].HeaderText = ((FitFunction)f).Name;
				parameters.Columns.Add(new DataGridViewTextBoxColumn());
				parameters.Columns[parameters.Columns.Count - 1].HeaderText = ((FitFunction)f).Name;
				parameters.Columns.Add(new DataGridViewTextBoxColumn());
			}
			
			for (double x = m_from; x <= m_to; x += m_step)
			{
				output.Rows.Add();
				output.Rows[output.RowCount - 1].Cells[0].Value = x.ToString(fs);
				output.Rows[output.RowCount - 1].Cells[1].Value = sum.GetValue(x).ToString(fs);
				i = 2;
				foreach (object f in functions)
				{
					output.Rows[output.RowCount - 1].Cells[i].Value = ((FitFunction)f).GetValue(x).ToString(fs);
					i++;
				}
			}

			i = 0;
			int j;
			foreach (object f in functions)
			{
				j = 0;
				foreach (FitFunctionParameter par in ((FitFunction)f).Parameters)
				{
					if (parameters.RowCount <= j)
						parameters.Rows.Add();
					parameters.Rows[j].Cells[i].Value = par.Name;
					parameters.Rows[j].Cells[i + 1].Value = par.Value.ToString(fs);
					j++;
				}
				i += 2;
			}
		}
	}
}
