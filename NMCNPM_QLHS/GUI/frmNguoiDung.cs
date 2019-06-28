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
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        #region -Fields-

        static bool state = false;
        List<string> lst = new List<string>();

        #endregion -Fields-

        #region -Constructor-

        public frmNguoiDung()
        {
            InitializeComponent();
        }

        #endregion -Constructor-

        #region -Form-

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            load_colNguoiDung();
            bindingSourceNguoiDung.DataSource = NGUOIDUNG_BUS.LayTatCaNguoiDung();
        }

        private void frmNguoiDung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.bindingNavigatorSaveItem_Click(bindingNavigatorSaveItem, e);
            }
        }

        #endregion -Form-

        #region -bindingNavigatorItem_Click-

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            var frm = new frmThemNguoiDung();
            frm.Show();
            this.Enabled = false;
            //col_TenDangNhap.OptionsColumn.ReadOnly = false;
            //dgvNguoiDung.FocusInvalidRow();
            //string maND = NGUOIDUNG_BUS.autoID(dgvNguoiDung);
            //dgvNguoiDung.AddNewRow();
            //dgvNguoiDung.SetFocusedRowCellValue(col_LoaiNguoiDung, "LND001");
            //int rowHandle = dgvNguoiDung.GetRowHandle(dgvNguoiDung.DataRowCount);
            //if (dgvNguoiDung.IsNewItemRow(rowHandle))
            //{
            //    dgvNguoiDung.SetRowCellValue(rowHandle, col_maNguoiDung, maND);
            //}
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa người dùng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maNguoiDung = dgvNguoiDung.GetFocusedRowCellDisplayText(col_maNguoiDung);
                dgvNguoiDung.DeleteSelectedRows();
                lst.Add(maNguoiDung);
            }
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maNguoiDung, tenNguoiDung, MaLND, tenTaiKhoan;
            bindingNavigatorNguoiDung.BindingSource.MoveFirst();
            // Thêm, sửa người dùng
            for (int i = 0; i < dgvNguoiDung.RowCount; i++)
            {
                maNguoiDung = dgvNguoiDung.GetFocusedRowCellDisplayText(col_maNguoiDung);
                tenNguoiDung = dgvNguoiDung.GetFocusedRowCellDisplayText(col_TenNguoiDung);
                MaLND = dgvNguoiDung.GetFocusedRowCellValue(col_LoaiNguoiDung).ToString();
                tenTaiKhoan = dgvNguoiDung.GetFocusedRowCellDisplayText(col_TenDangNhap);
                if (Utility.isPassword(tenTaiKhoan) || !Utility.isTen(tenNguoiDung))
                {
                    XtraMessageBox.Show("Sai định dạng tên tại dòng " + (i + 1), "Thông báo");
                    return;
                }

                if (NGUOIDUNG_BUS.LayTatCaNguoiDung().Any(a => a.MAND == maNguoiDung) == true)
                    NGUOIDUNG_BUS.update(maNguoiDung, tenNguoiDung, MaLND);
                else if (NGUOIDUNG_BUS.KiemTraTenDangNhap(tenTaiKhoan))
                {
                    XtraMessageBox.Show("Trùng tên đăng nhập tại dòng " + (i + 1), "Thông báo");
                    return;
                }
                else
                    NGUOIDUNG_BUS.insert(maNguoiDung, tenNguoiDung, MaLND, tenTaiKhoan);
                bindingNavigatorNguoiDung.BindingSource.MoveNext();
            }
            // Xóa người dùng
            if (lst != null)
            {
                for (int i = 0; i < lst.Count; i++)
                    NGUOIDUNG_BUS.delete(lst[i]);
            }

            XtraMessageBox.Show("Lưu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            state = false;
        }

        #endregion -bindingNavigatorItem_Click-

        #region -popupMenu-

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorAddNewItem_Click(sender, e);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender, e);
        }

        #endregion -popupMenu-

        private void dgvNguoiDung_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            state = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string maND = dgvNguoiDung.GetFocusedRowCellDisplayText(col_maNguoiDung);
            NGUOIDUNG_BUS.ResetMK(maND);
        }

        void load_colNguoiDung()
        {
            col_loaiNguoiDung_edit.DataSource = LOAINGUOIDUNG_BUS.LayTatCaLoaiNguoiDung();
        }


        private void gridControlHocSinh_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}