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

namespace TiemDien
{
    public partial class FUpdateNhanVien : Form
    {
        public FUpdateNhanVien()
        {
            InitializeComponent();
        }

        

        

        private void iconButton2_Click(object sender, EventArgs e)
        {
         
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
