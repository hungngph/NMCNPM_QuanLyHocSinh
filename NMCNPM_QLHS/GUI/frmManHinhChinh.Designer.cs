namespace NMCNPM_QLHS.GUI
{
    partial class frmManHinhChinh
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocky = new DevExpress.XtraBars.BarButtonItem();
            this.btnNamHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.barPhanLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnKQHKTheoLop = new DevExpress.XtraBars.BarButtonItem();
            this.KQHKTheoMon = new DevExpress.XtraBars.BarButtonItem();
            this.KQCNTheoLop = new DevExpress.XtraBars.BarButtonItem();
            this.KQCNTheoMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuuHS = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyDinhTuoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyDinhSiSo = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyDinhDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraCuuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barLenLop = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageThongKe = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageTraCuu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageQuyDinh = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnLop,
            this.btnKhoiLop,
            this.btnHocky,
            this.btnNamHoc,
            this.barMonHoc,
            this.barDiem,
            this.barHocSinh,
            this.barPhanLop,
            this.btnKQHKTheoLop,
            this.KQHKTheoMon,
            this.KQCNTheoLop,
            this.KQCNTheoMon,
            this.btnDSHocSinh,
            this.btnDSLopHoc,
            this.btnTraCuuHS,
            this.btnQuyDinhTuoi,
            this.btnQuyDinhSiSo,
            this.btnQuyDinhDiem,
            this.btnTraCuuDiem,
            this.barLenLop});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 27;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageQuanLy,
            this.ribbonPageThongKe,
            this.ribbonPageTraCuu,
            this.ribbonPageQuyDinh});
            this.ribbon.Size = new System.Drawing.Size(917, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLop
            // 
            this.btnLop.Caption = "Lớp";
            this.btnLop.Id = 3;
            this.btnLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.lophoc;
            this.btnLop.Name = "btnLop";
            this.btnLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLop_ItemClick);
            // 
            // btnKhoiLop
            // 
            this.btnKhoiLop.Caption = "Khối lớp";
            this.btnKhoiLop.Id = 4;
            this.btnKhoiLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.khoilop;
            this.btnKhoiLop.Name = "btnKhoiLop";
            this.btnKhoiLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKhoiLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoiLop_ItemClick);
            // 
            // btnHocky
            // 
            this.btnHocky.Caption = "Học kỳ";
            this.btnHocky.Id = 5;
            this.btnHocky.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.hocky;
            this.btnHocky.Name = "btnHocky";
            this.btnHocky.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnHocky.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocKy_ItemClick);
            // 
            // btnNamHoc
            // 
            this.btnNamHoc.Caption = "Năm học";
            this.btnNamHoc.Id = 6;
            this.btnNamHoc.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.namhoc;
            this.btnNamHoc.Name = "btnNamHoc";
            this.btnNamHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNamHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNamHoc_ItemClick);
            // 
            // barMonHoc
            // 
            this.barMonHoc.Caption = "Môn học";
            this.barMonHoc.Id = 7;
            this.barMonHoc.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.monhoc;
            this.barMonHoc.Name = "barMonHoc";
            this.barMonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // barDiem
            // 
            this.barDiem.Caption = "Điểm";
            this.barDiem.Id = 8;
            this.barDiem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.diem;
            this.barDiem.Name = "barDiem";
            this.barDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDiem_ItemClick);
            // 
            // barHocSinh
            // 
            this.barHocSinh.Caption = "Học sinh";
            this.barHocSinh.Id = 9;
            this.barHocSinh.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.pupils;
            this.barHocSinh.Name = "barHocSinh";
            this.barHocSinh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barHocSinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHocSinh_ItemClick);
            // 
            // barPhanLop
            // 
            this.barPhanLop.Caption = "Phân lớp";
            this.barPhanLop.Id = 10;
            this.barPhanLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.phanlop;
            this.barPhanLop.Name = "barPhanLop";
            this.barPhanLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barPhanLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhanLop_ItemClick);
            // 
            // btnKQHKTheoLop
            // 
            this.btnKQHKTheoLop.Caption = "Kết quả học kỳ theo lớp";
            this.btnKQHKTheoLop.Id = 11;
            this.btnKQHKTheoLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqhockytheolop;
            this.btnKQHKTheoLop.Name = "btnKQHKTheoLop";
            this.btnKQHKTheoLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKQHKTheoLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKQHKTheoLop_ItemClick);
            // 
            // KQHKTheoMon
            // 
            this.KQHKTheoMon.Caption = "Kết quả học kỳ theo môn học";
            this.KQHKTheoMon.Id = 12;
            this.KQHKTheoMon.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqhockytheomon;
            this.KQHKTheoMon.Name = "KQHKTheoMon";
            this.KQHKTheoMon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.KQHKTheoMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKQHKTheoMon_ItemClick);
            // 
            // KQCNTheoLop
            // 
            this.KQCNTheoLop.Caption = "Kết quả cả năm theo lớp";
            this.KQCNTheoLop.Id = 13;
            this.KQCNTheoLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqcnamtheolop;
            this.KQCNTheoLop.Name = "KQCNTheoLop";
            this.KQCNTheoLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.KQCNTheoLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKQCNTheoLop_ItemClick);
            // 
            // KQCNTheoMon
            // 
            this.KQCNTheoMon.Caption = "Kết quả cả năm theo môn học";
            this.KQCNTheoMon.Id = 14;
            this.KQCNTheoMon.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.kqcnamtheomon;
            this.KQCNTheoMon.Name = "KQCNTheoMon";
            this.KQCNTheoMon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.KQCNTheoMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKQCNTheoMon_ItemClick);
            // 
            // btnDSHocSinh
            // 
            this.btnDSHocSinh.Caption = "Danh sách học sinh";
            this.btnDSHocSinh.Id = 15;
            this.btnDSHocSinh.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.dshocsinh;
            this.btnDSHocSinh.Name = "btnDSHocSinh";
            this.btnDSHocSinh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDSHocSinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSHocSinh_ItemClick);
            // 
            // btnDSLopHoc
            // 
            this.btnDSLopHoc.Caption = "Danh sách lớp học";
            this.btnDSLopHoc.Id = 16;
            this.btnDSLopHoc.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.dslophoc;
            this.btnDSLopHoc.Name = "btnDSLopHoc";
            this.btnDSLopHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDSLopHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSLopHoc_ItemClick);
            // 
            // btnTraCuuHS
            // 
            this.btnTraCuuHS.Caption = "Tra cứu học sinh";
            this.btnTraCuuHS.Id = 17;
            this.btnTraCuuHS.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.tracuuhocsinh;
            this.btnTraCuuHS.Name = "btnTraCuuHS";
            this.btnTraCuuHS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTraCuuHS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuuHS_ItemClick);
            // 
            // btnQuyDinhTuoi
            // 
            this.btnQuyDinhTuoi.Caption = "Quy định tuổi";
            this.btnQuyDinhTuoi.Id = 18;
            this.btnQuyDinhTuoi.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.qddotuoi;
            this.btnQuyDinhTuoi.Name = "btnQuyDinhTuoi";
            this.btnQuyDinhTuoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuyDinhTuoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuyDinhTuoi_ItemClick);
            // 
            // btnQuyDinhSiSo
            // 
            this.btnQuyDinhSiSo.Caption = "Quy định sỉ số";
            this.btnQuyDinhSiSo.Id = 19;
            this.btnQuyDinhSiSo.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.qdsiso;
            this.btnQuyDinhSiSo.Name = "btnQuyDinhSiSo";
            this.btnQuyDinhSiSo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuyDinhSiSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuyDinhSiSo_ItemClick);
            // 
            // btnQuyDinhDiem
            // 
            this.btnQuyDinhDiem.Caption = "Quy định điểm";
            this.btnQuyDinhDiem.Id = 20;
            this.btnQuyDinhDiem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.qdthangdiem;
            this.btnQuyDinhDiem.Name = "btnQuyDinhDiem";
            this.btnQuyDinhDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnQuyDinhDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuyDinhDiem_ItemClick);
            // 
            // btnTraCuuDiem
            // 
            this.btnTraCuuDiem.Caption = "Tra cứ điểm học sinh";
            this.btnTraCuuDiem.Id = 25;
            this.btnTraCuuDiem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.phancong;
            this.btnTraCuuDiem.Name = "btnTraCuuDiem";
            this.btnTraCuuDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTraCuuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraCuuDiem_ItemClick);
            // 
            // barLenLop
            // 
            this.barLenLop.Caption = "Lên lớp";
            this.barLenLop.Id = 26;
            this.barLenLop.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.hocluc;
            this.barLenLop.Name = "barLenLop";
            this.barLenLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barLenLop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLenLop_ItemClick);
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKhoiLop);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lớp - Khối lớp";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHocky);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNamHoc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Năm học";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barMonHoc);
            this.ribbonPageGroup3.ItemLinks.Add(this.barDiem);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Môn học";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barHocSinh);
            this.ribbonPageGroup4.ItemLinks.Add(this.barPhanLop);
            this.ribbonPageGroup4.ItemLinks.Add(this.barLenLop);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Học Sinh";
            // 
            // ribbonPageThongKe
            // 
            this.ribbonPageThongKe.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPageThongKe.Name = "ribbonPageThongKe";
            this.ribbonPageThongKe.Text = "Thống kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnKQHKTheoLop);
            this.ribbonPageGroup5.ItemLinks.Add(this.KQHKTheoMon);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kết quả Học kỳ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.KQCNTheoLop);
            this.ribbonPageGroup6.ItemLinks.Add(this.KQCNTheoMon);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Kết quả cuối năm";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDSHocSinh);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnDSLopHoc);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Xuất danh sách";
            // 
            // ribbonPageTraCuu
            // 
            this.ribbonPageTraCuu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPageTraCuu.Name = "ribbonPageTraCuu";
            this.ribbonPageTraCuu.Text = "Tra cứu";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTraCuuHS);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTraCuuDiem);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Tra cứu";
            // 
            // ribbonPageQuyDinh
            // 
            this.ribbonPageQuyDinh.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPageQuyDinh.Name = "ribbonPageQuyDinh";
            this.ribbonPageQuyDinh.Text = "Quy định";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnQuyDinhTuoi);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnQuyDinhSiSo);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnQuyDinhDiem);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Quy định chung";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 507);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(917, 31);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 538);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Name = "frmManHinhChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản Lý Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageThongKe;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageTraCuu;
        private DevExpress.XtraBars.BarButtonItem btnLop;
        private DevExpress.XtraBars.BarButtonItem btnKhoiLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuyDinh;
        private DevExpress.XtraBars.BarButtonItem btnHocky;
        private DevExpress.XtraBars.BarButtonItem btnNamHoc;
        private DevExpress.XtraBars.BarButtonItem barMonHoc;
        private DevExpress.XtraBars.BarButtonItem barDiem;
        private DevExpress.XtraBars.BarButtonItem barHocSinh;
        private DevExpress.XtraBars.BarButtonItem barPhanLop;
        private DevExpress.XtraBars.BarButtonItem btnKQHKTheoLop;
        private DevExpress.XtraBars.BarButtonItem KQHKTheoMon;
        private DevExpress.XtraBars.BarButtonItem KQCNTheoLop;
        private DevExpress.XtraBars.BarButtonItem KQCNTheoMon;
        private DevExpress.XtraBars.BarButtonItem btnDSHocSinh;
        private DevExpress.XtraBars.BarButtonItem btnDSLopHoc;
        private DevExpress.XtraBars.BarButtonItem btnTraCuuHS;
        private DevExpress.XtraBars.BarButtonItem btnQuyDinhTuoi;
        private DevExpress.XtraBars.BarButtonItem btnQuyDinhSiSo;
        private DevExpress.XtraBars.BarButtonItem btnQuyDinhDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnTraCuuDiem;
        private DevExpress.XtraBars.BarButtonItem barLenLop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}