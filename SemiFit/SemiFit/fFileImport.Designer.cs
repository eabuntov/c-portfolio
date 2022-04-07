namespace SemiFit
{
	partial class fFileImport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbPath = new System.Windows.Forms.TextBox();
			this.bBrowse = new System.Windows.Forms.Button();
			this.ofdImportFile = new System.Windows.Forms.OpenFileDialog();
			this.pgImport = new System.Windows.Forms.PropertyGrid();
			this.wbPreview = new System.Windows.Forms.WebBrowser();
			this.bImport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbPath
			// 
			this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbPath.Enabled = false;
			this.tbPath.Location = new System.Drawing.Point(12, 12);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(686, 20);
			this.tbPath.TabIndex = 0;
			// 
			// bBrowse
			// 
			this.bBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bBrowse.Location = new System.Drawing.Point(704, 12);
			this.bBrowse.Name = "bBrowse";
			this.bBrowse.Size = new System.Drawing.Size(75, 23);
			this.bBrowse.TabIndex = 1;
			this.bBrowse.Text = "Browse...";
			this.bBrowse.UseVisualStyleBackColor = true;
			this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
			// 
			// ofdImportFile
			// 
			this.ofdImportFile.Filter = "Text files|*.txt|All files|*.*";
			// 
			// pgImport
			// 
			this.pgImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)));
			this.pgImport.Location = new System.Drawing.Point(12, 51);
			this.pgImport.Name = "pgImport";
			this.pgImport.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.pgImport.Size = new System.Drawing.Size(212, 212);
			this.pgImport.TabIndex = 2;
			this.pgImport.ToolbarVisible = false;
			this.pgImport.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgImport_PropertyValueChanged);
			// 
			// wbPreview
			// 
			this.wbPreview.AllowWebBrowserDrop = false;
			this.wbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.wbPreview.Location = new System.Drawing.Point(230, 51);
			this.wbPreview.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbPreview.Name = "wbPreview";
			this.wbPreview.Size = new System.Drawing.Size(549, 275);
			this.wbPreview.TabIndex = 3;
			// 
			// bImport
			// 
			this.bImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.bImport.Location = new System.Drawing.Point(12, 267);
			this.bImport.Name = "bImport";
			this.bImport.Size = new System.Drawing.Size(212, 59);
			this.bImport.TabIndex = 4;
			this.bImport.Text = "Import";
			this.bImport.UseVisualStyleBackColor = true;
			this.bImport.Click += new System.EventHandler(this.bImport_Click);
			// 
			// fFileImport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 338);
			this.Controls.Add(this.bImport);
			this.Controls.Add(this.wbPreview);
			this.Controls.Add(this.pgImport);
			this.Controls.Add(this.bBrowse);
			this.Controls.Add(this.tbPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fFileImport";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Import file...";
			this.TopMost = true;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fFileImport_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Button bBrowse;
		private System.Windows.Forms.OpenFileDialog ofdImportFile;
		private System.Windows.Forms.PropertyGrid pgImport;
		private System.Windows.Forms.WebBrowser wbPreview;
		private System.Windows.Forms.Button bImport;
	}
}