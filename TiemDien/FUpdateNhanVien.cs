using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TiemDien
{
    public partial class FUpdateNhanVien : Form
    {
        public NhanVien nhanvienUpdate { get; set; }
          
        public FUpdateNhanVien()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin khách hàng này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                nhanvienUpdate.Ma = textMANV.Text;
                nhanvienUpdate.Hoten = textHoTen.Text;
                nhanvienUpdate.Username = textUser.Text;
                nhanvienUpdate.NgaySinh = txtNgaySinh.Text;
                nhanvienUpdate.GioiTinh = TickNam.Checked ? TickNam.Text : TickNu.Text;
                nhanvienUpdate.MatKhau = textPassword.Text;
                nhanvienUpdate.DiaChi = txtDiaChiNV.Text;

                // Sử dụng XuLyEntity để lưu danh sách
                XuLyEntity<NhanVien>.SaveList(FNhanVien.dsNhanVien, "NhanVien.xml");
               
            }
        }

        private void FUpdateNhanVien_Load_1(object sender, EventArgs e)
        {
            if (nhanvienUpdate != null)
            {
                textMANV.Text = nhanvienUpdate.Ma.ToString();
                textHoTen.Text = nhanvienUpdate.Hoten.ToString();
                textPassword.Text = nhanvienUpdate.MatKhau;

                try
                {
                    DateTime ngaySinh = DateTime.ParseExact(nhanvienUpdate.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    txtNgaySinh.Value = ngaySinh;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                (TickNam.Checked, TickNu.Checked) = (nhanvienUpdate.GioiTinh == "Nam") ? (true, false) : (false, true);
                textUser.Text = nhanvienUpdate.Username.ToString();
                //textSDT.Text = nhanvienUpdate.SDT.ToString();
                txtDiaChiNV.Text = nhanvienUpdate.DiaChi.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
