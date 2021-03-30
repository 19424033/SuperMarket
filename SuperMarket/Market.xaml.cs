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
    /// Interaction logic for Market.xaml
    /// </summary>
    public partial class Market : Window
    {
        int maNV;

        public Market(string tenNV, int maCV, int MANV)
        {
            InitializeComponent();

            string[] arrListStr = tenNV.Split(' ');

            txtTK.Text = arrListStr[arrListStr.Length - 1];

            maNV = MANV;

            UserControl usc = null;
            GridMain.Children.Clear();
            if (maCV == 1 || maCV == 2)
            {
                usc = new QuanLy(maNV);
                GridMain.Children.Add(usc);
            }
            else if (maCV == 3)
            {
                usc = new ThuNgan(maNV);
                GridMain.Children.Add(usc);
            }
            else
            {
                usc = new Kho(maNV);
                GridMain.Children.Add(usc);
            }
        }

        public Market()
        {
            InitializeComponent();

            UserControl usc = null;
            GridMain.Children.Clear();
            usc = new QuanLy(maNV);
            GridMain.Children.Add(usc);
        }

        private void Acc_Click(object sender, RoutedEventArgs e)
        {
            ThongTinTaiKhoan tttk = new ThongTinTaiKhoan(maNV);
            tttk.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
