using DashboardApp.Models;
using DoAn_2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TiemDien
{
    internal static class Program
    {
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            Application.Run(new Flogin());
            //Application.Run(new FdoanhThu());

        }
    }
}
