using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TiemDien
{
    public partial class FThemSanPham : Form
    {
        private FChonTinhNangLoa fChonTinhNangLoa;
        private FChonTinhNangManHinh fChonTinhNangManHinh;
        private FChonTinhNangMayIn fchonTinhNangmayin;
        public static List<SanPham> dsSanPham = XuLyEntity<SanPham>.LoadList("SanPham.xml");
        public FThemSanPham()
        {
            InitializeComponent();

        }
        private SanPham CreateSanPhamFromInput()
        {
            string MaSP = textMaSP.Text;
            string TenSP = textTenSP.Text;
            string LoaiSP = cboLoaiSP.Text;
            string Mau = textMau.Text;
            decimal Gia =decimal.Parse(textGia.Text);
            double CongSuat = double.Parse(textCongSuat.Text);
            double TrongLuong= double.Parse(textTrongLuong.Text);
            string KichThuoc= numDai.Value.ToString()+" X "+numRong.Value+" X "+ numCao.Value;


            switch (LoaiSP)
            {
                case "May In":
                    fchonTinhNangmayin.LoadMayIn();
                    MayIn mayin = new MayIn(dsSanPham.Count() + 1, MaSP, LoaiSP, TenSP,Gia, CongSuat,TrongLuong, KichThuoc,Mau, fchonTinhNangmayin.KhoGiay, fchonTinhNangmayin.Tocdoin,fchonTinhNangmayin.BoNho, fchonTinhNangmayin.Dophangiai,fchonTinhNangmayin.KetNoi );
                    return mayin;

                case "Loa":
                    fChonTinhNangLoa.LoadLoa();
                    Loa loa = new Loa(dsSanPham.Count() + 1,MaSP, LoaiSP,TenSP, Gia,CongSuat,TrongLuong, KichThuoc,Mau,fChonTinhNangLoa.ChatLieu, fChonTinhNangLoa.TanSo,fChonTinhNangLoa.KetNoi);
                    return loa;

                case "Man Hinh":
                    fChonTinhNangManHinh.LoadManHinh();
                    Manhinh manhinh = new Manhinh( dsSanPham.Count() + 1,MaSP, LoaiSP,TenSP, Gia, CongSuat,TrongLuong, KichThuoc, Mau, fChonTinhNangManHinh.TamNen,fChonTinhNangManHinh.DoPhanGiai,fChonTinhNangManHinh.TiLeKhungHinh, fChonTinhNangManHinh.TanSoQuet, fChonTinhNangManHinh.LoaiManHinh);
                    return manhinh;


                default:
                    MessageBox.Show("Thêm sản phẩm thất bại!");
                    return null;
            }

            
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
  

        private void cboLoaiSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            if (cboLoaiSP.Text == "Loa")
            {
                fChonTinhNangLoa = new FChonTinhNangLoa();
                OpenchildForm(fChonTinhNangLoa);
                panelKichThuoc.Visible = true;
                labelkT.Visible = true;
            }
            else if (cboLoaiSP.Text == "Man Hinh")
            {
                fChonTinhNangManHinh = new FChonTinhNangManHinh();
                OpenchildForm(fChonTinhNangManHinh);
                panelKichThuoc.Visible = false;
                labelkT.Visible = false;
            }
            else if (cboLoaiSP.Text == "May In")
            {
                fchonTinhNangmayin = new FChonTinhNangMayIn();
                OpenchildForm(fchonTinhNangmayin);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

            SanPham sanpham = CreateSanPhamFromInput();

            if (sanpham != null)
            {
                // Thêm đối tượng nhân viên mới vào danh sách trước khi lưu
                dsSanPham.Add(sanpham);
                XuLyEntity<SanPham>.SaveList(dsSanPham, "SanPham.xml");
                MessageBox.Show("San Pham da them vao.");
            }
        }

        private void FThemSanPham_Load(object sender, EventArgs e)
        {

        }
    }
    
}
