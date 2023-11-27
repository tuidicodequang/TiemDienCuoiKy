using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiemDien;

namespace TiemDien
{
    public abstract class SanPham : ITietKiemDien
    {
        public int id { get; set; }
        public string masp { get; set; }

        public string loaisp {  get; set; }
        public string tensp { get; set; }

        public decimal gia { get; set; }

        public double congsuat { get; set; }

        public double trongluong { get; set; }

        public string kichthuoc { get; set; }

        public string Mau {  get; set; }
        public SanPham() { }

        public SanPham(int id, string masp, string loaisp,string tensp, decimal gia, double congsuat, double trongluong, string kichthuoc,string Mau )
        {
            this.id = id;
            this.masp = masp;
            this.loaisp = loaisp;
            this.tensp = tensp;
            this.gia = gia;
            this.congsuat = congsuat;
            this.trongluong = trongluong;
            this.kichthuoc = kichthuoc;
            this.Mau = Mau;
        }

        
        public abstract double LuongDienTietKiem();
    }
}
