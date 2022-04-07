using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitFunctions
{
	public class FFExponential : FitFunction
	{
		protected static uint m_instances = 0;

		public FFExponential()
			: base("Exponential" + (m_instances++).ToString())
		{
			m_color = GetColor(m_instances);
			m_parameters = new FitFunctionParameter[2];
			m_parameters[0] = new FitFunctionParameter(0, this);
			m_parameters[0].Name = m_name + ".x0";
			m_parameters[0].Min = -1E300;
			m_parameters[1] = new FitFunctionParameter(1, this);
			m_parameters[1].Name = m_name + ".t";
			m_parameters[1].Min = -1E300;

			m_markers = new FitFunctionMarker[1];
			m_markers[0] = new FFMoveExp(this);
			m_picture = Properties.FitFunctionPictures.FFExponent;
			m_description = "Exponential:\nx0 - offset\nt - decay constant";
			GetValue = EGetValue;
		}

		private double EGetValue(double X)
		{
			return Math.Exp((X - m_parameters[0].Value) / m_parameters[1].Value);
		}

		public override Gradient GetGradient(double X)
		{
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			grad[m_parameters[0].Name] = -Math.Exp((X - m_parameters[0].Value) / m_parameters[1].Value) / m_parameters[1].Value;
			grad[m_parameters[1].Name] = -Math.Exp((X - m_parameters[0].Value) / m_parameters[1].Value) * (X - m_parameters[0].Value) / m_parameters[1].Value / m_parameters[1].Value;
			return new Gradient(this.GetValue(X), grad);
		}

		public override void InitializeParams(RectangleF window)
		{
			m_parameters[1].Value = window.Width / 2;
			m_parameters[0].Value = window.Left + window.Width / 2 - window.Width * Math.Log(window.Top + window.Height / 2) / 2;
		}

		public static void ResetCounter()
		{
			m_instances = 1;
		}

	}

	class FFMoveExp : FitFunctionMarker
	{
		public FFMoveExp(FitFunction parent)
			: base(true, true, parent)
		{
			m_position.X = value_uninitialized;
		}

		public override PointF GetCoords(RectangleF view)
		{
			if ((m_position.X == value_uninitialized) || (m_position.X == float_changed))
			{
				double y1, y2;
				y1 = m_parentFunction.GetValue(view.Left);
				if (y1 > view.Bottom)
					y1 = view.Bottom;
				else if (y1 < view.Top)
					y1 = view.Top;
				y2 = m_parentFunction.GetValue(view.Right);
				if (y2 > view.Bottom)
					y2 = view.Bottom;
				else if (y2 < view.Top)
					y2 = view.Top;
				m_position.Y = (float)(y1 + y2) / 2;
				m_position.X = (float)m_parentFunction.Parameters[0].Value + (float)m_parentFunction.Parameters[1].Value * (float)Math.Log(m_position.Y);
			}
			return m_position;
		}

		public override void Move(double dx, double dy)
		{
			double new_x0 = m_parentFunction.Parameters[0].Value + dx;
			double new_t = (m_position.X + dx - new_x0) / Math.Log(m_position.Y + dy);
			m_position.X += (float)dx;
			m_position.Y += (float)dy;
			if ((new_x0 <= m_parentFunction.Parameters[0].Max) && (new_x0 >= m_parentFunction.Parameters[0].Min))
				m_parentFunction.Parameters[0].Value = new_x0;
			if ((new_t <= m_parentFunction.Parameters[1].Max) && (new_t >= m_parentFunction.Parameters[1].Min))
				m_parentFunction.Parameters[1].Value = new_t;
		}

		public override void Rotate(double angle)
		{
			double new_t = - m_parentFunction.Parameters[1].Value;
			double new_x0 = m_position.X - new_t*Math.Log(m_position.Y);
			if ((new_x0 > m_parentFunction.Parameters[0].Max) || (new_x0 < m_parentFunction.Parameters[0].Min) || (new_t < m_parentFunction.Parameters[1].Min) || (new_t > m_parentFunction.Parameters[1].Max))
				return;
			m_parentFunction.Parameters[0].Value = new_x0;
			m_parentFunction.Parameters[1].Value = new_t;
		}

	}
}
