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

        public string DoPhanGiai { get; set; }

        public string TiLeKhungHinh { get; set; }

        public string TanSoQuet { get; set; }
        public string LoaiManHinh { get; set; }
        public Manhinh()   { }
        
        public Manhinh(
            int id, string maSP, string loaiSP, string tenSP, decimal gia, double congSuat, double trongLuong,
            string kichThuoc, string mau, string tamNen, string doPhanGiai, string tiLeKhungHinh, string tanSoQuet, string loaiManHinh
        ) : base(id, maSP, loaiSP, tenSP, gia, congSuat, trongLuong, kichThuoc, mau)
        {
            TamNen = tamNen;
            DoPhanGiai = doPhanGiai;
            TiLeKhungHinh = tiLeKhungHinh;
            TanSoQuet = tanSoQuet;
            LoaiManHinh = loaiManHinh;
        }



    }
}

