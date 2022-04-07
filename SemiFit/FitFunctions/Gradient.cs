using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitFunctions
{
	public class Gradient
	{
		double m_value;
		SortedDictionary<string, double> m_grad;

		public double Value
		{
			get { return m_value; }
			set { m_value = value; }
		}

		public SortedDictionary<string, double> Grad
		{
			get { return m_grad; }
			set { m_grad = value; }
		}

		public Gradient(double value, SortedDictionary<string, double> grad)
		{
			m_value = value;
			m_grad = grad;
		}

		public void AddGradValue(string name, double value)
		{
			m_grad[name] = value;
		}

		public static Gradient operator +(Gradient g1, Gradient g2)
		{
			SortedDictionary<string, double> g = new SortedDictionary<string,double>();
			double value;
			foreach (KeyValuePair<string, double> pair in g1.Grad)
			{
				value = 0.0;
				g2.Grad.TryGetValue(pair.Key, out value);
				value += pair.Value;
				g[pair.Key] = value;
			}
			foreach (KeyValuePair<string, double> pair in g2.Grad)
			{
				if (!g1.Grad.ContainsKey(pair.Key))
					g[pair.Key] = pair.Value;
			}
			return new Gradient(g1.Value + g2.Value, g);
		}

		public static Gradient operator -(Gradient g1, Gradient g2)
		{
			SortedDictionary<string, double> g = new SortedDictionary<string, double>();
			double value;
			foreach (KeyValuePair<string, double> pair in g1.Grad)
			{
				value = 0.0;
				g2.Grad.TryGetValue(pair.Key, out value);
				value = pair.Value - value;
				g[pair.Key] = value;
			}
			foreach (KeyValuePair<string, double> pair in g2.Grad)
			{
				if (!g1.Grad.ContainsKey(pair.Key))
					g[pair.Key] = -pair.Value;
			}
			return new Gradient(g1.Value - g2.Value, g);
		}

		public static Gradient operator *(Gradient g1, Gradient g2)
		{
			SortedDictionary<string, double> g = new SortedDictionary<string, double>();
			double value;
			foreach (KeyValuePair<string, double> pair in g1.Grad)
			{
				value = 0.0;
				g2.Grad.TryGetValue(pair.Key, out value);
				g[pair.Key] = pair.Value * g2.Value + g1.Value * value;
			}
			foreach (KeyValuePair<string, double> pair in g2.Grad)
			{
				if (!g1.Grad.ContainsKey(pair.Key))
					g[pair.Key] = g2.Value*pair.Value;
			}
			return new Gradient(g1.Value * g2.Value, g);
		}

		public static Gradient operator /(Gradient g1, Gradient g2)
		{
			SortedDictionary<string, double> g = new SortedDictionary<string, double>();
			double value;
			foreach (KeyValuePair<string, double> pair in g1.Grad)
			{
				value = 0.0;
				g2.Grad.TryGetValue(pair.Key, out value);
				if (g2.Value != 0.0)
					g[pair.Key] = (g2.Value * pair.Value - g1.Value * value) / g2.Value / g2.Value;
				else
					g[pair.Key] = 1E300;
			}
			foreach (KeyValuePair<string, double> pair in g2.Grad)
			{
				if (!g1.Grad.ContainsKey(pair.Key))
					g[pair.Key] = pair.Value / g2.Value;
			}
			return new Gradient(g2.Value != 0.0 ? g1.Value / g2.Value : 1E300, g);
		}
	}
}
