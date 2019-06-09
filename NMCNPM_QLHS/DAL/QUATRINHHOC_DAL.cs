using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class QUATRINHHOC_DAL
    {
        public static void LuuPhanLopHS(string maHS, string maLop, string maNamHoc)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_ThemQTH(maHS, maLop, maNamHoc);
            }
        }
    }
}
