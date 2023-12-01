
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using TiemDien;

namespace DashboardApp.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class Dashboard
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public void CapNhatTime(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;

        }



        private int numberDays;
        List<KhachHang> dsKhachHang = XuLyEntity<KhachHang>.LoadList("KhachHang.xml");
        List<HoaDon> dsHoaDon = XuLyEntity<HoaDon>.LoadList("HoaDon.xml");
        List<NhanVien> dsNhanVien = XuLyEntity<NhanVien>.LoadList("NhanVien.xml");
        List<SanPham> dsSanPham = XuLyEntity<SanPham>.LoadList("SanPham.xml");
        public int NumCustomers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }
        public string Test { get; set; }

        public Dashboard()
        {

        }

        public void GetNumberItems()
        {
            
            NumCustomers = dsKhachHang.Count;
            NumProducts = dsSanPham.Count;
            NumOrders = 0 ;
            NumSuppliers = dsNhanVien.Count;
            TotalRevenue = 0;
            foreach (HoaDon hoadon in dsHoaDon)
            {
                DateTime ngay = DateTime.ParseExact(hoadon.NgayGiaoDich, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (ngay >= StartDate && ngay <= EndDate)
                {
                    TotalRevenue += hoadon.ThanhTien;
                    NumOrders++;

                }
            

            }

            TotalProfit = TotalRevenue * 0.2m;


        }

        public void Taolist()
        {
            GrossRevenueList = new List<RevenueByDate>();
            // Vòng lặp để kiểm tra và đếm số ngày lặp lại
            for (DateTime currentDate = StartDate; currentDate <= EndDate; currentDate = currentDate.AddDays(1))
            {
                decimal TotalRevenue = 0;

                foreach (HoaDon hoadon in dsHoaDon)
                {
                    DateTime ngay;

                    if (DateTime.TryParseExact(hoadon.NgayGiaoDich, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay))
                    {
                        // Kiểm tra xem ngày có bằng với currentDate không
                        if (ngay.Date == currentDate.Date) {


                            TotalRevenue += hoadon.ThanhTien;
                        }
                    }
                  
                }

                // Tạo đối tượng RevenueByDate và thêm vào danh sách
                RevenueByDate t = new RevenueByDate
                {
                    TotalRevenue = TotalRevenue,
                    Date = currentDate.ToString("dd/MM/yyyy")
                };

                // Kiểm tra và khởi tạo GrossRevenueList nếu nó vẫn là null
                if (GrossRevenueList == null)
                {
                    GrossRevenueList = new List<RevenueByDate>();
                }

                // Thêm vào danh sách
                GrossRevenueList.Add(t);
            }

        }
        public void LoadSanPhamBanChay()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            // Dictionary để đếm số lượng của từng sản phẩm
            Dictionary<string, int> productCounts = new Dictionary<string, int>();

            int soLuong = 0;
            // Duyệt qua danh sách dsHoaDon để đếm số lượng sản phẩm
            foreach (HoaDon hoadon in dsHoaDon)
            {
                foreach (ItemHoadon item in hoadon.DanhSachSanPham)
                {
                    DateTime ngay = DateTime.ParseExact(hoadon.NgayGiaoDich, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    if ((ngay >= StartDate && ngay <= EndDate))
                    {
                        string tenSp = item.TenSP;
                        soLuong = item.SoLuong;

                        if (productCounts.ContainsKey(tenSp))
                        {
                            // Tăng số lượng nếu sản phẩm đã tồn tại trong dictionary

                            productCounts[tenSp] += soLuong;
                        }

                        {
                            // Thêm sản phẩm vào dictionary nếu chưa tồn tại
                            productCounts[tenSp] = 1;
                        }
                    }
                }
            }

           
            List<KeyValuePair<string, int>> topProducts = productCounts.OrderByDescending(p => p.Value)
                                                                     .Take(5)
                                                                     .ToList();

            foreach (var product in topProducts)
            {
                TopProductsList.Add(product);
            }
        }
    

        

        public bool LoadData()
        {
            GetNumberItems();
            
            //  GetOrderAnalysis();

            Console.WriteLine("Refreshed data: {0} - {1}", StartDate.ToString(), EndDate.ToString());
            return true;
        }
    }
}
