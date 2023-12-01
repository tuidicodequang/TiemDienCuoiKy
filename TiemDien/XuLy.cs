using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace TiemDien
{
    public class XuLyEntity<T>
    {
        public static List<T> LoadList(string fileName)
        {
            List<T> dsEntities = new List<T>();

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute($"DanhSach{typeof(T).Name}"));

                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    dsEntities = (List<T>)serializer.Deserialize(fs);
                }

                Console.WriteLine($"File XML '{fileName}' đã được deserialized.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi deserialized từ XML: {ex.Message}");
            }

            return dsEntities;
        }

        public static void SaveList(List<T> entities, string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute($"DanhSach{typeof(T).Name}"));

                using (TextWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, entities);
                }

                MessageBox.Show($"Thông tin đã được cập nhật vào tập tin XML '{fileName}'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi serialize thành XML: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void XoaEntity(List<T> dsEntities, Func<T, bool> predicate,string filename)
        {
            Predicate<T> predicateDelegate = new Predicate<T>(predicate);

            // Sử dụng hàm FindIndex để tìm chỉ số của phần tử thỏa mãn điều kiện
            int index = dsEntities.FindIndex(predicateDelegate);

            if (index != -1)
            {
                dsEntities.RemoveAt(index);
                SaveList(dsEntities, filename);
            }
        }
        public static T TimKiem(List<T> dsEntities, Func<T, bool> predicate)
        {
            Predicate<T> predicateDelegate = new Predicate<T>(predicate);
            return dsEntities.Find(predicateDelegate);
        }
        public static int DemSoLuong(List<T> dsEntities)
        {
            return dsEntities.Count;
        }
    }
}
