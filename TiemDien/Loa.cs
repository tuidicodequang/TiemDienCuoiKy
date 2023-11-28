using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TiemDien
{
    
    public class Loa : SanPham
    {
        public string ChatLieu { get; set; }
        public string TanSo { get; set; }
        public string KetNoi { get; set; }
        
        public override double LuongDienTietKiem()
        {
            if (TanSo == "1000hz") { return 0.07; }
            else return 0.1;
        }

    }
}