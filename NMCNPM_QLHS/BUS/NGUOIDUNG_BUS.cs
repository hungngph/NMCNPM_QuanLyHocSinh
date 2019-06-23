using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMCNPM_QLHS.DAL;

namespace NMCNPM_QLHS.BUS
{
    class NGUOIDUNG_BUS
    {
        public static bool KiemTraNguoiDung(string tendangnhap) {
            return NGUOIDUNG_DAL.KiemTraNguoiDung(tendangnhap);
        }
    }
}
