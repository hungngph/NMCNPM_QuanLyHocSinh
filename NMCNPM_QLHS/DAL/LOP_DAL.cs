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
            //using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            //{
            //    List<LOP> lst = db.LOPs.ToList();
            //    return lst;
            //}
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

        // Lấy lớp theo Khối
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
    }
}
