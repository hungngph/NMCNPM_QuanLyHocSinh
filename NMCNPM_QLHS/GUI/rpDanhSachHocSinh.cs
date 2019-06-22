using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using NMCNPM_QLHS.BUS;

namespace NMCNPM_QLHS.GUI
{
    public partial class rpDanhSachHocSinh : DevExpress.XtraReports.UI.XtraReport
    {
        public rpDanhSachHocSinh(string namhoc)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
            pNamHoc.Value = namhoc;
            bindingSource1.DataSource = HOCSINH_BUS.LayTatCaHocSinh();
        }

    }
}
