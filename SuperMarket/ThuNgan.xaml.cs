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
    /// Interaction logic for ThuNgan.xaml
    /// </summary>
    public partial class ThuNgan : UserControl
    {
        int maNV;
        public ThuNgan(int manv)
        {
            InitializeComponent();
            maNV = manv;

            UserControl usc = null;
            GHMain.Children.Clear();
            usc = new LapHoaDon(manv);
            GHMain.Children.Add(usc);
        }
    }

}
