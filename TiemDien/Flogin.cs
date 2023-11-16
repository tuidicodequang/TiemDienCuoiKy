using TiemDien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYGARAGE;


namespace TiemDien
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void buttLogin_Click(object sender, EventArgs e)
        {
          
            try
            {
                
                string tk = txbUser.Text;
                string mk = txbPassWord.Text;
             
                if (tk=="Tienanh" && mk=="456")
                {
                    fTabManager f = new fTabManager();
                    this.Hide();
                    f.ShowDialog();
                    
                   
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác vui lòng nhập lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void buttLogin_MouseEnter(object sender, EventArgs e)
        {
            buttLogin.ForeColor = Color.Black;
        }

        private void buttLogin_MouseLeave(object sender, EventArgs e)
        {
            buttLogin.ForeColor = Color.White;
        }

        private void buttExit_MouseEnter(object sender, EventArgs e)
        {
            buttExit.ForeColor = Color.Black;
        }

        private void buttExit_MouseLeave(object sender, EventArgs e)
        {
            buttExit.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
    }
}
