using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCNPM_QLHS
{
    class CurrentUser
    {
        private static string code = "";
        private static string name = "";
        private static string quyen = "";

        public static string Code { get; set; }

        public static string Name { get; set; }

        public static string Quyen { get; set; }

        public static void Parse(string code, string name, string quyen)
        {
            Code = code;
            Name = name;
            Quyen = quyen;
        }
    }
}
