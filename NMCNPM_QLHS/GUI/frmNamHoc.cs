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
    public partial class frmNamHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmNamHoc()
        {
            InitializeComponent();
        }

        #region -Phân quyền-

        #region -Phân quyền đăng nhập-
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
        #endregion -Phân quyền đăng nhập-

        #region -Giao diện đăng nhập

        #region -Giao diện mặc định-
        public void Default()
        {
            // True
            // Enable các button
            // False 
            // Disable các button
            bindingNavigatorAdd.Enabled = true;
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorDelete.Enabled = true;
            bindingNavigatorSave.Enabled = true;
        }
        #endregion

        #region -Giao diện đăng nhập với quyền BGH-
        public void IsBGH()
        {
            // Enable, Disable các button
        }
        #endregion

        #region -Giao diện đăng nhập với quyền Giáo viên-
        public void IsGiaoVien()
        {
            // Enable, Disable các button
            bindingNavigatorAdd.Enabled = false;
            bindingNavigatorEdit.Enabled = false;
            bindingNavigatorDelete.Enabled = false;
            bindingNavigatorSave.Enabled = false;
        }
        #endregion

        #region -Giao diện đăng nhập với quyền Giáo vụ-
        public void IsGiaoVu()
        {
            // Enable, Disable các button
        }

        #endregion

        #endregion -Giao diện đăng nhập

        #endregion -Phân quyền-

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            load_DSNamHoc();
        }

        private void bindingNavigatorAdd_Click(object sender, EventArgs e)
        {
            NAMHOC_BUS.Insert();
            load_DSNamHoc();
        }

        private void btnDeletebindingNavigatorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa lớp này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maNamHoc = dgvNamHoc.GetFocusedRowCellDisplayText(col_maNamHoc);
                NAMHOC_BUS.Delete(maNamHoc);
                load_DSNamHoc();
            }
        }

        private void load_DSNamHoc()
        {

            bindingSourceNamHoc.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
        }
    }
}