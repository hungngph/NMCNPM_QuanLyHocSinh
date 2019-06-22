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
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navTimKiem;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dockPanelChucNang.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            navPanelChucNang.SelectedPage = navThem;
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            load_cboNamHoc();
        }

        private void load_cboNamHoc()
        {
            cboNamHoc.Properties.DataSource = NAMHOC_BUS.LayTatCaNamHoc();
            cboNamHoc.Properties.DisplayMember = "TENNAMHOC";
            cboNamHoc.Properties.ValueMember = "MANAMHOC";
        }

        private void load_DSLop()
        {
            string maNamHoc = cboNamHoc.EditValue.ToString();
            bindingSourceLop.DataSource = LOP_BUS.LayLopTheoNamHoc(maNamHoc);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            load_DSLop();
        }
    }
}