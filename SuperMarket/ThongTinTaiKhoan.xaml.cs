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
    /// Interaction logic for ThongTinTaiKhoan.xaml
    /// </summary>
    public partial class ThongTinTaiKhoan : Window
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        int maNV;

        public ThongTinTaiKhoan(int MANV)
        {
            InitializeComponent();
            maNV = MANV;
        }

        private void Capnhat_Click(object sender, RoutedEventArgs e)
        {
            if(txtPassHT.Password == "" || txtPassNew.Password == "" || txtPassNewCf.Password == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                var update = (from s in db.NHANVIENs where s.MaNV == maNV select s).Single();
                if(update.MatKhau == txtPassHT.Password)
                {
                    if(txtPassNew.Password == txtPassNewCf.Password)
                    {
                        var select = (from s in db.NHANVIENs
                                      where s.MatKhau.ToString() == txtPassNew.Password
                                      select s).FirstOrDefault();
                        if (select == null)
                        {
                            update.MatKhau = txtPassNew.Password;
                            db.SaveChanges();
                            MessageBox.Show("Cập Nhật Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu đã tồn tại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Xác Nhận Không Đúng");
                    }                    
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Hiện Tại Không Đúng");
                }
            }   
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
