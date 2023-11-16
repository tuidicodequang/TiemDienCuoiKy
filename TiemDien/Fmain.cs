
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiemDien;


namespace QUANLYGARAGE
{
    public partial class fTabManager : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize;

        public fTabManager()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);//Border size

        }


        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                iconButton1.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                iconButton1.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void Buttlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flogin formLogin = (Flogin)Application.OpenForms["flogin"];
            this.Close();
            formLogin.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                fTabManager_Load(sender as Form, e);
            }
        }

        private void ButtNhanVien_Click(object sender, EventArgs e)
        {
            FNhanVien f =  new FNhanVien();
            OpenchildForm(f);
        }

        private void ButtKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtSanPham_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtDoanhThu_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CollapseMenu();
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
            panelDesktop.Controls.Add(childFrom);
            panelDesktop.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        public void fTabManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Flogin formLogin = (Flogin)Application.OpenForms["flogin"];
            formLogin.Close();
        }

        private void fTabManager_Load(object sender, EventArgs e)
        {
        
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
         
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}

