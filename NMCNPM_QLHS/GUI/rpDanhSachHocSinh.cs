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
        public rpDanhSachHocSinh()
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
        }

        public void load_rpDanhSachHocSinh(string tenNamHoc, string tenLop, string maLop, DateTime ngayLap)
        {
            pNamHoc.Value = tenNamHoc;
            pLop.Value = tenLop;
            pNgayLap.Value = ngayLap;
            bindingSourceDiemTongKet.DataSource = HOCTAP_BUS.LayDiemHocSinhTheoLop(maLop);
        }

        public rpDanhSachHocSinh(string tenNamHoc, string tenLop, string maLop, DateTime ngayLap)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in Parameters)
                p.Visible = false;
            pNamHoc.Value = tenNamHoc;
            pLop.Value = tenLop;
            pNgayLap.Value = ngayLap.ToShortDateString();
            bindingSourceDiemTongKet.DataSource = HOCTAP_BUS.LayDiemHocSinhTheoLop(maLop);
        }

    }
}
