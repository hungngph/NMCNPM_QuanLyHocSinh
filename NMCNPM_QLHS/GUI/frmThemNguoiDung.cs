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
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        Action<string, string, string, string> actionHandle;
        public frmThemNguoiDung()
        {
            InitializeComponent();
        }

        public frmThemNguoiDung(string maND, Action<string, string, string, string> action)
        {
            InitializeComponent();
            actionHandle = action;
            txtMaNguoiDung.Text = maND;
        }

        private void frmThemNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["frmNguoiDung"].Enabled = true;
            Application.OpenForms["frmNguoiDung"].Refresh();
        }

        private void load_cboLoaiND()
        {
            cboLoaiNguoiDung.Properties.DataSource = LOAINGUOIDUNG_BUS.LayTatCaLoaiNguoiDung();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            actionHandle(txtMaNguoiDung.Text, txtTenNguoiDung.Text, cboLoaiNguoiDung.EditValue.ToString(), txtTenTaiKhoan.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemNguoiDung_Load(object sender, EventArgs e)
        {
            load_cboLoaiND();
        }
    }
}