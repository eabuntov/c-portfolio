using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace FitFunctions
{
	public class FFGauss : FitFunction
	{
		protected static uint m_instances = 0;
		public static double sq = 1.2533141373155002512078826424055;

		public FFGauss()
			:base("Gauss" + (m_instances++).ToString())
		{
			m_color = GetColor(m_instances);
			m_parameters = new FitFunctionParameter[3];
			m_parameters[0] = new FitFunctionParameter(0, this);
			m_parameters[0].Name = m_name + ".xc";
			m_parameters[0].Min = -1E300;
			m_parameters[1] = new FitFunctionParameter(1, this);
			m_parameters[1].Name = m_name + ".w";
			m_parameters[2] = new FitFunctionParameter(1, this);
			m_parameters[2].Name = m_name + ".A";
			m_parameters[2].Min = -1E300;

			m_markers = new FitFunctionMarker[2];
			m_markers[0] = new FFMoveGaussTop(this);
			m_markers[1] = new FFMoveGaussRight(this);
			m_picture = Properties.FitFunctionPictures.FFGauss;
			m_description = "Gaussian:\nxc - center position\nw - halfwidth (w=FWHM/sqrt(ln(4)))\nA - area under curve";
			GetValue = GGetValue;
		}

		public override void InitializeParams(RectangleF window)
		{
			int n = 1;
			int.TryParse(m_name.Remove(0, 5), out n);
			m_parameters[0].Value = window.Left + window.Width * n / m_instances;
			m_parameters[1].Value = 0.75 * window.Width / m_instances;
			m_parameters[2].Value = 0.75 * window.Bottom * m_parameters[1].Value / FFGauss.sq;
		}

		private double GGetValue(double X)
		{
			return m_parameters[2].Value/m_parameters[1].Value/sq*Math.Exp(-2*(X - m_parameters[0].Value)*(X - m_parameters[0].Value)/m_parameters[1].Value/m_parameters[1].Value);
		}

		public override Gradient GetGradient(double X)
		{
			double y = this.GetValue(X);
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			grad[m_parameters[0].Name] = 4 * (X - m_parameters[0].Value)/m_parameters[1].Value/m_parameters[1].Value * y;
			grad[m_parameters[1].Name] = -y/m_parameters[1].Value/m_parameters[1].Value/m_parameters[1].Value*(m_parameters[1].Value-2*X+2*m_parameters[0].Value)*(m_parameters[1].Value+2*X-2*m_parameters[0].Value);
			grad[m_parameters[2].Name] = y / m_parameters[2].Value;
			return new Gradient(y, grad);
		}

		public static void ResetCounter()
		{
			m_instances = 1;
		}
	}

	class FFMoveGaussTop : FitFunctionMarker
	{
		public FFMoveGaussTop(FitFunction parent)
			: base(true, false, parent)
		{

		}

		public override PointF GetCoords(RectangleF view)
		{
			return new PointF((float)m_parentFunction.Parameters[0].Value, (float)(m_parentFunction.Parameters[2].Value / m_parentFunction.Parameters[1].Value / FFGauss.sq));

		}

		public override void Move(double dx, double dy)
		{
			double new_xc = m_parentFunction.Parameters[0].Value + dx;
			double new_A = m_parentFunction.Parameters[2].Value + dy * m_parentFunction.Parameters[1].Value * FFGauss.sq;
			if (((new_xc > m_parentFunction.Parameters[0].Max) || (new_xc < m_parentFunction.Parameters[0].Min)) || ((new_A > m_parentFunction.Parameters[2].Max) || (new_A < m_parentFunction.Parameters[2].Min)))
				return;
			m_parentFunction.Parameters[0].Value = new_xc;
			m_parentFunction.Parameters[2].Value = new_A;
		}

	}

	class FFMoveGaussRight : FitFunctionMarker
	{
		public FFMoveGaussRight(FitFunction parent)
			: base(true, false, parent)
		{

		}

		public override PointF GetCoords(RectangleF view)
		{
			m_position.X = (float)(m_parentFunction.Parameters[0].Value + m_parentFunction.Parameters[1].Value / 2 * 1.1774100225154746910115693264597);
			m_position.Y = (float)(m_parentFunction.Parameters[2].Value / m_parentFunction.Parameters[1].Value / FFGauss.sq * 0.5);
			return m_position;

		}

		public override void Move(double dx, double dy)
		{
			double new_w = m_parentFunction.Parameters[1].Value + 2 * dx / 1.1774100225154746910115693264597;
			double new_A = m_parentFunction.Parameters[2].Value*new_w/m_parentFunction.Parameters[1].Value + dy * m_parentFunction.Parameters[1].Value * FFGauss.sq * 2;
			if (((new_w > m_parentFunction.Parameters[1].Max) || (new_w < m_parentFunction.Parameters[1].Min)) || ((new_A > m_parentFunction.Parameters[2].Max) || (new_A < m_parentFunction.Parameters[2].Min)))
				return;
			m_parentFunction.Parameters[1].Value = new_w;
			m_parentFunction.Parameters[2].Value = new_A;
		}

	}
}
