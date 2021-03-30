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
    /// Interaction logic for Number.xaml
    /// </summary>
    public partial class Number : Window
    {
        public Number()
        {
            InitializeComponent();
            KeyDown += Number_KeyDown;
        }

        private void Number_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {
                this.Close();
            }
            else  if (e.Key == Key.Escape) {
                txtnumber.Password = "";
                this.Close();
            }
            else if (e.Key == Key.Back)
            {
                txtnumber.Password = txtnumber.Password.Length == 0 ? "" : txtnumber.Password.Remove(txtnumber.Password.Length - 1);
            }
            else
            {
                Regex R = new Regex("[0-9]");

                var strKey = new KeyConverter().ConvertToString(e.Key);
                if (strKey.Length > 1)
                {
                    strKey = strKey.Replace("NumPad", "").Replace("D", "");
                }
                if (strKey.Length == 1)
                {
                    if (R.IsMatch(strKey))
                    {
                        txtnumber.Password += strKey;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            txtnumber.Password += (sender as Button).Content;
        }

        private void TxtCancel_Click(object sender, RoutedEventArgs e)
        {
            txtnumber.Password = "";
            this.Close();
        }

        private void TxtClear_Click(object sender, RoutedEventArgs e)
        {
            txtnumber.Password = "";
        }

        private void Txtok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
