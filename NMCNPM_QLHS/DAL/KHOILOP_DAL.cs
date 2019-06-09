using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class KHOILOP_DAL
    {
        // Lấy tất cả các khối
        public static List<KHOILOP> LayTatCaKhoi()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                List<KHOILOP> lst = db.KHOILOPs.ToList();
                return lst;
            }
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
                    {
                        khoiLop.MAKHOI = x.MAKHOI;
                        khoiLop.TENKHOI = x.TENKHOI;
                        lst.Add(khoiLop);
                    }
                }
            }
            return lst;
        }
    }
}
