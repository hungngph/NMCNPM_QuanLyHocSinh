using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.DAL
{
    class HOCTAP_DAL
    {
        public static void SuaDiem(string maHS, string maMon, string mahocky, string maNamHoc, float diemMieng, float diem15P, float diem1Tiet, float diemThi)
        {
            using (SQL_QLHSDataContext db = new SQL_QLHSDataContext())
            {
                db.sp_SuaDiem(maHS, maMon, mahocky, maNamHoc, diemMieng, diem15P, diem1Tiet, diemThi);
            }
        }
    }
}
