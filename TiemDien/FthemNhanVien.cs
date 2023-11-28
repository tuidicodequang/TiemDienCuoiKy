using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TiemDien
{
    public partial class FthemNhanVien : Form
    {
        // Thay đổi để sử dụng XuLyEntity cho NhanVien
        public static List<NhanVien> dsNhanVien = XuLyEntity<NhanVien>.LoadList("NhanVien.xml");

        public FthemNhanVien()
        {
            InitializeComponent();
        }

        private NhanVien CreateNhanVienFromInput()
        {
            string maNV = textMANV.Text;
            string hoTen = textHoTen.Text;
            string gioiTinh = TickNam.Checked ? TickNam.Text : TickNu.Text;
            string ngaySinh = textNgaySinh.Text;
            string diaChi = txtDiaChiNV.Text;
            string user = textUser.Text;
            string password = textPassword.Text;
            double HeSoluong = (double)numericUpDown1.Value;
            string prefix = maNV.Substring(0, 2);

            NhanVien nhanVien = null;

            switch (prefix)
            {
                case "KT":
                    nhanVien = new NhanVienKT();
                    nhanVien.ChucVu = "Ky thuat";
                    break;

                case "BH":
                    nhanVien = new NhanVienSale();
                    nhanVien.ChucVu = "Ban Hang";
                    break;

                case "QL":
                    nhanVien = new NhanVienQL();
                    nhanVien.ChucVu = "Quan Ly";
                    break;

                default:
                    MessageBox.Show("Thêm nhân viên thất bại!");
                    break;
            }

            if (nhanVien != null)
            {
                nhanVien.Ma = maNV;
                nhanVien.Hoten = hoTen;
                nhanVien.GioiTinh = gioiTinh;
                nhanVien.NgaySinh = ngaySinh;
                nhanVien.DiaChi = diaChi;
                nhanVien.Username = user;
                nhanVien.MatKhau = password;
                nhanVien.HeSoLuong = HeSoluong;
            }

            return nhanVien;
        }

        private void ButtonLuu_Click_1(object sender, EventArgs e)
        {
            NhanVien nhanVien = CreateNhanVienFromInput();

            if (nhanVien != null)
            {
                // Thêm đối tượng nhân viên mới vào danh sách trước khi lưu
                dsNhanVien.Add(nhanVien);
                XuLyEntity<NhanVien>.SaveList(dsNhanVien, "NhanVien.xml");
                MessageBox.Show("Thêm nhân viên thành công.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
