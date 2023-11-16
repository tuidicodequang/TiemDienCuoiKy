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
using System.Xml;

namespace TiemDien
{
    public partial class FNhanVien : Form
    {
        public static List<NhanVien> dsNhanVien = LoadListNhanVien();

        public static List<NhanVien> LoadListNhanVien()
        {
            string file = "NhanVien.xml";
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NhanVien>), new XmlRootAttribute("ArrayOfNhanVien"));

                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    dsNhanVien = (List<NhanVien>)serializer.Deserialize(fs);
                }

                Console.WriteLine($"File XML '{file}' đã được deserialized.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi deserialized từ XML: {ex.Message}");
            }

            return dsNhanVien;
        }

        public FNhanVien()
        {
            InitializeComponent();
            LoadBangNhanVien();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi nhấn nút Insert
        }

        private void LoadBangNhanVien()
        {
            dgvNV.Columns.Clear();

            // Thêm cột vào DataGridView
            dgvNV.Columns.Add("MaNV", "Mã NV");
            dgvNV.Columns.Add("Username", "Username");
            dgvNV.Columns.Add("HoTen", "Họ Tên");
            dgvNV.Columns.Add("DiaChi", "Địa Chỉ");
            dgvNV.Columns.Add("NgaySinh", "Ngày Sinh");
            dgvNV.Columns.Add("GioiTinh", "Giới Tính");
            dgvNV.Columns.Add("ChucVu", "Chức Vụ");
            dgvNV.Columns.Add("TinhLuong()", "Lương");

            foreach (NhanVien nhanVien in dsNhanVien)
            {
                dgvNV.Rows.Add(
                    nhanVien.Ma,
                    nhanVien.Username,
                    nhanVien.Hoten,
                    nhanVien.DiaChi,
                    nhanVien.NgaySinh,
                    nhanVien.GioiTinh,
                    nhanVien.ChucVu,
                    nhanVien.TinhLuong()
                );
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}