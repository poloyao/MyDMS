namespace YZXDMS.Views
{
    partial class SettingPortView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition5 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition6 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement7 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPortName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colBaudRate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDataBits = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colParity = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRouteTotal = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colStopBits = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.portConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colProtocol = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDeviceType = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colPortName
            // 
            this.colPortName.FieldName = "PortName";
            this.colPortName.Name = "colPortName";
            this.colPortName.Visible = true;
            this.colPortName.VisibleIndex = 2;
            // 
            // colBaudRate
            // 
            this.colBaudRate.FieldName = "BaudRate";
            this.colBaudRate.Name = "colBaudRate";
            this.colBaudRate.Visible = true;
            this.colBaudRate.VisibleIndex = 3;
            // 
            // colDataBits
            // 
            this.colDataBits.FieldName = "DataBits";
            this.colDataBits.Name = "colDataBits";
            this.colDataBits.Visible = true;
            this.colDataBits.VisibleIndex = 4;
            // 
            // colParity
            // 
            this.colParity.FieldName = "Parity";
            this.colParity.Name = "colParity";
            this.colParity.Visible = true;
            this.colParity.VisibleIndex = 5;
            // 
            // colRouteTotal
            // 
            this.colRouteTotal.FieldName = "RouteTotal";
            this.colRouteTotal.Name = "colRouteTotal";
            this.colRouteTotal.Visible = true;
            this.colRouteTotal.VisibleIndex = 7;
            // 
            // colStopBits
            // 
            this.colStopBits.FieldName = "StopBits";
            this.colStopBits.Name = "colStopBits";
            this.colStopBits.Visible = true;
            this.colStopBits.VisibleIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.portConfigBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(690, 569);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // portConfigBindingSource
            // 
            this.portConfigBindingSource.DataSource = typeof(YZXDMS.Models.PortConfig);
            // 
            // tileView1
            // 
            this.tileView1.Appearance.GroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(50)))));
            this.tileView1.Appearance.GroupText.Options.UseFont = true;
            this.tileView1.Appearance.GroupText.Options.UseForeColor = true;
            this.tileView1.Appearance.ItemFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(50)))));
            this.tileView1.Appearance.ItemFocused.Options.UseBackColor = true;
            this.tileView1.Appearance.ItemHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(124)))), ((int)(((byte)(50)))));
            this.tileView1.Appearance.ItemHovered.Options.UseBackColor = true;
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colPortName,
            this.colBaudRate,
            this.colDataBits,
            this.colParity,
            this.colStopBits,
            this.colRouteTotal,
            this.colProtocol,
            this.colDeviceType});
            this.tileView1.ContextButtonOptions.Indent = 6;
            this.tileView1.ContextButtonOptions.TopPanelPadding = new System.Windows.Forms.Padding(5, 10, 20, 5);
            this.tileView1.FocusBorderColor = System.Drawing.Color.Transparent;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsBehavior.AllowSmoothScrolling = true;
            this.tileView1.OptionsTiles.AllowItemHover = true;
            this.tileView1.OptionsTiles.AllowPressAnimation = false;
            this.tileView1.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView1.OptionsTiles.IndentBetweenItems = 0;
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(248, 60);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.OptionsTiles.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.TouchScrollBar;
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            this.tileView1.TileColumns.Add(tableColumnDefinition4);
            this.tileView1.TileColumns.Add(tableColumnDefinition5);
            this.tileView1.TileColumns.Add(tableColumnDefinition6);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            tableSpan1.ColumnIndex = 1;
            tableSpan1.ColumnSpan = 4;
            this.tileView1.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.colName;
            tileViewItemElement1.ColumnIndex = 2;
            tileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colName";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileViewItemElement2.Column = this.colPortName;
            tileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colPortName";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colBaudRate;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "colBaudRate";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.colDataBits;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "colDataBits";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Column = this.colParity;
            tileViewItemElement5.ColumnIndex = 3;
            tileViewItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "colParity";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.Column = this.colRouteTotal;
            tileViewItemElement6.ColumnIndex = 5;
            tileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement6.RowIndex = 1;
            tileViewItemElement6.Text = "colRouteTotal";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.Column = this.colStopBits;
            tileViewItemElement7.ColumnIndex = 4;
            tileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement7.RowIndex = 1;
            tileViewItemElement7.Text = "colStopBits";
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            this.tileView1.TileTemplate.Add(tileViewItemElement5);
            this.tileView1.TileTemplate.Add(tileViewItemElement6);
            this.tileView1.TileTemplate.Add(tileViewItemElement7);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colProtocol
            // 
            this.colProtocol.FieldName = "Protocol";
            this.colProtocol.Name = "colProtocol";
            this.colProtocol.Visible = true;
            this.colProtocol.VisibleIndex = 8;
            // 
            // colDeviceType
            // 
            this.colDeviceType.FieldName = "DeviceType";
            this.colDeviceType.Name = "colDeviceType";
            this.colDeviceType.Visible = true;
            this.colDeviceType.VisibleIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 569);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(688, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 669);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 572);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 97);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(570, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(457, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingPortView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "SettingPortView";
            this.Size = new System.Drawing.Size(1011, 669);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource portConfigBindingSource;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPortName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colBaudRate;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDataBits;
        private DevExpress.XtraGrid.Columns.TileViewColumn colParity;
        private DevExpress.XtraGrid.Columns.TileViewColumn colStopBits;
        private DevExpress.XtraGrid.Columns.TileViewColumn colRouteTotal;
        private DevExpress.XtraGrid.Columns.TileViewColumn colProtocol;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDeviceType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
