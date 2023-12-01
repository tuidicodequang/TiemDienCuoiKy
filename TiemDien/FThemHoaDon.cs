using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiemDien
{
    public partial class FThemHoaDon : Form
    {
        public static List<HoaDon> dsHoaDon = XuLyEntity<HoaDon>.LoadList("HoaDon.xml");
        public static List<KhachHang> dsKhachHang = XuLyEntity<KhachHang>.LoadList("KhachHang.xml");
        List<ItemHoadon> danhsachSanPhamHoaDon = new List<ItemHoadon>();


        public FThemHoaDon()
        {
            InitializeComponent();
            TaoMaHDRandom();
            LoadBangSanPhamHoaDon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhachHang foundCustomer = XuLyEntity<KhachHang>.TimKiem(dsKhachHang, khachhang => khachhang.SĐT == textSDT.Text);
            if (foundCustomer == null)
                MessageBox.Show("Khong tìm thấy thông tin khách hàng này");
            else
            {
                textTenKH.Text = foundCustomer.Hoten;
                textMaKH.Text = foundCustomer.Ma;

            }
        }

        private void TaoMaHDRandom()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] randomArray = new char[10];

            for (int i = 0; i < 10; i++)
            {
                randomArray[i] = chars[random.Next(chars.Length)];
            }
            textMaHD.Text = new string(randomArray);
        }

        private void buttonTimSP_Click(object sender, EventArgs e)
        {
            FTimSanPham f = new FTimSanPham();
            f.SanPhamSelected += (maSP, tenSP, giaSP) =>
            {
                textMaSP.Text = maSP;
                textTenSP.Text = tenSP;
                textGia.Text = giaSP.ToString();
            };
            f.Show();
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {

            try
            {
                int soluong = (int)numSoLuong.Value;

                if (soluong > 0)
                {
                    string maSP = textMaSP.Text;
                    ItemHoadon existingItem = danhsachSanPhamHoaDon.FirstOrDefault(item => item.MaSP == maSP);

                    if (existingItem != null)
                    {
                        // Sản phẩm đã tồn tại trong danh sách, tăng số lượng
                        existingItem.SoLuong += soluong;
                    }
                    else
                    {
                        // Sản phẩm chưa tồn tại, thêm vào danh sách
                        ItemHoadon newItem = new ItemHoadon
                        {
                            MaSP = textMaSP.Text,
                            TenSP = textTenSP.Text,
                            DonGia = decimal.Parse(textGia.Text),
                            SoLuong = soluong
                        };

                        danhsachSanPhamHoaDon.Add(newItem);
                    }

                    LoadBangSanPhamHoaDon();
                }
                else
                {
                    throw new Exception("Số lượng phải lớn hơn 0.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadBangSanPhamHoaDon()
        {
            decimal ThanhTien = 0;
            decimal TongCong = 0;
            dgvSanPham.Columns.Clear();

            // Thêm cột vào DataGridView
            dgvSanPham.Columns.Add("MaSP", "Mã Sản Phẩm");
            dgvSanPham.Columns.Add("TenSP", "Tên Sản Phẩm");
            dgvSanPham.Columns.Add("SoLuong", "Số Lượng");
            dgvSanPham.Columns.Add("DonGia", "Đơn Giá");
            dgvSanPham.Columns.Add("TongTien", "Tổng Tiền");

            foreach (ItemHoadon itemHoaDon in danhsachSanPhamHoaDon)
            {
                dgvSanPham.Rows.Add(
                    itemHoaDon.MaSP,
                    itemHoaDon.TenSP,
                    itemHoaDon.SoLuong,
                    itemHoaDon.DonGia,
                    itemHoaDon.SoLuong * itemHoaDon.DonGia

                );
                TongCong += itemHoaDon.TongGia();
            }
            textTongCong.Text = TongCong.ToString();
            KhachHang khachHang = dsKhachHang.Find(kh => kh.Ma == textMaKH.Text);
            if (khachHang != null)
            {
                ThanhTien = TongCong - TongCong * (decimal)khachHang.PhanTramGiamGia();
            }
            else
                ThanhTien = TongCong;

            textThanhTien.Text = ThanhTien.ToString();



        }


    

        private void ButtonDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textMaKH.Text))
                {
                    throw new Exception("Vui lòng nhập mã khách hàng.");
                }

                if (danhsachSanPhamHoaDon == null || danhsachSanPhamHoaDon.Count == 0)
                {
                    throw new Exception("Danh sách hóa đơn trống. Vui lòng thêm hóa đơn.");
                }

                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHD = textMaHD.Text;
                hoaDon.MaKH = textMaKH.Text;
                hoaDon.TenKH = textTenKH.Text;
                hoaDon.NgayGiaoDich = textNgayGiaoDich.Text;
                hoaDon.DanhSachSanPham = danhsachSanPhamHoaDon;
                hoaDon.ThanhTien = decimal.Parse(textThanhTien.Text);
                dsHoaDon.Add(hoaDon);
                XuLyEntity<HoaDon>.SaveList(dsHoaDon, "HoaDon.xml");
                MessageBox.Show("Tạo Thành Công Hóa Đơn");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            

        }

        private void textSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
