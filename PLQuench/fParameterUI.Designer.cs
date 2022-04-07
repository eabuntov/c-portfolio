namespace PLQuench
{
	partial class fParameterUI
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
			this.tbValue = new System.Windows.Forms.TextBox();
			this.tbMax = new System.Windows.Forms.TextBox();
			this.tbMin = new System.Windows.Forms.TextBox();
			this.cbValue = new System.Windows.Forms.CheckBox();
			this.cbMax = new System.Windows.Forms.CheckBox();
			this.cbMin = new System.Windows.Forms.CheckBox();
			this.lValue = new System.Windows.Forms.Label();
			this.lMax = new System.Windows.Forms.Label();
			this.lMin = new System.Windows.Forms.Label();
			this.cbDimension = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// tbValue
			// 
			this.tbValue.Location = new System.Drawing.Point(23, 5);
			this.tbValue.Name = "tbValue";
			this.tbValue.Size = new System.Drawing.Size(100, 20);
			this.tbValue.TabIndex = 0;
			// 
			// tbMax
			// 
			this.tbMax.Location = new System.Drawing.Point(23, 31);
			this.tbMax.Name = "tbMax";
			this.tbMax.Size = new System.Drawing.Size(100, 20);
			this.tbMax.TabIndex = 1;
			// 
			// tbMin
			// 
			this.tbMin.Location = new System.Drawing.Point(23, 57);
			this.tbMin.Name = "tbMin";
			this.tbMin.Size = new System.Drawing.Size(100, 20);
			this.tbMin.TabIndex = 2;
			// 
			// cbValue
			// 
			this.cbValue.AutoSize = true;
			this.cbValue.Location = new System.Drawing.Point(129, 8);
			this.cbValue.Name = "cbValue";
			this.cbValue.Size = new System.Drawing.Size(15, 14);
			this.cbValue.TabIndex = 3;
			this.cbValue.UseVisualStyleBackColor = true;
			// 
			// cbMax
			// 
			this.cbMax.AutoSize = true;
			this.cbMax.Location = new System.Drawing.Point(129, 34);
			this.cbMax.Name = "cbMax";
			this.cbMax.Size = new System.Drawing.Size(15, 14);
			this.cbMax.TabIndex = 4;
			this.cbMax.UseVisualStyleBackColor = true;
			// 
			// cbMin
			// 
			this.cbMin.AutoSize = true;
			this.cbMin.Location = new System.Drawing.Point(129, 60);
			this.cbMin.Name = "cbMin";
			this.cbMin.Size = new System.Drawing.Size(15, 14);
			this.cbMin.TabIndex = 5;
			this.cbMin.UseVisualStyleBackColor = true;
			// 
			// lValue
			// 
			this.lValue.AutoSize = true;
			this.lValue.Location = new System.Drawing.Point(8, 8);
			this.lValue.Name = "lValue";
			this.lValue.Size = new System.Drawing.Size(13, 13);
			this.lValue.TabIndex = 6;
			this.lValue.Text = "=";
			// 
			// lMax
			// 
			this.lMax.AutoSize = true;
			this.lMax.Location = new System.Drawing.Point(2, 34);
			this.lMax.Name = "lMax";
			this.lMax.Size = new System.Drawing.Size(19, 13);
			this.lMax.TabIndex = 7;
			this.lMax.Text = "<=";
			// 
			// lMin
			// 
			this.lMin.AutoSize = true;
			this.lMin.Location = new System.Drawing.Point(2, 62);
			this.lMin.Name = "lMin";
			this.lMin.Size = new System.Drawing.Size(19, 13);
			this.lMin.TabIndex = 8;
			this.lMin.Text = ">=";
			// 
			// cbDimension
			// 
			this.cbDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDimension.FormattingEnabled = true;
			this.cbDimension.Location = new System.Drawing.Point(150, 5);
			this.cbDimension.Name = "cbDimension";
			this.cbDimension.Size = new System.Drawing.Size(70, 21);
			this.cbDimension.TabIndex = 9;
			this.cbDimension.SelectedIndexChanged += new System.EventHandler(this.cbDimension_SelectedIndexChanged);
			// 
			// fParameterUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 84);
			this.ControlBox = false;
			this.Controls.Add(this.cbDimension);
			this.Controls.Add(this.lMin);
			this.Controls.Add(this.lMax);
			this.Controls.Add(this.lValue);
			this.Controls.Add(this.cbMin);
			this.Controls.Add(this.cbMax);
			this.Controls.Add(this.cbValue);
			this.Controls.Add(this.tbMin);
			this.Controls.Add(this.tbMax);
			this.Controls.Add(this.tbValue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "fParameterUI";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "fParameterUI";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox tbValue;
		public System.Windows.Forms.TextBox tbMax;
		public System.Windows.Forms.TextBox tbMin;
		public System.Windows.Forms.CheckBox cbValue;
		public System.Windows.Forms.CheckBox cbMax;
		public System.Windows.Forms.CheckBox cbMin;
		private System.Windows.Forms.Label lValue;
		private System.Windows.Forms.Label lMax;
		private System.Windows.Forms.Label lMin;
		public System.Windows.Forms.ComboBox cbDimension;
	}
}