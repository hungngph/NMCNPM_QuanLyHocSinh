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
                    CurrentUser.Parse(user.MALND, user.TENDANGNHAP, user.LOAINGUOIDUNG.TENLOAIND);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static string LayTenNguoiDung(string tendangnhap) {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                if (db.NGUOIDUNGs.Any(u => u.TENDANGNHAP == tendangnhap))
                {
                    return db.NGUOIDUNGs.First(u => u.TENDANGNHAP == tendangnhap).TENNGUOIDUNG;
                }
                return "Noname";
            }
        }
        public static List<NGUOIDUNG> LayTatCaNguoiDung()
        {
            List<NGUOIDUNG> lst = new List<NGUOIDUNG>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.NGUOIDUNGs.ToList();
                foreach (var x in ds)
                {
                    NGUOIDUNG ngd = new NGUOIDUNG();
                    {
                        ngd.MAND = x.MAND;
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
    }
}
