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
    public partial class FChonTinhNangLoa : Form
    {
        public string ChatLieu;
        public string KetNoi;
        public string TanSo;
        public FChonTinhNangLoa()
        {           
            InitializeComponent();
        }

        private void FChonTinhNangLoa_Load(object sender, EventArgs e)
        {
            ChatLieu = textChatLieu.Text;
            KetNoi = textKetNoi.Text;
            TanSo = textTanSo.Text;

        }
        public void LoadLoa()
        {
            ChatLieu = textChatLieu.Text;
            KetNoi = textKetNoi.Text;
            TanSo = textTanSo.Text;
        }
        public void HienThongTin()
        {
            textChatLieu.Text = ChatLieu;
            textKetNoi.Text = KetNoi;
            textTanSo.Text = TanSo;
        }
    }
}
