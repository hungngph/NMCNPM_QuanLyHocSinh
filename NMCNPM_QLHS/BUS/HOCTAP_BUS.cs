using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class HOCTAP_BUS
    {
        // Lấy điểm học sinh theo lớp
        public static DataTable LayDiemHocSinhTheoLop(string tenLop, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MAHS", typeof(string));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMTBHKI", typeof(float));
            dt.Columns.Add("DIEMTBHKII", typeof(float));

            SQL_QLHSDataContext db = new SQL_QLHSDataContext();
            var lst = db.sp_LayDiemHocSinhTheoLop(tenLop, maNamHoc);
            foreach (var i in lst)
            {
                DataRow r = dt.NewRow();
                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.DIEMTBHK1 != null)
                    r["DIEMTBHK1"] = i.DIEMTBHK1;
                if (i.DIEMTBHK2 != null)
                    r["DIEMTBHK2"] = i.DIEMTBHK1;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy điểm chi tiết học sinh theo môn học
        public static DataTable LayDiemChiTietHocSinhTheoMon(string maHS, string maHocKy, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TENMONHOC", typeof(string));
            dt.Columns.Add("DIEMMIENG", typeof(float));
            dt.Columns.Add("DIEM15P", typeof(float));
            dt.Columns.Add("DIEM1TIET", typeof(float));
            dt.Columns.Add("DIEMTHI", typeof(float));
            dt.Columns.Add("DIEMTBHK", typeof(float));

            SQL_QLHSDataContext db = new SQL_QLHSDataContext();
            var lst = db.sp_LayDiemChiTietHocSinhTheoMon(maHS, maHocKy, maNamHoc);
            foreach (var i in lst)
            {
                DataRow r = dt.NewRow();
                if (i.TENMONHOC != null)
                    r["TENMONHOC"] = i.TENMONHOC;
                if (i.DIEMMIENG != null)
                    r["DIEMMIENG"] = i.DIEMMIENG;
                if (i.DIEM15P != null)
                    r["DIEM15P"] = i.DIEM15P;
                if (i.DIEM1TIET != null)
                    r["DIEM1TIET"] = i.DIEM1TIET;
                if (i.DIEMTHI != null)
                    r["DIEMTHI"] = i.DIEMTHI;
                if (i.DIEMTBHK != null)
                    r["DIEMTBHK"] = i.DIEMTBHK;
                dt.Rows.Add(r);
            }
            return dt;
        }

        // Lấy điểm môn học theo lớp
        public static DataTable LayDiemMonHocTheoLop(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAHS", typeof(string));
            dt.Columns.Add("HOTEN", typeof(string));
            dt.Columns.Add("DIEMMIENG", typeof(float));
            dt.Columns.Add("DIEM15P", typeof(float));
            dt.Columns.Add("DIEM1TIET", typeof(float));
            dt.Columns.Add("DIEMTHI", typeof(float));

            SQL_QLHSDataContext db = new SQL_QLHSDataContext();
            var lst = db.sp_LayDiemMonHocTheoLop(maLop, maHocKy, maNamHoc, maMonHoc);
            foreach (var i in lst)
            {
                DataRow r = dt.NewRow();
                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                if (i.DIEMMIENG != null)
                    r["DIEMMIENG"] = i.DIEMMIENG;
                if (i.DIEM15P != null)
                    r["DIEM15P"] = i.DIEM15P;
                if (i.DIEM1TIET != null)
                    r["DIEM1TIET"] = i.DIEM1TIET;
                if (i.DIEMTHI != null)
                    r["DIEMTHI"] = i.DIEMTHI;
                dt.Rows.Add(r);
            }
            return dt;
        }

        // Sửa điểm
        public static void SuaDiem(string maHS, string maMon, string mahocky, string maNamHoc, float diemMieng, float diem15P, float diem1Tiet, float diemThi)
        {
            HOCTAP_DAL.SuaDiem(maHS, maMon, mahocky, maNamHoc, diemMieng, diem15P, diem1Tiet, diemThi);
        }

    }
}
