using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class LOP_DAL
    {
        // Lấy tất cả các lớp
        public static List<LOP> LayTatCaLop()
        {
            List<LOP> lst = new List<LOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = from lop in db.LOPs
                         select lop;
                foreach (var x in ds)
                {
                    LOP lop = new LOP();
                    {
                        lop.MALOP = x.MALOP;
                        lop.TENLOP = x.TENLOP;
                        lst.Add(lop);
                    }
                }
            }
            return lst;
        }

        // Lấy ds lớp theo năm học
        public static List<LOP> LayLopTheoNamHoc(string maNamHoc)
        {
            List<LOP> lst = new List<LOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.LOPs.Where(a => a.KHOILOP.MANAM == maNamHoc).ToList();
                foreach (var x in ds)
                {
                    LOP lop = new LOP();
                    {
                        lop.MALOP = x.MALOP;
                        lop.TENLOP = x.TENLOP;
                        lop.MAKHOI = x.MAKHOI;
                        lop.SISO = x.SISO;
                        lst.Add(lop);
                    }
                }
            }
            return lst;
        }

        // Lấy ds lớp theo Khối
        public static List<LOP> LayLopTheoKhoi(string maKhoi)
        {
            List<LOP> lst = new List<LOP>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.LOPs.Where(a => a.MAKHOI == maKhoi).ToList();
                foreach (var x in ds)
                {
                    LOP lop = new LOP();
                    {
                        lop.MALOP = x.MALOP;
                        lop.TENLOP = x.TENLOP;
                        lst.Add(lop);
                    }
                }
            }
            return lst;
        }

        // Lấy sĩ số lớp
        public static int LaySiSoLop(string maLop)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                LOP lop = db.LOPs.Where(a => a.MALOP == maLop).FirstOrDefault();
                if (lop != null)
                    return lop.SISO.Value;
                else
                    return 0;
            }
        }
    }
}
