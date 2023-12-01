using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiemDien
{
    public partial class FUpdateKH : Form
    {
        public KhachHang KhachHangUpdate {  get; set; }
        public FUpdateKH()
        {
            InitializeComponent();
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin khách hàng này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                KhachHangUpdate.Ma = textMAKH.Text;
                KhachHangUpdate.Hoten = textHoTen.Text;
                KhachHangUpdate.NgaySinh = textNgaySinh.Text;
                KhachHangUpdate.GioiTinh = TickNam.Checked ? TickNam.Text : TickNu.Text;
                KhachHangUpdate.LoaiKhachHang= textLoaiKH.Text;
                KhachHangUpdate.DiaChi = txtDiaChiNV.Text;

                // Sử dụng XuLyEntity để lưu danh sách
                XuLyEntity<KhachHang>.SaveList(FKhachHang.dsKhachHang, "KhachHang.xml");

            }
        }

        private void FUpdateKH_Load(object sender, EventArgs e)
        {
            if (KhachHangUpdate != null)
            {
                textMAKH.Text = KhachHangUpdate.Ma.ToString();
                textHoTen.Text = KhachHangUpdate.Hoten.ToString();
               

                try
                {
                    DateTime ngaySinh = DateTime.ParseExact(KhachHangUpdate.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    textNgaySinh.Value = ngaySinh;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                (TickNam.Checked, TickNu.Checked) = (KhachHangUpdate.GioiTinh == "Nam") ? (true, false) : (false, true);
             
                textSDT.Text = KhachHangUpdate.SĐT.ToString();
                txtDiaChiNV.Text = KhachHangUpdate.DiaChi.ToString();
                textLoaiKH.Text=KhachHangUpdate.LoaiKhachHang.ToString();  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
