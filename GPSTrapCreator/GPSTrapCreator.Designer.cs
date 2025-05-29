namespace GPSTrapCreator
{
    partial class GPSTrapCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPSTrapCreator));
            this._mapComponent = new GMap.NET.WindowsForms.GMapControl();
            this._rdoZones = new System.Windows.Forms.RadioButton();
            this._rdoAngles = new System.Windows.Forms.RadioButton();
            this._dg1 = new System.Windows.Forms.DataGridView();
            this._btnPrepare = new System.Windows.Forms.Button();
            this._btnClear = new System.Windows.Forms.Button();
            this._txtSearch = new System.Windows.Forms.TextBox();
            this._btnSearch = new System.Windows.Forms.Button();
            this._btnExport = new System.Windows.Forms.Button();
            this.txt_trapPolyHeight = new System.Windows.Forms.TextBox();
            this.txt_trapPolyWidth = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.groupBoxHelp = new System.Windows.Forms.GroupBox();
            this.txtInstructions = new System.Windows.Forms.RichTextBox();
            this.groupBoxTrapSettings = new System.Windows.Forms.GroupBox();
            this.lblTrapPolyWidth = new System.Windows.Forms.Label();
            this.lblTrapPolyHeight = new System.Windows.Forms.Label();
            this.groupBoxModeSelect = new System.Windows.Forms.GroupBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._dg1)).BeginInit();
            this.panelMap.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.groupBoxHelp.SuspendLayout();
            this.groupBoxTrapSettings.SuspendLayout();
            this.groupBoxModeSelect.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mapComponent
            // 
            this._mapComponent.Bearing = 0F;
            this._mapComponent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._mapComponent.CanDragMap = true;
            this._mapComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mapComponent.EmptyTileColor = System.Drawing.Color.Navy;
            this._mapComponent.GrayScaleMode = false;
            this._mapComponent.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this._mapComponent.LevelsKeepInMemmory = 5;
            this._mapComponent.Location = new System.Drawing.Point(0, 0);
            this._mapComponent.MarkersEnabled = true;
            this._mapComponent.MaxZoom = 1000;
            this._mapComponent.MinZoom = 0;
            this._mapComponent.MouseWheelZoomEnabled = true;
            this._mapComponent.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this._mapComponent.Name = "_mapComponent";
            this._mapComponent.NegativeMode = false;
            this._mapComponent.PolygonsEnabled = true;
            this._mapComponent.RetryLoadTile = 0;
            this._mapComponent.RoutesEnabled = true;
            this._mapComponent.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this._mapComponent.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this._mapComponent.ShowTileGridLines = false;
            this._mapComponent.Size = new System.Drawing.Size(986, 1100);
            this._mapComponent.TabIndex = 0;
            this._mapComponent.Zoom = 0D;
            this._mapComponent.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapComponent_MarkerClicked);
            this._mapComponent.Load += new System.EventHandler(this.mapComponent_Load);
            this._mapComponent.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapComponent_MouseDoubleClick);
            // 
            // _rdoZones
            // 
            this._rdoZones.AutoSize = true;
            this._rdoZones.Checked = true;
            this._rdoZones.Location = new System.Drawing.Point(15, 25);
            this._rdoZones.Margin = new System.Windows.Forms.Padding(2);
            this._rdoZones.Name = "_rdoZones";
            this._rdoZones.Size = new System.Drawing.Size(107, 24);
            this._rdoZones.TabIndex = 2;
            this._rdoZones.TabStop = true;
            this._rdoZones.Text = "Lay Points";
            this._rdoZones.UseVisualStyleBackColor = true;
            this._rdoZones.CheckedChanged += new System.EventHandler(this.rdoZones_CheckedChanged);
            // 
            // _rdoAngles
            // 
            this._rdoAngles.AutoSize = true;
            this._rdoAngles.Location = new System.Drawing.Point(15, 53);
            this._rdoAngles.Margin = new System.Windows.Forms.Padding(2);
            this._rdoAngles.Name = "_rdoAngles";
            this._rdoAngles.Size = new System.Drawing.Size(265, 24);
            this._rdoAngles.TabIndex = 3;
            this._rdoAngles.Text = "Lay Angles (Lines up with points)";
            this._rdoAngles.UseVisualStyleBackColor = true;
            this._rdoAngles.CheckedChanged += new System.EventHandler(this.rdoAngles_CheckedChanged);
            // 
            // _dg1
            // 
            this._dg1.AllowUserToAddRows = false;
            this._dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dg1.Location = new System.Drawing.Point(3, 22);
            this._dg1.Margin = new System.Windows.Forms.Padding(2);
            this._dg1.Name = "_dg1";
            this._dg1.RowHeadersWidth = 62;
            this._dg1.RowTemplate.Height = 33;
            this._dg1.Size = new System.Drawing.Size(584, 301);
            this._dg1.TabIndex = 4;
            // 
            // _btnPrepare
            // 
            this._btnPrepare.Location = new System.Drawing.Point(148, 25);
            this._btnPrepare.Margin = new System.Windows.Forms.Padding(2);
            this._btnPrepare.Name = "_btnPrepare";
            this._btnPrepare.Size = new System.Drawing.Size(132, 36);
            this._btnPrepare.TabIndex = 5;
            this._btnPrepare.Text = "Prepare";
            this._btnPrepare.UseVisualStyleBackColor = true;
            this._btnPrepare.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(15, 65);
            this._btnClear.Margin = new System.Windows.Forms.Padding(2);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(132, 36);
            this._btnClear.TabIndex = 7;
            this._btnClear.Text = "Clear All";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // _txtSearch
            // 
            this._txtSearch.Location = new System.Drawing.Point(15, 25);
            this._txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this._txtSearch.Name = "_txtSearch";
            this._txtSearch.Size = new System.Drawing.Size(268, 26);
            this._txtSearch.TabIndex = 10;
            this._txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // _btnSearch
            // 
            this._btnSearch.Location = new System.Drawing.Point(15, 55);
            this._btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this._btnSearch.Name = "_btnSearch";
            this._btnSearch.Size = new System.Drawing.Size(132, 36);
            this._btnSearch.TabIndex = 9;
            this._btnSearch.Text = "Search";
            this._btnSearch.UseVisualStyleBackColor = true;
            this._btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // _btnExport
            // 
            this._btnExport.Location = new System.Drawing.Point(151, 65);
            this._btnExport.Margin = new System.Windows.Forms.Padding(2);
            this._btnExport.Name = "_btnExport";
            this._btnExport.Size = new System.Drawing.Size(132, 36);
            this._btnExport.TabIndex = 11;
            this._btnExport.Text = "Export CSV";
            this._btnExport.UseVisualStyleBackColor = true;
            this._btnExport.Click += new System.EventHandler(this.BtnToCsv_Click);
            // 
            // txt_trapPolyHeight
            // 
            this.txt_trapPolyHeight.Location = new System.Drawing.Point(131, 31);
            this.txt_trapPolyHeight.MaxLength = 9;
            this.txt_trapPolyHeight.Name = "txt_trapPolyHeight";
            this.txt_trapPolyHeight.Size = new System.Drawing.Size(153, 26);
            this.txt_trapPolyHeight.TabIndex = 12;
            this.txt_trapPolyHeight.Text = "0.00006";
            this.txt_trapPolyHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_trapPolyHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trapPolyHeight_KeyPress);
            // 
            // txt_trapPolyWidth
            // 
            this.txt_trapPolyWidth.Location = new System.Drawing.Point(131, 63);
            this.txt_trapPolyWidth.MaxLength = 9;
            this.txt_trapPolyWidth.Name = "txt_trapPolyWidth";
            this.txt_trapPolyWidth.Size = new System.Drawing.Size(153, 26);
            this.txt_trapPolyWidth.TabIndex = 13;
            this.txt_trapPolyWidth.Text = "0.00023";
            this.txt_trapPolyWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_trapPolyWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_trapPolyWidth_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMap
            // 
            this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMap.Controls.Add(this._mapComponent);
            this.panelMap.Location = new System.Drawing.Point(12, 12);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(986, 1100);
            this.panelMap.TabIndex = 14;
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.Controls.Add(this.groupBoxHelp);
            this.panelControls.Controls.Add(this.groupBoxTrapSettings);
            this.panelControls.Controls.Add(this.groupBoxModeSelect);
            this.panelControls.Controls.Add(this.groupBoxSearch);
            this.panelControls.Controls.Add(this.groupBoxActions);
            this.panelControls.Controls.Add(this.groupBoxResults);
            this.panelControls.Location = new System.Drawing.Point(1004, 12);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(934, 1100);
            this.panelControls.TabIndex = 15;
            // 
            // groupBoxHelp
            // 
            this.groupBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHelp.Controls.Add(this.txtInstructions);
            this.groupBoxHelp.Location = new System.Drawing.Point(13, 657);
            this.groupBoxHelp.Name = "groupBoxHelp";
            this.groupBoxHelp.Size = new System.Drawing.Size(910, 431);
            this.groupBoxHelp.TabIndex = 22;
            this.groupBoxHelp.TabStop = false;
            this.groupBoxHelp.Text = "Instructions";
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.Control;
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInstructions.Location = new System.Drawing.Point(3, 22);
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(904, 406);
            this.txtInstructions.TabIndex = 0;
            this.txtInstructions.Text = resources.GetString("txtInstructions.Text");
            // 
            // groupBoxTrapSettings
            // 
            this.groupBoxTrapSettings.Controls.Add(this.lblTrapPolyWidth);
            this.groupBoxTrapSettings.Controls.Add(this.lblTrapPolyHeight);
            this.groupBoxTrapSettings.Controls.Add(this.txt_trapPolyHeight);
            this.groupBoxTrapSettings.Controls.Add(this.txt_trapPolyWidth);
            this.groupBoxTrapSettings.Location = new System.Drawing.Point(13, 278);
            this.groupBoxTrapSettings.Name = "groupBoxTrapSettings";
            this.groupBoxTrapSettings.Size = new System.Drawing.Size(302, 103);
            this.groupBoxTrapSettings.TabIndex = 21;
            this.groupBoxTrapSettings.TabStop = false;
            this.groupBoxTrapSettings.Text = "Trap Dimensions";
            // 
            // lblTrapPolyWidth
            // 
            this.lblTrapPolyWidth.AutoSize = true;
            this.lblTrapPolyWidth.Location = new System.Drawing.Point(15, 66);
            this.lblTrapPolyWidth.Name = "lblTrapPolyWidth";
            this.lblTrapPolyWidth.Size = new System.Drawing.Size(114, 20);
            this.lblTrapPolyWidth.TabIndex = 15;
            this.lblTrapPolyWidth.Text = "Polygon Width:";
            // 
            // lblTrapPolyHeight
            // 
            this.lblTrapPolyHeight.AutoSize = true;
            this.lblTrapPolyHeight.Location = new System.Drawing.Point(15, 34);
            this.lblTrapPolyHeight.Name = "lblTrapPolyHeight";
            this.lblTrapPolyHeight.Size = new System.Drawing.Size(120, 20);
            this.lblTrapPolyHeight.TabIndex = 14;
            this.lblTrapPolyHeight.Text = "Polygon Height:";
            // 
            // groupBoxModeSelect
            // 
            this.groupBoxModeSelect.Controls.Add(this._rdoZones);
            this.groupBoxModeSelect.Controls.Add(this._rdoAngles);
            this.groupBoxModeSelect.Location = new System.Drawing.Point(13, 187);
            this.groupBoxModeSelect.Name = "groupBoxModeSelect";
            this.groupBoxModeSelect.Size = new System.Drawing.Size(302, 85);
            this.groupBoxModeSelect.TabIndex = 20;
            this.groupBoxModeSelect.TabStop = false;
            this.groupBoxModeSelect.Text = "Mode Selection";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this._txtSearch);
            this.groupBoxSearch.Controls.Add(this._btnSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(13, 18);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(302, 104);
            this.groupBoxSearch.TabIndex = 18;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Location Search";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this._btnPrepare);
            this.groupBoxActions.Controls.Add(this._btnClear);
            this.groupBoxActions.Controls.Add(this._btnExport);
            this.groupBoxActions.Location = new System.Drawing.Point(13, 387);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(302, 114);
            this.groupBoxActions.TabIndex = 19;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResults.Controls.Add(this._dg1);
            this.groupBoxResults.Location = new System.Drawing.Point(333, 18);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(590, 326);
            this.groupBoxResults.TabIndex = 17;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 1113);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1950, 32);
            this.statusStrip.TabIndex = 16;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 25);
            this.statusLabel.Text = "Ready";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // GPSTrapCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1950, 1145);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelMap);
            this.Name = "GPSTrapCreator";
            this.Text = "GPS Trap Creator";
            ((System.ComponentModel.ISupportInitialize)(this._dg1)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.groupBoxHelp.ResumeLayout(false);
            this.groupBoxTrapSettings.ResumeLayout(false);
            this.groupBoxTrapSettings.PerformLayout();
            this.groupBoxModeSelect.ResumeLayout(false);
            this.groupBoxModeSelect.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl _mapComponent;
        private System.Windows.Forms.RadioButton _rdoZones;
        private System.Windows.Forms.RadioButton _rdoAngles;
        private System.Windows.Forms.DataGridView _dg1;
        private System.Windows.Forms.Button _btnPrepare;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.TextBox _txtSearch;
        private System.Windows.Forms.Button _btnSearch;
        private System.Windows.Forms.Button _btnExport;
        private System.Windows.Forms.TextBox txt_trapPolyHeight;
        private System.Windows.Forms.TextBox txt_trapPolyWidth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.GroupBox groupBoxModeSelect;
        private System.Windows.Forms.GroupBox groupBoxTrapSettings;
        private System.Windows.Forms.Label lblTrapPolyWidth;
        private System.Windows.Forms.Label lblTrapPolyHeight;
        private System.Windows.Forms.GroupBox groupBoxHelp;
        private System.Windows.Forms.RichTextBox txtInstructions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
