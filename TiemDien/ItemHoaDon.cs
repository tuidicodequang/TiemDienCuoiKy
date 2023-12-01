using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemDien
{
    public class ItemHoadon
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal DonGia {  get; set; }
        public decimal TongGia()
        {
            return SoLuong * DonGia;
        }

    }
}
