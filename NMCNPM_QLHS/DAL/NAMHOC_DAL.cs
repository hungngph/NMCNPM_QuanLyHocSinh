using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class NAMHOC_DAL
    {
        // Lấy tất cả các năm học
        public static List<NAMHOC> LayTatCaNamHoc()
        {
            List<NAMHOC> lst = new List<NAMHOC>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.NAMHOCs.ToList();
                foreach (var x in ds)
                {
                    NAMHOC namHoc = new NAMHOC();
                    {
                        namHoc.MANAMHOC = x.MANAMHOC;
                        namHoc.TENNAMHOC = x.TENNAMHOC;
                        lst.Add(namHoc);
                    }
                }
            }
            return lst;
        }

        // Lấy năm học theo Mã HS
        public static List<NAMHOC> LayNamHocTheoMaHS(string maHS)
        {
            List<NAMHOC> lst = new List<NAMHOC>();

            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayNamHocTheoMaHS(maHS);
                foreach (var x in ds)
                {
                    NAMHOC namHoc = new NAMHOC();
                    {
                        namHoc.MANAMHOC = x.MANAMHOC;
                        namHoc.TENNAMHOC = x.TENNAMHOC;
                        lst.Add(namHoc);
                    }
                }
            }
            return lst;
        }

        // Lấy năm học tiếp theo
        public static List<NAMHOC> LayNamHocTiepTheo(string maNamHocCu)
        {
            List<NAMHOC> namHoc = new List<NAMHOC>();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                NAMHOC namHocCu = db.NAMHOCs.Where(a => a.MANAMHOC == maNamHocCu).FirstOrDefault();
                int nam = namHocCu.NAM1.Value;
                namHoc = db.NAMHOCs.Where(a => a.NAM1 == nam + 1).ToList();
            }
            return namHoc;
        }

        // Lấy năm học hiện tại
        public static NAMHOC LayNamHocHienTai()
        {
            NAMHOC namHoc = new NAMHOC();
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                var ds = db.sp_LayNamHocHienTai();
                foreach (var x in ds)
                {
                        namHoc.MANAMHOC = x.MANAMHOC;
                        namHoc.TENNAMHOC = x.TENNAMHOC;
                }
            }
            return namHoc;
        }
    }
}
