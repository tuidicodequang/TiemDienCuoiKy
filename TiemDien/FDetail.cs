using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TiemDien
{
    public partial class FDetail : Form
    {
         public HoaDon hoaDonChitiet { get; set; }
        public static List<KhachHang> dsKhachHang = XuLyEntity<KhachHang>.LoadList("KhachHang.xml");
        public FDetail()
        {
            InitializeComponent();
         
        }

        private void FDetail_Load(object sender, EventArgs e)
        {
           
            if (hoaDonChitiet != null)
            { 
                KhachHang khachHangTimDuoc = dsKhachHang.Find(kh => kh.Ma == hoaDonChitiet.MaKH);
                if(khachHangTimDuoc != null)
                {
                    textMaKH.Text = hoaDonChitiet.MaKH.ToString();
                    textTenKH.Text = khachHangTimDuoc.Hoten;
                    textSDT.Text = khachHangTimDuoc.SĐT;
                    textDiaChi.Text = khachHangTimDuoc.DiaChi;
                    textMaHD.Text= hoaDonChitiet.MaHD.ToString();
                }
                
                dgvSanPham.Columns.Clear();

                // Thêm cột vào DataGridView
                dgvSanPham.Columns.Add("MaSP", "Mã Sản Phẩm");
                dgvSanPham.Columns.Add("TenSP", "Tên Sản Phẩm");
                dgvSanPham.Columns.Add("SoLuong", "Số Lượng");
                dgvSanPham.Columns.Add("DonGia", "Đơn Giá");
                dgvSanPham.Columns.Add("TongTien", "Tổng Tiền");

                foreach (ItemHoadon itemHoaDon in hoaDonChitiet.DanhSachSanPham)
                {
                    dgvSanPham.Rows.Add(
                        itemHoaDon.MaSP,
                        itemHoaDon.TenSP,
                        itemHoaDon.SoLuong,
                        itemHoaDon.DonGia,
                       itemHoaDon.SoLuong* itemHoaDon.DonGia

                    );
                
                }
                textThanhTien.Text = hoaDonChitiet.ThanhTien.ToString();

            }
        }

        private void dgvSanPham_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
