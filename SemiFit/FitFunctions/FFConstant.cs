using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FitFunctions
{
	public class FFConstant : FitFunction
	{
		protected static uint m_instances = 0;

		public FFConstant()
			: base("Constant" + (m_instances++).ToString())
		{
			m_color = GetColor(m_instances);
			m_parameters = new FitFunctionParameter[1];
			m_parameters[0] = new FitFunctionParameter(0, this);
			m_parameters[0].Name = m_name + ".c";
			m_parameters[0].Min = -1E300;

			m_markers = new FitFunctionMarker[1];
			m_markers[0] = new FFMoveConstant(this);
			m_picture = Properties.FitFunctionPictures.FFConstant;
			m_description = "Constant:\nc - constant value";
			GetValue = CGetValue;
		}

		private double CGetValue(double X)
		{
			return m_parameters[0].Value;
		}

		public override Gradient GetGradient(double X)
		{
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			grad[m_parameters[0].Name] = 1;
			return new Gradient(m_parameters[0].Value, grad);
		}

		public override void InitializeParams(RectangleF window)
		{
			m_parameters[0].Value = window.Top + 0.05 * window.Height;
		}

		public static void ResetCounter()
		{
			m_instances = 1;
		}

	}

	class FFMoveConstant : FitFunctionMarker
	{
		public FFMoveConstant(FitFunction parent)
			: base(true, false, parent)
		{
			
		}

		public override PointF GetCoords(RectangleF view)
		{
			m_position.X = (view.Right + view.Left) / 2;
			m_position.Y = (float)m_parentFunction.Parameters[0].Value;
			return m_position;

		}

		public override void Move(double dx, double dy)
		{
			double new_c = m_parentFunction.Parameters[0].Value + dy;
			if ((new_c > m_parentFunction.Parameters[0].Max) || (new_c < m_parentFunction.Parameters[0].Min))
				return;
			m_parentFunction.Parameters[0].Value = new_c;
		}

	}
}
