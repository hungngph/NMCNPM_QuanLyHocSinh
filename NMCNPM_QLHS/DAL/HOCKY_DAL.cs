using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class HOCKY_DAL
    {
        // Lấy tất cả các học kỳ
        public static List<HOCKY> LayTatCaHocKy()
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                List<HOCKY> lst = db.HOCKies.ToList();
                return lst;
            }
        }
    }
}
