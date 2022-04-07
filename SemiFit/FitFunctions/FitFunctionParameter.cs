using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.Design;
using System.Drawing.Design;

namespace FitFunctions
{
	/*public class ParameterEditor : UITypeEditor
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
				FitFunctionParameter param = (FitFunctionParameter)value;
				fParameterUI form = new fParameterUI();
				form.Tag = param;
				form.tbValue.Text = param.Value.ToString();
				form.cbValue.Checked = param.Active;
				form.tbMax.Text = param.Max.ToString();
				form.tbMin.Text = param.Min.ToString();
				form.Tag = param;
				wfes.DropDownControl(form);
				try
				{
					param.Value = double.Parse(form.tbValue.Text);
					param.Active = form.cbValue.Checked;
					param.Max = double.Parse(form.tbMax.Text);
					param.Min = double.Parse(form.tbMin.Text);
				}
				catch
				{
					throw new ArgumentException(
						"Can not convert to type FitFunctionParameter");
				}
				return param;
			}
			else return null;
		}

	}

	public class FitFunctionParameterConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context,
								  System.Type destinationType)
		{
			if (destinationType == typeof(FitFunctionParameter))
				return true;

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context,
							   CultureInfo culture,
							   object value,
							   System.Type destinationType)
		{
			if (destinationType == typeof(System.String) &&
				 value is FitFunctionParameter)
			{

				FitFunctionParameter so = (FitFunctionParameter)value;

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
					FitFunctionParameter so = new FitFunctionParameter(double.Parse(s));
					return so;
				}
				catch
				{
					throw new ArgumentException(
						"Can not convert '" + (string)value +
										   "' to type FitFunctionParameter");
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

	[Editor(typeof(ParameterEditor), typeof(UITypeEditor))]
	//[TypeConverterAttribute(typeof(FitFunctionParameterConverter)), DescriptionAttribute("You can edit value")]*/
	public class FitFunctionParameter
	{
		private double m_value;
		private double m_max;
		private double m_min;
		private bool m_active;
		private string m_name;
		private FitFunction m_parentFunction;
		private object m_tag;

		public string Name
		{
			get { return m_name; }
			set { m_name = value; }
		}

		public double Value
		{
			get { return m_value; }
			set { m_value = value; }
		}

		public double Max
		{
			get { return m_max; }
			set { m_max = value; }
		}

		public double Min
		{
			get { return m_min; }
			set { m_min = value; }
		}

		public bool Active
		{
			get { return m_active; }
			set { m_active = value; }
		}

		public FitFunction Parent
		{
			get { return m_parentFunction; }
		}

		public object Tag
		{
			get { return m_tag; }
			set { m_tag = value; }
		}

		public FitFunctionParameter(double value, FitFunction parent)
		{
			m_value = value;
			m_active = true;
			m_min = 0;
			m_max = 1E300;
			m_parentFunction = parent;
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

		public override string ToString()
		{
			return Value.ToString();
		}

		public FitFunctionParameter Clone()
		{
			FitFunctionParameter res = new FitFunctionParameter(m_value, null);
			res.Value = m_value;
			res.Max = m_max;
			res.Min = m_min;
			res.Active = m_active;
			res.Name = m_name;
			return res;
		}

	}
}
