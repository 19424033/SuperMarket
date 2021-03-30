using System;
using SuperMarket.Class;
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
using MaterialDesignThemes.Wpf;
using System.ComponentModel;

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for SanPham.xaml
    /// </summary>
    public partial class SanPham : UserControl
    {
        BindingList<ChiTietSanPham> CTSP = new BindingList<ChiTietSanPham>();

        bool checkLSP = false;
        bool closeLSP = false;
        bool insertLSP = false;
        string tenLoaiTruocUpDate;
        List<int> maLoaiList;
        int sttLSP = 0;

        bool checkNCC = false;
        bool closeNCC = false;
        bool insertNCC = false;
        string tenNCCTruocUpDate;
        List<int> maNCCList;
        int sttNCC = 0;

        int maSPUpdate;

        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        public SanPham()
        {
            InitializeComponent();

            SelectListLSP();

            SelectLSP();

            SelectListNCC();

            SelectNCC();

            Select();
        }

        void SelectListLSP()
        {
            var select = (from t in db.LOAISANPHAMs
                          where t.KichHoat == true
                          select t);

            maLoaiList = new List<int>();
            cbLSP.Items.Clear();

            var all = new LOAISANPHAM
            {
                TenLoaiSP = "Tất Cả"
            };
            dataLSP.Items.Clear();
            dataLSP.Items.Add(all);

            foreach (var data in select)
            {
                dataLSP.Items.Add(data);
                ComboBoxItem item = new ComboBoxItem();
                item.Tag = data.MaLoaiSP;
                item.Content = data.TenLoaiSP;
                cbLSP.Items.Add(item);
                maLoaiList.Add(data.MaLoaiSP);
            }


            if (sttLSP >= maLoaiList.Count)
            {
                sttLSP = maLoaiList.Count - 1;
            }
        }

        void SelectListNCC()
        {
            maNCCList = (from t in db.NHACUNGCAPs
                         where t.KichHoat == true
                         select t.MaNCC).ToList();

            if (sttNCC >= maNCCList.Count)
            {
                sttNCC = maNCCList.Count - 1;
            }
        }

        void SelectLSP(int maLSP = 0)
        {
            if (maLoaiList.Count > 0)
            {
                var mL = maLSP == 0 ? maLoaiList[sttLSP] : maLSP;
                var lsp = (from t in db.LOAISANPHAMs
                           where t.KichHoat == true 
                           select t).FirstOrDefault(x => (int)x.MaLoaiSP == mL);

                if (lsp != null)
                {
                    tenLoaiTruocUpDate = lsp.TenLoaiSP;
                    isActiveLSP.IsChecked = lsp.KichHoat;
                    TenLoai.Text = tenLoaiTruocUpDate;
                }
                isActiveLSP.Visibility = Visibility.Visible;
            }
            else
            {
                tenLoaiTruocUpDate = "";
                TenLoai.Text = tenLoaiTruocUpDate;
                insertLSP = true;
                isActiveLSP.Visibility = Visibility.Hidden;
            }
        }

        void SelectNCC()
        {
            if (maNCCList.Count > 0)
            {
                var maNcc = maNCCList[sttNCC];
                var ncc = (from t in db.NHACUNGCAPs
                           where t.KichHoat == true
                           select t).FirstOrDefault(x => (int)x.MaNCC == maNcc);

                if (ncc != null)
                {
                    tenNCCTruocUpDate = ncc.TenNCC;
                    isActiveNCC.IsChecked = ncc.KichHoat;
                    TenNCC.Text = tenNCCTruocUpDate;
                }
                isActiveNCC.Visibility = Visibility.Visible;
            }
            else
            {
                tenNCCTruocUpDate = "";
                TenNCC.Text = tenNCCTruocUpDate;
                insertNCC = true;
                isActiveNCC.Visibility = Visibility.Hidden;
            }
        }

        void Select(string lsp = "")
        {
            dataSP.ItemsSource = null;
            CTSP.Clear();

            if (keywordTextBox.Text == "")
            {
                var select = from s in db.SANPHAMs
                              from t in db.LOAISANPHAMs
                              where s.KichHoat == true && t.MaLoaiSP == s.MaLoaiSP
                              && s.MaLoaiSP.ToString().Contains(lsp)
                              select new { s.MaSP, s.TenSP, s.GiaBanRa, s.KhuyenMai, s.SoLuong, s.KichHoat, s.MaLoaiSP, t.TenLoaiSP };

                foreach (var data in select)
                {
                    var ctsp = new ChiTietSanPham()
                    {
                        TenLoaiSP = data.TenLoaiSP,
                        TenSP = data.TenSP,
                        MaLoaiSP = (int)data.MaLoaiSP,
                        MaSP = data.MaSP,
                        GiaBanRa = (decimal)data.GiaBanRa,
                        SoLuong = (int)data.SoLuong,
                        KichHoat = data.KichHoat.Value,
                        KhuyenMai = (int)data.KhuyenMai
                    };
                    CTSP.Add(ctsp);
                }
                
            }
            else
            {
                var select = from s in db.SANPHAMs
                             from t in db.LOAISANPHAMs
                             where s.KichHoat == true && t.MaLoaiSP == s.MaLoaiSP 
                             && s.MaLoaiSP.ToString().Contains(lsp)
                             && s.TenSP.ToLower().Contains(keywordTextBox.Text.ToLower())
                             select new { s.MaSP, s.TenSP, s.GiaBanRa, s.KhuyenMai, s.SoLuong, s.KichHoat, s.MaLoaiSP, t.TenLoaiSP };

                foreach (var data in select)
                {
                    var ctsp = new ChiTietSanPham()
                    {
                        TenLoaiSP = data.TenLoaiSP,
                        TenSP = data.TenSP,
                        MaLoaiSP = (int)data.MaLoaiSP,
                        MaSP = data.MaSP,
                        GiaBanRa = (decimal)data.GiaBanRa,
                        SoLuong = (int)data.SoLuong,
                        KichHoat = data.KichHoat.Value,
                        KhuyenMai = (int)data.KhuyenMai
                    };
                    CTSP.Add(ctsp);
                }
            }
            dataSP.ItemsSource = CTSP;         
        }

        private void TenLoai_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (checkLSP == true)
            {
                if (tenLoaiTruocUpDate.Length != TenLoai.Text.Length && !insertLSP)
                {
                    btnBack.Visibility = Visibility.Hidden;
                    btnNext.Visibility = Visibility.Hidden;

                    btnThHuy.Content = new PackIcon { Kind = PackIconKind.Close };
                    btnThHuy.Background = Brushes.Red;
                    btnSave.Visibility = Visibility.Visible;

                    closeLSP = true;
                }
            }
            if (checkLSP == false)
            {
                checkLSP = true;
            }
        }

        private void TenNCC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (checkNCC == true)
            {
                if (tenNCCTruocUpDate.Length != TenNCC.Text.Length && !insertNCC)
                {
                    btnBackNCC.Visibility = Visibility.Hidden;
                    btnNextNCC.Visibility = Visibility.Hidden;

                    btnThHuyNCC.Content = new PackIcon { Kind = PackIconKind.Close };
                    btnThHuyNCC.Background = Brushes.Red;
                    btnSaveNCC.Visibility = Visibility.Visible;

                    closeNCC = true;
                }
            }
            if (checkNCC == false)
            {
                checkNCC = true;
            }
        }

        private void BtnThHuy_Click(object sender, RoutedEventArgs e)
        {
            if (!closeLSP)
            {
                tenLoaiTruocUpDate = "";
                TenLoai.Text = "";

                btnBack.Visibility = Visibility.Hidden;
                btnNext.Visibility = Visibility.Hidden;

                btnThHuy.Content = new PackIcon { Kind = PackIconKind.Close };
                btnThHuy.Background = Brushes.Red;
                btnSave.Visibility = Visibility.Visible;
                closeLSP = true;
                insertLSP = true;
                isActiveLSP.Visibility = Visibility.Hidden;
            }
            else
            {
                btnBack.Visibility = Visibility.Visible;
                btnNext.Visibility = Visibility.Visible;

                btnThHuy.Content = new PackIcon { Kind = PackIconKind.Plus };
                btnThHuy.Background = Brushes.DeepSkyBlue;
                btnSave.Visibility = Visibility.Hidden;
                TenLoai.Text = tenLoaiTruocUpDate;
                closeLSP = false;
                insertLSP = false;
                isActiveLSP.Visibility = Visibility.Visible;
                SelectLSP();
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (TenLoai.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Thông Báo");
            }
            else
            {
                if (insertLSP)
                {
                    var lsp = new LOAISANPHAM()
                    {
                        TenLoaiSP = TenLoai.Text,
                        KichHoat = true
                    };
                    db.LOAISANPHAMs.Add(lsp);
                    MessageBox.Show("Thêm Thành Công");
                    db.SaveChanges();
                    SelectListLSP();
                    sttLSP = maLoaiList.Count - 1;
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Cập Nhật ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var maL = maLoaiList[sttLSP];
                        var update = (from s in db.LOAISANPHAMs where s.MaLoaiSP == maL select s).Single();
                        update.TenLoaiSP = TenLoai.Text;
                        update.KichHoat = isActiveLSP.IsChecked;
                        MessageBox.Show("Cập Nhật Thành Công");
                        db.SaveChanges();
                        SelectListLSP();
                    }
                }

                btnBack.Visibility = Visibility.Visible;
                btnNext.Visibility = Visibility.Visible;

                btnThHuy.Content = new PackIcon { Kind = PackIconKind.Plus };
                btnThHuy.Background = Brushes.DeepSkyBlue;
                btnSave.Visibility = Visibility.Hidden;
                TenLoai.Text = tenLoaiTruocUpDate;
                closeLSP = false;
                insertLSP = false;
                isActiveLSP.Visibility = Visibility.Visible;
                SelectLSP();
            }
        }

        private void BtnThHuyNCC_Click(object sender, RoutedEventArgs e)
        {
            if (!closeNCC)
            {
                tenNCCTruocUpDate = "";
                TenNCC.Text = "";

                btnBackNCC.Visibility = Visibility.Hidden;
                btnNextNCC.Visibility = Visibility.Hidden;

                btnThHuyNCC.Content = new PackIcon { Kind = PackIconKind.Close };
                btnThHuyNCC.Background = Brushes.Red;
                btnSaveNCC.Visibility = Visibility.Visible;
                closeNCC = true;
                insertNCC = true;
                isActiveNCC.Visibility = Visibility.Hidden;
            }
            else
            {
                btnBackNCC.Visibility = Visibility.Visible;
                btnNextNCC.Visibility = Visibility.Visible;

                btnThHuyNCC.Content = new PackIcon { Kind = PackIconKind.Plus };
                btnThHuyNCC.Background = Brushes.DeepSkyBlue;
                btnSaveNCC.Visibility = Visibility.Hidden;
                TenNCC.Text = tenNCCTruocUpDate;
                closeNCC = false;
                insertNCC = false;
                isActiveNCC.Visibility = Visibility.Visible;
                SelectNCC();
            }
        }

        private void BtnSaveNCC_Click(object sender, RoutedEventArgs e)
        {
            if (TenNCC.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin", "Thông Báo");
            }
            else
            {
                if (insertNCC)
                {
                    var ncc = new NHACUNGCAP()
                    {
                        TenNCC = TenNCC.Text,
                        KichHoat = true
                    };
                    db.NHACUNGCAPs.Add(ncc);
                    MessageBox.Show("Thêm Thành Công");
                    db.SaveChanges();
                    SelectListNCC();
                    sttNCC = maNCCList.Count - 1;
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Cập Nhật ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        var mancc = maNCCList[sttNCC];
                        var update = (from s in db.NHACUNGCAPs where s.MaNCC == mancc select s).Single();
                        update.TenNCC = TenNCC.Text;
                        update.KichHoat = isActiveNCC.IsChecked;
                        MessageBox.Show("Cập Nhật Thành Công");
                        db.SaveChanges();
                    }
                }

                btnBackNCC.Visibility = Visibility.Visible;
                btnNextNCC.Visibility = Visibility.Visible;

                btnThHuyNCC.Content = new PackIcon { Kind = PackIconKind.Plus };
                btnThHuyNCC.Background = Brushes.DeepSkyBlue;
                btnSaveNCC.Visibility = Visibility.Hidden;

                closeNCC = false;
                insertNCC = false;
                isActiveNCC.Visibility = Visibility.Visible;
                SelectListNCC();
                SelectNCC();
            }
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if (sttLSP < maLoaiList.Count - 1)
            {
                sttLSP++;
            }
            SelectLSP();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

            if (sttLSP > 0)
            {
                sttLSP--;
            }
            SelectLSP();
        }

        private void BtnNextNCC_Click(object sender, RoutedEventArgs e)
        {
            if (sttNCC < maNCCList.Count - 1)
            {
                sttNCC++;
            }
            SelectNCC();
        }

        private void BtnBackNCC_Click(object sender, RoutedEventArgs e)
        {
            if (sttNCC > 0)
            {
                sttNCC--;
            }
            SelectNCC();
        }

        private void IsActiveNCC_Click(object sender, RoutedEventArgs e)
        {
            btnBackNCC.Visibility = Visibility.Hidden;
            btnNextNCC.Visibility = Visibility.Hidden;

            btnThHuyNCC.Content = new PackIcon { Kind = PackIconKind.Close };
            btnThHuyNCC.Background = Brushes.Red;
            btnSaveNCC.Visibility = Visibility.Visible;
            closeNCC = true;
            insertNCC = false;
        }

        private void IsActiveLSP_Click(object sender, RoutedEventArgs e)
        {
            btnBack.Visibility = Visibility.Hidden;
            btnNext.Visibility = Visibility.Hidden;

            btnThHuy.Content = new PackIcon { Kind = PackIconKind.Close };
            btnThHuy.Background = Brushes.Red;
            btnSave.Visibility = Visibility.Visible;
            closeLSP = true;
            insertLSP = false;
        }

        private void KeywordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            hintText.Visibility = Visibility.Hidden;
        }

        private void KeywordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Select();
        }

        private void KeywordTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (keywordTextBox.Text.Length == 0)
            {
                hintText.Visibility = Visibility.Visible;
            }
        }

        private void DataLSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = dataLSP.SelectedItem as LOAISANPHAM;
            if (row != null)
            {
                if (row.MaLoaiSP == 0)
                    Select();
                else
                    Select(row.MaLoaiSP.ToString());
            }
        }

        private void DataLSP_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = dataLSP.SelectedItem as LOAISANPHAM;
            SelectLSP(row.MaLoaiSP);
            int i = 0;
            foreach (var data in maLoaiList)
            {
                if (data == row.MaLoaiSP)
                {
                    sttLSP = i;
                }
                i++;
            }
        }

        private void DataSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtTenSP.Text = "";
            cbLSP.Text = "";
            txtDG.Text = "";
            cbLSP.Text = "";
            txtKM.Text = "";
            isActiveSP.Visibility = Visibility.Hidden;

            btnUpdateSP.IsEnabled = false;
            btnCancelSP.IsEnabled = false;
            btnAddSP.IsEnabled = true;

            var row = dataSP.SelectedItem as ChiTietSanPham;
            isActiveSP.Visibility = Visibility.Visible;

            if (row != null)
            {
                isActiveSP.IsChecked = row.KichHoat;
                maSPUpdate = row.MaSP;
                txtTenSP.Text = row.TenSP;
                txtDG.Text = ((int)row.GiaBanRa).ToString();
                txtKM.Text = row.KhuyenMai.ToString();
                cbLSP.Text = (from s in db.LOAISANPHAMs
                              where s.MaLoaiSP == row.MaLoaiSP
                              select new { s.TenLoaiSP }).First().TenLoaiSP;

                btnUpdateSP.IsEnabled = true;
                btnAddNCC.IsEnabled = true;
                btnCancelSP.IsEnabled = true;
                btnAddSP.IsEnabled = false;
            }
        }

        private void BtnAddSP_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = cbLSP.SelectedItem as ComboBoxItem;
            if (txtTenSP.Text == "" || cbLSP.Text == "" || txtDG.Text == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else
            {
                var sp = new SANPHAM
                {
                    TenSP = txtTenSP.Text,
                    MaLoaiSP = (int)item.Tag,
                    GiaBanRa = decimal.Parse(txtDG.Text),
                    SoLuong = 0,
                    KichHoat = true,
                    KhuyenMai = txtKM.Text == "" ? 0 : int.Parse(txtKM.Text)
                };
                db.SANPHAMs.Add(sp);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành Công");

                var a = (from s in db.SANPHAMs
                         select s).Max(s => s.MaSP);

                NhaCungCapList ncc = new NhaCungCapList(a);
                ncc.ShowDialog();

                txtTenSP.Text = "";
                cbLSP.Text = "";
                txtDG.Text = "";
                cbLSP.Text = "";
                txtKM.Text = "";

                Select();
            }
        }

        private void BtnUpdateSP_Click(object sender, RoutedEventArgs e)
        {
            var update = (from s in db.SANPHAMs where s.MaSP == maSPUpdate select s).Single();

            ComboBoxItem item = cbLSP.SelectedItem as ComboBoxItem;
            if (txtTenSP.Text == "" || cbLSP.Text == "" || txtDG.Text == "")
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Chắc Cập Nhật ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    update.TenSP = txtTenSP.Text;
                    update.MaLoaiSP = (int)item.Tag;
                    update.GiaBanRa = decimal.Parse(txtDG.Text);
                    update.KichHoat = isActiveSP.IsChecked;
                    update.KhuyenMai = txtKM.Text == "" ? 0 : int.Parse(txtKM.Text);

                    MessageBox.Show("Cập Nhật Thành Công");

                    txtTenSP.Text = "";
                    cbLSP.Text = "";
                    txtDG.Text = "";
                    cbLSP.Text = "";
                    txtKM.Text = "";
                }
                isActiveSP.Visibility = Visibility.Hidden;
                btnUpdateSP.IsEnabled = false;
                btnAddNCC.IsEnabled = false;
                btnCancelSP.IsEnabled = false;
                btnAddSP.IsEnabled = true;
                db.SaveChanges();
                Select();
            }
        }

        private void BtnCancelSP_Click(object sender, RoutedEventArgs e)
        {
            isActiveSP.Visibility = Visibility.Hidden;
            txtTenSP.Text = "";
            txtDG.Text = "";
            txtKM.Text = "";
            cbLSP.Text = "";

            btnUpdateSP.IsEnabled = false;
            btnAddNCC.IsEnabled = false;
            btnCancelSP.IsEnabled = false;
            btnAddSP.IsEnabled = true;
        }

        private void BtnAddNCC_Click(object sender, RoutedEventArgs e)
        {
            NhaCungCapList ncc = new NhaCungCapList(maSPUpdate);
            ncc.ShowDialog();
        }

    }
}
