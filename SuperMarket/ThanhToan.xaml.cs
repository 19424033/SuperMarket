using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ThanhToan.xaml
    /// </summary>
    public partial class ThanhToan : Window
    {
        public int soTienDu = 0;
        public int soTienKhachDua = 0;
        public int soTienThanhToan;
        public ThanhToan(int sttt)
        {
            InitializeComponent();
            soTienThanhToan = sttt;
        }

        private void TxtST_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                soTienKhachDua = int.Parse(txtST.Text);
                if(soTienKhachDua >= soTienThanhToan)
                {
                    soTienDu = soTienKhachDua - soTienThanhToan;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Số Tiền Không Hợp Lệ");
                }

            }
            else if(e.Key == Key.Escape)
            {
                soTienDu = 0;
                this.Close();
            }
        }
    }
}
