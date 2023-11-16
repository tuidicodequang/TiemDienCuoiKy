using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiemDien
{
    public class Loa : SanPham
    {
        public string ChatLieu { get; set; }
        public string TanSo { get; set; }
        public string KetNoi { get; set; }
        public bool ChongNhieuTu { get; set; }
        public bool DieuChinhAmThanh { get; set; }
        public override void TinhNang()
        {
            bool ChongNhieuTu;
            bool DieuChinhAmThanh;
        }
        public override double LuongDienTietKiem()
        {
            if (ChongNhieuTu == true) { return 0.07; }
            else return 0.1;
        }

    }
}