using DashboardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TiemDien
{
    public partial class FdoanhThu : Form
    {
        private Dashboard model;
        DateTime end;
        DateTime st;
        public FdoanhThu()
        {
            InitializeComponent();
            
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            st= dtpStartDate.Value;
            dtpEndDate.Value = DateTime.Now;
            end = dtpEndDate.Value;
            btnLast7Days.Select();

            model = new Dashboard();
            LoadData();
        }

       
        private void LoadData()
        {

                 model.GetNumberItems();
               
                lblNumOrders.Text = model.NumOrders.ToString();
                lblTotalRevenue.Text = model.TotalRevenue.ToString() + " VNĐ";
                lblTotalProfit.Text = model.TotalProfit.ToString() + " VNĐ";

                lblNumCustomers.Text = model.NumCustomers.ToString();
                lblNumSuppliers.Text = model.NumSuppliers.ToString();
                lblNumProducts.Text = model.NumProducts.ToString();

                model.Taolist();
                    chartGrossRevenue.DataSource = model.GrossRevenueList;
                    chartGrossRevenue.Series[0].XValueMember = "Date";
                    chartGrossRevenue.Series[0].YValueMembers = "TotalRevenue";
                    chartGrossRevenue.DataBind();

                model.LoadSanPhamBanChay();
                chartTopProducts.DataSource = model.TopProductsList;
                chartTopProducts.Series[0].XValueMember = "key";
                chartTopProducts.Series[0].YValueMembers = "value";
                chartTopProducts.DataBind();
            
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            st = dtpStartDate.Value;
            dtpEndDate.Value = DateTime.Now;
            end=dtpEndDate.Value;
            model.CapNhatTime(st, end);
            LoadData();
            
            DisableCustomDates();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {

            dtpStartDate.Value = DateTime.Today;
            st = dtpStartDate.Value;
            dtpEndDate.Value = DateTime.Now;
            end = dtpEndDate.Value;
            model.CapNhatTime(st, end);
            LoadData();
            DisableCustomDates();
            
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            st = dtpStartDate.Value;
            dtpEndDate.Value = DateTime.Now;
            end = dtpEndDate.Value;
            model.CapNhatTime(st, end);
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {

            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            st = dtpStartDate.Value;
            dtpEndDate.Value = DateTime.Now;
            end = dtpEndDate.Value;
            model.CapNhatTime(st, end);
            LoadData();
            DisableCustomDates();
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            st = dtpStartDate.Value;
            end = dtpEndDate.Value;
            model.CapNhatTime(st, end);
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FdoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}
