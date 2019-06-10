namespace NMCNPM_QLHS.GUI
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
            this.btnDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.cboLop = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKhoiLop = new DevExpress.XtraEditors.LookUpEdit();
            this.cboNamHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstvDSLop = new System.Windows.Forms.ListView();
            this.colMaHS2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstvDSHS = new System.Windows.Forms.ListView();
            this.colMaHS1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoiLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnDanhSach);
            this.layoutControl1.Controls.Add(this.cboLop);
            this.layoutControl1.Controls.Add(this.cboKhoiLop);
            this.layoutControl1.Controls.Add(this.cboNamHoc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(967, 88);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(828, 38);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(117, 22);
            this.btnDanhSach.StyleController = this.layoutControl1;
            this.btnDanhSach.TabIndex = 7;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(583, 38);
            this.cboLop.Name = "cboLop";
            this.cboLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOP", "")});
            this.cboLop.Properties.NullText = "";
            this.cboLop.Size = new System.Drawing.Size(241, 20);
            this.cboLop.StyleController = this.layoutControl1;
            this.cboLop.TabIndex = 6;
            this.cboLop.EditValueChanged += new System.EventHandler(this.cboLop_EditValueChanged);
            // 
            // cboKhoiLop
            // 
            this.cboKhoiLop.Location = new System.Drawing.Point(320, 38);
            this.cboKhoiLop.Name = "cboKhoiLop";
            this.cboKhoiLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoiLop.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENKHOI", "")});
            this.cboKhoiLop.Properties.NullText = "";
            this.cboKhoiLop.Size = new System.Drawing.Size(211, 20);
            this.cboKhoiLop.StyleController = this.layoutControl1;
            this.cboKhoiLop.TabIndex = 5;
            this.cboKhoiLop.EditValueChanged += new System.EventHandler(this.cboKhoiLop_EditValueChanged);
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(70, 38);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNamHoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENNAMHOC", "")});
            this.cboNamHoc.Properties.NullText = "";
            this.cboNamHoc.Size = new System.Drawing.Size(198, 20);
            this.cboNamHoc.StyleController = this.layoutControl1;
            this.cboNamHoc.TabIndex = 4;
            this.cboNamHoc.EditValueChanged += new System.EventHandler(this.cboNamHoc_EditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(967, 88);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(949, 72);
            this.layoutControlGroup1.Text = "Thông tin";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cboNamHoc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(250, 34);
            this.layoutControlItem1.Text = "Năm học:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDanhSach;
            this.layoutControlItem4.Location = new System.Drawing.Point(806, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(121, 34);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cboKhoiLop;
            this.layoutControlItem2.Location = new System.Drawing.Point(250, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(263, 34);
            this.layoutControlItem2.Text = "Khối lớp:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cboLop;
            this.layoutControlItem3.Location = new System.Drawing.Point(513, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(293, 34);
            this.layoutControlItem3.Text = "Lớp:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(45, 13);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainer1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 88);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(967, 388);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Phân lớp";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 20);
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
            this.splitContainer1.Size = new System.Drawing.Size(963, 366);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 0;
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
            this.lstvDSLop.Size = new System.Drawing.Size(450, 344);
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lstvDSLop);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(454, 366);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách lớp";
            // 
            // btnChuyen
            // 
            this.btnChuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.ImageOptions.Image")));
            this.btnChuyen.Location = new System.Drawing.Point(20, 124);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(42, 44);
            this.btnChuyen.TabIndex = 0;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.Save_32px;
            this.btnLuu.Location = new System.Drawing.Point(20, 207);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(42, 44);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnChuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(425, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 366);
            this.panel1.TabIndex = 0;
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
            this.lstvDSHS.Size = new System.Drawing.Size(421, 344);
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
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lstvDSHS);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(425, 366);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách học sinh";
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 476);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmPhanLop";
            this.Text = "frmPhanLop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhanLop_FormClosing);
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoiLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNamHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnDanhSach;
        private DevExpress.XtraEditors.LookUpEdit cboLop;
        private DevExpress.XtraEditors.LookUpEdit cboKhoiLop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit cboNamHoc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListView lstvDSHS;
        private System.Windows.Forms.ColumnHeader colMaHS1;
        private System.Windows.Forms.ColumnHeader colHoTen1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.ListView lstvDSLop;
        private System.Windows.Forms.ColumnHeader colMaHS2;
        private System.Windows.Forms.ColumnHeader colHoTen2;
    }
}