using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NGUOIDUNG_DAL
    {
        public static bool KiemTraNguoiDung(string tendangnhap) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int x = 0;
                if (!int.TryParse(db.sp_KiemTraDangNhap(tendangnhap).ReturnValue.ToString(), out x))
                    return false;
                return x != 0;
            }
        }
    }
}
