using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TiemDien
{
    
    public class Manhinh : SanPham
    {

        public string TamNen { get; set; }
        public double KichThuocManHinh { get; set; }

        public string DoPhanGiai { get; set; }

        public string TiLeKhungHinh { get; set; }

        public string TanSoQuet { get; set; }
        public string LoaiManHinh { get; set; }

      
      
        public override double LuongDienTietKiem()
        {
            if (TamNen == "oled")
            {
                return 0.02;
            }
            else
                return 0.1;
        }
    }
}

