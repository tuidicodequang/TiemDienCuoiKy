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

        public string tansoquet { get; set; } //12
        public string LoaiManHinh { get; set; }

        public bool Co3d { get; set; }
        public bool Baovemat { get; set; }
        public bool Chongtroi { get; set; }
        public override void TinhNang()
        {
            bool Co3d;
            bool Baovemat;
            bool Chongtroi;

        }
        public override double LuongDienTietKiem()
        {
            if (Co3d == true)
            {
                return 0.02;
            }
            else
                return 0.1;
        }
    }
}

