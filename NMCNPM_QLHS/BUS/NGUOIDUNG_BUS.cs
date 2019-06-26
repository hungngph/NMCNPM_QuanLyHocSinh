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
        public static bool KiemTraTenDangNhap(string tendangnhap)
        {
            return NGUOIDUNG_DAL.KiemTraTonTai(tendangnhap);
        }
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            return NGUOIDUNG_DAL.DangNhap(tendangnhap, matkhau);
        }
    }
}
