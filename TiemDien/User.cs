using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiemDien;

namespace TiemDien
{
    public abstract class User:IGiamGia
    {
        public string Ma { get; set; }

        public string Hoten { get; set; }

        public string DiaChi { get; set; }

        public string NgaySinh { get; set; }

        public string GioiTinh { get; set; }

        public User() { }

        public User(string Ma, string Hoten, string DiaChi,string NgaySinh,string GioiTinh)
        {
            this.Ma = Ma;
            this.Hoten = Hoten;
            this.DiaChi = DiaChi;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
        }
        public abstract  double PhanTramGiamGia();
      
    }
}
