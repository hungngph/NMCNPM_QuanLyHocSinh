using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NGUOIDUNG_DAL
    {
        public static bool KiemTraTonTai(string tendangnhap) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                int x = 0;
                if (!int.TryParse(db.sp_KiemTraTonTai(tendangnhap).ReturnValue.ToString(), out x))
                    return false;
                return x != 0;
            }
        }
        public static string DangNhap(string tendangnhap, string matkhau) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                string result = "";
                result = db.sp_DangNhap(tendangnhap, matkhau).ReturnValue.ToString();
                return result;
            }
        }
    }
}
