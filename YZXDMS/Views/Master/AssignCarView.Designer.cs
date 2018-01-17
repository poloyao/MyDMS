namespace YZXDMS.Views.Master
{
    partial class AssignCarView
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.waitDetectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCarInfoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljylsh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colCarInfoId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljylsh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUDP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitDetectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Controls.Add(this.button1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1203, 273, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(802, 563);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.waitDetectionBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(12, 315);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(778, 236);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarInfoId1,
            this.coljylsh1,
            this.colLineID1,
            this.colStatus1,
            this.colUDP1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(778, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "添加到当前检测列表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.waitDetectionBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(778, 256);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // waitDetectionBindingSource
            // 
            this.waitDetectionBindingSource.DataSource = typeof(YZXDMS.Models.WaitDetection);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarInfoId,
            this.coljylsh,
            this.colLineID,
            this.colStatus,
            this.colUDP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCarInfoId
            // 
            this.colCarInfoId.FieldName = "CarInfoId";
            this.colCarInfoId.Name = "colCarInfoId";
            this.colCarInfoId.Visible = true;
            this.colCarInfoId.VisibleIndex = 0;
            // 
            // coljylsh
            // 
            this.coljylsh.FieldName = "jylsh";
            this.coljylsh.Name = "coljylsh";
            this.coljylsh.Visible = true;
            this.coljylsh.VisibleIndex = 1;
            // 
            // colLineID
            // 
            this.colLineID.FieldName = "LineID";
            this.colLineID.Name = "colLineID";
            this.colLineID.Visible = true;
            this.colLineID.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colUDP
            // 
            this.colUDP.FieldName = "UDP";
            this.colUDP.Name = "colUDP";
            this.colUDP.Visible = true;
            this.colUDP.VisibleIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(802, 563);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(782, 260);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.button1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 260);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 43);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(24, 43);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(782, 43);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 303);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(782, 240);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // colCarInfoId1
            // 
            this.colCarInfoId1.FieldName = "CarInfoId";
            this.colCarInfoId1.Name = "colCarInfoId1";
            this.colCarInfoId1.Visible = true;
            this.colCarInfoId1.VisibleIndex = 0;
            // 
            // coljylsh1
            // 
            this.coljylsh1.FieldName = "jylsh";
            this.coljylsh1.Name = "coljylsh1";
            this.coljylsh1.Visible = true;
            this.coljylsh1.VisibleIndex = 1;
            // 
            // colLineID1
            // 
            this.colLineID1.FieldName = "LineID";
            this.colLineID1.Name = "colLineID1";
            this.colLineID1.Visible = true;
            this.colLineID1.VisibleIndex = 2;
            // 
            // colStatus1
            // 
            this.colStatus1.FieldName = "Status";
            this.colStatus1.Name = "colStatus1";
            this.colStatus1.Visible = true;
            this.colStatus1.VisibleIndex = 3;
            // 
            // colUDP1
            // 
            this.colUDP1.FieldName = "UDP";
            this.colUDP1.Name = "colUDP1";
            this.colUDP1.Visible = true;
            this.colUDP1.VisibleIndex = 4;
            // 
            // AssignCarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "AssignCarView";
            this.Size = new System.Drawing.Size(802, 563);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitDetectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource waitDetectionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCarInfoId;
        private DevExpress.XtraGrid.Columns.GridColumn coljylsh;
        private DevExpress.XtraGrid.Columns.GridColumn colLineID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUDP;
        private DevExpress.XtraGrid.Columns.GridColumn colCarInfoId1;
        private DevExpress.XtraGrid.Columns.GridColumn coljylsh1;
        private DevExpress.XtraGrid.Columns.GridColumn colLineID1;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus1;
        private DevExpress.XtraGrid.Columns.GridColumn colUDP1;
    }
}
