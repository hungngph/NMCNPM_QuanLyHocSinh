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
    public partial class frmLoaiHinhKT : DevExpress.XtraEditors.XtraForm
    {
        static bool state = false; // đã thay đổi dữ liệu chưa
        public frmLoaiHinhKT()
        {
            InitializeComponent();
        }

        #region -Form-

        private void frmLoaiHinhKT_Load(object sender, EventArgs e)
        {
            bindingSourceLHKT.DataSource = LOAIHINHKIEMTRA_BUS.LayTatCaLHKT();
        }

        private void frmLoaiHinhKT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingNavigatorSaveItem.PerformClick();
            }
        }

        #endregion -Form-

        #region  -bingdingNagigatorItem_Click-

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maLHKT;
            int heSo;
            bindingNavigatorHocKy.BindingSource.MoveFirst();
            for (int i = 0; i < dgvLHKT.RowCount; i++)
            {
                maLHKT = dgvLHKT.GetFocusedRowCellDisplayText(col_maLHKT);
                heSo = int.Parse(dgvLHKT.GetFocusedRowCellDisplayText(col_heSo));
                LOAIHINHKIEMTRA_BUS.update(maLHKT, heSo);
                bindingNavigatorHocKy.BindingSource.MoveNext();
            }
            state = false;
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            bindingSourceLHKT.DataSource = LOAIHINHKIEMTRA_BUS.LayTatCaLHKT();
            state = false;
        }

        #endregion -bingdingNagigatorItem_Click-

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorSaveItem_Click(sender, e);
        }

        private void dgvHocKy_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            state = true;
        }

        private void gridControlLoaiKT_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
    }
}