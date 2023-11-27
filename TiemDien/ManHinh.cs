using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TiemDien
{
    public class Manhinh : SanPham
    {

        public string tamnen { get; set; }
        public double kichthuoc { get; set; }

        public string dophangiai { get; set; }

        public string tilekhunghinh { get; set; }

        public string tansoquet { get; set; }
        public string LoaiManHinh { get; set; }

      
      
        public override double LuongDienTietKiem()
        {
            if (tamnen == "oled")
            {
                return 0.02;
            }
            else
                return 0.1;
        }
    }
}

