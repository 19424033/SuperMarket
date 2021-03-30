using SuperMarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Kho.xaml
    /// </summary>
    public partial class Kho : UserControl
    {
        public int maNV;

        LOAISANPHAM maSelLSP;

        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        List<KiemKeKho> KK = new List<KiemKeKho>();


        public Kho(int manv)
        {
            InitializeComponent();

            maNV = manv;

            Select();
        }

        void SelectSP()
        {
            dataTon.ItemsSource = null;

            string lsp = "";
            if (maSelLSP != null && maSelLSP.MaLoaiSP != 0)
                lsp = maSelLSP.MaLoaiSP.ToString();


            IEnumerable<KiemKeKho> select;

            if (keywordTextBox.Text == "")
            {
                select = from s in KK
                         where s.MaLSP.ToString().Contains(lsp)
                         select s;
            }
            else
            {
                select = from s in KK
                         where s.MaLSP.ToString().Contains(lsp)
                         && s.TenSP.ToLower().Contains(keywordTextBox.Text.ToLower())
                         select s;
            }
            dataTon.ItemsSource = select.ToList();
        }

        private void DataListLSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            maSelLSP = dataListLSP.SelectedItem as LOAISANPHAM;

            SelectSP();
        } 

        private void KeywordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SelectSP();
        }

        void Select()
        {
            List<LOAISANPHAM> tc = new List<LOAISANPHAM>();

            var lsp = new LOAISANPHAM
            {
                TenLoaiSP = "Tất Cả"
            };

            tc.Add(lsp);

            var selectLSP = (from s in db.LOAISANPHAMs
                             where s.KichHoat == true
                             select s).ToList();

            var listLSP = tc.Concat(selectLSP);

            dataListLSP.ItemsSource = listLSP.ToList();

            SelectTonKho();
        }

        void SelectTonKho()
        {
            dataTon.ItemsSource = null;
            KK.Clear();
            var select = from s in db.SANPHAMs
                         from t in db.LOAISANPHAMs
                         where s.KichHoat == true && s.MaLoaiSP == t.MaLoaiSP
                         select new { s.MaSP, s.TenSP, s.GiaMuaVao, s.SoLuong, t.TenLoaiSP, t.MaLoaiSP };

            foreach (var data in select)
            {
                var kkk = new KiemKeKho()
                {
                    MaLSP = data.MaLoaiSP,
                    TenLoaiSP = data.TenLoaiSP,
                    MaSP = data.MaSP,
                    TenSP = data.TenSP,
                    GiaMuaVao = data.GiaMuaVao == null ? "" : ((int)data.GiaMuaVao).ToString(),
                    SoLuong = (int)data.SoLuong,
                    SLKK = ""
                };
                KK.Add(kkk);
            }

            dataTon.ItemsSource = KK.ToList();
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

        private void BtnNhap_Click(object sender, RoutedEventArgs e)
        {
            NhapHang nh = new NhapHang(maNV);
            nh.ShowDialog();
            SelectTonKho();
        }

        private void DataTon_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = dataTon.SelectedItem as KiemKeKho;

            if (row != null)
            {
                UpdateQuan update = new UpdateQuan(row.SLKK);
                update.ShowDialog();

                var foundDetail = KK.FirstOrDefault(p => p.MaSP == row.MaSP);
                foundDetail.SLKK = update.soLuong;
                foundDetail.SLCL = foundDetail.SLKK == "" ? 0 : int.Parse(foundDetail.SLKK) - foundDetail.SoLuong;

            }
        }

        private void BtnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Cập Nhật ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var select = (from s in db.KIEMKEKHOes
                              select new { s.MaKiemKe }).Max(y => y.MaKiemKe);

                int MaKK;
                if (select.ToString() == "")
                    MaKK = 1;
                else
                    MaKK = (int)select + 1;
                DateTime now = DateTime.Now;
                foreach (var data in KK)
                {
                    if (data.SLKK != "")
                    {
                        var insert = new KIEMKEKHO
                        {
                            MaKiemKe = MaKK,
                            MaNV = maNV,
                            MaSP = data.MaSP,
                            NgayKTKho = now,
                            SoLuongTonKho = data.SoLuong,
                            SoLuongTonQuay = int.Parse(data.SLKK),
                            SoLuongChenhLech = data.SLCL
                        };
                        db.KIEMKEKHOes.Add(insert);

                        var update = (from s in db.SANPHAMs
                                      where s.MaSP == data.MaSP
                                      select s).FirstOrDefault();
                        update.SoLuong = int.Parse(data.SLKK);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Cập Nhật Thành Công");
                SelectTonKho();
            }
        }
    }
}
