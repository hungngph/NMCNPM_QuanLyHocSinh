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
        #region -Constructor-

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
                    tabQuyDinh.SelectedPage = tabTuoi;
                    break;
                case "QuyDinhSiSo":
                    tabQuyDinh.SelectedPage = tabSiSo;
                    break;
                case "QuyDinhDiem":
                    tabQuyDinh.SelectedPage = tabDiem;
                    break;
            }
        }

        private void loadQuyDinh()
        {

        }


        #endregion -Constructor-

        #region -Button_click-

        #region -tabDoTuoi-

        private void btnDongY1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy1_Click(object sender, EventArgs e)
        {

        }

        #endregion -tabDoTuoi-

        #region -tabSiSo-

        private void btnDongY2_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {

        }

        #endregion-tabSiSo-

        #region -tabDiem

        private void btnDongY3_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy3_Click(object sender, EventArgs e)
        {

        }

        #endregion-tabDiem

        #endregion-Button_click-
    }
}