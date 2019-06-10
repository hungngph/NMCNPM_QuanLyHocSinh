using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class LOP_BUS
    {
        // Lấy tất cả các lớp
        public static List<LOP> LayTatCaLop()
        {
            return LOP_DAL.LayTatCaLop();
        }

        // Lấy ds lớp theo năm học
        public static List<LOP> LayLopTheoNamHoc(string maNamHoc)
        {
            return LOP_DAL.LayLopTheoNamHoc(maNamHoc);
        }

        // Lấy ds lớp theo Khối
        public static List<LOP> LayLopTheoKhoi(string maKhoi)
        {
            return LOP_DAL.LayLopTheoKhoi(maKhoi);
        }
    }
}
