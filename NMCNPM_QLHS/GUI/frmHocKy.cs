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
    public partial class frmHocKy : DevExpress.XtraEditors.XtraForm
    {
        static bool state = false; // đã thay đổi dữ liệu chưa

        public frmHocKy()
        {
            InitializeComponent();
            //hello
        }

        #region -Events-

        #region -Form-

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            bindingSourceHocKy.DataSource = HOCKY_BUS.LayTatCaHocKy();
        }

        private void frmHocKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (state == true)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu thay đổi không?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    bindingNavigatorSaveItem.PerformClick();
            }
        }

        #endregion -Form-

        #region -bingdingNagigatorItem_Click-

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            bindingSourceHocKy.DataSource = HOCKY_BUS.LayTatCaHocKy();
            state = false;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string maHK;
            int heSo;
            bindingNavigatorHocKy.BindingSource.MoveFirst();
            for (int i = 0; i < dgvHocKy.RowCount; i++)
            {
                maHK = dgvHocKy.GetFocusedRowCellDisplayText(col_maHocKy);
                heSo = int.Parse(dgvHocKy.GetFocusedRowCellDisplayText(col_heSo));
                HOCKY_BUS.update(maHK, heSo);
                bindingNavigatorHocKy.BindingSource.MoveNext();
            }
            XtraMessageBox.Show("Lưu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            state = false;
        }

        #endregion -bingdingNagigatorItem_Click-

        private void dgvHocKy_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            state = true;
        }

        private void gridControlHocKy_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }

        private void btuLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingNavigatorSaveItem_Click(sender, e);
        }
        private void gridControlHocKy_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(Control.MousePosition);
        }
        #endregion -Events-


    }
}