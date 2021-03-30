using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Class
{
    public class ChiTietSanPham 
    {
        public string TenLoaiSP { get; set; }
        public int MaLoaiSP { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBanRa { get; set; }
        public bool KichHoat { get; set; }
        public int KhuyenMai { get; set; }
    }
}
