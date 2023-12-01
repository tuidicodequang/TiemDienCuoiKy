using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TiemDien
{
    public class MayIn : SanPham
    {
        public string Dophangiai { get; set; }

        public string Tocdoin { get; set; }

        public string BoNho { get; set; }

        public string KhoGiay { get; set; }

        public string KetNoi { get; set; }

        public MayIn() { }
        public MayIn(
            int id, string maSP, string loaiSP, string tenSP, decimal gia, double congSuat, double trongLuong,
            string kichThuoc, string mau, string dophangiai, string tocdoin, string boNho, string khoGiay, string ketNoi
        ) : base(id, maSP, loaiSP, tenSP, gia, congSuat, trongLuong, kichThuoc, mau)
        {
            Dophangiai = dophangiai;
            Tocdoin = tocdoin;
            BoNho = boNho;
            KhoGiay = khoGiay;
            KetNoi = ketNoi;
        }

    }
}
