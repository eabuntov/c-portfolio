using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitFunctions
{
	public class FFLine : FitFunction
	{
		protected static uint m_instances = 0;

		public FFLine()
			: base("Line" + (m_instances++).ToString())
		{
			m_color = GetColor(m_instances);
			m_parameters = new FitFunctionParameter[2];
			m_parameters[0] = new FitFunctionParameter(1, this);
			m_parameters[0].Name = m_name + ".a";
			m_parameters[0].Min = -1E300;
			m_parameters[1] = new FitFunctionParameter(0, this);
			m_parameters[1].Name = m_name + ".b";
			m_parameters[1].Min = -1E300;

			m_markers = new FitFunctionMarker[1];
			m_markers[0] = new FFMoveLine(this);
			m_picture = Properties.FitFunctionPictures.FFLine;
			m_description = "Straight line:\na - slope\nb - offset";
			GetValue = LGetValue;
		}

		private double LGetValue(double X)
		{
			return m_parameters[0].Value*X + m_parameters[1].Value;
		}

		public override Gradient GetGradient(double X)
		{
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			grad[m_parameters[0].Name] = X;
			grad[m_parameters[1].Name] = m_parameters[0].Value * X;
			return new Gradient(this.GetValue(X), grad);
		}

		public override void InitializeParams(RectangleF window)
		{
			m_parameters[0].Value = window.Height / window.Width;
			m_parameters[1].Value = window.Top - m_parameters[0].Value * window.Left;
		}

		public static void ResetCounter()
		{
			m_instances = 1;
		}

	}

	class FFMoveLine : FitFunctionMarker
	{
		public FFMoveLine(FitFunction parent)
			: base(true, true, parent)
		{
			
		}

		public override PointF GetCoords(RectangleF view)
		{
			m_position.X = (view.Right + view.Left) / 2;
			m_position.Y = (float)m_parentFunction.Parameters[0].Value * (view.Right + view.Left) / 2 + (float)m_parentFunction.Parameters[1].Value;
			return m_position;

		}

		public override void Move(double dx, double dy)
		{
			double new_b = m_parentFunction.Parameters[1].Value + dy - m_parentFunction.Parameters[0].Value * dx;
			if ((new_b > m_parentFunction.Parameters[1].Max) || (new_b < m_parentFunction.Parameters[1].Min))
				return;
			m_parentFunction.Parameters[1].Value = new_b;
		}

		public override void Rotate(double angle)
		{
			double new_a = Math.Tan(angle);
			double new_b = m_parentFunction.Parameters[1].Value + (m_parentFunction.Parameters[0].Value - new_a) * m_position.X;
			if ((new_a > m_parentFunction.Parameters[0].Max) || (new_a < m_parentFunction.Parameters[0].Min) || (new_b < m_parentFunction.Parameters[1].Min) || (new_b > m_parentFunction.Parameters[1].Max))
				return;
			m_parentFunction.Parameters[0].Value = new_a;
			m_parentFunction.Parameters[1].Value = new_b;
		}

	}
}
