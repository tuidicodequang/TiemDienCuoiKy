using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiemDien
{
    public class KhacHang : User
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
            if (LoaiKhachHang == "vip") return 0.1;
            return 0;
        }

    }
}