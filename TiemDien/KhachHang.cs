using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiemDien
{
    public class KhachHang : User
    {
        public string LoaiKhachHang { get; set; }
        
        public KhachHang() { }
        public KhachHang(string ma, string hoten, string diaChi, string ngaySinh, string gioiTinh, string sdt, string loaiKhachHang)
            : base(ma, hoten, diaChi, ngaySinh, gioiTinh, sdt)
        {
            LoaiKhachHang = loaiKhachHang;
        }
        public override double PhanTramGiamGia()
        {
            if (LoaiKhachHang == "VIP") return 0.1;
            return 0;
        }

    }
}