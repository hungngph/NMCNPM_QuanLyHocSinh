using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class MONHOC_DAL
    {
        // Lấy tất cả các môn học
        public static List<MONHOC> LayTatCaMonHoc()
        {
            List<MONHOC> lst = new List<MONHOC>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.MONHOCs.ToList();
                foreach (var x in ds)
                {
                    MONHOC monHoc = new MONHOC();
                    monHoc.MAMONHOC = x.MAMONHOC;
                    monHoc.TENMONHOC = x.TENMONHOC;
                    lst.Add(monHoc);
                }
            }
            return lst;
        }
    }
}
