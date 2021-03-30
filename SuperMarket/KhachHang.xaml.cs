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
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class KhachHang : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();
        int maKHupdate;

        IEnumerable<KHACHHANG> select;

        public KhachHang()
        {
            InitializeComponent();
            Select();
        }

        void Select()
        {
            DataKH.ItemsSource = null;

            if (keywordTextBox.Text == "")
            {
                select = from s in db.KHACHHANGs
                         where s.MaKH != 0
                         select s;
            }
            else
            {
                select = from s in db.KHACHHANGs
                         where s.MaKH != 0 && s.TenKH.ToLower().Contains(keywordTextBox.Text.ToLower())
                         select s;
            }
              
            DataKH.ItemsSource = select.ToList();
        }

        private void BtnAddKH_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                var nv = new KHACHHANG()
                {
                    TenKH = txtName.Text,
                    DiaChi = txtDiaChi.Text,
                    SoDienThoai = txtDT.Text,
                    NgayLapThe = DateTime.Now,
                    DiemThuongTichLuy= 0
                };
                db.KHACHHANGs.Add(nv);
                MessageBox.Show("Thêm Thành Công");
                txtName.Text = "";
                txtDT.Text = "";
                txtDiaChi.Text = "";
            }
            db.SaveChanges();
            Select();
        }

        private void BtnUpdateKH_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "" || txtDT.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Chắc Cập Nhật ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    var update = (from s in db.KHACHHANGs where s.MaKH == maKHupdate select s).Single();
                    update.TenKH = txtName.Text;
                    update.SoDienThoai = txtDT.Text;
                    update.DiaChi = txtDiaChi.Text;
                    MessageBox.Show("Cập Nhật Thành Công");
                    txtName.Text = "";
                    txtDiaChi.Text = "";
                    txtDT.Text = "";
                    btnAddKH.IsEnabled = true;
                    btnUpdateKH.IsEnabled = false;
                    btnCancelKH.IsEnabled = false;
                    db.SaveChanges();
                    Select();
                }
            }
        }

        private void BtnCancelKH_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";

            btnAddKH.IsEnabled = true;
            btnUpdateKH.IsEnabled = false;
            btnCancelKH.IsEnabled = false;
        }

        private void KeywordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Select();
        }

        private void KeywordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            hintText.Visibility = Visibility.Hidden;
        }

        private void KeywordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (keywordTextBox.Text.Length == 0)
            {
                hintText.Visibility = Visibility.Visible;
            }
        }

        private void DataKH_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var row = DataKH.SelectedItem as KHACHHANG;
            if (row != null)
            {
                maKHupdate = row.MaKH;
                txtName.Text = row.TenKH;
                //txt.Text = Convert.ToDateTime(row.NgayLapThe).ToString("dd/MM/yyyy");
                txtDT.Text = row.SoDienThoai;
                txtDiaChi.Text = row.DiaChi;
                btnAddKH.IsEnabled = false;
                btnUpdateKH.IsEnabled = true;
                btnCancelKH.IsEnabled = true;
            }
        }
    }
}
