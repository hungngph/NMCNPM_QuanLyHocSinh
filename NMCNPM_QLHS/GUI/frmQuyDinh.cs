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
    public partial class frmQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }
        public frmQuyDinh(string s)
        {
            InitializeComponent();
            switch (s)
            {
                case "QuyDinhTuoi":
                    tabPane1.SelectedPage = tabTuoi;
                    break;
                case "QuyDinhSiSo":
                    tabPane1.SelectedPage = tabSiSo;
                    break;
                case "QuyDinhDiem":
                    tabPane1.SelectedPage = tabDiem;
                    break;
            }
        }
    }
}