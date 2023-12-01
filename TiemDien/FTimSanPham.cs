using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiemDien
{
    public partial class FTimSanPham : Form
    {
        public event Action<string, string, decimal> SanPhamSelected;
        public static List<SanPham> dsSanPham = XuLyEntity<SanPham>.LoadList("SanPham.xml");
        public FTimSanPham()
        {
            InitializeComponent();
        }

        private void dgvSP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FTimSanPham_Load(object sender, EventArgs e)
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
            dgvSanPham.Columns.Add("Mau", "Màu");
            dgvSanPham.Columns.Add("Gia", "Giá");


            foreach (SanPham sanPham in dsSanPham)
            {
                dgvSanPham.Rows.Add(
                    sanPham.ID,
                    sanPham.MaSP,
                    sanPham.LoaiSP,
                    sanPham.TenSP,
                    sanPham.Mau,
                    sanPham.Gia

                );
            }
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSanPham.Rows.Count)
            {
                string selectedMaSP = dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].Value.ToString();
                string selectedTenSP= dgvSanPham.Rows[e.RowIndex].Cells["TenSP"].Value.ToString();
                decimal selectedGiaSP = decimal.Parse(dgvSanPham.Rows[e.RowIndex].Cells["Gia"].Value.ToString());
                SanPhamSelected?.Invoke(selectedMaSP, selectedTenSP, selectedGiaSP);
                this.Close();
            }
        }
    }
}
