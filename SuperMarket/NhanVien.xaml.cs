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
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        int maNVUpdate;

        IEnumerable<NHANVIEN> select;

        public NhanVien()
        {
            InitializeComponent();

            var select = (from s in db.CHUCVUs
                          where s.MaChucVu != 1
                          select s).ToList();

            foreach (var data in select)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Tag = data.MaChucVu;
                item.Content = data.TenChucVu;
                cbCV.Items.Add(item);
            }

            SelectNgCa();

            cbCV.Text = "";

            Select();
        }

        private void BtnAddNV_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = cbCV.SelectedItem as ComboBoxItem;

            if (txtName.Text == "" || txtQQ.Text == "" || txtPass.Password == "" || txtDT.Text == "" || txtdateBirth.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                var select = (from s in db.NHANVIENs
                              where s.MatKhau.ToString() == txtPass.Password
                              select s).FirstOrDefault();
                if (select == null)
                {
                    var nv = new NHANVIEN()
                    {
                        TenNV = txtName.Text,
                        NgaySinh = DateTime.Parse(txtdateBirth.Text),
                        QueQuan = txtQQ.Text,
                        MatKhau = txtPass.Password,
                        SoDienThoai = txtDT.Text,
                        GioiTinh = checkGT.IsChecked,
                        KichHoat = true,
                        MaChucVu = (int)item.Tag
                    };
                    db.NHANVIENs.Add(nv);
                    MessageBox.Show("Thêm Thành Công");
                    txtName.Text = "";
                    txtdateBirth.Text = "";
                    txtDT.Text = "";
                    txtPass.Password = "";
                    txtQQ.Text = "";
                    cbCV.Text = "";
                    checkGT.IsChecked = false;
                }
                else {
                    MessageBox.Show("Mật Khẩu đã tồn tại");
                }
            }
            db.SaveChanges();
            Select();
        }

        void Select()
        {
            DataNV.ItemsSource = null;

            if (keywordTextBox.Text == "")
            {
                select = from s in db.NHANVIENs
                         where s.KichHoat == true && s.MaChucVu != 1
                         select s;
            }
            else
            {
                select = from s in db.NHANVIENs
                         where s.KichHoat == true && s.MaChucVu != 1
                         && s.TenNV.ToLower().Contains(keywordTextBox.Text.ToLower())
                         select s;
            }

            DataNV.ItemsSource = select.ToList();
        }

        private void DataNV_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var row = DataNV.SelectedItem as NHANVIEN;
            isActiveNV.Visibility = Visibility.Visible;

            if (row != null)
            {
                isActiveNV.IsChecked = row.KichHoat.Value;
                maNVUpdate = row.MaNV;
                txtName.Text = row.TenNV;
                txtdateBirth.Text = Convert.ToDateTime(row.NgaySinh).ToString("dd/MM/yyyy");
                txtDT.Text = row.SoDienThoai;
                txtQQ.Text = row.QueQuan;
                cbCV.Text = (from s in db.CHUCVUs
                            where s.MaChucVu == row.MaChucVu
                            select new { s.TenChucVu }).First().TenChucVu;
                checkGT.IsChecked = row.GioiTinh;
                LoadCa();
                Update(true);
                btnAddNV.IsEnabled = false;
            }
        }

        void Update(bool check)
        {
            btnUpdateNV.IsEnabled = check;
            btnCancelNV.IsEnabled = check;
            updateCaLam.IsEnabled = check;
            DateStart.IsEnabled = check;
            cbN1.IsEnabled = check;
            cbN2.IsEnabled = check;
            cbN3.IsEnabled = check;
            cbN4.IsEnabled = check;
            cbN5.IsEnabled = check;
            cbN6.IsEnabled = check;
            cbN7.IsEnabled = check;

            if(check == false)
            {
                cbN1.Text = "";
                cbN2.Text = "";
                cbN3.Text = "";
                cbN4.Text = "";
                cbN5.Text = "";
                cbN6.Text = "";
                cbN7.Text = "";
            }
        }

        private void BtnUpdateNV_Click(object sender, RoutedEventArgs e)
        {
            var update = (from s in db.NHANVIENs where s.MaNV == maNVUpdate select s).Single();
            if (txtName.Text == "" || txtQQ.Text == "" || txtDT.Text == "" || txtdateBirth.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                if (MessageBox.Show("Bạn Có Chắc Cập Nhật ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    if (txtPass.Password != "")
                    {
                        var select = (from s in db.NHANVIENs
                                      where s.MatKhau.ToString() == txtPass.Password
                                      select s).FirstOrDefault();
                        if (select == null)
                        {
                            ComboBoxItem item = cbCV.SelectedItem as ComboBoxItem;
                            update.TenNV = txtName.Text;
                            update.NgaySinh = DateTime.Parse(txtdateBirth.Text);
                            update.QueQuan = txtQQ.Text;
                            update.MatKhau = txtPass.Password;
                            update.SoDienThoai = txtDT.Text;
                            update.GioiTinh = checkGT.IsChecked;
                            update.MaChucVu = (int)item.Tag;
                            update.KichHoat = isActiveNV.IsChecked;
                            txtName.Text = "";
                            txtdateBirth.Text = "";
                            txtDT.Text = "";
                            txtPass.Password = "";
                            txtQQ.Text = "";
                            cbCV.Text = "";
                            checkGT.IsChecked = false;
                            MessageBox.Show("Cập Nhật Thành Công");
                            Update(false);
                            isActiveNV.Visibility = Visibility.Hidden;
                            btnAddNV.IsEnabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu đã tồn tại");
                        }
                    }
                    else
                    {
                        ComboBoxItem item = cbCV.SelectedItem as ComboBoxItem;
                        update.TenNV = txtName.Text;
                        update.NgaySinh = DateTime.Parse(txtdateBirth.Text);
                        update.QueQuan = txtQQ.Text;
                        update.SoDienThoai = txtDT.Text;
                        update.GioiTinh = checkGT.IsChecked;
                        update.MaChucVu = (int)item.Tag;
                        update.KichHoat = isActiveNV.IsChecked;
                        txtName.Text = "";
                        txtdateBirth.Text = "";
                        txtDT.Text = "";
                        txtPass.Password = "";
                        txtQQ.Text = "";
                        cbCV.Text = "";
                        checkGT.IsChecked = false;
                        MessageBox.Show("Cập Nhật Thành Công");
                        Update(false);
                        isActiveNV.Visibility = Visibility.Hidden;
                        btnAddNV.IsEnabled = true;
                    }
                }
            }

            db.SaveChanges();
            Select();
        }

        private void BtnCancelNV_Click(object sender, RoutedEventArgs e)
        {
            isActiveNV.Visibility = Visibility.Hidden;
            txtName.Text = "";
            txtdateBirth.Text = "";
            txtDT.Text = "";
            txtPass.Password = "";
            txtQQ.Text = "";
            cbCV.Text = "";
            checkGT.IsChecked = false;

            Update(false);
            btnAddNV.IsEnabled = true;

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

        private void DateStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DateStart.SelectedDate != null)
            {
                LoadCa();
            }
        }

        void SelectNgCa()
        {
            foreach (var data in db.CALAMs)
            {
                ComboBoxItem item1 = new ComboBoxItem();
                ComboBoxItem item2 = new ComboBoxItem();
                ComboBoxItem item3 = new ComboBoxItem();
                ComboBoxItem item4 = new ComboBoxItem();
                ComboBoxItem item5 = new ComboBoxItem();
                ComboBoxItem item6 = new ComboBoxItem();
                ComboBoxItem item7 = new ComboBoxItem();

                item1.Tag = item2.Tag = item3.Tag = item4.Tag = item5.Tag = item6.Tag = item7.Tag = data.Id;
                item1.Content = item2.Content = item3.Content = item4.Content = item5.Content = item6.Content = item7.Content = data.SoCa;
                cbN1.Items.Add(item1);
                cbN2.Items.Add(item2);
                cbN3.Items.Add(item3);
                cbN4.Items.Add(item4);
                cbN5.Items.Add(item5);
                cbN6.Items.Add(item6);
                cbN7.Items.Add(item7);
            }

            var date = DateTime.Now;
            while (date.DayOfWeek != DayOfWeek.Monday)
            {
                date = date.AddDays(-1);
            }
            DateStart.SelectedDate = date;

            LoadCa();
        }

        void LoadCa()
        {
                var date = DateStart.SelectedDate.Value;

                txtN1.Text = conVert(date.DayOfWeek.ToString());
                txtN2.Text = conVert(date.AddDays(1).DayOfWeek.ToString());
                txtN3.Text = conVert(date.AddDays(2).DayOfWeek.ToString());
                txtN4.Text = conVert(date.AddDays(3).DayOfWeek.ToString());
                txtN5.Text = conVert(date.AddDays(4).DayOfWeek.ToString());
                txtN6.Text = conVert(date.AddDays(5).DayOfWeek.ToString());
                txtN7.Text = conVert(date.AddDays(6).DayOfWeek.ToString());

            for (int i = 0; i < 7; i++)
            {
                var dateSL = date.AddDays(i);
                var selectNg = (from s in db.PHANCAs
                                from p in db.CALAMs
                                where s.Ca == p.Id && s.MaNV == maNVUpdate && s.NgayLam.Value == dateSL
                                select new { s.NgayLam, p.SoCa }).FirstOrDefault();
                string CaLam = selectNg == null ? "" : selectNg.SoCa;
                LoadCBCaLam(i, CaLam);
            }
        }

        void LoadCBCaLam(int i, string CaLam)
        {
            if (i == 0)
                cbN1.Text = CaLam;
            else if (i == 1)
                cbN2.Text = CaLam;
            else if (i == 2)
                cbN3.Text = CaLam;
            else if (i == 3)
                cbN4.Text = CaLam;
            else if (i == 4)
                cbN5.Text = CaLam;
            else if (i == 5)
                cbN6.Text = CaLam;
            else
                cbN7.Text = CaLam;
        }

        String conVert(string date)
        {
            if (date == "Monday")
                return "Thứ Hai: ";
            else if (date == "Tuesday")
                return "Thứ Ba: ";
            else if (date == "Wednesday")
                return "Thứ Tư: ";
            else if (date == "Thursday")
                return "Thứ Năm: ";
            else if (date == "Friday")
                return "Thứ Sáu: ";
            else if (date == "Saturday")
                return "Thứ Bảy: ";
            else
                return "Chủ Nhật: ";
        }

        int CaLam(int i)
        {
            ComboBoxItem item;
            if (i == 0)
                item = cbN1.SelectedItem as ComboBoxItem;
            else if (i == 1)
                item = cbN2.SelectedItem as ComboBoxItem;
            else if (i == 2)
                item = cbN3.SelectedItem as ComboBoxItem;
            else if (i == 3)
                item = cbN4.SelectedItem as ComboBoxItem;
            else if (i == 4)
                item = cbN5.SelectedItem as ComboBoxItem;
            else if (i == 5)
                item = cbN6.SelectedItem as ComboBoxItem;
            else
                item = cbN7.SelectedItem as ComboBoxItem;
            return (int)item.Tag;
        }

        private void UpdateCaLam_Click(object sender, RoutedEventArgs e)
        {
            if (cbN1.Text == "" || cbN2.Text == "" || cbN3.Text == "" || cbN4.Text == "" || cbN5.Text == "" || cbN6.Text == "" || cbN7.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Ca Làm");
            }
            else
            {
                if (MessageBox.Show("Bạn Muốn Cấp Nhật ?", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    var date = DateStart.SelectedDate.Value;

                    for (int i = 0; i < 7; i++)
                    {
                        var dateE = date.AddDays(i);
                        var selectNg = (from s in db.PHANCAs
                                        where s.MaNV == maNVUpdate && s.NgayLam.Value == dateE
                                        select s).FirstOrDefault();
                        if (selectNg == null)
                        {
                            var a = new PHANCA
                            {
                                MaNV = maNVUpdate,
                                NgayLam = dateE,
                                Ca = CaLam(i)
                            };
                            db.PHANCAs.Add(a);
                        }
                        else
                        {
                            selectNg.Ca = CaLam(i);
                        }
                    }
                    db.SaveChanges();
                }
            }
        }       
    }
}
