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
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                List<MONHOC> lst = db.MONHOCs.ToList();
                return lst;
            }
        }
    }
}
