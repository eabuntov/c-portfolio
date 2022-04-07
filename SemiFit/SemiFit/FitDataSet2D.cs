using System;
using System.Collections;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace SemiFit
{
    public class FitDataSet2D : FitDataSet
    {
        protected string m_xheader = "X";
        protected string m_yheader = "Y";

        public FitDataSet2D()
        {
			m_data = new ArrayList[2];
			m_data[0] = new ArrayList();
			m_data[1] = new ArrayList();
        }

        public override void FillDataGrid(System.Windows.Forms.DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Columns.Add("X", m_xheader);
            dgv.Columns.Add("Y", m_yheader);
			for (int i = 0; i < m_data[0].Count; i++)
				dgv.Rows.Add(m_data[0][i], m_data[1][i]);
        }

		public override void ReadDataGrid(DataGridView dgv)
		{
			m_data[0].Clear();
			m_data[1].Clear();
			double d;
			for (int i = 0; i < dgv.Rows.Count; i++)
			{
				if ((dgv.Rows[i].Cells[0].Value == null)||(dgv.Rows[i].Cells[1].Value == null))
					continue;
				if (double.TryParse(dgv.Rows[i].Cells[0].Value.ToString(), out d))
					m_data[0].Add(double.Parse(dgv.Rows[i].Cells[0].Value.ToString()));
				else
					m_data[0].Add(dgv.Rows[i].Cells[0].Value);
				if (double.TryParse(dgv.Rows[i].Cells[1].Value.ToString(), out d))
					m_data[1].Add(double.Parse(dgv.Rows[i].Cells[1].Value.ToString()));
				else
					m_data[1].Add(dgv.Rows[i].Cells[1].Value);
				this.UpdateBounds();
			}
		}

		public override void DrawChart(System.Windows.Forms.DataVisualization.Charting.Series series, System.Windows.Forms.DataVisualization.Charting.Series bounds, bool draw_bounds)
		{
			series.Points.Clear();
			series.Name = m_name;
			series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series.Color = m_color;
			double y = 0;
			for (int i = 0; i < m_data[0].Count; i++)
			{
				if (draw_bounds || (((double)m_data[0][i] > m_leftBound) && ((double)m_data[0][i] < m_rightBound)))
				series.Points.AddXY(m_data[0][i], m_data[1][i]);
				y += (double)m_data[1][i];
			}
			if (!draw_bounds || (bounds == null)) return;
			bounds.Color = System.Drawing.Color.Green;
			bounds.MarkerSize = 10;
			bounds.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
			y /= m_data[1].Count;
			bounds.Points.Clear();
			bounds.Points.AddXY(m_leftBound, y);
			bounds.Points[bounds.Points.Count - 1].Tag = this;
			bounds.Points.AddXY(m_rightBound, y);
			bounds.Points[bounds.Points.Count - 1].Tag = this;
		}

		public override void UpdateBounds()
		{
			double d = -1E300;
			for (int i = 0; i < m_data[0].Count; i++)
				if (((double)m_data[0][i]) > d)
					d = (double)m_data[0][i];
			m_rightBound = d;
			d = 1E300;
			for (int i = 0; i < m_data[0].Count; i++)
				if (((double)m_data[0][i]) < d)
					d = (double)m_data[0][i];
			m_leftBound = d;
		}
    }
}
