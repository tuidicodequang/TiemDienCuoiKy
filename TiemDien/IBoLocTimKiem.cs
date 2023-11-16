using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemDien
{
    interface IBoLocTimKiem
    {
        void SapXepTheoAZ();
        void SapXepTheoZA();
        void SapXepTheoGia();

        void TimKiemTheoMaSP(string masp);

        void TimKiemTheoTenSP(string tensp);
    }
}
