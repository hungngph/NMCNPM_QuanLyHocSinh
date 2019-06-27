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
        public static bool DangKy(string tendangnhap, string tennguoidung, string matkhau, string loaingdung) {
            return false;
        }
        public static string LayTenNguoiDung(string tendangnhap) {
            return NGUOIDUNG_DAL.LayTenNguoiDung(tendangnhap);
        }
        public static List<NGUOIDUNG> LayTatCaNguoiDung() {
            return NGUOIDUNG_DAL.LayTatCaNguoiDung();
        }
    }
}
