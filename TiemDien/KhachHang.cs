using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiemDien
{
    public class KhachHang : User
    {
        public string LoaiKhachHang { get; set; }
        public void DatHang()
        {
            // Logic đặt hàng  
        }
        public void HuyDatHang()
        {
            // Logic hủy đặt hàng
        }

        public override double PhanTramGiamGia()
        {
            if (LoaiKhachHang == "VIP") return 0.1;
            return 0;
        }

    }
}