using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemDien
{
    public class MayIn : SanPham
    {
        public string Dophangiai { get; set; }

        public string Tocdoin { get; set; }

        public string BoNho { get; set; }

        public string KhoGiay { get; set; }

        public string KetNoi { get; set; }
        public bool InHaiMat { get; set; }

        public override void TinhNang()
        {
            bool InHaiMat;
        }
        public override double LuongDienTietKiem()
        {
            if (InHaiMat == true)
            {
                return 0.03;
            }
            else
                return 0.1;
        }

    }
}
