using SuperMarket.Class;
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
    /// Interaction logic for TonHang.xaml
    /// </summary>
    public partial class TonHang : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        List<KiemKeKho> KK = new List<KiemKeKho>();

        LOAISANPHAM maSelLSP;

        public TonHang()
        {
            InitializeComponent();

            Select();
        }

        private void DataListLSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            maSelLSP = dataListLSP.SelectedItem as LOAISANPHAM;

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
        private void KeywordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SelectSP();
        }

        private void KeywordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            hintText.Visibility = Visibility.Hidden;
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
                };
                KK.Add(kkk);
            }

            dataTon.ItemsSource = KK.ToList();
        }

        private void KeywordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (keywordTextBox.Text.Length == 0)
            {
                hintText.Visibility = Visibility.Visible;
            }
        }

    }
}
