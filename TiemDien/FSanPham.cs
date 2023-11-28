using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TiemDien
{
    public partial class FSanPham : Form
    {
        // Thay đổi để sử dụng XuLyEntity cho SanPham
        public static List<SanPham> dsSanPham = XuLyEntity<SanPham>.LoadList("SanPham.xml");

        public FSanPham()
        {
            InitializeComponent();
            LoadBangSanPham();
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
            FThemSanPham f = new FThemSanPham();
            OpenchildForm(f);
        }

        private void LoadBangSanPham()
        {
            if (!dsSanPham.Any())
            {
                MessageBox.Show("Danh sách sản phẩm trống. Vui lòng thêm sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvSanPham.Columns.Clear();
            
              // Thêm cột vào DataGridView
              dgvSanPham.Columns.Add("ID", "id");
              dgvSanPham.Columns.Add("MaSP", "Mã SP");
              dgvSanPham.Columns.Add("LoaiSP", "Loại SP");
              dgvSanPham.Columns.Add("TenSP", "Tên SP");
              dgvSanPham.Columns.Add("Gia", "Giá");
              dgvSanPham.Columns.Add("CongSuat", "Công Suất");
              dgvSanPham.Columns.Add("TrongLuong", "Trọng Lượng");
              dgvSanPham.Columns.Add("KichThuoc", "Kích Thước");
              dgvSanPham.Columns.Add("Mau", "Màu");

              foreach (SanPham sanPham in dsSanPham)
              {
                  dgvSanPham.Rows.Add(
                      sanPham.ID,
                      sanPham.MaSP,
                      sanPham.LoaiSP,
                      sanPham.TenSP,
                      sanPham.Gia,
                      sanPham.CongSuat,
                      sanPham.TrongLuong,
                      sanPham.KichThuoc,
                      sanPham.Mau
                  );
              } 
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                FUpdateSanPham fUpdateSanPham = new FUpdateSanPham();
                int selectedRowIndex = dgvSanPham.SelectedRows[0].Index;
               // fUpdateSanPham.sanphamUpdate = dsSanPham[selectedRowIndex];
                OpenchildForm(fUpdateSanPham);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật.");
            }
        }

        private void dgvSanPham_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                var hti = dgvSanPham.HitTest(e.X, e.Y);
                dgvSanPham.Rows[hti.RowIndex].Selected = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                string selectedMaSP = dgvSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    XoaSanPham(selectedMaSP);
                    LoadBangSanPham();

                    MessageBox.Show("Sản phẩm đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void XoaSanPham(string MaSP)
        {
            XuLyEntity<SanPham>.XoaEntity(dsSanPham, sp => sp.MaSP == MaSP, "SanPham.xml");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadBangSanPham();
        }
    }
}
