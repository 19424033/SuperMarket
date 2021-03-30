using SuperMarket.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for LapHoaDon.xaml
    /// </summary>
    public partial class LapHoaDon : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        int KM = 0;
        decimal gia = 0;
        int stt = 1;

        int maNV;

        BindingList<HoaDonDetail> CTPNH = new BindingList<HoaDonDetail>();

        public decimal FinalTotal { get => CTPNH.Sum(detail => (decimal)detail.thanhTien); }
        public decimal Discount { get => CTPNH.Sum(detail => (decimal)detail.discount); }
        public LapHoaDon(int manv)
        {
            InitializeComponent();

            maNV = manv;
        }

        void Select()
        {
            if (txtMaSP.Text == "")
            {
                txtTenSP.Text = "";
                txtPrice.Text = "";
                txtQuan.Text = "";
                txtQuan.IsEnabled = false;
                KM = 0;
                gia = 0;
            }
            else
            {
                var select = (from s in db.SANPHAMs
                              where s.KichHoat == true
                              && s.MaSP.ToString().ToLower().Contains(txtMaSP.Text.ToLower())
                              select s).FirstOrDefault();
                if (select != null)
                {
                    txtTenSP.Text = select.TenSP;
                    txtPrice.Text = ((int)select.GiaBanRa).ToString();
                    txtQuan.Text = "1";
                    KM = (int)select.KhuyenMai;
                    gia = select.GiaMuaVao != null ? (decimal)select.GiaMuaVao : 0;
                    txtQuan.IsEnabled = true;
                }
                else
                {
                    txtTenSP.Text = "";
                    txtPrice.Text = "";
                    txtQuan.Text = "";
                    txtQuan.IsEnabled = false;
                    KM = 0;
                    gia = 0;
                }
            }
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {

            if (txtTenKH.Text == "" || txtTenSP.Text == "" || txtQuan.Text == "")
            {
                if (txtTenKH.Text == "")
                    MessageBox.Show("Mã Khách Hàng Không Tồn Tại");
                else if (txtTenSP.Text == "")
                    MessageBox.Show("Vui Lòng Thêm Sản Phẩm");
                else
                    MessageBox.Show("Vui Lòng Thêm Số Lượng Sản Phẩm");
            }
            else
            {
                txtKH.IsEnabled = false;
                btnKH.IsEnabled = false;
                var foundDetail = CTPNH.FirstOrDefault(p => p.maSP == int.Parse(txtMaSP.Text));

                if (foundDetail != null)
                {
                    foundDetail.soLuong = foundDetail.soLuong + int.Parse(txtQuan.Text);
                    foundDetail.discount = foundDetail.soLuong * foundDetail.donGia * foundDetail.khuyenMai / 100;
                    foundDetail.thanhTien = foundDetail.soLuong * foundDetail.donGia;
                }
                else
                {
                    var ctpnh = new HoaDonDetail()
                    {
                        STT = stt,
                        tenSP = txtTenSP.Text,
                        maSP = int.Parse(txtMaSP.Text),
                        soLuong = int.Parse(txtQuan.Text),
                        donGia = int.Parse(txtPrice.Text),
                        khuyenMai = KM,
                        giacost = gia,
                        discount = int.Parse(txtQuan.Text) * int.Parse(txtPrice.Text) * KM / 100,
                        thanhTien = int.Parse(txtQuan.Text) * int.Parse(txtPrice.Text)
                    };
                    CTPNH.Add(ctpnh);
                    stt++;
                }
                orderListView.ItemsSource = CTPNH;
                txtTongTien.Text = String.Format("{0:n0}đ ", FinalTotal);
                txtChietKhau.Text = String.Format("{0:n0}đ ", Discount);
                txtThanhToan.Text = String.Format("{0:n0}đ ", FinalTotal - Discount);
                txtMaSP.Text = "";
            }
        }

        private void DeleteSP_Click(object sender, RoutedEventArgs e)
        {
            var row = orderListView.SelectedItem as HoaDonDetail;

            if(row !=null)
            {
                for (int i = row.STT + 1; i <= CTPNH.Count; i++)
                {
                    var foundDetail = CTPNH.FirstOrDefault(p => p.STT == i);
                    foundDetail.STT = foundDetail.STT - 1;
                }
                stt--;
                CTPNH.Remove(row);
                orderListView.ItemsSource = CTPNH;
                txtTongTien.Text = String.Format("{0:n0}đ ", FinalTotal);
                txtChietKhau.Text = String.Format("{0:n0}đ ", Discount);
                txtThanhToan.Text = String.Format("{0:n0}đ ", FinalTotal - Discount);

                if (CTPNH.Count() == 0)
                {
                    txtKH.IsEnabled = true;
                    btnKH.IsEnabled = true;
                }
            }
        }

        private void TxtMaSP_TextChanged(object sender, TextChangedEventArgs e)
        {
            Select();
        }

        private void txtQuan_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtKH_TextChanged(object sender, TextChangedEventArgs e)
        {
            SelectKH();
        }

        void SelectKH()
        {
            if (txtKH.Text == "")
            {
                txtTenKH.Text = "Khách Vãng Lai";
            }
            else
            {
                var select = (from s in db.KHACHHANGs
                              where s.MaKH.ToString().ToLower().Contains(txtKH.Text.ToLower())
                              select s).FirstOrDefault();
                if (select != null)
                {
                    txtTenKH.Text = select.TenKH;
                }
                else
                {
                    txtTenKH.Text = "";
                }
            }
        }

        private void OrderListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = orderListView.SelectedItem as HoaDonDetail;

            if (row != null)
            {
                UpdateQuan update = new UpdateQuan(row.soLuong.ToString());
                update.ShowDialog();

                var foundDetail = CTPNH.FirstOrDefault(p => p.maSP == row.maSP);

                foundDetail.soLuong = int.Parse(update.soLuong);
                foundDetail.thanhTien = foundDetail.soLuong * foundDetail.donGia;

                txtTongTien.Text = String.Format("{0:n0}đ ", FinalTotal);
                txtChietKhau.Text = String.Format("{0:n0}đ ", Discount);
                txtThanhToan.Text = String.Format("{0:n0}đ ", FinalTotal - Discount);
            }

        }

        private void BtnTM_Click(object sender, RoutedEventArgs e)
        {
            Mua(1);
        }

        private void BtnThe_Click(object sender, RoutedEventArgs e)
        {
            Mua(2);
        }

        void Mua(int maHT)
        {
            if (CTPNH.Count() == 0)
            {
                MessageBox.Show("Vui Lòng Thêm Sản Phẩm");
            }
            else
            {
                int tiendu = -1;
                if (maHT == 1)
                {
                    ThanhToan ttoan = new ThanhToan((int)(FinalTotal - Discount));
                    ttoan.ShowDialog();
                    tiendu = ttoan.soTienDu;                 
                }

                if (tiendu != 0)
                {
                    if (maHT == 1)
                        MessageBox.Show(String.Format("Tiền Dư: {0:n0}đ ", tiendu));
                    else
                        MessageBox.Show("Đã Thanh Toán Thẻ Visa/MasterCard");
                    DateTime now = DateTime.Now;

                    var hd = new HOADON
                    {
                        MaNV = maNV,
                        MaKH = txtKH.Text == "" ? 0 : int.Parse(txtKH.Text),
                        NgayLapHD = now,
                        DiemThuong = txtKH.Text == "" ? 0 : (int)((FinalTotal - Discount) / 1000),
                        ThanhTien = FinalTotal - Discount
                    };
                    db.HOADONs.Add(hd);

                    var tt = new THANHTOAN
                    {
                        MaHD = hd.MaHD,
                        MaHinhThucTT = maHT,
                        ThanhTien = FinalTotal - Discount,
                        NgayThanhToan = now
                    };
                    db.THANHTOANs.Add(tt);

                    db.SaveChanges();

                    foreach (var data in CTPNH)
                    {
                        var cthd = new CHITIETHOADON
                        {
                            MaHD = hd.MaHD,
                            MaSP = data.maSP,
                            SoLuong = data.soLuong,
                            DonGia = data.donGia,
                            ThanhTien = data.thanhTien,
                            Discount = data.discount,
                            TienVon = data.giacost
                        };
                        db.CHITIETHOADONs.Add(cthd);

                        var update = (from s in db.SANPHAMs
                                      where s.MaSP == data.maSP
                                      select s).FirstOrDefault();
                        update.SoLuong = update.SoLuong - data.soLuong;
                        db.SaveChanges();
                    }
                    if (txtKH.Text != "")
                    {
                        var updateKH = (from s in db.KHACHHANGs
                                        where s.MaKH.ToString().ToLower().Contains(txtKH.Text.ToLower())
                                        select s).FirstOrDefault();

                        updateKH.DiemThuongTichLuy = updateKH.DiemThuongTichLuy + hd.DiemThuong;
                        updateKH.NgayMuaGanNhat = now;
                        db.SaveChanges();
                        MessageBox.Show(txtTenKH.Text + " Đã Tích Được " + updateKH.DiemThuongTichLuy + " Điểm Rồi");
                    }

                    CTPNH = new BindingList<HoaDonDetail>();
                    orderListView.ItemsSource = CTPNH;
                    txtTongTien.Text = "0";
                    txtChietKhau.Text = "0";
                    txtThanhToan.Text = "0";
                    txtMaSP.Text = "";
                    txtKH.Text = "";

                    txtKH.IsEnabled = true;
                }
            }
        }

        private void BtnMaSP_Click(object sender, RoutedEventArgs e)
        {
            DanhSachKH_SP list = new DanhSachKH_SP(2);
            list.ShowDialog();
            txtMaSP.Text = list.MA;
        }

        private void BtnKH_Click(object sender, RoutedEventArgs e)
        {
            DanhSachKH_SP list = new DanhSachKH_SP(1);
            list.ShowDialog();
            txtKH.Text = list.MA;
        }
    }
}