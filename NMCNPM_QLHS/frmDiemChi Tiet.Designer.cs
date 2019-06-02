namespace NMCNPM_QLHS
{
    partial class frmNhapDiemChiTiet
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.groupControlDiemCT = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtMaHocSinh = new DevExpress.XtraEditors.TextEdit();
            this.txtTenHocSinh = new DevExpress.XtraEditors.TextEdit();
            this.cboMon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboHocKy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboNamHoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutMaHocSinh = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridColumnDiemMieng = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiem15Phut = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiem1Tiet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnMonHoc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiemThi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridColumnDiemTB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDiemCT)).BeginInit();
            this.groupControlDiemCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHocSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHocSinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMaHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // groupControlDiemCT
            // 
            this.groupControlDiemCT.Controls.Add(this.gridControlHocSinh);
            this.groupControlDiemCT.Controls.Add(this.layoutControl1);
            this.groupControlDiemCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlDiemCT.Location = new System.Drawing.Point(0, 0);
            this.groupControlDiemCT.Name = "groupControlDiemCT";
            this.groupControlDiemCT.Size = new System.Drawing.Size(886, 511);
            this.groupControlDiemCT.TabIndex = 2;
            this.groupControlDiemCT.Text = "Thông tin điểm chi tiết";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Controls.Add(this.cboMon);
            this.layoutControl1.Controls.Add(this.txtTenHocSinh);
            this.layoutControl1.Controls.Add(this.txtMaHocSinh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(2, 20);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(882, 135);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(865, 136);
            this.Root.TextVisible = false;
            // 
            // txtMaHocSinh
            // 
            this.txtMaHocSinh.Location = new System.Drawing.Point(92, 42);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(338, 20);
            this.txtMaHocSinh.StyleController = this.layoutControl1;
            this.txtMaHocSinh.TabIndex = 4;
            // 
            // txtTenHocSinh
            // 
            this.txtTenHocSinh.Location = new System.Drawing.Point(92, 66);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(338, 20);
            this.txtTenHocSinh.StyleController = this.layoutControl1;
            this.txtTenHocSinh.TabIndex = 6;
            // 
            // cboMon
            // 
            this.cboMon.Location = new System.Drawing.Point(502, 42);
            this.cboMon.Name = "cboMon";
            this.cboMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMon.Size = new System.Drawing.Size(339, 20);
            this.cboMon.StyleController = this.layoutControl1;
            this.cboMon.TabIndex = 7;
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(502, 66);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Size = new System.Drawing.Size(339, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 8;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(502, 90);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Size = new System.Drawing.Size(339, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 9;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(410, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(411, 26);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboHocKy;
            this.layoutControlItem2.Location = new System.Drawing.Point(410, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(411, 24);
            this.layoutControlItem2.Text = "Học kỳ:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboMon;
            this.layoutControlItem3.Location = new System.Drawing.Point(410, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(411, 24);
            this.layoutControlItem3.Text = "Môn:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutMaHocSinh
            // 
            this.layoutMaHocSinh.Control = this.txtMaHocSinh;
            this.layoutMaHocSinh.Location = new System.Drawing.Point(0, 0);
            this.layoutMaHocSinh.Name = "layoutMaHocSinh";
            this.layoutMaHocSinh.Size = new System.Drawing.Size(410, 24);
            this.layoutMaHocSinh.Text = "Mã học sinh:";
            this.layoutMaHocSinh.TextSize = new System.Drawing.Size(64, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTenHocSinh;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(410, 24);
            this.layoutControlItem4.Text = "Tên học sinh:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(64, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(205, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutMaHocSinh,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(845, 116);
            this.layoutControlGroup1.Text = "Thông tin:";
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.Location = new System.Drawing.Point(2, 155);
            this.gridControlHocSinh.MainView = this.bandedGridView1;
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.Size = new System.Drawing.Size(882, 354);
            this.gridControlHocSinh.TabIndex = 4;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1,
            this.gridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.gridColumnMonHoc,
            this.gridColumnDiemMieng,
            this.gridColumnDiem15Phut,
            this.gridColumnDiem1Tiet,
            this.gridColumnDiemThi,
            this.gridColumnDiemTB});
            this.bandedGridView1.GridControl = this.gridControlHocSinh;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBand1.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridBand1.AppearanceHeader.Options.UseFont = true;
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "Bảng điểm chi tiết";
            this.gridBand1.Columns.Add(this.gridColumnMonHoc);
            this.gridBand1.Columns.Add(this.gridColumnDiemMieng);
            this.gridBand1.Columns.Add(this.gridColumnDiem15Phut);
            this.gridBand1.Columns.Add(this.gridColumnDiem1Tiet);
            this.gridBand1.Columns.Add(this.gridColumnDiemThi);
            this.gridBand1.Columns.Add(this.gridColumnDiemTB);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.RowCount = 2;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 866;
            // 
            // gridColumnDiemMieng
            // 
            this.gridColumnDiemMieng.Caption = "Điểm miệng";
            this.gridColumnDiemMieng.Name = "gridColumnDiemMieng";
            this.gridColumnDiemMieng.Visible = true;
            this.gridColumnDiemMieng.Width = 135;
            // 
            // gridColumnDiem15Phut
            // 
            this.gridColumnDiem15Phut.Caption = "Điểm 15 phút";
            this.gridColumnDiem15Phut.Name = "gridColumnDiem15Phut";
            this.gridColumnDiem15Phut.Visible = true;
            this.gridColumnDiem15Phut.Width = 144;
            // 
            // gridColumnDiem1Tiet
            // 
            this.gridColumnDiem1Tiet.Caption = "Điểm 1 tiết";
            this.gridColumnDiem1Tiet.Name = "gridColumnDiem1Tiet";
            this.gridColumnDiem1Tiet.Visible = true;
            this.gridColumnDiem1Tiet.Width = 137;
            // 
            // gridColumnMonHoc
            // 
            this.gridColumnMonHoc.Caption = "Môn học";
            this.gridColumnMonHoc.Name = "gridColumnMonHoc";
            this.gridColumnMonHoc.Visible = true;
            this.gridColumnMonHoc.Width = 155;
            // 
            // gridColumnDiemThi
            // 
            this.gridColumnDiemThi.Caption = "Điểm thi";
            this.gridColumnDiemThi.Name = "gridColumnDiemThi";
            this.gridColumnDiemThi.Visible = true;
            this.gridColumnDiemThi.Width = 160;
            // 
            // gridColumnDiemTB
            // 
            this.gridColumnDiemTB.Caption = "Điểm trung bình";
            this.gridColumnDiemTB.Name = "gridColumnDiemTB";
            this.gridColumnDiemTB.Visible = true;
            this.gridColumnDiemTB.Width = 135;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlHocSinh;
            this.gridView1.Name = "gridView1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(229, 90);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(201, 22);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Xem điểm";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.Location = new System.Drawing.Point(205, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(205, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frmNhapDiemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 511);
            this.Controls.Add(this.groupControlDiemCT);
            this.Name = "frmNhapDiemChiTiet";
            this.Text = "Điểm chi tiết";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlDiemCT)).EndInit();
            this.groupControlDiemCT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHocSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHocSinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMaHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl groupControlDiemCT;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnMonHoc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiemMieng;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiem15Phut;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiem1Tiet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiemThi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn gridColumnDiemTB;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboNamHoc;
        private DevExpress.XtraEditors.ComboBoxEdit cboHocKy;
        private DevExpress.XtraEditors.ComboBoxEdit cboMon;
        private DevExpress.XtraEditors.TextEdit txtTenHocSinh;
        private DevExpress.XtraEditors.TextEdit txtMaHocSinh;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutMaHocSinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}