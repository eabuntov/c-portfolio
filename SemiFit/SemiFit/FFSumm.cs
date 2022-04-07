using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using FitFunctions;

namespace SemiFit
{
	public class FFRPNSumm : FitFunctions.FitFunction
	{
		Func<double, Gradient> m_expression;

		public FFRPNSumm(Func<double, Gradient> f)
			: base("Summ")
		{
			m_color = Color.Black;
			m_expression = f;
			m_description = "Auxilary summ function";
			GetValue = SGetValue;
		}

		

		private double SGetValue(double X)
		{
			return m_expression.Invoke(X).Value;
		}

		public override Gradient GetGradient(double X)
		{
			return m_expression.Invoke(X);
		}

		public override void DrawFit(System.Windows.Forms.DataVisualization.Charting.Series line, System.Windows.Forms.DataVisualization.Charting.Series markers, RectangleF window)
		{
			while (Math.Floor((1.00000001 * window.Right - window.Left) / m_smooth / window.Width) < (line.Points.Count - 1))
				line.Points.RemoveAt(line.Points.Count - 1);
			line.Color = m_color;
			double x = window.Left;
			for (; x <= 1.00000001 * window.Right; x += m_smooth * window.Width)
				if (Math.Floor((x - window.Left) / m_smooth / window.Width) < line.Points.Count)
					line.Points[(int)Math.Floor((x - window.Left) / m_smooth / window.Width)].SetValueXY(x, this.GetValue(x));
				else
					line.Points.AddXY(x, this.GetValue(x));
			m_sline = line;
		}
	}
}
