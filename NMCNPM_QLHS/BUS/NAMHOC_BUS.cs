using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class NAMHOC_BUS
    {
        // Lấy tất cả các năm học
        public static List<NAMHOC> LayTatCaNamHoc()
        {
            return NAMHOC_DAL.LayTatCaNamHoc();
        }

        // Lấy năm học theo Mã HS
        public static DataTable LayNamHocTheoMaHS(string maHS)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MANAMHOC", typeof(string));
            dt.Columns.Add("TENNAMHOC", typeof(string));

            SQL_QLHSDataContext db = new SQL_QLHSDataContext();
            var lst = NAMHOC_DAL.LayNamHocTheoMaHS(maHS);
            foreach (var i in lst)
            {
                DataRow r = dt.NewRow();
                if (i.MANAMHOC != null)
                    r["MANAMHOC"] = i.MANAMHOC;
                if (i.TENNAMHOC != null)
                    r["TENNAMHOC"] = i.TENNAMHOC;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }
    }
}
