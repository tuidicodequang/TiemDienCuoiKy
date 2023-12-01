using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TiemDien
{
    public partial class FHoaDon : Form
    {
       
        public static List<HoaDon> dsHoaDon = XuLyEntity<HoaDon>.LoadList("HoaDon.xml");
        public FHoaDon()
        {
            InitializeComponent();
            LoadBangHoaDon(dsHoaDon);
            textTimNV.TextChanged += textTimNV_TextChanged;
        }
        private Form currentFormChild;

        private void OpenchildForm(Form childFrom)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            panel1.Controls.Add(childFrom);
            panel1.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }


        private void LoadBangHoaDon(List<HoaDon> dshoadon)
        {
            if (!dshoadon.Any())
            {
                MessageBox.Show("Danh sách hóa đơn trống");
                return;
            }

            dgvHoaDon.Columns.Clear();

            // Thêm cột vào DataGridView
            dgvHoaDon.Columns.Add("MaHD", "Mã Hóa Đơn");
            dgvHoaDon.Columns.Add("MaKH", "Mã Khách Hàng");
            dgvHoaDon.Columns.Add("TenKH", "Tên Khách Hàng");
            dgvHoaDon.Columns.Add("NgayGiaoDich", "Ngày Giao Dich");
            dgvHoaDon.Columns.Add("ThanhTien", "Thành Tiền");

            foreach (HoaDon hoadon in dshoadon)
            {
                dgvHoaDon.Rows.Add(
                    hoadon.MaHD,
                    hoadon.MaKH,
                    hoadon.TenKH,
                    hoadon.NgayGiaoDich,
                    hoadon.ThanhTien
                );
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            FThemHoaDon f = new FThemHoaDon();
            OpenchildForm(f);
        }

        private void textTimNV_TextChanged(object sender, EventArgs e)
        {
            string keyword = textTimNV.Text.Trim().ToUpper(); // Chuyển đổi keyword sang chữ in hoa để tìm kiếm không phân biệt hoa thường

            var filteredHoaDons = dsHoaDon.Where(hd => hd.MaHD.ToUpper().Contains(keyword) || hd.TenKH.ToUpper().Contains(keyword)).ToList();

            // Cập nhật DataGridView với danh sách đã lọc
            LoadBangHoaDon(filteredHoaDons);
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FHoaDon_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                FDetail f = new FDetail();
                string selectedMaHD = dgvHoaDon.SelectedRows[0].Cells["MaHD"].Value.ToString();
                f.hoaDonChitiet = dsHoaDon.Find(hd => hd.MaHD == selectedMaHD);
                f.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.");
            }
        }

        private void dgvHoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvHoaDon.HitTest(e.X, e.Y);
                dgvHoaDon.Rows[hti.RowIndex].Selected = true;
                butchitiet.Enabled = true;

            }
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            dsHoaDon = XuLyEntity<HoaDon>.LoadList("HoaDon.xml");
            LoadBangHoaDon(dsHoaDon);
        }
    }
}
