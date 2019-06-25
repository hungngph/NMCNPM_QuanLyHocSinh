using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class KHOILOP_DAL
    {
        // Lấy tất cả các khối
        public static DataTable LayTatCaKhoi()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAKHOI", typeof(string));
            dt.Columns.Add("TENKHOI", typeof(string));
            dt.Columns.Add("SOLOP", typeof(int));
            dt.Columns.Add("TENNAMHOC", typeof(string));
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = from khoi in db.KHOILOPs
                         from namHoc in db.NAMHOCs 
                         where khoi.MANAM == namHoc.MANAMHOC 
                         select new
                         {
                             tenNamHoc = namHoc.TENNAMHOC,
                             maKhoi = khoi.MAKHOI,
                             tenKHoi = khoi.TENKHOI,
                             soLop = khoi.SOLOP
                         };
                foreach (var i in ds)
                {
                    DataRow r = dt.NewRow();
                    if (i.maKhoi != null)
                        r["MAKHOI"] = i.maKhoi;
                    if (i.tenKHoi != null)
                        r["TENKHOI"] = i.tenKHoi;
                    if (i.soLop != null)
                        r["SOLOP"] = i.soLop.Value;
                    if (i.tenNamHoc != null)
                        r["TENNAMHOC"] = i.tenNamHoc;
                    dt.Rows.Add(r);
                }
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy khối theo năm học
        public static List<KHOILOP> LayKhoiTheoNamHoc(string maNamHoc)
        {
            List<KHOILOP> lst = new List<KHOILOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.KHOILOPs.Where(a => a.MANAM == maNamHoc).ToList();
                foreach (var x in ds)
                {
                    KHOILOP khoiLop = new KHOILOP();
                    khoiLop.MAKHOI = x.MAKHOI;
                    khoiLop.TENKHOI = x.TENKHOI;
                    khoiLop.MANAM = x.MANAM;
                    khoiLop.SOLOP = x.SOLOP;
                    lst.Add(khoiLop);
                }
            }
            return lst;
        }

        // Lấy khối 10 & 11 theo năm học
        public static List<KHOILOP> LayKhoi1011(string maNamHoc)
        {
            List<KHOILOP> lst = new List<KHOILOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.KHOILOPs.Where(a => (a.MANAM == maNamHoc) && (a.TENKHOI == "10" || a.TENKHOI == "11")).ToList();
                foreach (var x in ds)
                {
                    KHOILOP khoiLop = new KHOILOP();
                    {
                        khoiLop.MAKHOI = x.MAKHOI;
                        khoiLop.TENKHOI = x.TENKHOI;
                        lst.Add(khoiLop);
                    }
                }
            }
            return lst;
        }

        // Lấy khối lớp theo mã khối mã năm
        public static List<KHOILOP> LayKhoiTheoMaKhoiMaNam(string tenKhoiLop, string maNamHoc)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                return db.KHOILOPs.Where(a => a.MANAM == maNamHoc && a.TENKHOI == tenKhoiLop).ToList();
            }
        }
    }
}
