using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using DotNetMatrix;

namespace PLQuench
{

	public class PLQData
	{
		static int dataCount = 0;
		const double kb = 8.629E-5; // Boltzmann constant in eV units
		static Random rnd = new Random();
		public static int ParametersCount = 2;
		static Color[] Palette = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Magenta, Color.Cyan, Color.Gray, Color.Brown, Color.DarkBlue, Color.DarkGreen, Color.Gold, Color.LightGray };

		static Color GetColor(int index)
		{
			if (index < Palette.Length) return Palette[index];
			return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
		}

		int m_number;
		GeneralMatrix m_data;
		string m_name;
		PLQParameter m_alpha;
		PLQParameter m_ps;
		bool m_show;
		bool m_fit;
		double m_Emax;
		double m_dE;
		double m_Tmax;
		double m_dT;
		DataGridView m_input;
		Steema.TeeChart.TChart m_quenching;
		Steema.TeeChart.TChart m_distribution;
		Steema.TeeChart.Styles.Line m_quenchingLine;
		Steema.TeeChart.Styles.Points m_quenchingPoints;
		Steema.TeeChart.Styles.Line m_distributionLine;

		[DescriptionAttribute("Name of the curve")]
		public string Name
		{
			get { return m_name; }
			set { m_name = value; }
		}

		[DescriptionAttribute("Regularisation parameter > 0")]
		public PLQParameter Alpha
		{
			get { return m_alpha; }
			set { m_alpha = value; RefreshDistributionGraph(); }
		}

		[DescriptionAttribute("Frequency factor, >10")]
		public PLQParameter Ps
		{
			get { return m_ps; }
			set { m_ps = value; RefreshDistributionGraph(); }
		}

		[DescriptionAttribute("Activation energy upper limit in eV")]
		public double Emax
		{
			get { return m_Emax; }
			set { m_Emax = value; RefreshDistributionGraph(); }
		}

		[DescriptionAttribute("Activation energy discretization step, eV")]
		public double dE
		{
			get { return m_dE; }
			set { m_dE = value; RefreshDistributionGraph(); }
		}

		[DescriptionAttribute("Temperature discretization step, K")]
		public double dT
		{
			get { return m_dT; }
			set { m_dT = value; RefreshApproximation(true); }
		}

		[DescriptionAttribute("Temperature upper limit, K")]
		public double Tmax
		{
			get { return m_Tmax; }
			set { m_Tmax = value; RefreshApproximation(true); }
		}

		[DescriptionAttribute("Plot the curves")]
		public bool Show
		{
			get { return m_show; }
			set { m_show = value; RefreshQuenchingGraph(true); RefreshDistributionGraph(); }
		}

		[DescriptionAttribute("Fit this quenching")]
		public bool Fit
		{
			get { return m_fit; }
			set { m_fit = value; RefreshQuenchingGraph(true); RefreshDistributionGraph(); }
		}

		[DescriptionAttribute("Number of input points")]
		public int PointsCount
		{
			get
			{
				int imax = 0;
				while (m_data.GetElement(imax, 0) != 0)
					imax++; 
				return imax; 
			}
		}

		[DescriptionAttribute("Parameters to fit")]
		public double[] FitParameters
		{
			get { double[] res = { 0, m_ps.Value, m_alpha.Value};	return res; }
			set { m_ps.Value = value[1]; m_alpha.Value = value[2]; }
		}

		public GeneralMatrix Data
		{
			get { return m_data; }
		}

		public PLQData(DataGridView input, Steema.TeeChart.TChart quenching, Steema.TeeChart.TChart distribution)
		{
			m_input = input;
			m_data = new GeneralMatrix(1000, 2, 0);
			m_number = dataCount++;
			m_name = "Data" + (dataCount).ToString();
			m_alpha = new PLQParameter(1, "a. u.");
			m_alpha.Max = 2;
			m_alpha.Min = 0;
			m_ps = new PLQParameter(113, "s^-1");
			m_ps.Max = 900000;
			m_ps.Min = 1;
			m_dE = 0.005;
			m_Emax = 0.2;
			m_dT = 2;
			m_Tmax = 250;
			m_distribution = distribution;
			m_quenching = quenching;
			m_show = true;
			m_fit = true;

			m_quenchingPoints = new Steema.TeeChart.Styles.Points();
			m_quenchingPoints.Pointer.Brush.Visible = false;
			m_quenchingPoints.Color = GetColor(m_number);
			m_quenching.Series.Add(m_quenchingPoints);

			m_quenchingLine = new Steema.TeeChart.Styles.Line();
			m_quenchingLine.Color = GetColor(m_number);
			m_quenchingLine.OutLine.Width = 2;
			m_quenching.Series.Add(m_quenchingLine);

			m_distributionLine = new Steema.TeeChart.Styles.Line();
			m_distributionLine.Color = GetColor(m_number);
			m_distributionLine.OutLine.Width = 2;
			m_distribution.Series.Add(m_distributionLine);			
		}

		public void AddPoint(double t, double i)
		{
			for (int j = 0; j < m_data.RowDimension; j++)
				if (m_data.GetElement(j, 0) == 0) { m_data.SetElement(j, 0, t); m_data.SetElement(j, 1, i); return; }

			m_data.SetElement(0, 0, t); m_data.SetElement(0, 1, i);
		}

		public override string ToString()
		{
			return m_name;
		}

		public GeneralMatrix CalculateDistribution(double ps, double alpha)
		{
			int imax = 0;
			while (m_data.GetElement(imax, 0) != 0)
				imax++;
			int pointsE = (int)(m_Emax/m_dE);  //Discretization of activation energy [0, Emax] with step dE
			if (pointsE < 1) return null;
			GeneralMatrix K = new GeneralMatrix(imax, pointsE, 0); // main equation matrix - discretized kernel
			double max = 0;
			double k;
			int i;
			for (int j = 0; j < imax; j++)
			{
				for (i = 0; i < pointsE; i++)
				{
					k = -i * m_dE / (kb * m_data.GetElement(j, 0));
					k = m_dE / (1 + ps * Math.Exp(k));
					K.SetElement(j, i, k);
					if (k > max) max = k;
				}
				K.SetElement(j, 1, K.GetElement(j, 1) + 2 * m_dE / (1 + ps));
				K.SetElement(j, 2, K.GetElement(j, 2) - m_dE / (1 + ps));
			}
			K = K.Multiply(1 / max);
			GeneralMatrix M = K.Transpose() * K;
			M = M + GeneralMatrix.Identity(M.RowDimension, M.ColumnDimension).Multiply(alpha); // solving by means of zero-order Tikhonov method
			M = M.Solve(K.Transpose() * m_data.GetMatrix(0, imax - 1, 1, 1).Multiply(1 / max));
			M.SetElement(0, 0, 2 * M.GetElement(1, 0) - M.GetElement(2, 0));
			K = new GeneralMatrix(pointsE, 2);
			for (i = 0; i < pointsE; i++)
			{
				K.SetElement(i, 0, i * m_dE);
				K.SetElement(i, 1, M.GetElement(i, 0));
			}
			return K;
		}

		public GeneralMatrix CalculateQuenchingApproximation(GeneralMatrix distribution, double ps)
		{
			int pointsT = (int)(m_Tmax/m_dT);
			int pointsE = (int)(m_Emax/m_dE);
			if ((pointsT < 2)||(pointsE < 2)) return null;
			GeneralMatrix quench = new GeneralMatrix(pointsT, 2);
			int j;
			double s = 0;
			quench.SetElement(0, 0, 0);
			for (j = 0; j < pointsE; j++)
				s += distribution.GetElement(j, 1) * m_dE / (1 + ps * Math.Exp(-j * m_dE / (kb * 0.01)));
			quench.SetElement(0, 1, s);
			for (int i = 1; i < pointsT; i++)
			{
				quench.SetElement(i, 0, i * m_dT);
				s = 0;
				for (j = 0; j < pointsE; j++)
					s += distribution.GetElement(j, 1) * m_dE / (1 + ps * Math.Exp(-j * m_dE / (kb * i * m_dT)));
				quench.SetElement(i, 1, s);
			}
			return quench;
		}

		public double GetApproximationPoint(GeneralMatrix distribution, double T, double ps)
		{
			int pointsE = (int)(m_Emax / m_dE);
			double s = 0;
			for (int j = 0; j < pointsE; j++)
				s += distribution.GetElement(j, 1) * m_dE / (1 + ps * Math.Exp(-j * m_dE / (kb * T)));
			return s;
		}

		public GeneralMatrix CalculateDistribution()
		{
			return CalculateDistribution(m_ps.Value, m_alpha.Value);
		}

		public void RefreshInput()
		{
			while (m_input.ColumnCount < (dataCount * 2))
			{
				m_input.Columns.Add(new DataGridViewTextBoxColumn());
				m_input.Columns.Add(new DataGridViewTextBoxColumn());
			}
			int imax = 0;
			while (m_data.GetElement(imax, 0) != 0)
				imax++;
			if (m_input.RowCount < imax)
				m_input.RowCount = imax;
			for (int i = 0; i < imax; i++)
			{
				m_input.Rows[i].Cells[(m_number) * 2].Value = m_data.GetElement(i, 0);
				m_input.Rows[i].Cells[(m_number) * 2 + 1].Value = m_data.GetElement(i, 1);
			}
		}

		public void RefreshQuenchingGraph(bool normalize)
		{
			int imax = 0;
			while (m_data.GetElement(imax, 0) != 0)
				imax++;
			m_quenchingPoints.Clear();
			if (!m_show) return;
			double max = 1;
			if (normalize)
				max = m_data.GetElement(0, 1);
			for (int i = 0; i < imax; i++)
			{
				m_quenchingPoints.Add(m_data.GetElement(i, 0), m_data.GetElement(i, 1) / max);
			}
		}

		public void RefreshDistributionGraph()
		{
			
			m_distributionLine.Clear();
			if (!m_show) return;
			GeneralMatrix M = this.CalculateDistribution();
			if (M == null) return;
			for (int i = 0; i < M.RowDimension; i++)
			{
				m_distributionLine.Add(M.GetElement(i, 0), M.GetElement(i, 1));
			}
		}

		public void RefreshApproximation(bool normalize)
		{
			m_quenchingLine.Clear();
			if (!m_show) return;
			GeneralMatrix K = this.CalculateDistribution();
			if (K == null) return;
			GeneralMatrix M = this.CalculateQuenchingApproximation(K, m_ps.Value);
			double max = 1;
			if (normalize)
				max = M.GetElement(0, 1);
			for (int i = 0; i < M.RowDimension; i++)
			{
				m_quenchingLine.Add(M.GetElement(i, 0), M.GetElement(i, 1) / max);
			}
		}

		public double[] GetMinValues()
		{
			double[] res = {0, m_ps.Min, m_alpha.Min };
			return res;
		}

		public double[] GetMaxValues()
		{
			double[] res = {0, m_ps.Max, m_alpha.Max };
			return res;
		}

	}
}
