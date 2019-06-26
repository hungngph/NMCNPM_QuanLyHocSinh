namespace NMCNPM_QLHS.GUI
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelChucNang = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navPanelChucNang = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navNhapLieu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnThemKhoi = new System.Windows.Forms.Button();
            this.btnThemNam = new System.Windows.Forms.Button();
            this.btnHoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboKhoiLop = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.navTimKiem = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.rbtnTen = new System.Windows.Forms.RadioButton();
            this.rbtnMaHS = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlHocSinh = new DevExpress.XtraEditors.GroupControl();
            this.gridControlLop = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceLop = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDSLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SiSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Khoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Nam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Khoi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bindingNavigatorLop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDelete = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorLuu = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelChucNang.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navPanelChucNang)).BeginInit();
            this.navPanelChucNang.SuspendLayout();
            this.navNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            this.navTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHocSinh)).BeginInit();
            this.groupControlHocSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_Khoi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLop)).BeginInit();
            this.bindingNavigatorLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelChucNang});
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
            // dockPanelChucNang
            // 
            this.dockPanelChucNang.Controls.Add(this.dockPanel1_Container);
            this.dockPanelChucNang.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelChucNang.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockPanelChucNang.ForeColor = System.Drawing.Color.Black;
            this.dockPanelChucNang.ID = new System.Guid("797054d8-1154-434f-80e5-00d553231bd7");
            this.dockPanelChucNang.Location = new System.Drawing.Point(0, 0);
            this.dockPanelChucNang.Name = "dockPanelChucNang";
            this.dockPanelChucNang.OriginalSize = new System.Drawing.Size(247, 200);
            this.dockPanelChucNang.Size = new System.Drawing.Size(247, 548);
            this.dockPanelChucNang.Text = "Chức năng";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navPanelChucNang);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(238, 521);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navPanelChucNang
            // 
            this.navPanelChucNang.Controls.Add(this.navNhapLieu);
            this.navPanelChucNang.Controls.Add(this.navTimKiem);
            this.navPanelChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelChucNang.Location = new System.Drawing.Point(0, 0);
            this.navPanelChucNang.Name = "navPanelChucNang";
            this.navPanelChucNang.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navPanelChucNang.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navNhapLieu,
            this.navTimKiem});
            this.navPanelChucNang.RegularSize = new System.Drawing.Size(238, 521);
            this.navPanelChucNang.SelectedPage = this.navNhapLieu;
            this.navPanelChucNang.Size = new System.Drawing.Size(238, 521);
            this.navPanelChucNang.TabIndex = 0;
            this.navPanelChucNang.Text = "navigationPane1";
            // 
            // navNhapLieu
            // 
            this.navNhapLieu.Caption = "Nhập liệu";
            this.navNhapLieu.Controls.Add(this.btnThemKhoi);
            this.navNhapLieu.Controls.Add(this.btnThemNam);
            this.navNhapLieu.Controls.Add(this.btnHoanTat);
            this.navNhapLieu.Controls.Add(this.txtTenLop);
            this.navNhapLieu.Controls.Add(this.labelControl5);
            this.navNhapLieu.Controls.Add(this.txtMaLop);
            this.navNhapLieu.Controls.Add(this.labelControl4);
            this.navNhapLieu.Controls.Add(this.cboKhoiLop);
            this.navNhapLieu.Controls.Add(this.labelControl3);
            this.navNhapLieu.Controls.Add(this.cboNamHoc);
            this.navNhapLieu.Controls.Add(this.labelControl2);
            this.navNhapLieu.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.Add_32px;
            this.navNhapLieu.Name = "navNhapLieu";
            this.navNhapLieu.Size = new System.Drawing.Size(172, 461);
            // 
            // btnThemKhoi
            // 
            this.btnThemKhoi.Image = global::NMCNPM_QLHS.Properties.Resources.Add_New_32px;
            this.btnThemKhoi.Location = new System.Drawing.Point(135, 98);
            this.btnThemKhoi.Name = "btnThemKhoi";
            this.btnThemKhoi.Size = new System.Drawing.Size(24, 20);
            this.btnThemKhoi.TabIndex = 152;
            this.btnThemKhoi.UseVisualStyleBackColor = true;
            this.btnThemKhoi.Click += new System.EventHandler(this.btnThemKhoi_Click);
            // 
            // btnThemNam
            // 
            this.btnThemNam.Image = global::NMCNPM_QLHS.Properties.Resources.Add_New_32px;
            this.btnThemNam.Location = new System.Drawing.Point(135, 42);
            this.btnThemNam.Name = "btnThemNam";
            this.btnThemNam.Size = new System.Drawing.Size(24, 20);
            this.btnThemNam.TabIndex = 151;
            this.btnThemNam.UseVisualStyleBackColor = true;
            this.btnThemNam.Click += new System.EventHandler(this.btnThemNam_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(49, 228);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 150;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(12, 202);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(147, 20);
            this.txtTenLop.TabIndex = 149;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 148;
            this.labelControl5.Text = "Tên lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(11, 147);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Properties.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(148, 20);
            this.txtMaLop.TabIndex = 147;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 128);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 146;
            this.labelControl4.Text = "Mã lớp:";
            // 
            // cboKhoiLop
            // 
            this.cboKhoiLop.Location = new System.Drawing.Point(11, 98);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoiLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKHOI", "")});
            this.cboKhoiLop.Properties.NullText = "";
            this.cboKhoiLop.Size = new System.Drawing.Size(100, 20);
            this.cboKhoiLop.TabIndex = 145;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 144;
            this.labelControl3.Text = "Khối:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(11, 42);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(100, 20);
            this.cboNamHoc.TabIndex = 143;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 142;
            this.labelControl2.Text = "Năm học:";
            // 
            // navTimKiem
            // 
            this.navTimKiem.Caption = "Tìm kiếm";
            this.navTimKiem.Controls.Add(this.rbtnTen);
            this.navTimKiem.Controls.Add(this.rbtnMaHS);
            this.navTimKiem.Controls.Add(this.txtTimKiem);
            this.navTimKiem.Controls.Add(this.labelControl1);
            this.navTimKiem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.Search_32px;
            this.navTimKiem.Name = "navTimKiem";
            this.navTimKiem.Size = new System.Drawing.Size(172, 461);
            // 
            // rbtnTen
            // 
            this.rbtnTen.AutoSize = true;
            this.rbtnTen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTen.Location = new System.Drawing.Point(13, 91);
            this.rbtnTen.Name = "rbtnTen";
            this.rbtnTen.Size = new System.Drawing.Size(151, 17);
            this.rbtnTen.TabIndex = 143;
            this.rbtnTen.TabStop = true;
            this.rbtnTen.Text = "Tìm kiếm theo tên học sinh";
            this.rbtnTen.UseVisualStyleBackColor = true;
            // 
            // rbtnMaHS
            // 
            this.rbtnMaHS.AutoSize = true;
            this.rbtnMaHS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMaHS.Location = new System.Drawing.Point(13, 67);
            this.rbtnMaHS.Name = "rbtnMaHS";
            this.rbtnMaHS.Size = new System.Drawing.Size(149, 17);
            this.rbtnMaHS.TabIndex = 142;
            this.rbtnMaHS.TabStop = true;
            this.rbtnMaHS.Text = "Tìm kiếm theo mã học sinh";
            this.rbtnMaHS.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(13, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(116, 20);
            this.txtTimKiem.TabIndex = 141;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Nhập thông tin tìm kiếm:";
            // 
            // groupControlHocSinh
            // 
            this.groupControlHocSinh.Controls.Add(this.gridControlLop);
            this.groupControlHocSinh.Controls.Add(this.bindingNavigatorLop);
            this.groupControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlHocSinh.Location = new System.Drawing.Point(247, 0);
            this.groupControlHocSinh.Name = "groupControlHocSinh";
            this.groupControlHocSinh.Size = new System.Drawing.Size(716, 548);
            this.groupControlHocSinh.TabIndex = 2;
            this.groupControlHocSinh.Text = "Danh sách học sinh";
            // 
            // gridControlLop
            // 
            this.gridControlLop.DataSource = this.bindingSourceLop;
            this.gridControlLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLop.Location = new System.Drawing.Point(2, 51);
            this.gridControlLop.MainView = this.dgvDSLop;
            this.gridControlLop.Name = "gridControlLop";
            this.gridControlLop.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_Khoi_edit});
            this.gridControlLop.Size = new System.Drawing.Size(712, 495);
            this.gridControlLop.TabIndex = 2;
            this.gridControlLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDSLop});
            // 
            // bindingSourceLop
            // 
            this.bindingSourceLop.DataSource = typeof(NMCNPM_QLHS.DAL.sp_LayLopTheoNamHocResult);
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.Appearance.Row.Options.UseTextOptions = true;
            this.dgvDSLop.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.dgvDSLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_MaLop,
            this.col_TenLop,
            this.col_SiSo,
            this.col_Khoi,
            this.col_Nam});
            this.dgvDSLop.GridControl = this.gridControlLop;
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.OptionsBehavior.Editable = false;
            this.dgvDSLop.OptionsView.ShowGroupPanel = false;
            this.dgvDSLop.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvDSLop_FocusedRowChanged);
            // 
            // col_MaLop
            // 
            this.col_MaLop.Caption = "Mã lớp";
            this.col_MaLop.FieldName = "MALOP";
            this.col_MaLop.MinWidth = 21;
            this.col_MaLop.Name = "col_MaLop";
            this.col_MaLop.Visible = true;
            this.col_MaLop.VisibleIndex = 2;
            this.col_MaLop.Width = 81;
            // 
            // col_TenLop
            // 
            this.col_TenLop.Caption = "Tên lớp";
            this.col_TenLop.FieldName = "TENLOP";
            this.col_TenLop.MinWidth = 21;
            this.col_TenLop.Name = "col_TenLop";
            this.col_TenLop.Visible = true;
            this.col_TenLop.VisibleIndex = 3;
            this.col_TenLop.Width = 81;
            // 
            // col_SiSo
            // 
            this.col_SiSo.Caption = "Sĩ số";
            this.col_SiSo.FieldName = "SISO";
            this.col_SiSo.MinWidth = 21;
            this.col_SiSo.Name = "col_SiSo";
            this.col_SiSo.Visible = true;
            this.col_SiSo.VisibleIndex = 4;
            this.col_SiSo.Width = 81;
            // 
            // col_Khoi
            // 
            this.col_Khoi.Caption = "Khối";
            this.col_Khoi.FieldName = "TENKHOI";
            this.col_Khoi.MinWidth = 21;
            this.col_Khoi.Name = "col_Khoi";
            this.col_Khoi.Visible = true;
            this.col_Khoi.VisibleIndex = 1;
            this.col_Khoi.Width = 81;
            // 
            // col_Nam
            // 
            this.col_Nam.Caption = "Năm học";
            this.col_Nam.FieldName = "TENNAMHOC";
            this.col_Nam.MinWidth = 21;
            this.col_Nam.Name = "col_Nam";
            this.col_Nam.Visible = true;
            this.col_Nam.VisibleIndex = 0;
            this.col_Nam.Width = 81;
            // 
            // col_Khoi_edit
            // 
            this.col_Khoi_edit.AutoHeight = false;
            this.col_Khoi_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_Khoi_edit.DisplayMember = "TENKHOI";
            this.col_Khoi_edit.Name = "col_Khoi_edit";
            this.col_Khoi_edit.ValueMember = "MAKHOI";
            // 
            // bindingNavigatorLop
            // 
            this.bindingNavigatorLop.AddNewItem = null;
            this.bindingNavigatorLop.BindingSource = this.bindingSourceLop;
            this.bindingNavigatorLop.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorLop.DeleteItem = null;
            this.bindingNavigatorLop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAdd,
            this.bindingNavigatorDelete,
            this.bindingNavigatorEdit,
            this.bindingNavigatorLuu,
            this.bindingNavigatorSearch});
            this.bindingNavigatorLop.Location = new System.Drawing.Point(2, 20);
            this.bindingNavigatorLop.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLop.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLop.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorLop.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorLop.Name = "bindingNavigatorLop";
            this.bindingNavigatorLop.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorLop.Size = new System.Drawing.Size(712, 31);
            this.bindingNavigatorLop.TabIndex = 0;
            this.bindingNavigatorLop.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAdd
            // 
            this.bindingNavigatorAdd.Image = global::NMCNPM_QLHS.Properties.Resources.Add_32px;
            this.bindingNavigatorAdd.Name = "bindingNavigatorAdd";
            this.bindingNavigatorAdd.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAdd.Size = new System.Drawing.Size(66, 28);
            this.bindingNavigatorAdd.Text = "Thêm";
            this.bindingNavigatorAdd.Click += new System.EventHandler(this.bindingNavigatorAdd_Click);
            // 
            // bindingNavigatorDelete
            // 
            this.bindingNavigatorDelete.Image = global::NMCNPM_QLHS.Properties.Resources.Delete_32px;
            this.bindingNavigatorDelete.Name = "bindingNavigatorDelete";
            this.bindingNavigatorDelete.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDelete.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorDelete.Text = "Xóa";
            this.bindingNavigatorDelete.Click += new System.EventHandler(this.bindingNavigatorDelete_Click);
            // 
            // bindingNavigatorEdit
            // 
            this.bindingNavigatorEdit.Image = global::NMCNPM_QLHS.Properties.Resources.Edit_32px;
            this.bindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEdit.Name = "bindingNavigatorEdit";
            this.bindingNavigatorEdit.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorEdit.Text = "Sửa";
            this.bindingNavigatorEdit.Click += new System.EventHandler(this.bindingNavigatorEdit_Click);
            // 
            // bindingNavigatorLuu
            // 
            this.bindingNavigatorLuu.Image = global::NMCNPM_QLHS.Properties.Resources.Save_32px;
            this.bindingNavigatorLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorLuu.Name = "bindingNavigatorLuu";
            this.bindingNavigatorLuu.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorLuu.Text = "Lưu";
            // 
            // bindingNavigatorSearch
            // 
            this.bindingNavigatorSearch.Image = global::NMCNPM_QLHS.Properties.Resources.Search_32px;
            this.bindingNavigatorSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearch.Name = "bindingNavigatorSearch";
            this.bindingNavigatorSearch.Size = new System.Drawing.Size(85, 28);
            this.bindingNavigatorSearch.Text = "Tìm kiếm";
            this.bindingNavigatorSearch.Click += new System.EventHandler(this.bindingNavigatorSearch_Click);
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 548);
            this.Controls.Add(this.groupControlHocSinh);
            this.Controls.Add(this.dockPanelChucNang);
            this.Name = "frmLop";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.frmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelChucNang.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navPanelChucNang)).EndInit();
            this.navPanelChucNang.ResumeLayout(false);
            this.navNhapLieu.ResumeLayout(false);
            this.navNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            this.navTimKiem.ResumeLayout(false);
            this.navTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlHocSinh)).EndInit();
            this.groupControlHocSinh.ResumeLayout(false);
            this.groupControlHocSinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_Khoi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLop)).EndInit();
            this.bindingNavigatorLop.ResumeLayout(false);
            this.bindingNavigatorLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelChucNang;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Navigation.NavigationPane navPanelChucNang;
        private DevExpress.XtraBars.Navigation.NavigationPage navNhapLieu;
        private DevExpress.XtraBars.Navigation.NavigationPage navTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControlHocSinh;
        private DevExpress.XtraGrid.GridControl gridControlLop;
        private System.Windows.Forms.BindingNavigator bindingNavigatorLop;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAdd;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorLuu;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
        private System.Windows.Forms.BindingSource bindingSourceLop;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDSLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_SiSo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Khoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit col_Khoi_edit;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraGrid.Columns.GridColumn col_Nam;
        private DevExpress.XtraEditors.LookUpEdit cboKhoiLop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnHoanTat;
        private System.Windows.Forms.Button btnThemKhoi;
        private System.Windows.Forms.Button btnThemNam;
        private System.Windows.Forms.RadioButton rbtnTen;
        private System.Windows.Forms.RadioButton rbtnMaHS;
    }
}