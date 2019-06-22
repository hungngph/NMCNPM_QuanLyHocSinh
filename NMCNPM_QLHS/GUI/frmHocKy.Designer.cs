namespace NMCNPM_QLHS.GUI
{
    partial class frmHocKy
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlHocKy = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maHocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tenHocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHeSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.BIThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.BIXoa = new DevExpress.XtraBars.BarButtonItem();
            this.BILuuDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.bindingSourceHocKy = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocKy)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControlHocKy);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(657, 442);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách học kỳ";
            // 
            // gridControlHocKy
            // 
            this.gridControlHocKy.DataSource = this.bindingSourceHocKy;
            this.gridControlHocKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocKy.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlHocKy.Location = new System.Drawing.Point(2, 25);
            this.gridControlHocKy.MainView = this.gridView;
            this.gridControlHocKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlHocKy.Name = "gridControlHocKy";
            this.gridControlHocKy.Size = new System.Drawing.Size(653, 415);
            this.gridControlHocKy.TabIndex = 3;
            this.gridControlHocKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maHocKy,
            this.col_tenHocKy,
            this.gridColumnHeSo});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControlHocKy;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // col_maHocKy
            // 
            this.col_maHocKy.Caption = "Mã học kỳ";
            this.col_maHocKy.FieldName = "MAHK";
            this.col_maHocKy.MinWidth = 23;
            this.col_maHocKy.Name = "col_maHocKy";
            this.col_maHocKy.Visible = true;
            this.col_maHocKy.VisibleIndex = 0;
            this.col_maHocKy.Width = 201;
            // 
            // col_tenHocKy
            // 
            this.col_tenHocKy.Caption = "Tên học kỳ";
            this.col_tenHocKy.FieldName = "TENHOCKY";
            this.col_tenHocKy.MinWidth = 23;
            this.col_tenHocKy.Name = "col_tenHocKy";
            this.col_tenHocKy.Visible = true;
            this.col_tenHocKy.VisibleIndex = 1;
            this.col_tenHocKy.Width = 226;
            // 
            // gridColumnHeSo
            // 
            this.gridColumnHeSo.Caption = "Hệ số";
            this.gridColumnHeSo.MinWidth = 23;
            this.gridColumnHeSo.Name = "gridColumnHeSo";
            this.gridColumnHeSo.Visible = true;
            this.gridColumnHeSo.VisibleIndex = 2;
            this.gridColumnHeSo.Width = 1413;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControlHocKy;
            this.gridView1.Name = "gridView1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(657, 0);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.BIThemMoi,
            this.BIXoa,
            this.BILuuDanhSach});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 442);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(657, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(657, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // BIThemMoi
            // 
            this.BIThemMoi.Caption = "Thêm mới";
            this.BIThemMoi.Id = 0;
            this.BIThemMoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.add;
            this.BIThemMoi.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert);
            this.BIThemMoi.Name = "BIThemMoi";
            this.BIThemMoi.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            // 
            // BIXoa
            // 
            this.BIXoa.Caption = "Xóa dòng chọn";
            this.BIXoa.Id = 1;
            this.BIXoa.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.delete;
            this.BIXoa.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.BIXoa.Name = "BIXoa";
            // 
            // BILuuDanhSach
            // 
            this.BILuuDanhSach.Caption = "Lưu danh sách";
            this.BILuuDanhSach.Id = 2;
            this.BILuuDanhSach.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.save;
            this.BILuuDanhSach.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.BILuuDanhSach.Name = "BILuuDanhSach";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // bindingSourceHocKy
            // 
            this.bindingSourceHocKy.DataSource = typeof(NMCNPM_QLHS.DAL.HOCKY);
            // 
            // frmHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 442);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHocKy";
            this.Text = "Học kỳ";
            this.Load += new System.EventHandler(this.frmHocKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHocKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem BIThemMoi;
        private DevExpress.XtraBars.BarButtonItem BIXoa;
        private DevExpress.XtraBars.BarButtonItem BILuuDanhSach;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraGrid.GridControl gridControlHocKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn col_maHocKy;
        private DevExpress.XtraGrid.Columns.GridColumn col_tenHocKy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHeSo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSourceHocKy;
    }
}