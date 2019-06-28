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
        List<string> lst = new List<string>();
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string maND = dgvNguoiDung.GetFocusedRowCellDisplayText(col_maNguoiDung);
            NGUOIDUNG_BUS.ResetMK(maND);
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            load_colNguoiDung();
            load_DSNguoiDung();
        }

        private void load_DSNguoiDung()
        {
            bindingSourceNguoiDung.DataSource = NGUOIDUNG_BUS.LayTatCaNguoiDung();
        }

        void load_colNguoiDung()
        {
            col_loaiNguoiDung_edit.DataSource = LOAINGUOIDUNG_BUS.LayTatCaLoaiNguoiDung();
        }

        private void dgvNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MessageBox.Show(dgvNguoiDung.GetRowCellDisplayText(0,col_LoaiNguoiDung).ToString());
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            string maND = NGUOIDUNG_BUS.autoID(dgvNguoiDung);
            dgvNguoiDung.AddNewRow();
            int rowHandle = dgvNguoiDung.GetRowHandle(dgvNguoiDung.DataRowCount);
            if (dgvNguoiDung.IsNewItemRow(rowHandle))
            {
                dgvNguoiDung.SetRowCellValue(rowHandle, col_maNguoiDung, maND);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa lớp này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                if (NGUOIDUNG_BUS.LayTatCaNguoiDung().Any(a => a.MAND == maNguoiDung) == true)
                    NGUOIDUNG_BUS.update(maNguoiDung, tenNguoiDung, MaLND);
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
        }
    }
}