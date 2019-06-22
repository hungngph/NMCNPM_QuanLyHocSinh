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
        public frmHocKy()
        {
            InitializeComponent();
            //hello
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            bindingSourceHocKy.DataSource = HOCKY_BUS.LayTatCaHocKy();
        }
    }
}