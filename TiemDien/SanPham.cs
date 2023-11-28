using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TiemDien;

namespace TiemDien
{
    [XmlInclude(typeof(Manhinh))]
    [XmlInclude(typeof(Loa))]
    [XmlInclude(typeof(MayIn))]
    public abstract class SanPham : ITietKiemDien
    {
        public int ID { get; set; }
        public string MaSP { get; set; }

        public string LoaiSP {  get; set; }
        public string TenSP { get; set; }

        public decimal Gia { get; set; }

        public double CongSuat { get; set; }

        public double TrongLuong { get; set; }

        public string KichThuoc { get; set; }

        public string Mau {  get; set; }
       // public SanPham() { }

        public abstract double LuongDienTietKiem();
    }
}
