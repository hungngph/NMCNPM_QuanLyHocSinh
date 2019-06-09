using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class MONHOC_BUS
    {
        // Lấy tất cả các môn học
        public static List<MONHOC> LayTatCaMonHoc()
        {
            return MONHOC_DAL.LayTatCaMonHoc();
        }
    }
}
