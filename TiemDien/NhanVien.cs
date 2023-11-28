using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace TiemDien
{
    [XmlInclude(typeof(NhanVienSale))]
    [XmlInclude(typeof(NhanVienKT))]
    [XmlInclude(typeof(NhanVienQL))]

    public  class NhanVien : User
    {
        public string Username { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; }
        public double HeSoLuong { get; set; }
        protected decimal LuongCB { get; set; } = 5000000.00m; // Lương cơ bản

        public NhanVien() { }
        public NhanVien(string username, string matKhau, string chucVu, double heSoLuong)
        {
            Username = username;
            MatKhau = matKhau;
            ChucVu = chucVu;
            HeSoLuong = heSoLuong;
        }

        public virtual decimal TinhLuong()
        {
            return (decimal)HeSoLuong * LuongCB; // Tính lương dựa trên hệ số lương và lương cơ bản
        }

        public override double PhanTramGiamGia()
        {
            return 0.15;
        }
    }
    //
    public class NhanVienKT : NhanVien
    {
        public int SoNgayTangCa { get; set; }
        public NhanVienKT() { }
        public NhanVienKT(string username, string matKhau, double heSoLuong, int soNgayTangCa)
            : base(username, matKhau, "KT", heSoLuong)
        {
            SoNgayTangCa = soNgayTangCa;
        }

        public override decimal TinhLuong()
        {
            return base.TinhLuong() + (decimal)HeSoLuong * SoNgayTangCa; // Tính tổng lương bao gồm lương cơ bản và tiền thưởng
        }
    }

    public class NhanVienSale : NhanVien
    {
        public int SanPhamBanDuoc { get; set; }
        public NhanVienSale() { }   
        public NhanVienSale(string username, string matKhau, double heSoLuong, int sanPhamBanDuoc)
            : base(username, matKhau, "Sale", heSoLuong)
        {
            SanPhamBanDuoc = sanPhamBanDuoc;
        }

        public override decimal TinhLuong()
        {
            return base.TinhLuong() + SanPhamBanDuoc * 10000; // Tính tổng lương bao gồm lương cơ bản và tiền thưởng
        }
    }

    public class NhanVienQL : NhanVien
    {
        public NhanVienQL() { }
        public NhanVienQL(string username, string matKhau, double heSoLuong)
            : base(username, matKhau, "QL", heSoLuong)
        {
        }

        public override decimal TinhLuong()
        {
            return base.TinhLuong(); // Tính lương dựa trên lương cơ bản
        }
    }
}
