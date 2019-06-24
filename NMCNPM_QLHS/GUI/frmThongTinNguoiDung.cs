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

namespace NMCNPM_QLHS.GUI
{
    public partial class frmThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void frmThongTinNguoiDung_FormClosed(object sender, FormClosedEventArgs e)
        {
 
                Application.OpenForms["frmManHinhChinh"].Enabled=true;
        }
    }
}