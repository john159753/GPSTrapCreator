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
            this.mapexplr = new GMap.NET.WindowsForms.GMapControl();
            this.rdoZones = new System.Windows.Forms.RadioButton();
            this.rdoAngles = new System.Windows.Forms.RadioButton();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.BtnPrepare = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapexplr
            // 
            this.mapexplr.Bearing = 0F;
            this.mapexplr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mapexplr.CanDragMap = true;
            this.mapexplr.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapexplr.GrayScaleMode = false;
            this.mapexplr.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapexplr.LevelsKeepInMemmory = 5;
            this.mapexplr.Location = new System.Drawing.Point(12, 12);
            this.mapexplr.MarkersEnabled = true;
            this.mapexplr.MaxZoom = 1000;
            this.mapexplr.MinZoom = 0;
            this.mapexplr.MouseWheelZoomEnabled = true;
            this.mapexplr.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapexplr.Name = "mapexplr";
            this.mapexplr.NegativeMode = false;
            this.mapexplr.PolygonsEnabled = true;
            this.mapexplr.RetryLoadTile = 0;
            this.mapexplr.RoutesEnabled = true;
            this.mapexplr.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapexplr.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapexplr.ShowTileGridLines = false;
            this.mapexplr.Size = new System.Drawing.Size(1313, 1528);
            this.mapexplr.TabIndex = 0;
            this.mapexplr.Zoom = 0D;
            this.mapexplr.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.mapMarkerClicked);
            this.mapexplr.Load += new System.EventHandler(this.mapexplr_Load_1);
            this.mapexplr.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mapexplr_MouseDoubleClick);
            // 
            // rdoZones
            // 
            this.rdoZones.AutoSize = true;
            this.rdoZones.Checked = true;
            this.rdoZones.Location = new System.Drawing.Point(1547, 24);
            this.rdoZones.Name = "rdoZones";
            this.rdoZones.Size = new System.Drawing.Size(144, 29);
            this.rdoZones.TabIndex = 2;
            this.rdoZones.TabStop = true;
            this.rdoZones.Text = "Lay Points";
            this.rdoZones.UseVisualStyleBackColor = true;
            this.rdoZones.CheckedChanged += new System.EventHandler(this.rdoZones_CheckedChanged);
            // 
            // rdoAngles
            // 
            this.rdoAngles.AutoSize = true;
            this.rdoAngles.Location = new System.Drawing.Point(1547, 59);
            this.rdoAngles.Name = "rdoAngles";
            this.rdoAngles.Size = new System.Drawing.Size(360, 29);
            this.rdoAngles.TabIndex = 3;
            this.rdoAngles.Text = "Lay Angles (Lines up with points)";
            this.rdoAngles.UseVisualStyleBackColor = true;
            this.rdoAngles.CheckedChanged += new System.EventHandler(this.rdoAngles_CheckedChanged);
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(1331, 126);
            this.dg1.Name = "dg1";
            this.dg1.RowTemplate.Height = 33;
            this.dg1.Size = new System.Drawing.Size(1167, 625);
            this.dg1.TabIndex = 4;
            // 
            // BtnPrepare
            // 
            this.BtnPrepare.Location = new System.Drawing.Point(2322, 757);
            this.BtnPrepare.Name = "BtnPrepare";
            this.BtnPrepare.Size = new System.Drawing.Size(176, 48);
            this.BtnPrepare.TabIndex = 5;
            this.BtnPrepare.Text = "Prepare";
            this.BtnPrepare.UseVisualStyleBackColor = true;
            this.BtnPrepare.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1331, 757);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(176, 48);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1331, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 31);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1331, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 48);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(2322, 811);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(176, 48);
            this.BtnExport.TabIndex = 11;
            this.BtnExport.Text = "Export CSV";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnToCsv_Click);
            // 
            // GPSTrapCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(2613, 1783);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.BtnPrepare);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.rdoAngles);
            this.Controls.Add(this.rdoZones);
            this.Controls.Add(this.mapexplr);
            this.Name = "GPSTrapCreator";
            this.Text = "GPS Trap Creator";
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapexplr;
        private System.Windows.Forms.RadioButton rdoZones;
        private System.Windows.Forms.RadioButton rdoAngles;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Button BtnPrepare;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button BtnExport;
    }
}

