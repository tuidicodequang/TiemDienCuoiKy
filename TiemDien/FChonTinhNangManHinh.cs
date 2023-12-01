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
    public partial class FChonTinhNangManHinh : Form
    {
        public string TamNen;
        public string KichThuoc;
        public string DoPhanGiai;
        public string TiLeKhungHinh;
        public string TanSoQuet;
        public string LoaiManHinh;

        public FChonTinhNangManHinh()
        {
            InitializeComponent();
        }
        public void LoadManHinh()
        {
            TamNen = textTamNen.Text;
            KichThuoc= (textKichThuocMH.Text);
            DoPhanGiai = textDoPhanGiai.Text;
            TiLeKhungHinh = textTiLeKhungHinh.Text;
            TanSoQuet = textTanSoQuet.Text;
            LoaiManHinh = textLoaiMH.Text;
        }

        public void HienThongTin()
        {
             textTamNen.Text =TamNen;
             (textKichThuocMH.Text)= KichThuoc ;
            textDoPhanGiai.Text =DoPhanGiai ;
            textTiLeKhungHinh.Text = TiLeKhungHinh  ;
             textTanSoQuet.Text= TanSoQuet ;
             textLoaiMH.Text = LoaiManHinh ;
     
        }
        private void FChonTinhNangManHinh_Load(object sender, EventArgs e)
        {

        }
    }
}
