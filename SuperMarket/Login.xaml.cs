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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {

        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            Number nb = new Number();
            nb.ShowDialog();
            var select = (from s in db.NHANVIENs
                          where s.MatKhau.ToString() == nb.txtnumber.Password
                          select s).FirstOrDefault();
            if (select == null)
            {
                MessageBox.Show("Mật Khẩu Không Đúng");
            }
            else
            {
                if (select.KichHoat == true)
                {
                    this.Hide();
                    Market mk = new Market(select.TenNV, select.MaChucVu.Value, select.MaNV);
                    mk.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài Khoản Chưa Kích Hoạt");
                }
            }
        }
    }
}
