using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitFunctions
{
	public class FFLorentz : FitFunction
	{
		protected static uint m_instances = 0;
		public static double sq = 1.2533141373155002512078826424055;

		public FFLorentz()
			:base("Lorentz" + (m_instances++).ToString())
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
			m_markers[0] = new FFMoveLorentzTop(this);
			m_markers[1] = new FFMoveLorentzRight(this);
			m_picture = Properties.FitFunctionPictures.FFLorentz;
			m_description = "Lorentz:\nxc - center position\nw - halfwidth\nA - area under curve";
			GetValue = LGetValue;
		}

		public override void InitializeParams(RectangleF window)
		{
			int n = 1;
			int.TryParse(m_name.Remove(0, 7), out n);
			m_parameters[0].Value = window.Left + window.Width * n / m_instances;
			m_parameters[1].Value = 0.75 * window.Width / m_instances;
			m_parameters[2].Value = 1.5 * window.Bottom * m_parameters[1].Value / Math.PI;
		}

		private double LGetValue(double X)
		{
			return 2 * m_parameters[2].Value * m_parameters[1].Value / Math.PI / (4 * (X - m_parameters[0].Value) * (X - m_parameters[0].Value) + m_parameters[1].Value*m_parameters[1].Value);
		}

		public override Gradient GetGradient(double X)
		{
			double y = this.GetValue(X);
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			grad[m_parameters[0].Name] = 4 * (X - m_parameters[0].Value) * Math.PI * y * y / m_parameters[2].Value / m_parameters[1].Value;
			grad[m_parameters[1].Name] = y / m_parameters[1].Value - y *y / Math.PI / m_parameters[2].Value;
			grad[m_parameters[2].Name] = y / m_parameters[2].Value;
			return new Gradient(y, grad);
		}

		public static void ResetCounter()
		{
			m_instances = 1;
		}
	}

	class FFMoveLorentzTop : FitFunctionMarker
	{
		public FFMoveLorentzTop(FitFunction parent)
			: base(true, false, parent)
		{

		}

		public override PointF GetCoords(RectangleF view)
		{
			return new PointF((float)m_parentFunction.Parameters[0].Value, (float)(2*m_parentFunction.Parameters[2].Value / m_parentFunction.Parameters[1].Value / Math.PI));

		}

		public override void Move(double dx, double dy)
		{
			double new_xc = m_parentFunction.Parameters[0].Value + dx;
			double new_A = m_parentFunction.Parameters[2].Value + dy * m_parentFunction.Parameters[1].Value * Math.PI/2;
			if (((new_xc > m_parentFunction.Parameters[0].Max) || (new_xc < m_parentFunction.Parameters[0].Min)) || ((new_A > m_parentFunction.Parameters[2].Max) || (new_A < m_parentFunction.Parameters[2].Min)))
				return;
			m_parentFunction.Parameters[0].Value = new_xc;
			m_parentFunction.Parameters[2].Value = new_A;
		}

	}

	class FFMoveLorentzRight : FitFunctionMarker
	{
		public FFMoveLorentzRight(FitFunction parent)
			: base(true, false, parent)
		{

		}

		public override PointF GetCoords(RectangleF view)
		{
			m_position.X = (float)(m_parentFunction.Parameters[0].Value + m_parentFunction.Parameters[1].Value / 2);
			m_position.Y = (float)(m_parentFunction.Parameters[2].Value / m_parentFunction.Parameters[1].Value / Math.PI);
			return m_position;

		}

		public override void Move(double dx, double dy)
		{
			double new_w = m_parentFunction.Parameters[1].Value + 2 * dx;
			double new_A = m_parentFunction.Parameters[2].Value * new_w / m_parentFunction.Parameters[1].Value + dy * m_parentFunction.Parameters[1].Value * Math.PI;
			if (((new_w > m_parentFunction.Parameters[1].Max) || (new_w < m_parentFunction.Parameters[1].Min)) || ((new_A > m_parentFunction.Parameters[2].Max) || (new_A < m_parentFunction.Parameters[2].Min)))
				return;
			m_parentFunction.Parameters[1].Value = new_w;
			m_parentFunction.Parameters[2].Value = new_A;
		}
	}
}
