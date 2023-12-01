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

        public Loa() : base(){}
        public Loa(
            int id, string maSP, string loaiSP, string tenSP, decimal gia, double congSuat, double trongLuong,
            string kichThuoc, string mau, string chatLieu, string tanSo, string ketNoi
        ) : base(id, maSP, loaiSP, tenSP, gia, congSuat, trongLuong, kichThuoc, mau)
        {
            ChatLieu = chatLieu;
            TanSo = tanSo;
            KetNoi = ketNoi;
        }

    }
}