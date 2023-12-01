using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Linq;

namespace TiemDien
{
    public partial class FNhanVien : Form
    {
        // Thay đổi để sử dụng XuLyEntity cho NhanVien
          public static List<NhanVien> dsNhanVien = XuLyEntity<NhanVien>.LoadList("NhanVien.xml");
    

        public FNhanVien()
        {
            InitializeComponent();
            LoadBangNhanVien(dsNhanVien);
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
            FthemNhanVien f = new FthemNhanVien();
            OpenchildForm(f);
        }

        private void LoadBangNhanVien(List<NhanVien> danhsachnhanvien)
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

                foreach (NhanVien nhanVien in danhsachnhanvien)
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

          private void btnUpdate_Click(object sender, EventArgs e)
           {
               if (dgvNV.SelectedRows.Count > 0)
               {
                   FUpdateNhanVien fUpdateKhachHang = new FUpdateNhanVien();
                   int selectedRowIndex = dgvNV.SelectedRows[0].Index;
                   fUpdateKhachHang.nhanvienUpdate = dsNhanVien[selectedRowIndex];
                   OpenchildForm(fUpdateKhachHang);
               }
               else
               {
                   MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật.");
               }
           }

           private void dgvNV_MouseDoubleClick(object sender, MouseEventArgs e)
           {
               if (e.Button == System.Windows.Forms.MouseButtons.Left)
               {
                   var hti = dgvNV.HitTest(e.X, e.Y);
                   dgvNV.Rows[hti.RowIndex].Selected = true;
                   btnDelete.Enabled = true;
                   btnUpdate.Enabled = true;
               }
           }

           private void btnDelete_Click(object sender, EventArgs e)
           {
               if (dgvNV.SelectedRows.Count > 0)
               {
                   string selectedMaNV = dgvNV.SelectedRows[0].Cells["MaNV"].Value.ToString();
                   DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                   if (result == DialogResult.Yes)
                   {
                       XoaNhanVien(selectedMaNV);
                       LoadBangNhanVien(dsNhanVien);

                       MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
               }
           }

           public void XoaNhanVien(string MaNV)
           {
               XuLyEntity<NhanVien>.XoaEntity(dsNhanVien, nv => nv.Ma == MaNV,"NhanVien.xml");
           }

           private void iconButton2_Click(object sender, EventArgs e)
           {

           }

           private void button2_Click(object sender, EventArgs e)
           {
             FNhanVien_Load(sender, e);
           }

        private void panel1_SizeChanged(object sender, EventArgs e) { }
        
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textTimNV_TextChanged(object sender, EventArgs e)
        {
            string keyword = textTimNV.Text.Trim().ToUpper(); // Chuyển đổi keyword sang chữ in hoa để tìm kiếm không phân biệt hoa thường

            var filteredNhanViens = dsNhanVien.Where(nv => nv.Ma.ToUpper().Contains(keyword) || nv.Hoten.ToUpper().Contains(keyword)).ToList();

            // Cập nhật DataGridView với danh sách đã lọc
            LoadBangNhanVien(filteredNhanViens);
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            dsNhanVien = XuLyEntity<NhanVien>.LoadList("NhanVien.xml");
            LoadBangNhanVien(dsNhanVien);
        }
    } 
    }

