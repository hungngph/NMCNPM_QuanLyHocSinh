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