﻿namespace NMCNPM_QLHS.GUI
{
    partial class frmrpMon
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControlHocSinh = new DevExpress.XtraGrid.GridControl();
            this.dgvMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Lop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_maHS_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_SiSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hoTen_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_SLDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ngaySinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.col_TyLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diaChi_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_gioiTinh_edit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.col_email_edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboMon = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Controls.Add(this.btnLamMoi);
            this.layoutControl1.Controls.Add(this.btnIn);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Controls.Add(this.cboMon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(873, 53);
            this.layoutControl1.TabIndex = 14;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(315, 12);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Size = new System.Drawing.Size(170, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 9;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(792, 12);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(69, 22);
            this.btnLamMoi.StyleController = this.layoutControl1;
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(718, 12);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(70, 22);
            this.btnIn.StyleController = this.layoutControl1;
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(60, 12);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(203, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem5,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(873, 53);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnLamMoi;
            this.layoutControlItem4.Location = new System.Drawing.Point(780, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(73, 33);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnIn;
            this.layoutControlItem3.Location = new System.Drawing.Point(706, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(74, 33);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(255, 33);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboHocKy;
            this.layoutControlItem5.Location = new System.Drawing.Point(255, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(222, 33);
            this.layoutControlItem5.Text = "Học kỳ:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(45, 13);
            // 
            // gridControlHocSinh
            // 
            this.gridControlHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHocSinh.Location = new System.Drawing.Point(0, 53);
            this.gridControlHocSinh.MainView = this.dgvMon;
            this.gridControlHocSinh.Name = "gridControlHocSinh";
            this.gridControlHocSinh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.col_maHS_edit,
            this.col_hoTen_edit,
            this.col_gioiTinh_edit,
            this.col_ngaySinh_edit,
            this.col_diaChi_edit,
            this.col_email_edit});
            this.gridControlHocSinh.Size = new System.Drawing.Size(873, 370);
            this.gridControlHocSinh.TabIndex = 15;
            this.gridControlHocSinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMon});
            // 
            // dgvMon
            // 
            this.dgvMon.Appearance.GroupPanel.BackColor = System.Drawing.Color.Transparent;
            this.dgvMon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Transparent;
            this.dgvMon.Appearance.GroupPanel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.dgvMon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.dgvMon.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvMon.Appearance.GroupPanel.Options.UseFont = true;
            this.dgvMon.Appearance.GroupPanel.Options.UseForeColor = true;
            this.dgvMon.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.dgvMon.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Lop,
            this.col_SiSo,
            this.col_SLDat,
            this.col_TyLe});
            this.dgvMon.GridControl = this.gridControlHocSinh;
            this.dgvMon.GroupPanelText = "BÁO CÁO TỔNG KẾT MÔN";
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.OptionsBehavior.Editable = false;
            // 
            // col_Lop
            // 
            this.col_Lop.Caption = "Lớp";
            this.col_Lop.ColumnEdit = this.col_maHS_edit;
            this.col_Lop.FieldName = "MAHS";
            this.col_Lop.MinWidth = 21;
            this.col_Lop.Name = "col_Lop";
            this.col_Lop.Visible = true;
            this.col_Lop.VisibleIndex = 0;
            this.col_Lop.Width = 134;
            // 
            // col_maHS_edit
            // 
            this.col_maHS_edit.AutoHeight = false;
            this.col_maHS_edit.Name = "col_maHS_edit";
            // 
            // col_SiSo
            // 
            this.col_SiSo.Caption = "Sĩ số";
            this.col_SiSo.ColumnEdit = this.col_hoTen_edit;
            this.col_SiSo.FieldName = "HOTEN";
            this.col_SiSo.MinWidth = 21;
            this.col_SiSo.Name = "col_SiSo";
            this.col_SiSo.Visible = true;
            this.col_SiSo.VisibleIndex = 1;
            this.col_SiSo.Width = 176;
            // 
            // col_hoTen_edit
            // 
            this.col_hoTen_edit.AutoHeight = false;
            this.col_hoTen_edit.Name = "col_hoTen_edit";
            // 
            // col_SLDat
            // 
            this.col_SLDat.Caption = "Số lượng đạt";
            this.col_SLDat.ColumnEdit = this.col_ngaySinh_edit;
            this.col_SLDat.FieldName = "NGAYSINH";
            this.col_SLDat.MinWidth = 21;
            this.col_SLDat.Name = "col_SLDat";
            this.col_SLDat.Visible = true;
            this.col_SLDat.VisibleIndex = 2;
            this.col_SLDat.Width = 176;
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
            // col_TyLe
            // 
            this.col_TyLe.Caption = "Tỷ lệ";
            this.col_TyLe.ColumnEdit = this.col_diaChi_edit;
            this.col_TyLe.FieldName = "DIACHI";
            this.col_TyLe.MinWidth = 21;
            this.col_TyLe.Name = "col_TyLe";
            this.col_TyLe.Visible = true;
            this.col_TyLe.VisibleIndex = 3;
            this.col_TyLe.Width = 176;
            // 
            // col_diaChi_edit
            // 
            this.col_diaChi_edit.AutoHeight = false;
            this.col_diaChi_edit.Name = "col_diaChi_edit";
            // 
            // col_gioiTinh_edit
            // 
            this.col_gioiTinh_edit.AutoHeight = false;
            this.col_gioiTinh_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.col_gioiTinh_edit.Name = "col_gioiTinh_edit";
            // 
            // col_email_edit
            // 
            this.col_email_edit.AutoHeight = false;
            this.col_email_edit.Name = "col_email_edit";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboMon;
            this.layoutControlItem2.Location = new System.Drawing.Point(477, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 33);
            this.layoutControlItem2.Text = "Môn:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // cboMon
            // 
            this.cboMon.Location = new System.Drawing.Point(537, 12);
            this.cboMon.Name = "cboMon";
            this.cboMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMon.Properties.NullText = "";
            this.cboMon.Size = new System.Drawing.Size(177, 20);
            this.cboMon.StyleController = this.layoutControl1;
            this.cboMon.TabIndex = 10;
            // 
            // frmrpMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 423);
            this.Controls.Add(this.gridControlHocSinh);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmrpMon";
            this.Text = "Báo cáo tổng kết môn";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_maHS_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_hoTen_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_ngaySinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_diaChi_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_gioiTinh_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.col_email_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit cboHocKy;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControlHocSinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMon;
        private DevExpress.XtraGrid.Columns.GridColumn col_Lop;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_maHS_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_SiSo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_hoTen_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_SLDat;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit col_ngaySinh_edit;
        private DevExpress.XtraGrid.Columns.GridColumn col_TyLe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_diaChi_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox col_gioiTinh_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit col_email_edit;
        private DevExpress.XtraEditors.LookUpEdit cboMon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}