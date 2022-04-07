namespace SemiFit
{
    partial class fSemiFit
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSemiFit));
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tpData = new System.Windows.Forms.TabPage();
			this.scData = new System.Windows.Forms.SplitContainer();
			this.scDataLeft = new System.Windows.Forms.SplitContainer();
			this.lDataSets = new System.Windows.Forms.Label();
			this.clbDataSet = new System.Windows.Forms.CheckedListBox();
			this.cmsDataSets = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miCreateDataSet = new System.Windows.Forms.ToolStripMenuItem();
			this.miCreate2D = new System.Windows.Forms.ToolStripMenuItem();
			this.miCreate3D = new System.Windows.Forms.ToolStripMenuItem();
			this.miCreateSurface = new System.Windows.Forms.ToolStripMenuItem();
			this.mqiImportFile = new System.Windows.Forms.ToolStripMenuItem();
			this.miCopyBuffer = new System.Windows.Forms.ToolStripMenuItem();
			this.miPasteBuffer = new System.Windows.Forms.ToolStripMenuItem();
			this.miPaste2D = new System.Windows.Forms.ToolStripMenuItem();
			this.miPasteXYY = new System.Windows.Forms.ToolStripMenuItem();
			this.miPasteXYXY = new System.Windows.Forms.ToolStripMenuItem();
			this.miPaste3DCurve = new System.Windows.Forms.ToolStripMenuItem();
			this.miPasteMultiple3D = new System.Windows.Forms.ToolStripMenuItem();
			this.miPasteMatrix = new System.Windows.Forms.ToolStripMenuItem();
			this.miDeleteDataSet = new System.Windows.Forms.ToolStripMenuItem();
			this.pgDataSet = new System.Windows.Forms.PropertyGrid();
			this.scDataRight = new System.Windows.Forms.SplitContainer();
			this.dgvDataSet = new System.Windows.Forms.DataGridView();
			this.cDataSet = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tpFunction = new System.Windows.Forms.TabPage();
			this.scFunction = new System.Windows.Forms.SplitContainer();
			this.scFunctionLeft = new System.Windows.Forms.SplitContainer();
			this.lFunctions = new System.Windows.Forms.Label();
			this.tvFunctions = new System.Windows.Forms.TreeView();
			this.lFitby = new System.Windows.Forms.Label();
			this.lbFunctions = new System.Windows.Forms.ListBox();
			this.cmsFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.miSubtract = new System.Windows.Forms.ToolStripMenuItem();
			this.miMultiply = new System.Windows.Forms.ToolStripMenuItem();
			this.miDivide = new System.Windows.Forms.ToolStripMenuItem();
			this.miLeftBracket = new System.Windows.Forms.ToolStripMenuItem();
			this.miRightBracket = new System.Windows.Forms.ToolStripMenuItem();
			this.miClear = new System.Windows.Forms.ToolStripMenuItem();
			this.scFunctionView = new System.Windows.Forms.SplitContainer();
			this.cFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.flpFunction = new System.Windows.Forms.FlowLayoutPanel();
			this.pbExpression = new System.Windows.Forms.PictureBox();
			this.rtbParameters = new System.Windows.Forms.RichTextBox();
			this.tpFit = new System.Windows.Forms.TabPage();
			this.scFit = new System.Windows.Forms.SplitContainer();
			this.cFit = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.scFitParameters = new System.Windows.Forms.SplitContainer();
			this.cbDataSet = new System.Windows.Forms.ComboBox();
			this.clbFitFunctions = new System.Windows.Forms.CheckedListBox();
			this.dgvParameters = new System.Windows.Forms.DataGridView();
			this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ParameterVary = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ParameterValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ParameterMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ParameterMaximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tpResults = new System.Windows.Forms.TabPage();
			this.scResults = new System.Windows.Forms.SplitContainer();
			this.scParameters = new System.Windows.Forms.SplitContainer();
			this.pgOutput = new System.Windows.Forms.PropertyGrid();
			this.dgvOutputParameters = new System.Windows.Forms.DataGridView();
			this.dgvOutput = new System.Windows.Forms.DataGridView();
			this.ssStatus = new System.Windows.Forms.StatusStrip();
			this.ddbFit = new System.Windows.Forms.ToolStripDropDownButton();
			this.miIterations = new System.Windows.Forms.ToolStripMenuItem();
			this.cbIterations = new System.Windows.Forms.ToolStripComboBox();
			this.miAlgorithm = new System.Windows.Forms.ToolStripMenuItem();
			this.cbAlgorithm = new System.Windows.Forms.ToolStripComboBox();
			this.miAccuracy = new System.Windows.Forms.ToolStripMenuItem();
			this.tbFitAccuracy = new System.Windows.Forms.ToolStripTextBox();
			this.miFit = new System.Windows.Forms.ToolStripMenuItem();
			this.pbFit = new System.Windows.Forms.ToolStripProgressBar();
			this.lFitStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.msMainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xYYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xYXYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmLogScale = new System.Windows.Forms.ToolStripMenuItem();
			this.tcMain.SuspendLayout();
			this.tpData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scData)).BeginInit();
			this.scData.Panel1.SuspendLayout();
			this.scData.Panel2.SuspendLayout();
			this.scData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scDataLeft)).BeginInit();
			this.scDataLeft.Panel1.SuspendLayout();
			this.scDataLeft.Panel2.SuspendLayout();
			this.scDataLeft.SuspendLayout();
			this.cmsDataSets.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scDataRight)).BeginInit();
			this.scDataRight.Panel1.SuspendLayout();
			this.scDataRight.Panel2.SuspendLayout();
			this.scDataRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cDataSet)).BeginInit();
			this.tpFunction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFunction)).BeginInit();
			this.scFunction.Panel1.SuspendLayout();
			this.scFunction.Panel2.SuspendLayout();
			this.scFunction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFunctionLeft)).BeginInit();
			this.scFunctionLeft.Panel1.SuspendLayout();
			this.scFunctionLeft.Panel2.SuspendLayout();
			this.scFunctionLeft.SuspendLayout();
			this.cmsFunctions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFunctionView)).BeginInit();
			this.scFunctionView.Panel1.SuspendLayout();
			this.scFunctionView.Panel2.SuspendLayout();
			this.scFunctionView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cFunction)).BeginInit();
			this.flpFunction.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbExpression)).BeginInit();
			this.tpFit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFit)).BeginInit();
			this.scFit.Panel1.SuspendLayout();
			this.scFit.Panel2.SuspendLayout();
			this.scFit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cFit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scFitParameters)).BeginInit();
			this.scFitParameters.Panel1.SuspendLayout();
			this.scFitParameters.Panel2.SuspendLayout();
			this.scFitParameters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
			this.tpResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scResults)).BeginInit();
			this.scResults.Panel1.SuspendLayout();
			this.scResults.Panel2.SuspendLayout();
			this.scResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scParameters)).BeginInit();
			this.scParameters.Panel1.SuspendLayout();
			this.scParameters.Panel2.SuspendLayout();
			this.scParameters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutputParameters)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
			this.ssStatus.SuspendLayout();
			this.msMainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMain
			// 
			this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcMain.Controls.Add(this.tpData);
			this.tcMain.Controls.Add(this.tpFunction);
			this.tcMain.Controls.Add(this.tpFit);
			this.tcMain.Controls.Add(this.tpResults);
			this.tcMain.Location = new System.Drawing.Point(0, 27);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(1020, 685);
			this.tcMain.TabIndex = 0;
			this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
			this.tcMain.TabIndexChanged += new System.EventHandler(this.tcMain_TabIndexChanged);
			// 
			// tpData
			// 
			this.tpData.Controls.Add(this.scData);
			this.tpData.Location = new System.Drawing.Point(4, 22);
			this.tpData.Name = "tpData";
			this.tpData.Padding = new System.Windows.Forms.Padding(3);
			this.tpData.Size = new System.Drawing.Size(1012, 659);
			this.tpData.TabIndex = 0;
			this.tpData.Text = "Data";
			this.tpData.UseVisualStyleBackColor = true;
			// 
			// scData
			// 
			this.scData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scData.Location = new System.Drawing.Point(3, 3);
			this.scData.Name = "scData";
			// 
			// scData.Panel1
			// 
			this.scData.Panel1.Controls.Add(this.scDataLeft);
			// 
			// scData.Panel2
			// 
			this.scData.Panel2.Controls.Add(this.scDataRight);
			this.scData.Size = new System.Drawing.Size(1006, 653);
			this.scData.SplitterDistance = 334;
			this.scData.TabIndex = 0;
			// 
			// scDataLeft
			// 
			this.scDataLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scDataLeft.Location = new System.Drawing.Point(0, 0);
			this.scDataLeft.Name = "scDataLeft";
			this.scDataLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scDataLeft.Panel1
			// 
			this.scDataLeft.Panel1.Controls.Add(this.lDataSets);
			this.scDataLeft.Panel1.Controls.Add(this.clbDataSet);
			// 
			// scDataLeft.Panel2
			// 
			this.scDataLeft.Panel2.Controls.Add(this.pgDataSet);
			this.scDataLeft.Size = new System.Drawing.Size(334, 653);
			this.scDataLeft.SplitterDistance = 287;
			this.scDataLeft.TabIndex = 0;
			// 
			// lDataSets
			// 
			this.lDataSets.AutoSize = true;
			this.lDataSets.Location = new System.Drawing.Point(5, 3);
			this.lDataSets.Name = "lDataSets";
			this.lDataSets.Size = new System.Drawing.Size(58, 13);
			this.lDataSets.TabIndex = 1;
			this.lDataSets.Text = "Input data:";
			// 
			// clbDataSet
			// 
			this.clbDataSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.clbDataSet.ContextMenuStrip = this.cmsDataSets;
			this.clbDataSet.FormattingEnabled = true;
			this.clbDataSet.Location = new System.Drawing.Point(0, 15);
			this.clbDataSet.Name = "clbDataSet";
			this.clbDataSet.Size = new System.Drawing.Size(334, 244);
			this.clbDataSet.TabIndex = 0;
			this.clbDataSet.ThreeDCheckBoxes = true;
			this.clbDataSet.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbDataSet_ItemCheck);
			this.clbDataSet.SelectedIndexChanged += new System.EventHandler(this.clbDataSet_SelectedIndexChanged);
			// 
			// cmsDataSets
			// 
			this.cmsDataSets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateDataSet,
            this.mqiImportFile,
            this.miCopyBuffer,
            this.miPasteBuffer,
            this.miDeleteDataSet});
			this.cmsDataSets.Name = "cmsDataSets";
			this.cmsDataSets.Size = new System.Drawing.Size(150, 114);
			// 
			// miCreateDataSet
			// 
			this.miCreateDataSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreate2D,
            this.miCreate3D,
            this.miCreateSurface});
			this.miCreateDataSet.Name = "miCreateDataSet";
			this.miCreateDataSet.Size = new System.Drawing.Size(149, 22);
			this.miCreateDataSet.Text = "Create";
			// 
			// miCreate2D
			// 
			this.miCreate2D.Name = "miCreate2D";
			this.miCreate2D.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.miCreate2D.Size = new System.Drawing.Size(137, 22);
			this.miCreate2D.Text = "2D";
			this.miCreate2D.Click += new System.EventHandler(this.miCreate2D_Click);
			// 
			// miCreate3D
			// 
			this.miCreate3D.Enabled = false;
			this.miCreate3D.Name = "miCreate3D";
			this.miCreate3D.Size = new System.Drawing.Size(137, 22);
			this.miCreate3D.Text = "3D curve";
			this.miCreate3D.Click += new System.EventHandler(this.miCreate3D_Click);
			// 
			// miCreateSurface
			// 
			this.miCreateSurface.Enabled = false;
			this.miCreateSurface.Name = "miCreateSurface";
			this.miCreateSurface.Size = new System.Drawing.Size(137, 22);
			this.miCreateSurface.Text = "Surface";
			this.miCreateSurface.Click += new System.EventHandler(this.miCreateSurface_Click);
			// 
			// mqiImportFile
			// 
			this.mqiImportFile.Name = "mqiImportFile";
			this.mqiImportFile.Size = new System.Drawing.Size(149, 22);
			this.mqiImportFile.Text = "Import file";
			this.mqiImportFile.Click += new System.EventHandler(this.mqiImportFile_Click);
			// 
			// miCopyBuffer
			// 
			this.miCopyBuffer.Image = global::SemiFit.Properties.Resources.Copy;
			this.miCopyBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.miCopyBuffer.Name = "miCopyBuffer";
			this.miCopyBuffer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.miCopyBuffer.Size = new System.Drawing.Size(149, 22);
			this.miCopyBuffer.Text = "Copy";
			// 
			// miPasteBuffer
			// 
			this.miPasteBuffer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPaste2D,
            this.miPasteXYY,
            this.miPasteXYXY,
            this.miPaste3DCurve,
            this.miPasteMultiple3D,
            this.miPasteMatrix});
			this.miPasteBuffer.Image = global::SemiFit.Properties.Resources.Paste;
			this.miPasteBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.miPasteBuffer.Name = "miPasteBuffer";
			this.miPasteBuffer.Size = new System.Drawing.Size(149, 22);
			this.miPasteBuffer.Text = "Paste";
			// 
			// miPaste2D
			// 
			this.miPaste2D.Name = "miPaste2D";
			this.miPaste2D.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.miPaste2D.Size = new System.Drawing.Size(159, 22);
			this.miPaste2D.Text = "XYY";
			this.miPaste2D.Click += new System.EventHandler(this.miPaste2D_Click);
			// 
			// miPasteXYY
			// 
			this.miPasteXYY.Enabled = false;
			this.miPasteXYY.Name = "miPasteXYY";
			this.miPasteXYY.Size = new System.Drawing.Size(159, 22);
			this.miPasteXYY.Text = "Multiple XYY";
			// 
			// miPasteXYXY
			// 
			this.miPasteXYXY.Enabled = false;
			this.miPasteXYXY.Name = "miPasteXYXY";
			this.miPasteXYXY.Size = new System.Drawing.Size(159, 22);
			this.miPasteXYXY.Text = "Multiple XYXY";
			// 
			// miPaste3DCurve
			// 
			this.miPaste3DCurve.Enabled = false;
			this.miPaste3DCurve.Name = "miPaste3DCurve";
			this.miPaste3DCurve.Size = new System.Drawing.Size(159, 22);
			this.miPaste3DCurve.Text = "Single 3D curve";
			// 
			// miPasteMultiple3D
			// 
			this.miPasteMultiple3D.Enabled = false;
			this.miPasteMultiple3D.Name = "miPasteMultiple3D";
			this.miPasteMultiple3D.Size = new System.Drawing.Size(159, 22);
			this.miPasteMultiple3D.Text = "Multiple 3D";
			// 
			// miPasteMatrix
			// 
			this.miPasteMatrix.Enabled = false;
			this.miPasteMatrix.Name = "miPasteMatrix";
			this.miPasteMatrix.Size = new System.Drawing.Size(159, 22);
			this.miPasteMatrix.Text = "Matrix";
			// 
			// miDeleteDataSet
			// 
			this.miDeleteDataSet.Image = global::SemiFit.Properties.Resources.Delete;
			this.miDeleteDataSet.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.miDeleteDataSet.Name = "miDeleteDataSet";
			this.miDeleteDataSet.Size = new System.Drawing.Size(149, 22);
			this.miDeleteDataSet.Text = "Delete";
			this.miDeleteDataSet.Click += new System.EventHandler(this.miDeleteDataSet_Click);
			// 
			// pgDataSet
			// 
			this.pgDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgDataSet.Location = new System.Drawing.Point(0, 0);
			this.pgDataSet.Name = "pgDataSet";
			this.pgDataSet.Size = new System.Drawing.Size(334, 362);
			this.pgDataSet.TabIndex = 0;
			this.pgDataSet.ToolbarVisible = false;
			this.pgDataSet.SelectedObjectsChanged += new System.EventHandler(this.pgDataSet_SelectedObjectsChanged);
			// 
			// scDataRight
			// 
			this.scDataRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scDataRight.Location = new System.Drawing.Point(0, 0);
			this.scDataRight.Name = "scDataRight";
			this.scDataRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scDataRight.Panel1
			// 
			this.scDataRight.Panel1.Controls.Add(this.dgvDataSet);
			// 
			// scDataRight.Panel2
			// 
			this.scDataRight.Panel2.Controls.Add(this.cDataSet);
			this.scDataRight.Size = new System.Drawing.Size(668, 653);
			this.scDataRight.SplitterDistance = 287;
			this.scDataRight.TabIndex = 0;
			// 
			// dgvDataSet
			// 
			this.dgvDataSet.AllowUserToOrderColumns = true;
			this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDataSet.Location = new System.Drawing.Point(0, 0);
			this.dgvDataSet.Name = "dgvDataSet";
			this.dgvDataSet.Size = new System.Drawing.Size(668, 287);
			this.dgvDataSet.TabIndex = 1;
			this.dgvDataSet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataSet_CellEndEdit);
			this.dgvDataSet.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDataSet_CellValidating);
			this.dgvDataSet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDataSet_KeyUp);
			// 
			// cDataSet
			// 
			chartArea1.Name = "ChartArea1";
			this.cDataSet.ChartAreas.Add(chartArea1);
			this.cDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.cDataSet.Legends.Add(legend1);
			this.cDataSet.Location = new System.Drawing.Point(0, 0);
			this.cDataSet.Name = "cDataSet";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series2.Color = System.Drawing.Color.Cyan;
			series2.Legend = "Legend1";
			series2.Name = "Series2";
			this.cDataSet.Series.Add(series1);
			this.cDataSet.Series.Add(series2);
			this.cDataSet.Size = new System.Drawing.Size(668, 362);
			this.cDataSet.TabIndex = 0;
			this.cDataSet.Text = "chart1";
			this.cDataSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cDataSet_MouseDown);
			this.cDataSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cDataSet_MouseMove);
			this.cDataSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cDataSet_MouseUp);
			// 
			// tpFunction
			// 
			this.tpFunction.Controls.Add(this.scFunction);
			this.tpFunction.Location = new System.Drawing.Point(4, 22);
			this.tpFunction.Name = "tpFunction";
			this.tpFunction.Padding = new System.Windows.Forms.Padding(3);
			this.tpFunction.Size = new System.Drawing.Size(1012, 659);
			this.tpFunction.TabIndex = 1;
			this.tpFunction.Text = "Function";
			this.tpFunction.UseVisualStyleBackColor = true;
			// 
			// scFunction
			// 
			this.scFunction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFunction.Location = new System.Drawing.Point(3, 3);
			this.scFunction.Name = "scFunction";
			// 
			// scFunction.Panel1
			// 
			this.scFunction.Panel1.Controls.Add(this.scFunctionLeft);
			// 
			// scFunction.Panel2
			// 
			this.scFunction.Panel2.Controls.Add(this.scFunctionView);
			this.scFunction.Size = new System.Drawing.Size(1018, 699);
			this.scFunction.SplitterDistance = 339;
			this.scFunction.TabIndex = 0;
			// 
			// scFunctionLeft
			// 
			this.scFunctionLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFunctionLeft.Location = new System.Drawing.Point(0, 0);
			this.scFunctionLeft.Name = "scFunctionLeft";
			this.scFunctionLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scFunctionLeft.Panel1
			// 
			this.scFunctionLeft.Panel1.Controls.Add(this.lFunctions);
			this.scFunctionLeft.Panel1.Controls.Add(this.tvFunctions);
			// 
			// scFunctionLeft.Panel2
			// 
			this.scFunctionLeft.Panel2.Controls.Add(this.lFitby);
			this.scFunctionLeft.Panel2.Controls.Add(this.lbFunctions);
			this.scFunctionLeft.Size = new System.Drawing.Size(339, 699);
			this.scFunctionLeft.SplitterDistance = 305;
			this.scFunctionLeft.TabIndex = 1;
			// 
			// lFunctions
			// 
			this.lFunctions.AutoSize = true;
			this.lFunctions.Location = new System.Drawing.Point(3, 3);
			this.lFunctions.Name = "lFunctions";
			this.lFunctions.Size = new System.Drawing.Size(81, 13);
			this.lFunctions.TabIndex = 1;
			this.lFunctions.Text = "Function library:";
			// 
			// tvFunctions
			// 
			this.tvFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tvFunctions.Location = new System.Drawing.Point(0, 19);
			this.tvFunctions.Name = "tvFunctions";
			treeNode1.Checked = true;
			treeNode1.Name = "General";
			treeNode1.Text = "General";
			this.tvFunctions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.tvFunctions.Size = new System.Drawing.Size(339, 286);
			this.tvFunctions.TabIndex = 0;
			this.tvFunctions.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvFunctions_ItemDrag);
			this.tvFunctions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFunctions_AfterSelect);
			// 
			// lFitby
			// 
			this.lFitby.AutoSize = true;
			this.lFitby.Location = new System.Drawing.Point(0, 6);
			this.lFitby.Name = "lFitby";
			this.lFitby.Size = new System.Drawing.Size(35, 13);
			this.lFitby.TabIndex = 1;
			this.lFitby.Text = "Fit by:";
			// 
			// lbFunctions
			// 
			this.lbFunctions.AllowDrop = true;
			this.lbFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbFunctions.ContextMenuStrip = this.cmsFunctions;
			this.lbFunctions.FormattingEnabled = true;
			this.lbFunctions.Location = new System.Drawing.Point(0, 22);
			this.lbFunctions.Name = "lbFunctions";
			this.lbFunctions.Size = new System.Drawing.Size(339, 355);
			this.lbFunctions.TabIndex = 0;
			this.lbFunctions.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFunctions_DragDrop);
			this.lbFunctions.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFunctions_DragEnter);
			this.lbFunctions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbFunctions_KeyPress);
			this.lbFunctions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbFunctions_KeyUp);
			// 
			// cmsFunctions
			// 
			this.cmsFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAdd,
            this.miSubtract,
            this.miMultiply,
            this.miDivide,
            this.miLeftBracket,
            this.miRightBracket,
            this.miClear});
			this.cmsFunctions.Name = "cmsFunctions";
			this.cmsFunctions.Size = new System.Drawing.Size(127, 158);
			// 
			// miAdd
			// 
			this.miAdd.Name = "miAdd";
			this.miAdd.Size = new System.Drawing.Size(126, 22);
			this.miAdd.Text = "Add";
			this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
			// 
			// miSubtract
			// 
			this.miSubtract.Name = "miSubtract";
			this.miSubtract.Size = new System.Drawing.Size(126, 22);
			this.miSubtract.Text = "Subtract";
			this.miSubtract.Click += new System.EventHandler(this.miSubtract_Click);
			// 
			// miMultiply
			// 
			this.miMultiply.Name = "miMultiply";
			this.miMultiply.Size = new System.Drawing.Size(126, 22);
			this.miMultiply.Text = "Multiply";
			this.miMultiply.Click += new System.EventHandler(this.miMultiply_Click);
			// 
			// miDivide
			// 
			this.miDivide.Name = "miDivide";
			this.miDivide.Size = new System.Drawing.Size(126, 22);
			this.miDivide.Text = "Divide";
			this.miDivide.Click += new System.EventHandler(this.miDivide_Click);
			// 
			// miLeftBracket
			// 
			this.miLeftBracket.Name = "miLeftBracket";
			this.miLeftBracket.Size = new System.Drawing.Size(126, 22);
			this.miLeftBracket.Text = "(";
			this.miLeftBracket.Click += new System.EventHandler(this.miLeftBracket_Click);
			// 
			// miRightBracket
			// 
			this.miRightBracket.Name = "miRightBracket";
			this.miRightBracket.Size = new System.Drawing.Size(126, 22);
			this.miRightBracket.Text = ")";
			this.miRightBracket.Click += new System.EventHandler(this.miRightBracket_Click);
			// 
			// miClear
			// 
			this.miClear.Name = "miClear";
			this.miClear.Size = new System.Drawing.Size(126, 22);
			this.miClear.Text = "Clear";
			this.miClear.Click += new System.EventHandler(this.miClear_Click);
			// 
			// scFunctionView
			// 
			this.scFunctionView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFunctionView.Location = new System.Drawing.Point(0, 0);
			this.scFunctionView.Name = "scFunctionView";
			this.scFunctionView.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scFunctionView.Panel1
			// 
			this.scFunctionView.Panel1.Controls.Add(this.cFunction);
			// 
			// scFunctionView.Panel2
			// 
			this.scFunctionView.Panel2.Controls.Add(this.flpFunction);
			this.scFunctionView.Size = new System.Drawing.Size(760, 699);
			this.scFunctionView.SplitterDistance = 465;
			this.scFunctionView.TabIndex = 0;
			// 
			// cFunction
			// 
			chartArea2.AxisX.IsMarginVisible = false;
			chartArea2.AxisY.IsMarginVisible = false;
			chartArea2.Name = "ChartArea1";
			this.cFunction.ChartAreas.Add(chartArea2);
			this.cFunction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cFunction.Location = new System.Drawing.Point(0, 0);
			this.cFunction.Margin = new System.Windows.Forms.Padding(0);
			this.cFunction.Name = "cFunction";
			series3.BorderWidth = 2;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Name = "Function";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series4.Color = System.Drawing.Color.Red;
			series4.MarkerSize = 7;
			series4.Name = "Markers";
			this.cFunction.Series.Add(series3);
			this.cFunction.Series.Add(series4);
			this.cFunction.Size = new System.Drawing.Size(760, 465);
			this.cFunction.TabIndex = 0;
			this.cFunction.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cFunction_MouseDown);
			this.cFunction.MouseLeave += new System.EventHandler(this.cFunction_MouseLeave);
			this.cFunction.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cFunction_MouseMove);
			this.cFunction.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cFunction_MouseUp);
			// 
			// flpFunction
			// 
			this.flpFunction.BackColor = System.Drawing.Color.White;
			this.flpFunction.Controls.Add(this.pbExpression);
			this.flpFunction.Controls.Add(this.rtbParameters);
			this.flpFunction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFunction.Location = new System.Drawing.Point(0, 0);
			this.flpFunction.Name = "flpFunction";
			this.flpFunction.Size = new System.Drawing.Size(760, 317);
			this.flpFunction.TabIndex = 0;
			// 
			// pbExpression
			// 
			this.pbExpression.BackColor = System.Drawing.Color.White;
			this.pbExpression.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbExpression.Location = new System.Drawing.Point(3, 3);
			this.pbExpression.Name = "pbExpression";
			this.pbExpression.Size = new System.Drawing.Size(221, 118);
			this.pbExpression.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbExpression.TabIndex = 0;
			this.pbExpression.TabStop = false;
			// 
			// rtbParameters
			// 
			this.rtbParameters.BackColor = System.Drawing.Color.White;
			this.rtbParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbParameters.Location = new System.Drawing.Point(230, 3);
			this.rtbParameters.Name = "rtbParameters";
			this.rtbParameters.ReadOnly = true;
			this.rtbParameters.Size = new System.Drawing.Size(217, 96);
			this.rtbParameters.TabIndex = 1;
			this.rtbParameters.Text = "";
			// 
			// tpFit
			// 
			this.tpFit.Controls.Add(this.scFit);
			this.tpFit.Location = new System.Drawing.Point(4, 22);
			this.tpFit.Name = "tpFit";
			this.tpFit.Size = new System.Drawing.Size(1012, 659);
			this.tpFit.TabIndex = 2;
			this.tpFit.Text = "Fit";
			this.tpFit.UseVisualStyleBackColor = true;
			// 
			// scFit
			// 
			this.scFit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFit.Location = new System.Drawing.Point(0, 0);
			this.scFit.Name = "scFit";
			this.scFit.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scFit.Panel1
			// 
			this.scFit.Panel1.Controls.Add(this.cFit);
			// 
			// scFit.Panel2
			// 
			this.scFit.Panel2.Controls.Add(this.scFitParameters);
			this.scFit.Size = new System.Drawing.Size(1012, 659);
			this.scFit.SplitterDistance = 414;
			this.scFit.TabIndex = 0;
			// 
			// cFit
			// 
			chartArea3.AxisX.IsMarginVisible = false;
			chartArea3.AxisY.IsMarginVisible = false;
			chartArea3.Name = "ChartArea1";
			this.cFit.ChartAreas.Add(chartArea3);
			this.cFit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cFit.Location = new System.Drawing.Point(0, 0);
			this.cFit.Margin = new System.Windows.Forms.Padding(0);
			this.cFit.Name = "cFit";
			this.cFit.Size = new System.Drawing.Size(1012, 414);
			this.cFit.TabIndex = 1;
			this.cFit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cFit_MouseDown);
			this.cFit.MouseLeave += new System.EventHandler(this.cFit_MouseLeave);
			this.cFit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cFit_MouseMove);
			this.cFit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cFit_MouseUp);
			// 
			// scFitParameters
			// 
			this.scFitParameters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFitParameters.Location = new System.Drawing.Point(0, 0);
			this.scFitParameters.Name = "scFitParameters";
			// 
			// scFitParameters.Panel1
			// 
			this.scFitParameters.Panel1.Controls.Add(this.cbDataSet);
			this.scFitParameters.Panel1.Controls.Add(this.clbFitFunctions);
			// 
			// scFitParameters.Panel2
			// 
			this.scFitParameters.Panel2.Controls.Add(this.dgvParameters);
			this.scFitParameters.Size = new System.Drawing.Size(1012, 241);
			this.scFitParameters.SplitterDistance = 337;
			this.scFitParameters.TabIndex = 0;
			// 
			// cbDataSet
			// 
			this.cbDataSet.Dock = System.Windows.Forms.DockStyle.Top;
			this.cbDataSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataSet.FormattingEnabled = true;
			this.cbDataSet.Location = new System.Drawing.Point(0, 0);
			this.cbDataSet.Name = "cbDataSet";
			this.cbDataSet.Size = new System.Drawing.Size(337, 21);
			this.cbDataSet.TabIndex = 1;
			this.cbDataSet.SelectedIndexChanged += new System.EventHandler(this.cbDataSet_SelectedIndexChanged);
			// 
			// clbFitFunctions
			// 
			this.clbFitFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.clbFitFunctions.FormattingEnabled = true;
			this.clbFitFunctions.Location = new System.Drawing.Point(0, 29);
			this.clbFitFunctions.Name = "clbFitFunctions";
			this.clbFitFunctions.Size = new System.Drawing.Size(334, 214);
			this.clbFitFunctions.TabIndex = 0;
			this.clbFitFunctions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbFitFunctions_ItemCheck);
			// 
			// dgvParameters
			// 
			this.dgvParameters.AllowUserToAddRows = false;
			this.dgvParameters.AllowUserToDeleteRows = false;
			this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterName,
            this.ParameterVary,
            this.ParameterValue,
            this.ParameterMinimum,
            this.ParameterMaximum});
			this.dgvParameters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvParameters.Location = new System.Drawing.Point(0, 0);
			this.dgvParameters.Name = "dgvParameters";
			this.dgvParameters.RowHeadersVisible = false;
			this.dgvParameters.Size = new System.Drawing.Size(671, 241);
			this.dgvParameters.TabIndex = 0;
			this.dgvParameters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParameters_CellEndEdit);
			this.dgvParameters.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvParameters_CellValidating);
			// 
			// ParameterName
			// 
			this.ParameterName.HeaderText = "Name";
			this.ParameterName.Name = "ParameterName";
			this.ParameterName.ReadOnly = true;
			// 
			// ParameterVary
			// 
			this.ParameterVary.HeaderText = "Vary";
			this.ParameterVary.Name = "ParameterVary";
			// 
			// ParameterValue
			// 
			this.ParameterValue.HeaderText = "Value";
			this.ParameterValue.Name = "ParameterValue";
			// 
			// ParameterMinimum
			// 
			this.ParameterMinimum.HeaderText = "Minimum";
			this.ParameterMinimum.Name = "ParameterMinimum";
			// 
			// ParameterMaximum
			// 
			this.ParameterMaximum.HeaderText = "Maximum";
			this.ParameterMaximum.Name = "ParameterMaximum";
			// 
			// tpResults
			// 
			this.tpResults.Controls.Add(this.scResults);
			this.tpResults.Location = new System.Drawing.Point(4, 22);
			this.tpResults.Name = "tpResults";
			this.tpResults.Size = new System.Drawing.Size(1012, 659);
			this.tpResults.TabIndex = 3;
			this.tpResults.Text = "Results";
			this.tpResults.UseVisualStyleBackColor = true;
			// 
			// scResults
			// 
			this.scResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scResults.Location = new System.Drawing.Point(0, 0);
			this.scResults.Name = "scResults";
			this.scResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scResults.Panel1
			// 
			this.scResults.Panel1.Controls.Add(this.scParameters);
			// 
			// scResults.Panel2
			// 
			this.scResults.Panel2.Controls.Add(this.dgvOutput);
			this.scResults.Size = new System.Drawing.Size(1024, 705);
			this.scResults.SplitterDistance = 239;
			this.scResults.TabIndex = 0;
			// 
			// scParameters
			// 
			this.scParameters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scParameters.Location = new System.Drawing.Point(0, 0);
			this.scParameters.Name = "scParameters";
			// 
			// scParameters.Panel1
			// 
			this.scParameters.Panel1.Controls.Add(this.pgOutput);
			// 
			// scParameters.Panel2
			// 
			this.scParameters.Panel2.Controls.Add(this.dgvOutputParameters);
			this.scParameters.Size = new System.Drawing.Size(1024, 239);
			this.scParameters.SplitterDistance = 341;
			this.scParameters.TabIndex = 0;
			// 
			// pgOutput
			// 
			this.pgOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgOutput.Location = new System.Drawing.Point(0, 0);
			this.pgOutput.Name = "pgOutput";
			this.pgOutput.Size = new System.Drawing.Size(341, 239);
			this.pgOutput.TabIndex = 0;
			this.pgOutput.ToolbarVisible = false;
			this.pgOutput.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgOutput_PropertyValueChanged);
			this.pgOutput.SelectedObjectsChanged += new System.EventHandler(this.pgOutput_SelectedObjectsChanged);
			// 
			// dgvOutputParameters
			// 
			this.dgvOutputParameters.AllowUserToAddRows = false;
			this.dgvOutputParameters.AllowUserToDeleteRows = false;
			this.dgvOutputParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOutputParameters.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOutputParameters.Location = new System.Drawing.Point(0, 0);
			this.dgvOutputParameters.Name = "dgvOutputParameters";
			this.dgvOutputParameters.ReadOnly = true;
			this.dgvOutputParameters.RowHeadersVisible = false;
			this.dgvOutputParameters.Size = new System.Drawing.Size(679, 239);
			this.dgvOutputParameters.TabIndex = 0;
			// 
			// dgvOutput
			// 
			this.dgvOutput.AllowUserToAddRows = false;
			this.dgvOutput.AllowUserToDeleteRows = false;
			this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOutput.Location = new System.Drawing.Point(0, 0);
			this.dgvOutput.Name = "dgvOutput";
			this.dgvOutput.ReadOnly = true;
			this.dgvOutput.RowHeadersVisible = false;
			this.dgvOutput.Size = new System.Drawing.Size(1024, 507);
			this.dgvOutput.TabIndex = 0;
			// 
			// ssStatus
			// 
			this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbFit,
            this.pbFit,
            this.lFitStatus});
			this.ssStatus.Location = new System.Drawing.Point(0, 712);
			this.ssStatus.Name = "ssStatus";
			this.ssStatus.Size = new System.Drawing.Size(1016, 22);
			this.ssStatus.TabIndex = 2;
			this.ssStatus.Text = "statusStrip1";
			// 
			// ddbFit
			// 
			this.ddbFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ddbFit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miIterations,
            this.cbIterations,
            this.miAlgorithm,
            this.cbAlgorithm,
            this.miAccuracy,
            this.tbFitAccuracy,
            this.miFit});
			this.ddbFit.Image = global::SemiFit.Properties.Resources.Run;
			this.ddbFit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ddbFit.Name = "ddbFit";
			this.ddbFit.Size = new System.Drawing.Size(29, 20);
			this.ddbFit.Text = "toolStripDropDownButton1";
			// 
			// miIterations
			// 
			this.miIterations.Name = "miIterations";
			this.miIterations.Size = new System.Drawing.Size(181, 22);
			this.miIterations.Text = "Iterations:";
			// 
			// cbIterations
			// 
			this.cbIterations.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.cbIterations.Items.AddRange(new object[] {
            "1",
            "10",
            "100",
            "1000"});
			this.cbIterations.Name = "cbIterations";
			this.cbIterations.Size = new System.Drawing.Size(121, 21);
			this.cbIterations.Text = "100";
			// 
			// miAlgorithm
			// 
			this.miAlgorithm.Name = "miAlgorithm";
			this.miAlgorithm.Size = new System.Drawing.Size(181, 22);
			this.miAlgorithm.Text = "Algorithm:";
			// 
			// cbAlgorithm
			// 
			this.cbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAlgorithm.Name = "cbAlgorithm";
			this.cbAlgorithm.Size = new System.Drawing.Size(121, 21);
			// 
			// miAccuracy
			// 
			this.miAccuracy.Name = "miAccuracy";
			this.miAccuracy.Size = new System.Drawing.Size(181, 22);
			this.miAccuracy.Text = "Accuracy:";
			// 
			// tbFitAccuracy
			// 
			this.tbFitAccuracy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tbFitAccuracy.Name = "tbFitAccuracy";
			this.tbFitAccuracy.Size = new System.Drawing.Size(100, 21);
			this.tbFitAccuracy.Text = "0.0";
			// 
			// miFit
			// 
			this.miFit.Name = "miFit";
			this.miFit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.miFit.Size = new System.Drawing.Size(181, 22);
			this.miFit.Text = "Fit";
			this.miFit.Click += new System.EventHandler(this.miFit_Click);
			// 
			// pbFit
			// 
			this.pbFit.Name = "pbFit";
			this.pbFit.Size = new System.Drawing.Size(100, 16);
			// 
			// lFitStatus
			// 
			this.lFitStatus.Name = "lFitStatus";
			this.lFitStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// msMainMenu
			// 
			this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fitToolStripMenuItem});
			this.msMainMenu.Location = new System.Drawing.Point(0, 0);
			this.msMainMenu.Name = "msMainMenu";
			this.msMainMenu.Size = new System.Drawing.Size(1016, 24);
			this.msMainMenu.TabIndex = 3;
			this.msMainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.createToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.importToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.importToolStripMenuItem.Text = "Import";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.mqiImportFile_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.createToolStripMenuItem.Text = "Create";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.miCreate2D_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = global::SemiFit.Properties.Resources.Copy;
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xYYToolStripMenuItem,
            this.xYXYToolStripMenuItem});
			this.pasteToolStripMenuItem.Image = global::SemiFit.Properties.Resources.Paste;
			this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			// 
			// xYYToolStripMenuItem
			// 
			this.xYYToolStripMenuItem.Name = "xYYToolStripMenuItem";
			this.xYYToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.xYYToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.xYYToolStripMenuItem.Text = "XYY";
			this.xYYToolStripMenuItem.Click += new System.EventHandler(this.miPaste2D_Click);
			// 
			// xYXYToolStripMenuItem
			// 
			this.xYXYToolStripMenuItem.Enabled = false;
			this.xYXYToolStripMenuItem.Name = "xYXYToolStripMenuItem";
			this.xYXYToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.xYXYToolStripMenuItem.Text = "XYXY";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::SemiFit.Properties.Resources.Delete;
			this.deleteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.miDeleteDataSet_Click);
			// 
			// fitToolStripMenuItem
			// 
			this.fitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitToolStripMenuItem1,
            this.tsmLogScale});
			this.fitToolStripMenuItem.Name = "fitToolStripMenuItem";
			this.fitToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
			this.fitToolStripMenuItem.Text = "Fit";
			// 
			// fitToolStripMenuItem1
			// 
			this.fitToolStripMenuItem1.Image = global::SemiFit.Properties.Resources.Run;
			this.fitToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.fitToolStripMenuItem1.Name = "fitToolStripMenuItem1";
			this.fitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.fitToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
			this.fitToolStripMenuItem1.Text = "Fit";
			// 
			// tsmLogScale
			// 
			this.tsmLogScale.CheckOnClick = true;
			this.tsmLogScale.Name = "tsmLogScale";
			this.tsmLogScale.Size = new System.Drawing.Size(135, 22);
			this.tsmLogScale.Text = "Log scale";
			this.tsmLogScale.CheckedChanged += new System.EventHandler(this.tsmLogScale_CheckedChanged);
			// 
			// fSemiFit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.msMainMenu);
			this.Controls.Add(this.ssStatus);
			this.Controls.Add(this.tcMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fSemiFit";
			this.Text = "SemiFit";
			this.tcMain.ResumeLayout(false);
			this.tpData.ResumeLayout(false);
			this.scData.Panel1.ResumeLayout(false);
			this.scData.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scData)).EndInit();
			this.scData.ResumeLayout(false);
			this.scDataLeft.Panel1.ResumeLayout(false);
			this.scDataLeft.Panel1.PerformLayout();
			this.scDataLeft.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scDataLeft)).EndInit();
			this.scDataLeft.ResumeLayout(false);
			this.cmsDataSets.ResumeLayout(false);
			this.scDataRight.Panel1.ResumeLayout(false);
			this.scDataRight.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scDataRight)).EndInit();
			this.scDataRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cDataSet)).EndInit();
			this.tpFunction.ResumeLayout(false);
			this.scFunction.Panel1.ResumeLayout(false);
			this.scFunction.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scFunction)).EndInit();
			this.scFunction.ResumeLayout(false);
			this.scFunctionLeft.Panel1.ResumeLayout(false);
			this.scFunctionLeft.Panel1.PerformLayout();
			this.scFunctionLeft.Panel2.ResumeLayout(false);
			this.scFunctionLeft.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFunctionLeft)).EndInit();
			this.scFunctionLeft.ResumeLayout(false);
			this.cmsFunctions.ResumeLayout(false);
			this.scFunctionView.Panel1.ResumeLayout(false);
			this.scFunctionView.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scFunctionView)).EndInit();
			this.scFunctionView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cFunction)).EndInit();
			this.flpFunction.ResumeLayout(false);
			this.flpFunction.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbExpression)).EndInit();
			this.tpFit.ResumeLayout(false);
			this.scFit.Panel1.ResumeLayout(false);
			this.scFit.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scFit)).EndInit();
			this.scFit.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cFit)).EndInit();
			this.scFitParameters.Panel1.ResumeLayout(false);
			this.scFitParameters.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scFitParameters)).EndInit();
			this.scFitParameters.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
			this.tpResults.ResumeLayout(false);
			this.scResults.Panel1.ResumeLayout(false);
			this.scResults.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scResults)).EndInit();
			this.scResults.ResumeLayout(false);
			this.scParameters.Panel1.ResumeLayout(false);
			this.scParameters.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scParameters)).EndInit();
			this.scParameters.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOutputParameters)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
			this.ssStatus.ResumeLayout(false);
			this.ssStatus.PerformLayout();
			this.msMainMenu.ResumeLayout(false);
			this.msMainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpData;
        private System.Windows.Forms.TabPage tpFunction;
        private System.Windows.Forms.SplitContainer scData;
        private System.Windows.Forms.TabPage tpFit;
		private System.Windows.Forms.TabPage tpResults;
		private System.Windows.Forms.SplitContainer scDataLeft;
		private System.Windows.Forms.PropertyGrid pgDataSet;
        private System.Windows.Forms.SplitContainer scFunction;
        private System.Windows.Forms.TreeView tvFunctions;
        private System.Windows.Forms.SplitContainer scFunctionView;
        private System.Windows.Forms.FlowLayoutPanel flpFunction;
        private System.Windows.Forms.SplitContainer scFit;
        private System.Windows.Forms.SplitContainer scFitParameters;
        private System.Windows.Forms.CheckedListBox clbFitFunctions;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ParameterVary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterMaximum;
        private System.Windows.Forms.SplitContainer scResults;
        private System.Windows.Forms.SplitContainer scParameters;
        private System.Windows.Forms.PropertyGrid pgOutput;
        private System.Windows.Forms.DataGridView dgvOutputParameters;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart cFunction;
        private System.Windows.Forms.ContextMenuStrip cmsDataSets;
        private System.Windows.Forms.ToolStripMenuItem mqiImportFile;
        private System.Windows.Forms.ToolStripMenuItem miCreateDataSet;
        private System.Windows.Forms.ToolStripMenuItem miDeleteDataSet;
        private System.Windows.Forms.ToolStripMenuItem miCreate2D;
        private System.Windows.Forms.ToolStripMenuItem miCreate3D;
		private System.Windows.Forms.ToolStripMenuItem miCreateSurface;
		private System.Windows.Forms.SplitContainer scDataRight;
		private System.Windows.Forms.DataGridView dgvDataSet;
		private System.Windows.Forms.DataVisualization.Charting.Chart cDataSet;
		private System.Windows.Forms.ToolStripMenuItem miCopyBuffer;
		private System.Windows.Forms.ToolStripMenuItem miPasteBuffer;
		private System.Windows.Forms.ComboBox cbDataSet;
		private System.Windows.Forms.CheckedListBox clbDataSet;
		private System.Windows.Forms.ToolStripMenuItem miPaste2D;
		private System.Windows.Forms.ToolStripMenuItem miPasteXYY;
		private System.Windows.Forms.ToolStripMenuItem miPaste3DCurve;
		private System.Windows.Forms.ToolStripMenuItem miPasteXYXY;
		private System.Windows.Forms.ToolStripMenuItem miPasteMultiple3D;
		private System.Windows.Forms.ToolStripMenuItem miPasteMatrix;
		private System.Windows.Forms.PictureBox pbExpression;
		private System.Windows.Forms.RichTextBox rtbParameters;
		private System.Windows.Forms.SplitContainer scFunctionLeft;
		private System.Windows.Forms.ListBox lbFunctions;
		private System.Windows.Forms.ContextMenuStrip cmsFunctions;
		private System.Windows.Forms.ToolStripMenuItem miAdd;
		private System.Windows.Forms.ToolStripMenuItem miSubtract;
		private System.Windows.Forms.ToolStripMenuItem miMultiply;
		private System.Windows.Forms.ToolStripMenuItem miDivide;
		private System.Windows.Forms.ToolStripMenuItem miLeftBracket;
		private System.Windows.Forms.ToolStripMenuItem miRightBracket;
		private System.Windows.Forms.ToolStripMenuItem miClear;
		private System.Windows.Forms.DataVisualization.Charting.Chart cFit;
		private System.Windows.Forms.StatusStrip ssStatus;
		private System.Windows.Forms.ToolStripDropDownButton ddbFit;
		private System.Windows.Forms.ToolStripMenuItem miFit;
		private System.Windows.Forms.ToolStripMenuItem miIterations;
		private System.Windows.Forms.ToolStripComboBox cbIterations;
		private System.Windows.Forms.ToolStripComboBox cbAlgorithm;
		private System.Windows.Forms.ToolStripMenuItem miAlgorithm;
		private System.Windows.Forms.ToolStripProgressBar pbFit;
		private System.Windows.Forms.ToolStripStatusLabel lFitStatus;
		private System.Windows.Forms.ToolStripTextBox tbFitAccuracy;
		private System.Windows.Forms.ToolStripMenuItem miAccuracy;
		private System.Windows.Forms.MenuStrip msMainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xYYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xYXYToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem tsmLogScale;
		private System.Windows.Forms.Label lDataSets;
		private System.Windows.Forms.Label lFunctions;
		private System.Windows.Forms.Label lFitby;
    }
}

