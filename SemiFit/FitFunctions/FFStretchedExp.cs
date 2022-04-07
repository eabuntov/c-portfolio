using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitFunctions
{
	public class FFStretchedExp : FitFunction
	{
		protected static uint m_instances = 0;

		public FFStretchedExp()
			: base("StretchedExp" + (m_instances++).ToString())
		{
			m_color = GetColor(m_instances);
			m_parameters = new FitFunctionParameter[4];
			m_parameters[0] = new FitFunctionParameter(0, this);
			m_parameters[0].Name = m_name + ".I0";
			m_parameters[0].Min = -1E300;
			m_parameters[1] = new FitFunctionParameter(1, this);
			m_parameters[1].Name = m_name + ".t0";
			m_parameters[1].Min = -1E300;
			m_parameters[2] = new FitFunctionParameter(1, this);
			m_parameters[2].Name = m_name + ".tau";
			m_parameters[2].Min = 0;
			m_parameters[3] = new FitFunctionParameter(1, this);
			m_parameters[3].Name = m_name + ".beta";
			m_parameters[3].Min = -1E300;

			m_markers = new FitFunctionMarker[2];
			m_markers[0] = new FFMoveStretchedExpTop(this);
			m_markers[1] = new FFMoveStretchedExpBottom(this);
			m_picture = Properties.FitFunctionPictures.FFStretchedExp;
			m_description = "Stretched exponential:\nI0 - starting intensity\nt0 - starting position\ntau - lifetime\nbeta - stretching factor";
			GetValue = SEGetValue;
		}

		public override void InitializeParams(RectangleF window)
		{
			m_parameters[0].Value = 0.75 * window.Bottom;
			m_parameters[1].Value = 0.25 * window.Width + window.Left;
			m_parameters[2].Value = 0.1 * window.Width;
			m_parameters[3].Value = 1;
		}

		private double SEGetValue(double X)
		{
			if ((X < m_parameters[1].Value) && (Math.Abs(m_parameters[2].Value) < 1))
				return 0.0;
			return m_parameters[0].Value * Math.Exp(-Math.Pow((X - m_parameters[1].Value) / m_parameters[2].Value, m_parameters[3].Value));
		}

		public override Gradient GetGradient(double X)
		{
			double y = this.GetValue(X);
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			grad[m_parameters[0].Name] = y / m_parameters[0].Value;
			grad[m_parameters[1].Name] = y * m_parameters[3].Value / m_parameters[2].Value * Math.Pow((X - m_parameters[1].Value)/m_parameters[2].Value, m_parameters[3].Value - 1);
			grad[m_parameters[2].Name] = y * Math.Pow((X - m_parameters[1].Value) / m_parameters[2].Value, m_parameters[3].Value - 1) * (X - m_parameters[1].Value) * m_parameters[3].Value / m_parameters[2].Value / m_parameters[2].Value;
			grad[m_parameters[3].Name] = -y * Math.Pow((X - m_parameters[1].Value) / m_parameters[2].Value, m_parameters[3].Value) * Math.Log((X - m_parameters[1].Value) / m_parameters[2].Value);
			return new Gradient(y, grad);
		}

		public static void ResetCounter()
		{
			m_instances = 1;
		}
	}

	class FFMoveStretchedExpTop : FitFunctionMarker
	{
		public FFMoveStretchedExpTop(FitFunction parent)
			: base(true, false, parent)
		{

		}

		public override PointF GetCoords(RectangleF view)
		{
			return new PointF((float)m_parentFunction.Parameters[1].Value, (float)m_parentFunction.Parameters[0].Value);

		}

		public override void Move(double dx, double dy)
		{
			double new_t0 = m_parentFunction.Parameters[1].Value + dx;
			double new_I0 = m_parentFunction.Parameters[0].Value + dy;
			if (((new_t0 > m_parentFunction.Parameters[1].Max) || (new_t0 < m_parentFunction.Parameters[1].Min)) || ((new_I0 > m_parentFunction.Parameters[0].Max) || (new_I0 < m_parentFunction.Parameters[0].Min)))
				return;
			m_parentFunction.Parameters[1].Value = new_t0;
			m_parentFunction.Parameters[0].Value = new_I0;
		}

	}

	class FFMoveStretchedExpBottom : FitFunctionMarker
	{
		public FFMoveStretchedExpBottom(FitFunction parent)
			: base(true, true, parent)
		{

		}

		public override PointF GetCoords(RectangleF view)
		{
			m_position.X = (float)(m_parentFunction.Parameters[1].Value + m_parentFunction.Parameters[2].Value);
			m_position.Y = (float)(m_parentFunction.Parameters[0].Value / Math.E);
			return m_position;

		}

		public override void Move(double dx, double dy)
		{
			double new_tau = m_parentFunction.Parameters[2].Value + dx;
			if ((new_tau > m_parentFunction.Parameters[2].Max) || (new_tau < m_parentFunction.Parameters[2].Min))
				return;
			m_parentFunction.Parameters[2].Value = new_tau;
		}

		public override void Rotate(double angle)
		{
			double new_beta = 0.1*Math.Tan(angle);
			if ((new_beta > m_parentFunction.Parameters[3].Max) || (new_beta < m_parentFunction.Parameters[3].Min))
				return;
			m_parentFunction.Parameters[3].Value = new_beta;
		}
	}
}
