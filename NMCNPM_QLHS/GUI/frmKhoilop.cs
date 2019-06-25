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
    public partial class frmKhoilop : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoilop()
        {
            InitializeComponent();
        }
        #region -Phân quyền-

        public void Permissions()
        {
            switch ("LND001")
            {
                case "LND001":      // Giao diện đăng nhập với quyền BGH
                    IsBGH();
                    break;
                case "LND002":      // Giao diện đăng nhập với quyền GiaoVien
                    IsGiaoVien();
                    break;
                case "LND003":      // Giao diện đăng nhập với quyền GiaoVu
                    IsGiaoVu();
                    break;
                default:
                    Default();
                    break;
            }
        }


        public void Default()
        {
            // True
            // Enable các button
            // False 
            // Disable các button
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnDelete.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void IsBGH()
        {
            // Enable, Disable các button
        }

        public void IsGiaoVien()
        {
            // Enable, Disable các button
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnDelete.Enabled = false;
            btnLuu.Enabled = false;
        }

        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }



        #endregion -Phân quyền-

        private void frmKhoilop_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
            bindingSourceKhoiLop.DataSource = KHOILOP_BUS.LayTatCaKhoi();
        }

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }
    }
}