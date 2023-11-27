using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TiemDien
{
    public partial class FthemNhanVien : Form
    {
        public FthemNhanVien()
        {
            InitializeComponent();
        }

        

        private void FthemNhanVien_Load(object sender, EventArgs e)
        {
            // You can add any initialization logic here.
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = CreateNhanVienFromInput();

            if (nhanVien != null)
            {
                FNhanVien.dsNhanVien.Add(nhanVien);
                SaveListNhanVien(FNhanVien.dsNhanVien);
            }
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
            string prefix = maNV.Substring(0, 2);

            NhanVien nhanVien = null;

            switch (prefix)
            {
                case "KT":
                    nhanVien = new NhanVienKT();
                    break;

                case "BH":
                    nhanVien = new NhanVienSale();
                    break;

                case "QL":
                    nhanVien = new NhanVienQL();
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
            }

            return nhanVien;
        }

        public static void SaveListNhanVien(List<NhanVien> employees)
        {
            string file = "NhanVien.xml";

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<NhanVien>), new XmlRootAttribute("ArrayOfNhanVien"));

                using (TextWriter writer = new StreamWriter(file))
                {
                    serializer.Serialize(writer, employees);
                }

                MessageBox.Show($"Updated information saved to XML file '{file}'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error serializing to XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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

                Console.WriteLine($"XML file '{file}' has been deserialized.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing from XML: {ex.Message}");
            }

            return dsNhanVien;



        }


        static void SerializeToXml<T>(string fileName, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, obj);
            }

            MessageBox.Show($"XML file '{fileName}' has been created.");
        }

        private void ButtonLuu_Click_1(object sender, EventArgs e)
        {
            NhanVien nhanVien = CreateNhanVienFromInput();

            if (nhanVien != null)
            {
                FNhanVien.dsNhanVien.Add(nhanVien);
                SaveListNhanVien(FNhanVien.dsNhanVien);
            }
        }
    }
}