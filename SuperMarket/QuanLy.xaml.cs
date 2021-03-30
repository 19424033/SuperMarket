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
using System.Timers;
using System.Windows.Threading;

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for QuanLy.xaml
    /// </summary>
    public partial class QuanLy : UserControl
    {
        int maNV;

        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();


        public QuanLy()
        {
            InitializeComponent();
        }

        public QuanLy(int ma)
        {
            InitializeComponent();

            maNV = ma;
            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new NhanVien();
            GridMain.Children.Add(usc);
        }


        private void BtnQLNV_Click(object sender, RoutedEventArgs e)
        {
            btnQLNV.Background = Brushes.DeepSkyBlue;
            btnDTXN.Background = Brushes.White;
            btnLHNH.Background = Brushes.White;
            btnQLSP.Background = Brushes.White;
            btnKH.Background = Brushes.White;

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new NhanVien();
            GridMain.Children.Add(usc);

            btnQLNV.IsEnabled = false;
            btnLHNH.IsEnabled = true;
            btnQLSP.IsEnabled = true;
            btnKH.IsEnabled = true;
        }

        private void BtnDTXN_Click(object sender, RoutedEventArgs e)
        {
            btnDTXN.Background = Brushes.DeepSkyBlue;
            btnLHNH.Background = Brushes.White;
            btnQLNV.Background = Brushes.White;
            btnQLSP.Background = Brushes.White;
            btnKH.Background = Brushes.White;

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new ThongKeXuatNhap();
            GridMain.Children.Add(usc);

            btnQLNV.IsEnabled = true;
            btnLHNH.IsEnabled = true;
            btnQLSP.IsEnabled = true;
            btnKH.IsEnabled = true;
            btnDTXN.IsEnabled = false;

        }

        private void BtnQLSP_Click(object sender, RoutedEventArgs e)
        {
            btnQLSP.Background = Brushes.DeepSkyBlue;
            btnDTXN.Background = Brushes.White;
            btnQLNV.Background = Brushes.White;
            btnLHNH.Background = Brushes.White;
            btnKH.Background = Brushes.White;

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new SanPham();
            GridMain.Children.Add(usc);

            btnQLNV.IsEnabled = true;
            btnLHNH.IsEnabled = true;
            btnQLSP.IsEnabled = false;
            btnKH.IsEnabled = true;
            btnDTXN.IsEnabled = true;
        }

        private void BtnLHNH_Click(object sender, RoutedEventArgs e)
        {
            btnLHNH.Background = Brushes.DeepSkyBlue;
            btnDTXN.Background = Brushes.White;
            btnQLNV.Background = Brushes.White;      
            btnQLSP.Background = Brushes.White;
            btnKH.Background = Brushes.White;

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new TaoPhieuNhapKho(maNV);
            GridMain.Children.Add(usc);

            btnLHNH.IsEnabled = false;
            btnQLNV.IsEnabled = true;
            btnQLSP.IsEnabled = true;
            btnKH.IsEnabled = true;
            btnDTXN.IsEnabled = true;

        }

        private void BtnKH_Click(object sender, RoutedEventArgs e)
        {
            btnKH.Background = Brushes.DeepSkyBlue;
            btnDTXN.Background = Brushes.White;
            btnQLNV.Background = Brushes.White;
            btnQLSP.Background = Brushes.White;
            btnLHNH.Background = Brushes.White;

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new KhachHang();
            GridMain.Children.Add(usc);

            btnLHNH.IsEnabled = true;
            btnQLNV.IsEnabled = true;
            btnQLSP.IsEnabled = true;
            btnKH.IsEnabled = false;
            btnDTXN.IsEnabled = true;
        }

    }
}
