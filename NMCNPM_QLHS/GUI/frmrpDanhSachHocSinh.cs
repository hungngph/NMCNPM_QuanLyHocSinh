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
            ReportDSHS();
        }
        public void ReportDSHS()
        {
            rpDanhSachHocSinh rp = new rpDanhSachHocSinh();
            documentViewer1.DocumentSource = rp;
            rp.CreateDocument();
        }

    }
}