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
            bindingSourceNamHoc.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
        }
    }
}