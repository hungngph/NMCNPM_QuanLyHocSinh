using NMCNPM_QLHS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS.BUS
{
    class QUATRINHHOC_BUS
    {
        public static void LuuPhanLopHS(ListView hocSinh, string maLop, string maNamHoc)
        {
            foreach (ListViewItem item in hocSinh.Items)
            {
                QUATRINHHOC_DAL.LuuPhanLopHS(item.SubItems[0].Text.ToString(), maLop, maNamHoc);
            }
        }
    }
}
