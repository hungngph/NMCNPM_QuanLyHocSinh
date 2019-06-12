using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS.BUS
{
    class THAMSO_BUS
    {
        // Lấy tham số
        public static double LayThamSo(string tenThamSo)
        {
            THAMSO ts = THAMSO_DAL.LayThamSo(tenThamSo);
            if (ts != null)
                return ts.GIATRI.Value;
            else
                return 0;
        }

        // Lưu quy định
        public static void LuuQuyDinh(double tuoiToiThieu, double tuoiToiDa, double siSoToiDa, 
                                    double diemToiThieu, double diemToiDa, double diemDatMon, double diemDatHK)
        {
            THAMSO_DAL.LuuQuyDinh(tuoiToiThieu, tuoiToiDa, siSoToiDa, diemToiThieu, diemToiDa, diemDatMon, diemDatHK);
        }

        public static bool KiemTraTuoi(double tuoiToiThieu, double TuoiToiDa)
        {
            if (tuoiToiThieu >= TuoiToiDa)
                return false;
            else
                return true;
        }

        public static int KiemTraDiem(double diemToiThieu, double diemToiDa, double diemDatMon, double diemDatHK)
        {
            if (diemToiThieu >= diemToiDa)
                return 2;
            else if (diemDatMon > diemToiDa || diemDatMon < diemToiThieu
                    || diemDatHK > diemToiDa || diemDatHK < diemToiThieu)
                return 3;
            else
                return 1;
        }
    }
}
