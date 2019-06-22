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
    public partial class frmrpDanhSachHocSinh : DevExpress.XtraEditors.XtraForm
    {
        public frmrpDanhSachHocSinh()
        {
            InitializeComponent();
        }
        public void ReportDSHS(string namhoc)
        {
            rpDanhSachHocSinh rp = new rpDanhSachHocSinh(namhoc);
            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            ReportDSHS(cboNamHoc.Text);
        }
    }
}