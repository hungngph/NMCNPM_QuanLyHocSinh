using DevExpress.XtraGrid.Views.Grid;
using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class HOCSINH_BUS
    {
        // Thêm học sinh
        public static void Insert(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string email, string diaChi)
        {
            HOCSINH_DAL.Insert(maHS, hoTen, gioiTinh, ngaySinh, email, diaChi);
        }

        // Sửa học sinh
        public static void Update(string maHS, string hoTen, string gioiTinh, DateTime ngaySinh, string diaChi, string email)
        {
            HOCSINH_DAL.Update(maHS, hoTen, gioiTinh, ngaySinh, diaChi, email);
        }

        // Xóa học sinh
        public static void Delete(string MaHS)
        {
            HOCSINH_DAL.Delete(MaHS);
        }

        // Tạo MaHS
        public static string getMaHS()
        {
            return HOCSINH_DAL.getMaHS();
        }

        // Lấy danh sách tất cả học sinh
        public static List<HOCSINH> LayTatCaHocSinh()
        {
            return HOCSINH_DAL.LayTatCaHocSinh();
        }

        // Lấy danh sách học sinh theo MaLop
        public static List<HOCSINH> LayHocSinhTheoLop(string maLop)
        {
            return HOCSINH_DAL.LayHocSinhTheoLop(maLop);
        }

        // Lấy danh sách Mã HS, họ tên học sinh đã được phân lớp
        public static DataTable LayDSHocSinhDaPhanLop()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAHS", typeof(string));
            dt.Columns.Add("HOTEN", typeof(string));

            SQL_QLHSDataContext db = new SQL_QLHSDataContext();
            var lst = HOCSINH_DAL.LayDSHocSinhDaPhanLop();
            foreach (var i in lst)
            {
                DataRow r = dt.NewRow();
                if (i.MAHS != null)
                    r["MAHS"] = i.MAHS;
                if (i.HOTEN != null)
                    r["HOTEN"] = i.HOTEN;
                dt.Rows.Add(r);
            }
            if (dt.Rows.Count == 0)
                return null;
            return dt;
        }

        // Lấy danh sách học sinh chưa phân lớp
        public static List<HOCSINH> LayHocSinhChuaPhanLop()
        {
            return HOCSINH_DAL.LayHocSinhChuaPhanLop();
        }

        // Tìm kiếm thông tin học sinh theo tên
        public static List<HOCSINH> timTTHSTheoTen(string ten)
        {
            return HOCSINH_DAL.timTTHSTheoTen(ten);
        }
    }
}
