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
    public partial class FKhachHang : Form
    {
        public static List<KhachHang> dsKhachHang = XuLyEntity<KhachHang>.LoadList("KhachHang.xml");
        public FKhachHang()
        {
            InitializeComponent();
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FThemKhachHang f = new FThemKhachHang();
            OpenchildForm(f);
        }

        private void FKhachHang_Load(object sender, EventArgs e)
        {
            dsKhachHang = XuLyEntity<KhachHang>.LoadList("KhachHang.xml");
            LoadBangKhachHang(dsKhachHang);
        }
        private void LoadBangKhachHang(List<KhachHang> danhsachkhachhang)
        {
            dgvKH.Columns.Clear();

            // Thêm cột vào DataGridView
            dgvKH.Columns.Add("Ma", "Mã KH");
            dgvKH.Columns.Add("HoTen", "Họ Tên");
            dgvKH.Columns.Add("LoaiKhachHang", "Loại Khách Hàng");
            dgvKH.Columns.Add("GioiTinh", "Giới Tính");
            dgvKH.Columns.Add("NgaySinh", "Ngày Sinh");
            dgvKH.Columns.Add("SĐT", "Số Điện Thoại");
            dgvKH.Columns.Add("DiaChi", "Địa Chỉ");

            foreach (KhachHang Khachhang in danhsachkhachhang)
            {
                dgvKH.Rows.Add(
                    Khachhang.Ma,
                    Khachhang.Hoten,
                    Khachhang.LoaiKhachHang,
                     Khachhang.GioiTinh,
                      Khachhang.NgaySinh,
                      Khachhang.SĐT,
                    Khachhang.DiaChi
                );
            }
        }

     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                FUpdateKH fUpdateKhachHang = new FUpdateKH();
                //int selectedRowIndex = dgvKH.SelectedRows[0].Index;
                string selectedMaKH = dgvKH.SelectedRows[0].Cells["Ma"].Value.ToString();

                fUpdateKhachHang.KhachHangUpdate= dsKhachHang.Find(khachHang => khachHang.Ma == selectedMaKH);
                OpenchildForm(fUpdateKhachHang);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvKH.SelectedRows.Count > 0)
            {
                string selectedMaKH = dgvKH.SelectedRows[0].Cells["Ma"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    XoaKH(selectedMaKH);
                    FKhachHang_Load(sender, e);

                    MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void XoaKH(string MaKH)
        {
            XuLyEntity<KhachHang>.XoaEntity(dsKhachHang, kh => kh.Ma == MaKH, "KhachHang.xml");
        }

       

        private void dgvKH_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvKH.HitTest(e.X, e.Y);
                dgvKH.Rows[hti.RowIndex].Selected = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            FKhachHang_Load(sender, e);
        }

        private void textTimNV_TextChanged(object sender, EventArgs e)
        {
            string keyword = textTimNV.Text.Trim().ToUpper(); // Chuyển đổi keyword sang chữ in hoa để tìm kiếm không phân biệt hoa thường

            var filteredKhachHangs = dsKhachHang.Where(kh => kh.Ma.ToUpper().Contains(keyword) || kh.Hoten.ToUpper().Contains(keyword)).ToList();

            // Cập nhật DataGridView với danh sách đã lọc
            LoadBangKhachHang(filteredKhachHangs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FKhachHang_Load(sender, e);
        }
    }
}
