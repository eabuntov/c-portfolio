namespace PLQuench
{
	partial class fPLFitter
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPLFitter));
			this.scMain = new System.Windows.Forms.SplitContainer();
			this.scTop = new System.Windows.Forms.SplitContainer();
			this.cbDataSelected = new System.Windows.Forms.ComboBox();
			this.pgDataFitParameters = new System.Windows.Forms.PropertyGrid();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Intensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmData = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miImport = new System.Windows.Forms.ToolStripMenuItem();
			this.miPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.miInsertColumn = new System.Windows.Forms.ToolStripMenuItem();
			this.miInsertRow = new System.Windows.Forms.ToolStripMenuItem();
			this.miDeleteColumn = new System.Windows.Forms.ToolStripMenuItem();
			this.miDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
			this.scBottom = new System.Windows.Forms.SplitContainer();
			this.tcQuenching = new Steema.TeeChart.TChart();
			this.line1 = new Steema.TeeChart.Styles.Line();
			this.tcDistribution = new Steema.TeeChart.TChart();
			this.ofdImport = new System.Windows.Forms.OpenFileDialog();
			this.ssStatus = new System.Windows.Forms.StatusStrip();
			this.mOptions = new System.Windows.Forms.ToolStripDropDownButton();
			this.miNormQuenching = new System.Windows.Forms.ToolStripMenuItem();
			this.mFit = new System.Windows.Forms.ToolStripDropDownButton();
			this.tailLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbTailPercent = new System.Windows.Forms.ToolStripTextBox();
			this.iterationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbIterations = new System.Windows.Forms.ToolStripTextBox();
			this.accuracyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tbAccuracy = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cbFitEngine = new System.Windows.Forms.ToolStripComboBox();
			this.miFit = new System.Windows.Forms.ToolStripMenuItem();
			this.pbFitProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.cmGraph = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miCopyData = new System.Windows.Forms.ToolStripMenuItem();
			this.copyBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.line2 = new Steema.TeeChart.Styles.Line();
			this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.scMain.Panel1.SuspendLayout();
			this.scMain.Panel2.SuspendLayout();
			this.scMain.SuspendLayout();
			this.scTop.Panel1.SuspendLayout();
			this.scTop.Panel2.SuspendLayout();
			this.scTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.cmData.SuspendLayout();
			this.scBottom.Panel1.SuspendLayout();
			this.scBottom.Panel2.SuspendLayout();
			this.scBottom.SuspendLayout();
			this.ssStatus.SuspendLayout();
			this.cmGraph.SuspendLayout();
			this.SuspendLayout();
			// 
			// scMain
			// 
			this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scMain.Location = new System.Drawing.Point(0, 0);
			this.scMain.Name = "scMain";
			this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scMain.Panel1
			// 
			this.scMain.Panel1.Controls.Add(this.scTop);
			// 
			// scMain.Panel2
			// 
			this.scMain.Panel2.Controls.Add(this.scBottom);
			this.scMain.Size = new System.Drawing.Size(1016, 734);
			this.scMain.SplitterDistance = 291;
			this.scMain.TabIndex = 0;
			// 
			// scTop
			// 
			this.scTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scTop.Location = new System.Drawing.Point(0, 0);
			this.scTop.Name = "scTop";
			// 
			// scTop.Panel1
			// 
			this.scTop.Panel1.Controls.Add(this.cbDataSelected);
			this.scTop.Panel1.Controls.Add(this.pgDataFitParameters);
			// 
			// scTop.Panel2
			// 
			this.scTop.Panel2.Controls.Add(this.dgvData);
			this.scTop.Size = new System.Drawing.Size(1016, 291);
			this.scTop.SplitterDistance = 338;
			this.scTop.TabIndex = 0;
			// 
			// cbDataSelected
			// 
			this.cbDataSelected.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbDataSelected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataSelected.FormattingEnabled = true;
			this.cbDataSelected.Location = new System.Drawing.Point(0, 0);
			this.cbDataSelected.Name = "cbDataSelected";
			this.cbDataSelected.Size = new System.Drawing.Size(338, 21);
			this.cbDataSelected.TabIndex = 1;
			this.cbDataSelected.SelectedIndexChanged += new System.EventHandler(this.cbDataSelected_SelectedIndexChanged);
			// 
			// pgDataFitParameters
			// 
			this.pgDataFitParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pgDataFitParameters.Location = new System.Drawing.Point(0, 27);
			this.pgDataFitParameters.Name = "pgDataFitParameters";
			this.pgDataFitParameters.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pgDataFitParameters.Size = new System.Drawing.Size(338, 264);
			this.pgDataFitParameters.TabIndex = 0;
			this.pgDataFitParameters.ToolbarVisible = false;
			// 
			// dgvData
			// 
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temp,
            this.Intensity});
			this.dgvData.ContextMenuStrip = this.cmData;
			this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvData.Location = new System.Drawing.Point(0, 0);
			this.dgvData.Name = "dgvData";
			this.dgvData.Size = new System.Drawing.Size(674, 291);
			this.dgvData.TabIndex = 0;
			// 
			// Temp
			// 
			this.Temp.HeaderText = "T (K)";
			this.Temp.Name = "Temp";
			// 
			// Intensity
			// 
			this.Intensity.HeaderText = "I (a. u.)";
			this.Intensity.Name = "Intensity";
			// 
			// cmData
			// 
			this.cmData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miImport,
            this.miPaste,
            this.miCopy,
            this.miInsertColumn,
            this.miInsertRow,
            this.miDeleteColumn,
            this.miDeleteRow});
			this.cmData.Name = "cmData";
			this.cmData.Size = new System.Drawing.Size(196, 180);
			// 
			// miImport
			// 
			this.miImport.Name = "miImport";
			this.miImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.miImport.Size = new System.Drawing.Size(195, 22);
			this.miImport.Text = "Import curve...";
			this.miImport.Click += new System.EventHandler(this.miImport_Click);
			// 
			// miPaste
			// 
			this.miPaste.Name = "miPaste";
			this.miPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.miPaste.Size = new System.Drawing.Size(195, 22);
			this.miPaste.Text = "Paste curve";
			this.miPaste.Click += new System.EventHandler(this.miPaste_Click);
			// 
			// miInsertColumn
			// 
			this.miInsertColumn.Name = "miInsertColumn";
			this.miInsertColumn.Size = new System.Drawing.Size(195, 22);
			this.miInsertColumn.Text = "Insert column";
			// 
			// miInsertRow
			// 
			this.miInsertRow.Name = "miInsertRow";
			this.miInsertRow.Size = new System.Drawing.Size(195, 22);
			this.miInsertRow.Text = "Insert row";
			// 
			// miDeleteColumn
			// 
			this.miDeleteColumn.Name = "miDeleteColumn";
			this.miDeleteColumn.Size = new System.Drawing.Size(195, 22);
			this.miDeleteColumn.Text = "Delete column";
			// 
			// miDeleteRow
			// 
			this.miDeleteRow.Name = "miDeleteRow";
			this.miDeleteRow.Size = new System.Drawing.Size(195, 22);
			this.miDeleteRow.Text = "Delete row";
			// 
			// scBottom
			// 
			this.scBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scBottom.Location = new System.Drawing.Point(0, 0);
			this.scBottom.Name = "scBottom";
			// 
			// scBottom.Panel1
			// 
			this.scBottom.Panel1.Controls.Add(this.tcQuenching);
			// 
			// scBottom.Panel2
			// 
			this.scBottom.Panel2.Controls.Add(this.tcDistribution);
			this.scBottom.Size = new System.Drawing.Size(1016, 439);
			this.scBottom.SplitterDistance = 338;
			this.scBottom.TabIndex = 0;
			// 
			// tcQuenching
			// 
			// 
			// 
			// 
			this.tcQuenching.Aspect.ElevationFloat = 345;
			this.tcQuenching.Aspect.RotationFloat = 345;
			this.tcQuenching.Aspect.View3D = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Bottom.Automatic = true;
			// 
			// 
			// 
			this.tcQuenching.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcQuenching.Axes.Bottom.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Bottom.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Axes.Depth.Automatic = true;
			// 
			// 
			// 
			this.tcQuenching.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcQuenching.Axes.Depth.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Depth.Labels.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Depth.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Depth.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Axes.DepthTop.Automatic = true;
			// 
			// 
			// 
			this.tcQuenching.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcQuenching.Axes.DepthTop.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Axes.Left.Automatic = true;
			// 
			// 
			// 
			this.tcQuenching.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcQuenching.Axes.Left.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Left.Labels.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Left.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Left.Title.Shadow.Visible = false;
			this.tcQuenching.Axes.Left.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Axes.Right.AutomaticMaximum = false;
			this.tcQuenching.Axes.Right.AutomaticMinimum = false;
			// 
			// 
			// 
			this.tcQuenching.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcQuenching.Axes.Right.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Right.Labels.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Right.Labels.Shadow.Visible = false;
			this.tcQuenching.Axes.Right.Maximum = 100;
			this.tcQuenching.Axes.Right.Minimum = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Right.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Right.Title.Shadow.Visible = false;
			this.tcQuenching.Axes.Right.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Axes.Top.Automatic = true;
			// 
			// 
			// 
			this.tcQuenching.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcQuenching.Axes.Top.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Top.Labels.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Axes.Top.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Axes.Top.Title.Shadow.Visible = false;
			this.tcQuenching.BackColor = System.Drawing.Color.Transparent;
			this.tcQuenching.ContextMenuStrip = this.cmGraph;
			this.tcQuenching.Cursor = System.Windows.Forms.Cursors.Default;
			this.tcQuenching.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Footer.Font.Shadow.Visible = false;
			this.tcQuenching.Footer.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Footer.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Header.Font.Shadow.Visible = false;
			this.tcQuenching.Header.Font.Unit = System.Drawing.GraphicsUnit.World;
			this.tcQuenching.Header.Lines = new string[] {
        "TeeChart"};
			// 
			// 
			// 
			this.tcQuenching.Header.Shadow.Visible = false;
			this.tcQuenching.Header.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Legend.Font.Shadow.Visible = false;
			this.tcQuenching.Legend.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Legend.Title.Font.Bold = true;
			// 
			// 
			// 
			this.tcQuenching.Legend.Title.Font.Shadow.Visible = false;
			this.tcQuenching.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.Legend.Title.Pen.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Legend.Title.Shadow.Visible = false;
			this.tcQuenching.Legend.Visible = false;
			this.tcQuenching.Location = new System.Drawing.Point(0, 0);
			this.tcQuenching.Name = "tcQuenching";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tcQuenching.Panel.MarginBottom = 6;
			this.tcQuenching.Panel.MarginLeft = 2;
			this.tcQuenching.Panel.MarginRight = 1;
			this.tcQuenching.Panel.MarginTop = 1;
			// 
			// 
			// 
			this.tcQuenching.Panel.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Panning.Allow = Steema.TeeChart.ScrollModes.None;
			this.tcQuenching.Series.Add(this.line1);
			this.tcQuenching.Size = new System.Drawing.Size(338, 439);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.SubFooter.Font.Shadow.Visible = false;
			this.tcQuenching.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.SubFooter.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.SubHeader.Font.Shadow.Visible = false;
			this.tcQuenching.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcQuenching.SubHeader.Shadow.Visible = false;
			this.tcQuenching.TabIndex = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcQuenching.Walls.Back.AutoHide = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Back.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Bottom.AutoHide = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Bottom.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Left.AutoHide = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Left.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Right.AutoHide = false;
			// 
			// 
			// 
			this.tcQuenching.Walls.Right.Shadow.Visible = false;
			this.tcQuenching.Walls.Visible = false;
			// 
			// 
			// 
			this.tcQuenching.Zoom.MouseButton = System.Windows.Forms.MouseButtons.Right;
			this.tcQuenching.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tcQuenching_MouseUp);
			this.tcQuenching.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tcQuenching_MouseMove);
			this.tcQuenching.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcQuenching_MouseDown);
			// 
			// line1
			// 
			// 
			// 
			// 
			this.line1.Brush.Color = System.Drawing.Color.Red;
			// 
			// 
			// 
			this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.line1.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.line1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.line1.Marks.Callout.Distance = 0;
			this.line1.Marks.Callout.Draw3D = false;
			this.line1.Marks.Callout.Length = 10;
			this.line1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Marks.Font.Shadow.Visible = false;
			this.line1.Marks.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			// 
			// 
			// 
			this.line1.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.line1.Pointer.Dark3D = false;
			this.line1.Pointer.Draw3D = false;
			this.line1.Pointer.HorizSize = 3;
			this.line1.Pointer.InflateMargins = false;
			this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line1.Pointer.VertSize = 3;
			this.line1.Pointer.Visible = true;
			this.line1.ShowInLegend = false;
			this.line1.Title = "line1";
			this.line1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
			// 
			// 
			// 
			this.line1.XValues.DataMember = "X";
			this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.line1.YValues.DataMember = "Y";
			this.line1.Click += new System.Windows.Forms.MouseEventHandler(this.line1_Click);
			this.line1.MouseLeave += new System.EventHandler(this.line1_MouseLeave);
			// 
			// tcDistribution
			// 
			// 
			// 
			// 
			this.tcDistribution.Aspect.ElevationFloat = 345;
			this.tcDistribution.Aspect.RotationFloat = 345;
			this.tcDistribution.Aspect.View3D = false;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Bottom.Automatic = true;
			// 
			// 
			// 
			this.tcDistribution.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcDistribution.Axes.Bottom.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Bottom.Labels.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Bottom.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Bottom.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Bottom.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Bottom.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Bottom.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Axes.Depth.Automatic = true;
			// 
			// 
			// 
			this.tcDistribution.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcDistribution.Axes.Depth.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Depth.Labels.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Depth.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Depth.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Depth.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Depth.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Depth.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Axes.DepthTop.Automatic = true;
			// 
			// 
			// 
			this.tcDistribution.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcDistribution.Axes.DepthTop.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.DepthTop.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.DepthTop.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.DepthTop.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.DepthTop.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.DepthTop.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Axes.Left.Automatic = true;
			// 
			// 
			// 
			this.tcDistribution.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcDistribution.Axes.Left.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Left.Labels.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Left.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Left.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Left.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Left.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Left.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Axes.Right.Automatic = true;
			// 
			// 
			// 
			this.tcDistribution.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcDistribution.Axes.Right.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Right.Labels.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Right.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Right.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Right.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Right.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Right.Title.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Axes.Top.Automatic = true;
			// 
			// 
			// 
			this.tcDistribution.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash;
			this.tcDistribution.Axes.Top.Grid.ZPosition = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Top.Labels.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Top.Labels.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Top.Labels.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Axes.Top.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Axes.Top.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Axes.Top.Title.Shadow.Visible = false;
			this.tcDistribution.ContextMenuStrip = this.cmGraph;
			this.tcDistribution.Cursor = System.Windows.Forms.Cursors.Default;
			this.tcDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Footer.Font.Shadow.Visible = false;
			this.tcDistribution.Footer.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Footer.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Header.Font.Shadow.Visible = false;
			this.tcDistribution.Header.Font.Unit = System.Drawing.GraphicsUnit.World;
			this.tcDistribution.Header.Lines = new string[] {
        "TeeChart"};
			// 
			// 
			// 
			this.tcDistribution.Header.Shadow.Visible = false;
			this.tcDistribution.Header.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Legend.Font.Shadow.Visible = false;
			this.tcDistribution.Legend.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Legend.Title.Font.Bold = true;
			// 
			// 
			// 
			this.tcDistribution.Legend.Title.Font.Shadow.Visible = false;
			this.tcDistribution.Legend.Title.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.Legend.Title.Pen.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Legend.Title.Shadow.Visible = false;
			this.tcDistribution.Legend.Visible = false;
			this.tcDistribution.Location = new System.Drawing.Point(0, 0);
			this.tcDistribution.Name = "tcDistribution";
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tcDistribution.Panel.MarginBottom = 6;
			this.tcDistribution.Panel.MarginLeft = 0;
			this.tcDistribution.Panel.MarginRight = 1;
			this.tcDistribution.Panel.MarginTop = 2;
			// 
			// 
			// 
			this.tcDistribution.Panel.Shadow.Visible = false;
			this.tcDistribution.Series.Add(this.line2);
			this.tcDistribution.Size = new System.Drawing.Size(674, 439);
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.SubFooter.Font.Shadow.Visible = false;
			this.tcDistribution.SubFooter.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.SubFooter.Shadow.Visible = false;
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.SubHeader.Font.Shadow.Visible = false;
			this.tcDistribution.SubHeader.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			this.tcDistribution.SubHeader.Shadow.Visible = false;
			this.tcDistribution.TabIndex = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.tcDistribution.Walls.Back.AutoHide = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Back.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Bottom.AutoHide = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Bottom.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Left.AutoHide = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Left.Shadow.Visible = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Right.AutoHide = false;
			// 
			// 
			// 
			this.tcDistribution.Walls.Right.Shadow.Visible = false;
			this.tcDistribution.Walls.Visible = false;
			// 
			// ofdImport
			// 
			this.ofdImport.FileName = "openFileDialog1";
			this.ofdImport.Filter = "Text files|*.txt|All files|*.*";
			this.ofdImport.Title = "Import text data";
			// 
			// ssStatus
			// 
			this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOptions,
            this.mFit,
            this.pbFitProgress,
            this.lStatus});
			this.ssStatus.Location = new System.Drawing.Point(0, 712);
			this.ssStatus.Name = "ssStatus";
			this.ssStatus.Size = new System.Drawing.Size(1016, 22);
			this.ssStatus.TabIndex = 1;
			this.ssStatus.Text = "statusStrip1";
			// 
			// mOptions
			// 
			this.mOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNormQuenching});
			this.mOptions.Image = ((System.Drawing.Image)(resources.GetObject("mOptions.Image")));
			this.mOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mOptions.Name = "mOptions";
			this.mOptions.Size = new System.Drawing.Size(57, 20);
			this.mOptions.Text = "Options";
			// 
			// miNormQuenching
			// 
			this.miNormQuenching.Name = "miNormQuenching";
			this.miNormQuenching.Size = new System.Drawing.Size(131, 22);
			this.miNormQuenching.Text = "Normalize";
			// 
			// mFit
			// 
			this.mFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mFit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tailLengthToolStripMenuItem,
            this.tbTailPercent,
            this.iterationsToolStripMenuItem,
            this.tbIterations,
            this.accuracyToolStripMenuItem,
            this.tbAccuracy,
            this.toolStripSeparator1,
            this.cbFitEngine,
            this.miFit});
			this.mFit.Image = ((System.Drawing.Image)(resources.GetObject("mFit.Image")));
			this.mFit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.mFit.Name = "mFit";
			this.mFit.Size = new System.Drawing.Size(50, 20);
			this.mFit.Text = "Fitting";
			// 
			// tailLengthToolStripMenuItem
			// 
			this.tailLengthToolStripMenuItem.Name = "tailLengthToolStripMenuItem";
			this.tailLengthToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.tailLengthToolStripMenuItem.Text = "Tail length, %";
			// 
			// tbTailPercent
			// 
			this.tbTailPercent.Name = "tbTailPercent";
			this.tbTailPercent.Size = new System.Drawing.Size(100, 21);
			this.tbTailPercent.Text = "50";
			this.tbTailPercent.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// iterationsToolStripMenuItem
			// 
			this.iterationsToolStripMenuItem.Name = "iterationsToolStripMenuItem";
			this.iterationsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.iterationsToolStripMenuItem.Text = "Iterations";
			// 
			// tbIterations
			// 
			this.tbIterations.Name = "tbIterations";
			this.tbIterations.Size = new System.Drawing.Size(100, 21);
			this.tbIterations.Text = "10";
			this.tbIterations.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// accuracyToolStripMenuItem
			// 
			this.accuracyToolStripMenuItem.Name = "accuracyToolStripMenuItem";
			this.accuracyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.accuracyToolStripMenuItem.Text = "Accuracy";
			// 
			// tbAccuracy
			// 
			this.tbAccuracy.Name = "tbAccuracy";
			this.tbAccuracy.Size = new System.Drawing.Size(100, 21);
			this.tbAccuracy.Text = "1E-5";
			this.tbAccuracy.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
			// 
			// cbFitEngine
			// 
			this.cbFitEngine.Name = "cbFitEngine";
			this.cbFitEngine.Size = new System.Drawing.Size(121, 21);
			// 
			// miFit
			// 
			this.miFit.Name = "miFit";
			this.miFit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.miFit.Size = new System.Drawing.Size(181, 22);
			this.miFit.Text = "Fit";
			this.miFit.Click += new System.EventHandler(this.miFit_Click);
			// 
			// pbFitProgress
			// 
			this.pbFitProgress.Name = "pbFitProgress";
			this.pbFitProgress.Size = new System.Drawing.Size(100, 16);
			// 
			// lStatus
			// 
			this.lStatus.Name = "lStatus";
			this.lStatus.Size = new System.Drawing.Size(38, 17);
			this.lStatus.Text = "Ready";
			// 
			// cmGraph
			// 
			this.cmGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopyData,
            this.copyBitmapToolStripMenuItem});
			this.cmGraph.Name = "cmGraph";
			this.cmGraph.Size = new System.Drawing.Size(146, 48);
			// 
			// miCopyData
			// 
			this.miCopyData.Name = "miCopyData";
			this.miCopyData.Size = new System.Drawing.Size(145, 22);
			this.miCopyData.Text = "Copy data";
			this.miCopyData.Click += new System.EventHandler(this.miCopyData_Click);
			// 
			// copyBitmapToolStripMenuItem
			// 
			this.copyBitmapToolStripMenuItem.Name = "copyBitmapToolStripMenuItem";
			this.copyBitmapToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.copyBitmapToolStripMenuItem.Text = "Copy bitmap";
			this.copyBitmapToolStripMenuItem.Click += new System.EventHandler(this.copyBitmapToolStripMenuItem_Click);
			// 
			// line2
			// 
			// 
			// 
			// 
			this.line2.Brush.Color = System.Drawing.Color.Red;
			// 
			// 
			// 
			this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			// 
			// 
			// 
			// 
			// 
			// 
			this.line2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
			this.line2.Marks.Callout.ArrowHeadSize = 8;
			// 
			// 
			// 
			this.line2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
			this.line2.Marks.Callout.Distance = 0;
			this.line2.Marks.Callout.Draw3D = false;
			this.line2.Marks.Callout.Length = 10;
			this.line2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			// 
			// 
			// 
			// 
			// 
			// 
			this.line2.Marks.Font.Shadow.Visible = false;
			this.line2.Marks.Font.Unit = System.Drawing.GraphicsUnit.World;
			// 
			// 
			// 
			// 
			// 
			// 
			this.line2.Pointer.Brush.Color = System.Drawing.Color.Red;
			this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
			this.line2.Title = "line1";
			// 
			// 
			// 
			this.line2.XValues.DataMember = "X";
			this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
			// 
			// 
			// 
			this.line2.YValues.DataMember = "Y";
			// 
			// miCopy
			// 
			this.miCopy.Name = "miCopy";
			this.miCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.miCopy.Size = new System.Drawing.Size(195, 22);
			this.miCopy.Text = "Copy";
			this.miCopy.Click += new System.EventHandler(this.miCopy_Click);
			// 
			// fPLFitter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.ssStatus);
			this.Controls.Add(this.scMain);
			this.Name = "fPLFitter";
			this.Text = "PL quenching fitter";
			this.scMain.Panel1.ResumeLayout(false);
			this.scMain.Panel2.ResumeLayout(false);
			this.scMain.ResumeLayout(false);
			this.scTop.Panel1.ResumeLayout(false);
			this.scTop.Panel2.ResumeLayout(false);
			this.scTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.cmData.ResumeLayout(false);
			this.scBottom.Panel1.ResumeLayout(false);
			this.scBottom.Panel2.ResumeLayout(false);
			this.scBottom.ResumeLayout(false);
			this.ssStatus.ResumeLayout(false);
			this.ssStatus.PerformLayout();
			this.cmGraph.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer scMain;
		private System.Windows.Forms.SplitContainer scTop;
		private System.Windows.Forms.ComboBox cbDataSelected;
		private System.Windows.Forms.PropertyGrid pgDataFitParameters;
		private System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.DataGridViewTextBoxColumn Temp;
		private System.Windows.Forms.DataGridViewTextBoxColumn Intensity;
		private System.Windows.Forms.SplitContainer scBottom;
		private Steema.TeeChart.TChart tcQuenching;
		private Steema.TeeChart.TChart tcDistribution;
		private System.Windows.Forms.ContextMenuStrip cmData;
		private System.Windows.Forms.ToolStripMenuItem miImport;
		private System.Windows.Forms.ToolStripMenuItem miPaste;
		private System.Windows.Forms.ToolStripMenuItem miInsertColumn;
		private System.Windows.Forms.ToolStripMenuItem miInsertRow;
		private System.Windows.Forms.ToolStripMenuItem miDeleteColumn;
		private System.Windows.Forms.ToolStripMenuItem miDeleteRow;
		private System.Windows.Forms.OpenFileDialog ofdImport;
		private System.Windows.Forms.StatusStrip ssStatus;
		private System.Windows.Forms.ToolStripDropDownButton mOptions;
		private System.Windows.Forms.ToolStripDropDownButton mFit;
		private System.Windows.Forms.ToolStripMenuItem iterationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem accuracyToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox tbAccuracy;
		private System.Windows.Forms.ToolStripTextBox tbIterations;
		private System.Windows.Forms.ToolStripMenuItem miNormQuenching;
		private System.Windows.Forms.ToolStripMenuItem miFit;
		private System.Windows.Forms.ToolStripProgressBar pbFitProgress;
		private System.Windows.Forms.ToolStripStatusLabel lStatus;
		private System.Windows.Forms.ToolStripComboBox cbFitEngine;
		private System.Windows.Forms.ToolStripMenuItem tailLengthToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox tbTailPercent;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private Steema.TeeChart.Styles.Line line1;
		private System.Windows.Forms.ContextMenuStrip cmGraph;
		private System.Windows.Forms.ToolStripMenuItem miCopyData;
		private System.Windows.Forms.ToolStripMenuItem copyBitmapToolStripMenuItem;
		private Steema.TeeChart.Styles.Line line2;
		private System.Windows.Forms.ToolStripMenuItem miCopy;
	}
}

