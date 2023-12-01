using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TiemDien
{
    public partial class FUpdateSanPham : Form
    {
        public SanPham sanphamUpdate { get; set; }
        private FChonTinhNangLoa fChonTinhNangLoa;
        private FChonTinhNangManHinh fChonTinhNangManHinh;
        private FChonTinhNangMayIn fchonTinhNangMayin;
        public void SetFormReadOnly()
        {
           this.Enabled = false;
            label6.Text = "Chi tiết sản phẩm";
            iconButton1.    Visible = false;
            btnCancel.Visible = false;
        }
        private void SetReadOnlyRecursive(Control control, bool readOnly)
        {
            foreach (Control subControl in control.Controls)
            {
                SetReadOnlyRecursive(subControl, readOnly);
            }

            if (control is System.Windows.Forms.TextBoxBase)
            {
                ((System.Windows.Forms.TextBoxBase)control).ReadOnly = readOnly;
            }
            else if (control is NumericUpDown)
            {
                ((NumericUpDown)control).ReadOnly = readOnly;
            }
        }

        public FUpdateSanPham()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật lại thông tin sản phẩm này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (sanphamUpdate is Loa)
                {
                    fChonTinhNangLoa.LoadLoa();
                    Loa loaUpdate = (Loa)sanphamUpdate;
                    loaUpdate.MaSP = textMaSP.Text;
                    loaUpdate.TenSP = textTenSP.Text;
                    loaUpdate.Gia = decimal.Parse(textGia.Text);
                    loaUpdate.CongSuat = double.Parse(textCongSuat.Text);
                    loaUpdate.TrongLuong = double.Parse(textTrongLuong.Text);
                    loaUpdate.Mau = textMau.Text;
                    loaUpdate.KichThuoc = numDai.Value.ToString() + " X " + numRong.Value + " X " + numCao.Value;
                    loaUpdate.ChatLieu = fChonTinhNangLoa.ChatLieu;
                    loaUpdate.TanSo = fChonTinhNangLoa.TanSo;
                    loaUpdate.KetNoi = fChonTinhNangLoa.KetNoi;
                }
                else if (sanphamUpdate is Manhinh )
                {
                    fChonTinhNangManHinh.LoadManHinh();
                    Manhinh ManHinhUpDate = (Manhinh)sanphamUpdate;
                    ManHinhUpDate.MaSP = textMaSP.Text;
                    ManHinhUpDate.TenSP = textTenSP.Text;
                    ManHinhUpDate.Gia=decimal.Parse(textGia.Text);
                    ManHinhUpDate.CongSuat= double.Parse(textCongSuat.Text); 
                    ManHinhUpDate.TrongLuong = double.Parse(textTrongLuong.Text);
                    ManHinhUpDate.Mau=textMau.Text;
                    ManHinhUpDate.TanSoQuet = fChonTinhNangManHinh.TanSoQuet;
                    ManHinhUpDate.DoPhanGiai = fChonTinhNangManHinh.DoPhanGiai;
                    ManHinhUpDate.KichThuoc = fChonTinhNangManHinh.KichThuoc;
                    ManHinhUpDate.TiLeKhungHinh = fChonTinhNangManHinh.TiLeKhungHinh;
                    ManHinhUpDate.DoPhanGiai = fChonTinhNangManHinh.DoPhanGiai;
                    ManHinhUpDate.LoaiManHinh = fChonTinhNangManHinh.LoaiManHinh;
                    ManHinhUpDate.TamNen= fChonTinhNangManHinh.TamNen;
                }    
                else if ( sanphamUpdate is MayIn)
                {
                    fchonTinhNangMayin.LoadMayIn();
                    MayIn mayInUpDate = (MayIn)sanphamUpdate;
                    mayInUpDate.MaSP = textMaSP.Text;
                    mayInUpDate.TenSP = textTenSP.Text;
                    mayInUpDate.Gia = decimal.Parse(textGia.Text);
                    mayInUpDate.CongSuat = double.Parse(textCongSuat.Text);
                    mayInUpDate.TrongLuong = double.Parse(textTrongLuong.Text);
                    mayInUpDate.Mau = textMau.Text;
                    mayInUpDate.KichThuoc = numDai.Value.ToString() + " X " + numRong.Value + " X " + numCao.Value;
                    mayInUpDate.Tocdoin = fchonTinhNangMayin.Tocdoin;
                    mayInUpDate.KhoGiay = fchonTinhNangMayin.KhoGiay;
                    mayInUpDate.BoNho = fchonTinhNangMayin.BoNho;
                    mayInUpDate.Dophangiai = fchonTinhNangMayin.Dophangiai;
                    mayInUpDate.KetNoi = fchonTinhNangMayin.KetNoi;
                }    

                // Sử dụng XuLyEntity để lưu danh sách
                XuLyEntity<SanPham>.SaveList(FSanPham.dsSanPham, "SanPham.xml");

            }
        }

        private void FUpdateSanPham_Load(object sender, EventArgs e)
        {
            if(sanphamUpdate.LoaiSP=="Loa")
            {
                Loa loaUpdate = (Loa)sanphamUpdate;
                fChonTinhNangLoa = new FChonTinhNangLoa();
                OpenchildForm(fChonTinhNangLoa);
                textMaSP.Text = loaUpdate.MaSP;
                textLoaiSP.Text = loaUpdate.LoaiSP;
                textTenSP.Text = loaUpdate.TenSP;
                textGia.Text = loaUpdate.Gia.ToString();
                textCongSuat.Text = loaUpdate.CongSuat.ToString();
                textTrongLuong.Text = loaUpdate.TrongLuong.ToString();
                textMau.Text = loaUpdate.Mau;
                string[] values =loaUpdate.KichThuoc.Split('X');
                numDai.Value = int.Parse(values[0].Trim());
                numRong.Value = int.Parse(values[1].Trim());
                numCao.Value = int.Parse(values[2].Trim());
                fChonTinhNangLoa.ChatLieu = loaUpdate.ChatLieu;
                fChonTinhNangLoa.TanSo = loaUpdate.TanSo;
                fChonTinhNangLoa.KetNoi = loaUpdate.KetNoi;
                fChonTinhNangLoa.HienThongTin();
            }
            else if (sanphamUpdate.LoaiSP == "Man Hinh")
            {
                panelKichThuoc.Visible = false;
                labelkT.Visible = false;
                Manhinh ManHinhUpDate = (Manhinh)sanphamUpdate;
                fChonTinhNangManHinh = new FChonTinhNangManHinh();
                OpenchildForm(fChonTinhNangManHinh);
                textMaSP.Text = ManHinhUpDate.MaSP;
                textLoaiSP.Text = ManHinhUpDate.LoaiSP;
                textMau.Text=ManHinhUpDate.Mau;
                textTenSP.Text = ManHinhUpDate.TenSP;
                textGia.Text = ManHinhUpDate.Gia.ToString();
                textCongSuat.Text = ManHinhUpDate.CongSuat.ToString();
                textTrongLuong.Text = ManHinhUpDate.TrongLuong.ToString();
                fChonTinhNangManHinh.TanSoQuet = ManHinhUpDate.TanSoQuet;
                fChonTinhNangManHinh.TiLeKhungHinh = ManHinhUpDate.TiLeKhungHinh;
                fChonTinhNangManHinh.TamNen = ManHinhUpDate.TamNen;
                fChonTinhNangManHinh.LoaiManHinh = ManHinhUpDate.LoaiManHinh;
                fChonTinhNangManHinh.KichThuoc = ManHinhUpDate.KichThuoc;
                fChonTinhNangManHinh.DoPhanGiai = ManHinhUpDate.DoPhanGiai;
                fChonTinhNangManHinh.HienThongTin();



            }
            else if (sanphamUpdate.LoaiSP == "May In")
            {
                
                MayIn mayInUpdate = (MayIn)sanphamUpdate;
                fchonTinhNangMayin = new FChonTinhNangMayIn();
                OpenchildForm(fchonTinhNangMayin);
                textMaSP.Text = mayInUpdate.MaSP;
                textLoaiSP.Text = mayInUpdate.LoaiSP;
                textMau.Text = mayInUpdate.Mau;
                textTenSP.Text = mayInUpdate.TenSP;
                textGia.Text = mayInUpdate.Gia.ToString();
                string[] values = mayInUpdate.KichThuoc.Split('X');
                numDai.Value= int.Parse(values[0].Trim());
                numRong.Value = int.Parse(values[1].Trim());
                numCao.Value = int.Parse(values[2].Trim());
                textCongSuat.Text = mayInUpdate.CongSuat.ToString();
                textTrongLuong.Text = mayInUpdate.TrongLuong.ToString();
                fchonTinhNangMayin.Tocdoin= mayInUpdate.Tocdoin;
                fchonTinhNangMayin.KetNoi= mayInUpdate.KetNoi;
                fchonTinhNangMayin.KhoGiay= mayInUpdate.KhoGiay;
                fchonTinhNangMayin.BoNho= mayInUpdate.BoNho;
                fchonTinhNangMayin.Dophangiai= mayInUpdate.Dophangiai;
                fchonTinhNangMayin.HienThongTin();


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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
