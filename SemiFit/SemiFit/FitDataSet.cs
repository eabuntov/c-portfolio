using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;

namespace SemiFit
{
	public abstract class FitDataSet
    {
		static Random rnd = new Random();
		static readonly Color[] Palette = { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Magenta, Color.Cyan, Color.Gray, Color.Brown, Color.DarkBlue, Color.DarkGreen, Color.Gold, Color.LightGray };
		static Color GetColor(uint index)
		{
			if (index < Palette.Length) return Palette[index];
			return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
		}

        protected static uint m_instances = 0;
        protected ArrayList [] m_data;
        protected const ushort m_dimensions = 2;
        protected string m_name = "Data" + (++m_instances).ToString();
		protected Color m_color = GetColor(m_instances);
		protected double m_leftBound, m_rightBound;

		public double LeftBound
		{
			get { return m_leftBound; }
			set { m_leftBound = value; }
		}

		public double RightBound
		{
			get { return m_rightBound; }
			set { m_rightBound = value; }
		}

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }
        
        public ArrayList [] Data
        {
            get { return m_data; }
        }

		public Color Color
		{
			get { return m_color; }
			set { m_color = value; }
		}
		
        public FitDataSet()
        {

        }

        public virtual void FillDataGrid(DataGridView dgv)
        {

        }

		public virtual void ReadDataGrid(DataGridView dgv)
		{

		}

		public virtual void DrawChart(Series series, Series bounds, bool draw_bounds)
		{

		}

		public virtual void UpdateBounds()
		{

		}
       
        public override string ToString()
        {
            return m_name;
        }
    }
}
