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
            string sdt =textSDT.Text;
            string password = textPassword.Text;
            double HeSoluong = (double)numericUpDown1.Value;
            string prefix = maNV.Substring(0, 2);

            NhanVien nhanVien = null;

            switch (prefix)
            {
                case "KT":
                    nhanVien = new NhanVienKT(maNV, hoTen, diaChi, ngaySinh, gioiTinh, sdt, user, password, "Kỹ Thuật", HeSoluong, 0);
                    break;

                case "BH":
                    nhanVien = new NhanVienSale(maNV, hoTen, diaChi, ngaySinh, gioiTinh, sdt, user, password, "Bán Hàng", HeSoluong, 0);
                    break;

                case "QL":
                    nhanVien = new NhanVienQL(maNV, hoTen, diaChi, ngaySinh, gioiTinh, sdt, user, password, "Quản Lý", HeSoluong);
                    break;

                default:
                    MessageBox.Show("Thêm nhân viên thất bại!");
                    break;
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
