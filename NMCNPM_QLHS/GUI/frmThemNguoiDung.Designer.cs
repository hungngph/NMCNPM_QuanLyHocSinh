namespace NMCNPM_QLHS.GUI
{
    partial class frmThemNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNguoiDung));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNguoiDung = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNguoiDung = new DevExpress.XtraEditors.TextEdit();
            this.cboLoaiNguoiDung = new DevExpress.XtraEditors.LookUpEdit();
            this.errTenTK = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNguoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTenTaiKhoan);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnHuy);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtMaNguoiDung);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.txtTenNguoiDung);
            this.groupControl1.Controls.Add(this.cboLoaiNguoiDung);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(338, 304);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Đổi mật khẩu";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(142, 208);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(180, 22);
            this.txtTenTaiKhoan.TabIndex = 11;
            this.txtTenTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên tài khoản:";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Delete_16px;
            this.btnHuy.Location = new System.Drawing.Point(237, 256);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 28);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã người dùng:";
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.EditValue = "";
            this.txtMaNguoiDung.Enabled = false;
            this.txtMaNguoiDung.Location = new System.Drawing.Point(142, 41);
            this.txtMaNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Properties.NullText = "Mật khẩu cũ";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.txtMaNguoiDung.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên người dùng";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = global::NMCNPM_QLHS.Properties.Resources.icons8_Ok_16px;
            this.btnThem.Location = new System.Drawing.Point(142, 256);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 28);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(142, 95);
            this.txtTenNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.txtTenNguoiDung.TabIndex = 2;
            this.txtTenNguoiDung.EditValueChanged += new System.EventHandler(this.txtTenNguoiDung_EditValueChanged);
            // 
            // cboLoaiNguoiDung
            // 
            this.cboLoaiNguoiDung.Location = new System.Drawing.Point(142, 151);
            this.cboLoaiNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiNguoiDung.Name = "cboLoaiNguoiDung";
            this.cboLoaiNguoiDung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiNguoiDung.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOAIND", "")});
            this.cboLoaiNguoiDung.Properties.DisplayMember = "TENLOAIND";
            this.cboLoaiNguoiDung.Properties.NullText = "";
            this.cboLoaiNguoiDung.Properties.ValueMember = "MALND";
            this.cboLoaiNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.cboLoaiNguoiDung.TabIndex = 3;
            // 
            // errTenTK
            // 
            this.errTenTK.ContainerControl = this;
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 304);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm người dùng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThemNguoiDung_FormClosed);
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiNguoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMaNguoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTenNguoiDung;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit cboLoaiNguoiDung;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errTenTK;
    }
}