﻿namespace NMCNPM_QLHS.GUI
{
    partial class frmPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLop));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboHocKy = new DevExpress.XtraEditors.LookUpEdit();
            this.cboLop = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKhoiLop = new DevExpress.XtraEditors.LookUpEdit();
            this.cboNamHoc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstvDSHS = new System.Windows.Forms.ListView();
            this.colMaHS1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lstvDSLop = new System.Windows.Forms.ListView();
            this.colMaHS2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboHocKy);
            this.layoutControl1.Controls.Add(this.cboLop);
            this.layoutControl1.Controls.Add(this.cboKhoiLop);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(967, 79);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(766, 38);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHocKy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENHOCKY", "")});
            this.cboHocKy.Properties.NullText = "";
            this.cboHocKy.Size = new System.Drawing.Size(179, 20);
            this.cboHocKy.StyleController = this.layoutControl1;
            this.cboHocKy.TabIndex = 4;
            this.cboHocKy.EditValueChanged += new System.EventHandler(this.cboHocKy_EditValueChanged);
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(520, 38);
            this.cboLop.Name = "cboLop";
            this.cboLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOP", "")});
            this.cboLop.Properties.NullText = "";
            this.cboLop.Size = new System.Drawing.Size(194, 20);
            this.cboLop.StyleController = this.layoutControl1;
            this.cboLop.TabIndex = 3;
            this.cboLop.EditValueChanged += new System.EventHandler(this.cboLop_EditValueChanged);
            // 
            // cboKhoiLop
            // 
            this.cboKhoiLop.Location = new System.Drawing.Point(293, 38);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoiLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKHOI", "")});
            this.cboKhoiLop.Properties.NullText = "";
            this.cboKhoiLop.Size = new System.Drawing.Size(175, 20);
            this.cboKhoiLop.StyleController = this.layoutControl1;
            this.cboKhoiLop.TabIndex = 2;
            this.cboKhoiLop.EditValueChanged += new System.EventHandler(this.cboKhoiLop_EditValueChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(70, 38);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.PopupSizeable = true;
            this.cboNamHoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboNamHoc.Size = new System.Drawing.Size(171, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(967, 79);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(949, 63);
            this.layoutControlGroup1.Text = "Thông tin";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(223, 25);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboKhoiLop;
            this.layoutControlItem2.Location = new System.Drawing.Point(223, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(227, 25);
            this.layoutControlItem2.Text = "Khối lớp:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboLop;
            this.layoutControlItem3.Location = new System.Drawing.Point(450, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(246, 25);
            this.layoutControlItem3.Text = "Lớp:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cboHocKy;
            this.layoutControlItem6.Location = new System.Drawing.Point(696, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(231, 25);
            this.layoutControlItem6.Text = "Học kỳ:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(45, 13);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainer1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 79);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(967, 397);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Phân lớp";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainer1.Size = new System.Drawing.Size(963, 393);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lstvDSHS);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(422, 393);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách học sinh";
            // 
            // lstvDSHS
            // 
            this.lstvDSHS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHS1,
            this.colHoTen1});
            this.lstvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvDSHS.FullRowSelect = true;
            this.lstvDSHS.Location = new System.Drawing.Point(2, 20);
            this.lstvDSHS.Name = "lstvDSHS";
            this.lstvDSHS.Size = new System.Drawing.Size(418, 371);
            this.lstvDSHS.TabIndex = 1;
            this.lstvDSHS.UseCompatibleStateImageBehavior = false;
            this.lstvDSHS.View = System.Windows.Forms.View.Details;
            // 
            // colMaHS1
            // 
            this.colMaHS1.Text = "Mã học sinh";
            this.colMaHS1.Width = 173;
            // 
            // colHoTen1
            // 
            this.colHoTen1.Text = "Họ tên";
            this.colHoTen1.Width = 324;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnChuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(422, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 393);
            this.panel1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lstvDSLop);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(457, 393);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách lớp";
            // 
            // lstvDSLop
            // 
            this.lstvDSLop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHS2,
            this.colHoTen2});
            this.lstvDSLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvDSLop.FullRowSelect = true;
            this.lstvDSLop.Location = new System.Drawing.Point(2, 20);
            this.lstvDSLop.Name = "lstvDSLop";
            this.lstvDSLop.Size = new System.Drawing.Size(453, 371);
            this.lstvDSLop.TabIndex = 1;
            this.lstvDSLop.UseCompatibleStateImageBehavior = false;
            this.lstvDSLop.View = System.Windows.Forms.View.Details;
            // 
            // colMaHS2
            // 
            this.colMaHS2.Text = "Mã học sinh";
            this.colMaHS2.Width = 174;
            // 
            // colHoTen2
            // 
            this.colHoTen2.Text = "Họ tên";
            this.colHoTen2.Width = 330;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.Cancel_32px;
            this.btnHuy.Location = new System.Drawing.Point(20, 208);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(42, 44);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.Back_Arrow_32px;
            this.simpleButton1.Location = new System.Drawing.Point(20, 145);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(42, 41);
            this.simpleButton1.TabIndex = 4;
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.Save_32px;
            this.btnLuu.Location = new System.Drawing.Point(20, 275);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(42, 44);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.Image")));
            this.btnChuyen.Location = new System.Drawing.Point(20, 72);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(42, 44);
            this.btnChuyen.TabIndex = 0;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 476);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân lớp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanLop_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit cboLop;
        private DevExpress.XtraEditors.LookUpEdit cboKhoiLop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ListView lstvDSLop;
        private System.Windows.Forms.ColumnHeader colMaHS2;
        private System.Windows.Forms.ColumnHeader colHoTen2;
        private DevExpress.XtraEditors.LookUpEdit cboHocKy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.ComboBoxEdit cboNamHoc;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListView lstvDSHS;
        private System.Windows.Forms.ColumnHeader colMaHS1;
        private System.Windows.Forms.ColumnHeader colHoTen1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
    }
}