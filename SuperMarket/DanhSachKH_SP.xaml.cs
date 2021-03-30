using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for DanhSachKH_SP.xaml
    /// </summary>
    public partial class DanhSachKH_SP : Window
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();
        public string MA = "";
        bool check = false;

        public DanhSachKH_SP(int cn)
        {
            InitializeComponent();

            if (cn == 1)
                SelectKH();
            else
                SelectSP();
        }

        private void LV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (check)
            {
                var row = LV.SelectedItem as KHACHHANG;
                MA = row.MaKH.ToString();
            }
            else
            {
                var row = LV.SelectedItem as SANPHAM;
                MA = row.MaSP.ToString();
            }
            this.Close();
        }

        void SelectKH()
        {
            clLV.DisplayMemberBinding = new Binding("TenKH");
            clLV.Header = "Khách Hàng";


            var select = from p in db.KHACHHANGs
                         where p.MaKH != 0
                         select p;

            LV.ItemsSource = select.ToList();
            check = true;
        }

        void SelectSP()
        {
            clLV.DisplayMemberBinding = new Binding("TenSP");
            clLV.Header = "Sản Phẩm";


            var select = from p in db.SANPHAMs
                         where p.KichHoat == true
                         select p;

            LV.ItemsSource = select.ToList();
        }
    }
}
