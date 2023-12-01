using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TiemDien
{
    public partial class FThemKhachHang : Form
    {
        public static List<KhachHang> dsKhachHang = XuLyEntity<KhachHang>.LoadList("KhachHang.xml");
        public FThemKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLuu_Click(object sender, EventArgs e)
        {
            KhachHang Khachhang = CreateKHFromInput();

            if (Khachhang != null)
            {
                dsKhachHang.Add(Khachhang);
                XuLyEntity<KhachHang>.SaveList(dsKhachHang, "KhachHang.xml");
                MessageBox.Show("Thêm nhân viên thành công.");
            }
        }
        private KhachHang CreateKHFromInput()
        {
            string maKH = textMAKH.Text;
            string hoTen = textHoTen.Text;
            string gioiTinh = TickNam.Checked ? TickNam.Text : TickNu.Text;
            string ngaySinh = textNgaySinh.Text;
            string diaChi = txtDiaChiNV.Text;
            string Loai = textLoaiKH.Text;
            string SĐT = textSDT.Text;
            KhachHang Khachhang = new KhachHang(maKH, hoTen, diaChi, ngaySinh, gioiTinh, SĐT, Loai);
            return Khachhang;
        }

      
      
    }
}
