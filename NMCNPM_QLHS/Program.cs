﻿using NMCNPM_QLHS.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMCNPM_QLHS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmManHinhChinh());
            Application.Run(new frmNhapDiemChung());
            //Application.Run(new frmNhapDiemChiTiet());
            //Application.Run(new frmPhanLop());
        }
    }
}
