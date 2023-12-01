using System.Collections.Generic;
using TiemDien;

public class HoaDon
{
    public string MaHD { get; set; }
    public string MaKH { get; set; }
    public string TenKH { get; set; }
    public string NgayGiaoDich { get; set; }

    public List<ItemHoadon> DanhSachSanPham = new List<ItemHoadon>();
    public decimal ThanhTien { get; set; }
    public HoaDon() { }
    public HoaDon(string MaHD, string MaKH, string TenKH, string NgayGiaoDich, List<ItemHoadon> DanhSachSanPham, decimal ThanhTien)
    {
        this.MaHD = MaHD;
        this.TenKH = TenKH;
        this.MaKH = MaKH;
        this.NgayGiaoDich = NgayGiaoDich;
        this.DanhSachSanPham = DanhSachSanPham;
        this.ThanhTien = ThanhTien;
    }


}