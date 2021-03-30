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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for ThongKeXuatNhap.xaml
    /// </summary>
    public partial class ThongKeXuatNhap : UserControl
    {
        public ThongKeXuatNhap()
        {
            InitializeComponent();

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new BanHang();
            GridMain.Children.Add(usc);
        }

        private void BtnBH_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new BanHang();
            GridMain.Children.Add(usc);

            btnBH.IsEnabled = false;
            btnNH.IsEnabled = true;
            btnTH.IsEnabled = true;
        }

        private void BtnNH_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new NhapHangBC();
            GridMain.Children.Add(usc);

            btnBH.IsEnabled = true;
            btnNH.IsEnabled = false;
            btnTH.IsEnabled = true;
        }

        private void BtnTH_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new TonHang();
            GridMain.Children.Add(usc);

            btnBH.IsEnabled = true;
            btnNH.IsEnabled = true;
            btnTH.IsEnabled = false;
        }
    }
}
