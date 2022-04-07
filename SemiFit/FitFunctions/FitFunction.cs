using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace FitFunctions
{
	public delegate double FGetValue(double X);

	public abstract class FitFunction
	{
		protected static Random rnd = new Random();
		protected static readonly Color[] Palette = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Cyan, Color.Gray, Color.Brown, Color.DarkBlue, Color.DarkGreen, Color.Gold, Color.LightGray };
		protected static Color GetColor(uint index)
		{
			if (index < Palette.Length) return Palette[index];
			return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
		}
		protected string m_name;
		protected Image m_picture;
		protected string m_description;
		protected FitFunctionParameter[] m_parameters;
		protected FitFunctionMarker[] m_markers;
		protected Color m_color;
		protected bool m_enabled;
		protected float m_smooth;
		protected Series m_sline;
		protected Series m_smarkers;


		public string Name
		{
			get { return m_name; }
			set { m_name = value; }
		}

		public Image Picture
		{
			get { return m_picture; }
		}

		public string Description
		{
			get { return m_description; }
		}

		public FitFunctionParameter[] Parameters
		{
			get { return m_parameters; }
		}

		public FitFunctionMarker[] Markers
		{
			get { return m_markers; }
		}

		public Color Color
		{
			get { return m_color; }
			set { m_color = value; }
		}

		public bool Enabled
		{
			get { return m_enabled; }
			set { m_enabled = value; }
		}

		public float Smoothness
		{
			get { return m_smooth; }
			set { m_smooth = value; }
		}

		public Series LineSeries
		{
			get { return m_sline; }
		}

		public Series MarkerSeries
		{
			get { return m_smarkers; }
		}

		public FitFunction(string name)
		{
			m_name = name;
			m_smooth = 0.02F;
			m_enabled = true;
		}

		public FGetValue GetValue;

		public virtual Gradient GetGradient(double X)
		{
			SortedDictionary<string, double> grad = new SortedDictionary<string, double>();
			double value = 0;
			double x;
			for (int i = 0; i < m_parameters.Length; i++)
			{
				value = m_parameters[i].Value;
				m_parameters[i].Value = value * 1.01;
				x = this.GetValue(X);
				m_parameters[i].Value = value * 0.99;
				x -= this.GetValue(X);
				grad[m_parameters[i].Name] = x / 0.02 * value;
				m_parameters[i].Value = value;
			}
			return new Gradient(this.GetValue(X), grad);
		}

		public virtual void InitializeParams(RectangleF window)
		{

		}

		public virtual void DrawDemo(Series line, Series markers)
		{
			line.Points.Clear();
			line.Color = m_color;
			for (double x = -10; x <= 10; x+=0.1)
				line.Points.AddXY(x, this.GetValue(x));
			markers.Points.Clear();
			markers.Color = m_color;
			PointF p;
			foreach (FitFunctionMarker marker in m_markers)
			{
				p = marker.GetCoords(new RectangleF(-10, 10, 20, 20));
				markers.Points.AddXY(p.X+1E-300, p.Y); //Microsoft has some problem with x=0 :)
				markers.Points[markers.Points.Count - 1].Tag = marker;
			}
			m_sline = line;
			m_smarkers = markers;
		}

		public virtual void DrawFit(Series line, Series markers, RectangleF window)
		{
			markers.Points.Clear();
			if (!m_enabled)
			{
				line.Points.Clear();
				return;
			}
			line.Color = m_color;
			while (Math.Floor((1.00000001 * window.Right - window.Left) / m_smooth / window.Width) < (line.Points.Count - 1))
				line.Points.RemoveAt(line.Points.Count - 1);
			double x = window.Left;
			for (; x <= 1.00000001 * window.Right; x += m_smooth * window.Width)
				if (Math.Floor((x - window.Left) / m_smooth / window.Width) < line.Points.Count)
					line.Points[(int)Math.Floor((x - window.Left) / m_smooth / window.Width)].SetValueXY(x, this.GetValue(x));
				else
					line.Points.AddXY(x, this.GetValue(x));
			markers.Color = m_color;
			PointF p;
			foreach (FitFunctionMarker marker in m_markers)
			{
				p = marker.GetCoords(window);
				markers.Points.AddXY(p.X + 1E-300, p.Y); //Microsoft has some problem with x=0 :)
				markers.Points[markers.Points.Count - 1].Tag = marker;
			}
			m_sline = line;
			m_smarkers = markers;
		}

		public virtual void UpdateMarkers(RectangleF view)
		{
			foreach (FitFunctionMarker marker in m_markers)
			{
				marker.UpdateCoords(view);
			}
		}

		public override string ToString()
		{
			return m_name;
		}
	}
}
