namespace NMCNPM_QLHS.GUI
{
    partial class frmrpDanhSachHocSinh
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.dgvHocSinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_maHS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_hoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_HocKy1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ngaySinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_HocKy2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diaChi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_CaNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_email_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cboLop = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboLop);
            this.layoutControl1.Controls.Add(this.btnLamMoi);
            this.layoutControl1.Controls.Add(this.btnIn);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(859, 49);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(781, 10);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(67, 22);
            this.btnLamMoi.StyleController = this.layoutControl1;
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(708, 10);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(69, 22);
            this.btnIn.StyleController = this.layoutControl1;
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(59, 10);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(322, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 4;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(859, 49);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLamMoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(770, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(71, 33);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnIn;
            this.layoutControlItem3.Location = new System.Drawing.Point(697, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(73, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(374, 33);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.Location = new System.Drawing.Point(0, 49);
            this.gridControlHocSinh.MainView = this.dgvHocSinh;
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_ngaySinh_edit,
            this.col_diaChi_edit,
            this.col_email_edit});
            this.gridControlHocSinh.Size = new System.Drawing.Size(859, 465);
            this.gridControlHocSinh.TabIndex = 11;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHocSinh});
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvHocSinh.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvHocSinh.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvHocSinh.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvHocSinh.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvHocSinh.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvHocSinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_maHS,
            this.col_hoTen,
            this.col_HocKy1,
            this.col_HocKy2,
            this.col_CaNam});
            this.dgvHocSinh.GridControl = this.gridControlHocSinh;
            this.dgvHocSinh.GroupPanelText = "DANH SÁCH HỌC SINH";
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.OptionsBehavior.Editable = false;
            // 
            // col_maHS
            // 
            this.col_maHS.Caption = "Mã Học Sinh";
            this.col_maHS.ColumnEdit = this.col_maHS_edit;
            this.col_maHS.FieldName = "MAHS";
            this.col_maHS.MinWidth = 21;
            this.col_maHS.Name = "col_maHS";
            this.col_maHS.Visible = true;
            this.col_maHS.VisibleIndex = 0;
            this.col_maHS.Width = 134;
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_hoTen
            // 
            this.col_hoTen.Caption = "Họ Tên";
            this.col_hoTen.ColumnEdit = this.col_hoTen_edit;
            this.col_hoTen.FieldName = "HOTEN";
            this.col_hoTen.MinWidth = 21;
            this.col_hoTen.Name = "col_hoTen";
            this.col_hoTen.Visible = true;
            this.col_hoTen.VisibleIndex = 1;
            this.col_hoTen.Width = 176;
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_HocKy1
            // 
            this.col_HocKy1.Caption = "Học kỳ 1";
            this.col_HocKy1.ColumnEdit = this.col_ngaySinh_edit;
            this.col_HocKy1.FieldName = "NGAYSINH";
            this.col_HocKy1.MinWidth = 21;
            this.col_HocKy1.Name = "col_HocKy1";
            this.col_HocKy1.Visible = true;
            this.col_HocKy1.VisibleIndex = 2;
            this.col_HocKy1.Width = 176;
            // 
            // col_ngaySinh_edit
            // 
            this.col_ngaySinh_edit.AutoHeight = false;
            this.col_ngaySinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_ngaySinh_edit.Name = "col_ngaySinh_edit";
            // 
            // col_HocKy2
            // 
            this.col_HocKy2.Caption = "Học kỳ 2";
            this.col_HocKy2.ColumnEdit = this.col_diaChi_edit;
            this.col_HocKy2.FieldName = "DIACHI";
            this.col_HocKy2.MinWidth = 21;
            this.col_HocKy2.Name = "col_HocKy2";
            this.col_HocKy2.Visible = true;
            this.col_HocKy2.VisibleIndex = 3;
            this.col_HocKy2.Width = 176;
            // 
            // col_diaChi_edit
            // 
            this.col_diaChi_edit.AutoHeight = false;
            this.col_diaChi_edit.Name = "col_diaChi_edit";
            // 
            // col_CaNam
            // 
            this.col_CaNam.Caption = "Cả năm";
            this.col_CaNam.ColumnEdit = this.col_email_edit;
            this.col_CaNam.FieldName = "EMAIL";
            this.col_CaNam.MinWidth = 21;
            this.col_CaNam.Name = "col_CaNam";
            this.col_CaNam.Visible = true;
            this.col_CaNam.VisibleIndex = 4;
            this.col_CaNam.Width = 179;
            // 
            // col_email_edit
            // 
            this.col_email_edit.AutoHeight = false;
            this.col_email_edit.Name = "col_email_edit";
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(433, 10);
            this.cboLop.Name = "cboLop";
            this.cboLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLop.Size = new System.Drawing.Size(271, 20);
            this.cboLop.StyleController = this.layoutControl1;
            this.cboLop.TabIndex = 9;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboLop;
            this.layoutControlItem5.Location = new System.Drawing.Point(374, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(323, 33);
            this.layoutControlItem5.Text = "Lớp:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
            // 
            // frmrpDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 514);
            this.Controls.Add(this.gridControlHocSinh);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmrpDanhSachHocSinh";
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.frmrpDanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHocSinh;
        private DevExpress.XtraGrid.Columns.GridColumn col_maHS;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_hoTen;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_HocKy1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_ngaySinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_HocKy2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diaChi_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_CaNam;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_email_edit;
        private DevExpress.XtraEditors.LookUpEdit cboLop;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}