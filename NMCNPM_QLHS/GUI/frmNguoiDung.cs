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
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            bindingSourceNguoiDung.DataSource = NGUOIDUNG_BUS.LayTatCaNguoiDung();
            load_colNguoiDung();
        }

        void load_colNguoiDung()
        {
            col_loaiNguoiDung_edit.DataSource = LOAINGUOIDUNG_BUS.LayTatCaLoaiNguoiDung();
        }
    }
}