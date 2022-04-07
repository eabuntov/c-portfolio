using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SemiFit
{
	public partial class fFileImport : Form
	{
		public fFileImport()
		{
			InitializeComponent();
		}

		private void bBrowse_Click(object sender, EventArgs e)
		{
			if (ofdImportFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				tbPath.Text = ofdImportFile.FileName;
				pgImport.SelectedObject = new FileImport(ofdImportFile.FileName);
				wbPreview.Navigate("file://" + ((FileImport)pgImport.SelectedObject).GetHtmlFile(ofdImportFile.FileName));
			}
		}

		private void pgImport_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
		{
			wbPreview.Navigate("file://" + ((FileImport)pgImport.SelectedObject).GetHtmlFile(ofdImportFile.FileName));
		}

		private void bImport_Click(object sender, EventArgs e)
		{
			if (tbPath.Text.Length > 0)
				((fSemiFit)Application.OpenForms[0]).AddDataSets(((FileImport)pgImport.SelectedObject).Import(ofdImportFile.FileName));
			this.Close();
		}

		private void fFileImport_FormClosed(object sender, FormClosedEventArgs e)
		{
			foreach (var fi in Directory.EnumerateFiles(Path.GetDirectoryName(Application.ExecutablePath), "*.tmp"))
			{
				try
				{
					File.Delete(fi);
				}
				// Catch unauthorized access to a file.
				catch (UnauthorizedAccessException UnAuthTop)
				{
					
				}
			}				
		}
	}
}
