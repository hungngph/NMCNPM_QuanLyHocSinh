using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class BAOCAO_BUS
    {
        public static List<HOCSINH> inDanhSachLop(string tenLop)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                List<HOCSINH> lst = (from qth in db.QUATRINHHOCs
                                     from hs in db.HOCSINHs
                                     where qth.MAHS == hs.MAHS && qth.LOP.TENLOP == tenLop
                                     select hs).ToList();
                return lst;
            }
        }
    }
}
