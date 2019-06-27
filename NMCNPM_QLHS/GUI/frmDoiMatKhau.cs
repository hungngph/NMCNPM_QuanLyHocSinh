using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
            PhanQuyen();
        }
        public void PhanQuyen()
        {

        }

        private void frmDoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmManHinhChinh"].Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["frmManHinhChinh"].Enabled = true;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text != txtNhapLai.Text)
                MessageBox.Show("Nhập lại không trùng");
            else if (NGUOIDUNG_BUS.LayMatKhau(CurrentUser.Code) != txtMatKhau.Text)
                MessageBox.Show("Mật khẩu cũ sai");
            else if (txtMatKhau.Text == txtMatKhauMoi.Text)
                MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ");
            else if (!NGUOIDUNG_BUS.DoiMatKhau(CurrentUser.Code, txtMatKhau.Text, txtMatKhauMoi.Text))
                MessageBox.Show("Đổi mật khẩu không thành công");
            else
                MessageBox.Show("Đổi mật khẩu thành công");
        }
    }
}