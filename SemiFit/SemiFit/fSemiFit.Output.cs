using System;
using System.Collections;
using System.Windows.Forms;
using FitFunctions;
using System.Drawing;
using System.IO;

namespace SemiFit
{
	public partial class fSemiFit
	{
		private void pgOutput_SelectedObjectsChanged(object sender, EventArgs e)
		{
			((FitOutput)pgOutput.SelectedObject).Calculate((FitDataSet)cbDataSet.SelectedItem, m_sum, clbFitFunctions.Items, dgvOutputParameters, dgvOutput);
		}

		private void pgOutput_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			((FitOutput)pgOutput.SelectedObject).Calculate((FitDataSet)cbDataSet.SelectedItem, m_sum, clbFitFunctions.Items, dgvOutputParameters, dgvOutput);
		}
	}
}