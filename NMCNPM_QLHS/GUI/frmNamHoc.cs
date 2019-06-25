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