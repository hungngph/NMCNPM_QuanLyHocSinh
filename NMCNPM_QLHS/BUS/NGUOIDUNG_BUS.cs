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
        public static string LayTenDangNhap(string code)
        {
            return NGUOIDUNG_DAL.LayTenDangNhap(code);
        }
        public static string LayTenQuyen(string code)
        {
            return NGUOIDUNG_DAL.LayTenQuyen(code);
        }
        public static string LayMaQuyen(string code) {
            return NGUOIDUNG_DAL.LayMaQuyen(code);
        }
        public static bool DoiMatKhau(string code, string matkhaucu, string matkhaumoi) {
            if (NGUOIDUNG_DAL.LayMatKhau(code) != matkhaucu)
                return false;
            else  
                return NGUOIDUNG_DAL.DoiMatKhau(code, matkhaumoi);
        }
        public static string LayMatKhau(string code) {
            return NGUOIDUNG_DAL.LayMatKhau(code);
        }
        public static bool ThemNguoiDung(string taikhoan, string ten, string loaiquyen)
        {
            return NGUOIDUNG_DAL.ThemNguoiDung(taikhoan, ten, loaiquyen);
        }
        public static bool XoaNguoiDung(string code)
        {
            return NGUOIDUNG_DAL.XoaNguoiDung(code);
        }
    }
}
