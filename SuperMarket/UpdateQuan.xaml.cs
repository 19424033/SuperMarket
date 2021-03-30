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
    /// Interaction logic for UpdateQuan.xaml
    /// </summary>
    public partial class UpdateQuan : Window
    {
        public string soLuong { get; set; }

        public UpdateQuan(string SL)
        {
            InitializeComponent();

            soLuong = SL;
        }

        private void TxtSL_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtSL.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Số Lượng");
                }
                else
                {
                    soLuong = txtSL.Text;
                    this.Close();
                }
            }
            else if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }
    }
}
