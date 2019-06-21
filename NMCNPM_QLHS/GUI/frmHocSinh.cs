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
using System.Globalization;

namespace NMCNPM_QLHS.GUI
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {

        #region -Constructor-

        public frmHocSinh()
        {
            InitializeComponent();
            //DataService.OpenConnection();
        }

        #endregion -Constructor-

        #region -Events-

        #region -Form-

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            btnHoanTat.Visible = false;
            load_dgvHocSinh();
        }

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion -Form-

        #region -BindingNavigatorItems_Events-

        // Thêm học sinh
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Chuyển sang panel nhập liệu
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navNhapLieu;

            bindingNavigatorAddNewItem.Enabled = false;
            btnHoanTat.Visible = true;
            btnHoanTat.Text = "Lưu";
            clear();
            enableAllTextBox();
            txtMaHS.Text = HOCSINH_BUS.getMaHS();
            txtHoTen.Focus();
        }

        // Xóa học sinh
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa học sinh này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maHS = txtMaHS.Text;
                HOCSINH_BUS.Delete(maHS);
                load_dgvHocSinh();
            }
        }

        // Sửa học sinh
        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            btnHoanTat.Text = "Hoàn tất";
            btnHoanTat.Visible = true;
            enableAllTextBox();
            txtHoTen.Focus();
        }

        // Lưu thay đổi
        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        // Tìm kiếm học sinh
        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navTimKiem;
            txtTTTimKiem.Focus();
        }

        #endregion -BindingNavigatorItems_Events-

        #region -Nhập liệu Events-

        private void dgvHocSinh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            btnHoanTat.Visible = false;
            disableAllTextBox();
            txtMaHS.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_maHS);
            txtHoTen.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_hoTen);
            dtpNgaySinh.EditValue = dgvHocSinh.GetFocusedRowCellValue(col_ngaySinh);
            cboGioiTinh.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_gioiTinh);
            txtDiaChi.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_diaChi);
            txtEmail.Text = dgvHocSinh.GetFocusedRowCellDisplayText(col_email);
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text;
            string hoTen = txtHoTen.Text;
            string gioiTinh = cboGioiTinh.Text;
            DateTime ngaySinh = DateTime.ParseExact(dtpNgaySinh.Text.ToString(), "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("en-GB"));
            string email = txtEmail.Text;
            string diaChi = txtDiaChi.Text;

            if (HOCSINH_BUS.KiemTraTuoi(ngaySinh) == true)
            {
                try
                {
                    if (btnHoanTat.Text == "Lưu")
                    {
                        HOCSINH_BUS.Insert(maHS, hoTen, gioiTinh, ngaySinh, email, diaChi);
                        bindingNavigatorHocSinh.BindingSource.MoveLast();
                    }
                    else
                        HOCSINH_BUS.Update(maHS, hoTen, gioiTinh, ngaySinh, email, diaChi);
                    load_dgvHocSinh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                bindingNavigatorAddNewItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tuổi không hợp lệ", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgaySinh.Focus();
            }
        }

        #endregion -Nhập liệu Events-

        #region -Tìm kiếm Events-

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTTTimKiem_TextChanged(object sender, EventArgs e)
        {
            bindingSourceHocSinh.DataSource = HOCSINH_BUS.timTTHSTheoTen(txtTTTimKiem.Text);
        }

        #endregion -Tìm kiếm Events-

        #endregion -Events-

        #region -Methods-

        #region -Load-

        public void load_dgvHocSinh()
        {
            bindingSourceHocSinh.DataSource = HOCSINH_BUS.LayTatCaHocSinh();
        }

        #endregion -Load-

        public void clear()
        {
            txtHoTen.Text = null;
            txtDiaChi.Text = null;
            txtEmail.Text = null;
            dtpNgaySinh.Text = null;
            cboGioiTinh.Text = null;
        }

        public void enableAllTextBox()
        {
            txtHoTen.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            dtpNgaySinh.ReadOnly = false;
            cboGioiTinh.Enabled = true;
        }

        public void disableAllTextBox()
        {
            txtHoTen.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            dtpNgaySinh.ReadOnly = true;
            cboGioiTinh.Enabled = false;
        }

        #endregion -Methods-

    }
}