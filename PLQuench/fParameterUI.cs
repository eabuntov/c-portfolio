using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLQuench
{
	public partial class fParameterUI : Form
	{
		public fParameterUI()
		{
			InitializeComponent();
			TopLevel = false;
		}

		private void cbDimension_SelectedIndexChanged(object sender, EventArgs e)
		{
			double prev_coeff = ((PLQParameter)this.Tag).GetCurrentDimension().Coefficient;
			double curr_coeff = 1;
			foreach (Dimension dim in ((PLQParameter)this.Tag).GetDimensions())
				if (dim.DimensionString.Equals(cbDimension.Text))
				{
					curr_coeff = dim.Coefficient;
					break;
				}
			if (prev_coeff == curr_coeff) return;
			if (!String.IsNullOrEmpty(tbValue.Text))
				tbValue.Text = ((double)(curr_coeff / prev_coeff * double.Parse(tbValue.Text))).ToString();
			if (!String.IsNullOrEmpty(tbMax.Text))
				tbMax.Text = ((double)(curr_coeff / prev_coeff * double.Parse(tbMax.Text))).ToString();
			if (!String.IsNullOrEmpty(tbMin.Text))
				tbMin.Text = ((double)(curr_coeff / prev_coeff * double.Parse(tbMin.Text))).ToString();
			((PLQParameter)this.Tag).SetDimension(cbDimension.Text);
		}
	}
}