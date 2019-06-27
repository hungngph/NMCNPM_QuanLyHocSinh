using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NGUOIDUNG_DAL
    {
        public static bool KiemTraTonTai(string tendangnhap)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap))
                    return true;
                return false;
            }
        }
        public static bool DangNhap(string tendangnhap, string matkhau)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {

                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap && u.MATKHAU == matkhau))
                {
                    NGUOIDUNG user = db.NGUOIDUNGs.FirstOrDefault(u => u.TENDANGNHAP == tendangnhap && u.MATKHAU == matkhau);
                    CurrentUser.Code = user.MAND;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string LayTenNguoiDung(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).TENNGUOIDUNG;
                }
                return "unknown";
            }
        }
        public static List<NGUOIDUNG> LayTatCaNguoiDung()
        {
            List<NGUOIDUNG> lst = new List<NGUOIDUNG>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = from ngd in db.NGUOIDUNGs
                         select new
                         {
                             MANGUOIDUNG = ngd.MAND,
                             TENDANGNHAP = ngd.TENDANGNHAP,
                             TENNGUOIDUNG = ngd.TENNGUOIDUNG,
                             MATKHAU = ngd.MATKHAU,
                             LOAINGUOIDUNG = ngd.LOAINGUOIDUNG
                         };
                foreach (var x in ds)
                {
                    NGUOIDUNG ngd = new NGUOIDUNG();
                    {
                        ngd.MAND = x.MANGUOIDUNG;
                        ngd.TENDANGNHAP = x.TENDANGNHAP;
                        ngd.TENNGUOIDUNG = x.TENNGUOIDUNG;
                        ngd.MATKHAU = x.MATKHAU;
                        ngd.LOAINGUOIDUNG = x.LOAINGUOIDUNG;
                        lst.Add(ngd);
                    }
                }
            }
            return lst;
        }
        public static string LayTenDangNhap(string code) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).TENDANGNHAP;
                }
                return "unknown";
            }
        }
        public static string LayQuyen(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).LOAINGUOIDUNG.TENLOAIND;
                }
                return "unknown";
            }
        }
        public static string LayMatKhau(string code)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.MAND == code))
                {
                    return db.NGUOIDUNGs.First(u => u.MAND == code).MATKHAU;
                }
                return "unknown";
            }
        }
    }
}
