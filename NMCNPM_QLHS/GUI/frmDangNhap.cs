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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (NGUOIDUNG_BUS.DangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                frmManHinhChinh frm = new frmManHinhChinh();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }
    }
}