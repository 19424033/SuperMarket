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
    /// Interaction logic for ListDS.xaml
    /// </summary>
    public partial class ListDS : Window
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        public string MA = "";

        bool check = false;

        public ListDS()
        {
            InitializeComponent();
            clLV.DisplayMemberBinding = new Binding("TenNCC");
            clLV.Header = "Nhà Cung Cấp";


            var select = from s in db.NHACUNGCAPs
                         where s.KichHoat == true
                         select s;

            LV.ItemsSource = select.ToList();
        }

        public ListDS(string NCC)
        {
            InitializeComponent();

            clLV.DisplayMemberBinding = new Binding("TenSP");
            clLV.Header = "Sản Phẩm";


            var select = from p in db.NCC_SP
                          join a in db.SANPHAMs on p.MaSP equals a.MaSP
                          where p.KichHoat == true && a.KichHoat == true
                          && p.MaNCC.ToString().ToLower().Contains(NCC.ToLower())
                          select a;

            LV.ItemsSource = select.ToList();

            check = true;
        }

        private void LV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (check)
            {
                var row = LV.SelectedItem as SANPHAM;
                MA = row.MaSP.ToString();
            }
            else
            {
                var row = LV.SelectedItem as NHACUNGCAP;
                MA = row.MaNCC.ToString();
            }
            this.Close();
        }
    }
}
