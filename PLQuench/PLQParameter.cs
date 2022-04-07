using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace PLQuench
{
	public class ParameterEditor : UITypeEditor
	{
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.DropDown;
		}

		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			IWindowsFormsEditorService wfes = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
			if (wfes != null)
			{
				PLQParameter param = (PLQParameter)value;
				fParameterUI form = new fParameterUI();
				form.Tag = param;
				form.tbValue.Text = param.Value.ToString();
				form.cbValue.Checked = param.Active;
				form.tbMax.Text = param.Max.ToString();
				form.tbMin.Text = param.Min.ToString();
				form.cbDimension.Items.Clear();
				form.cbDimension.Items.AddRange(param.GetDimensionStrings());
				form.cbDimension.Text = param.GetCurrentDimension().DimensionString;
				form.Tag = param;
				wfes.DropDownControl(form);
				try
				{
					param.SetDimension(form.cbDimension.Text);
					param.Value = double.Parse(form.tbValue.Text.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
					param.Active = form.cbValue.Checked;
					param.Max = double.Parse(form.tbMax.Text.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
					param.Min = double.Parse(form.tbMin.Text.Replace(".", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator).Replace(",", NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
				}
				catch
				{
					throw new ArgumentException(
						"Can not convert to type PLQParameter");
				}
				return param;
			}
			else return null;
		}

	}

	public class PLQParameterConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context,
								  System.Type destinationType)
		{
			if (destinationType == typeof(PLQParameter))
				return true;

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context,
							   CultureInfo culture,
							   object value,
							   System.Type destinationType)
		{
			if (destinationType == typeof(System.String) &&
				 value is PLQParameter)
			{

				PLQParameter so = (PLQParameter)value;

				return so.ToString();
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context,
							  CultureInfo culture, object value)
		{
			if (value is string)
			{
				try
				{
					string s = (string)value;
					
						char[] sep = { ' ' };
						PLQParameter so = new PLQParameter(double.Parse(s.Split(sep)[0]), s.Split(sep)[1]);
						return so;
				}
				catch
				{
					throw new ArgumentException(
						"Can not convert '" + (string)value +
										   "' to type PLQParameter");
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context,
							  System.Type sourceType)
		{
			if (sourceType == typeof(string))
				return true;
			return base.CanConvertFrom(context, sourceType);
		}
	}

	public class Dimension
	{
		private string m_dimension;
		private double m_coeff;

		public string DimensionString
		{
			get { return m_dimension; }
		}

		public double Coefficient
		{
			get { return m_coeff; }
			set { m_coeff = value; }
		}

		public Dimension(string dim)
		{
			m_dimension = dim;
			m_coeff = 1;
		}

		public Dimension(string dim, double coeff)
		{
			m_dimension = dim;
			m_coeff = coeff;
		}

		public override string ToString()
		{
			return m_dimension;
		}
		
	}

	[Editor(typeof(ParameterEditor), typeof(UITypeEditor))]
	//[TypeConverterAttribute(typeof(PLQParameterConverter)), DescriptionAttribute("You can edit value")]
	public class PLQParameter
	{
		private double m_value;
		private double m_max;
		private double m_min;
		private bool m_active;
		private List<Dimension> m_dimensions;
		private Dimension m_currentDim;

		public double Value
		{
			get { return m_value * m_currentDim.Coefficient; }
			set { m_value = value / m_currentDim.Coefficient; }
		}

		public double Max
		{
			get { return m_max * m_currentDim.Coefficient; }
			set { m_max = value / m_currentDim.Coefficient; }
		}

		public double Min
		{
			get { return m_min * m_currentDim.Coefficient; }
			set { m_min = value / m_currentDim.Coefficient; }
		}

		public bool Active
		{
			get { return m_active; }
			set { m_active = value; }
		}

		public PLQParameter(double value, string dimension)
		{
			m_dimensions = new List<Dimension>();
			m_dimensions.Add(new Dimension(dimension));
			m_currentDim = m_dimensions[0];
			m_value = value;
			m_active = true;
			m_min = 0;
			m_max = 1E300;
		}

		public void SetDimension(string dim)
		{
			this.SetDimension(dim, 1);
		}

		public void SetDimension(string dimstr, double coeff)
		{
			Dimension dim = null;
			for (int i = 0; i < m_dimensions.Count; i++)
				if (m_dimensions[i].DimensionString.Equals(dimstr))
					dim = m_dimensions[i];
			if (dim == null)
			{
				m_dimensions.Add(new Dimension(dimstr, coeff));
				m_currentDim = m_dimensions[m_dimensions.Count - 1];
			}
			else
			{
				m_currentDim = dim;
				if (coeff != 1)
					m_currentDim.Coefficient = coeff;
			}
		}

		public Dimension GetCurrentDimension()
		{
			return m_currentDim;
		}

		public double GetValue()
		{
			return m_value;
		}

		public void SetValue(double value)
		{
			m_value = value;
		}

		public double GetMinValue()
		{
			return m_min;
		}

		public double GetMaxValue()
		{
			return m_max;
		}

		public string[] GetDimensionStrings()
		{
			string[] ds = new string[m_dimensions.Count];
			for (int i = 0; i < m_dimensions.Count; i++)
				ds[i] = m_dimensions[i].DimensionString;
			return ds;
		}

		public List<Dimension> GetDimensions()
		{
			return m_dimensions;
		}

		public override string ToString()
		{
			return Value.ToString() + " " + m_currentDim.DimensionString;
		}

		public PLQParameter Clone()
		{
			PLQParameter res = new PLQParameter(m_value, m_dimensions[0].DimensionString);
			res.Value = m_value;
			res.Max = m_max;
			res.Min = m_min;
			res.Active = m_active;
			for (int i = 0; i < m_dimensions.Count; i++)
				res.SetDimension(m_dimensions[i].DimensionString, m_dimensions[i].Coefficient);
			res.SetDimension(m_currentDim.DimensionString);
			return res;
		}

	}
}
