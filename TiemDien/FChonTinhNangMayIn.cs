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
    public partial class FChonTinhNangMayIn : Form
    {
        public string Dophangiai;

        public string Tocdoin;

        public string BoNho;

        public string KhoGiay;

        public string KetNoi;
        public FChonTinhNangMayIn()
        {
            InitializeComponent();
        }
        public void LoadMayIn()
        {
            BoNho = textBoNho.Text;
            KhoGiay = comboKhoGiay.Text;
            Dophangiai = textDoPhanGiai.Text;
            KetNoi = textKetNoi.Text;
            Tocdoin= numTocDoIn.Value.ToString();
       
        }

        public void HienThongTin()
        {
            textBoNho.Text= BoNho;
            comboKhoGiay.Text = KhoGiay;
            textDoPhanGiai.Text = Dophangiai;
            textKetNoi.Text=KetNoi;
            numTocDoIn.Value= int.Parse(Tocdoin);

        }
    }
}
