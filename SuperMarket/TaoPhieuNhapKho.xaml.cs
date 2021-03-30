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
    /// Interaction logic for TaoPhieuNhapKho.xaml
    /// </summary>
    public partial class TaoPhieuNhapKho : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        BindingList<PhieuNhapHangDetail> CTPNH = new BindingList<PhieuNhapHangDetail>();

        int stt = 1;

        int maNV;

        public TaoPhieuNhapKho(int manv)
        {
            InitializeComponent();

            maNV = manv;
        }

        public decimal FinalTotal { get => CTPNH.Sum(detail => (decimal)detail.ThanhTien); }

        private void TxtMaNCC_TextChanged(object sender, TextChangedEventArgs e)
        {
            SelectNCC();
        }

        private void TxtMaH_TextChanged(object sender, TextChangedEventArgs e)
        {
            SelectSP();
        }

        void SelectNCC()
        {
            if (txtMaNCC.Text == "")
            {
                txtTenNCC.Text = "";
                txtMaH.Text = "";
                txtSL.Text = "";
                btnSP.IsEnabled = false;
                txtMaH.IsEnabled = false;
            }
            else
            {
                var select = (from s in db.NHACUNGCAPs
                              where s.KichHoat == true
                              && s.MaNCC.ToString().ToLower().Contains(txtMaNCC.Text.ToLower())
                              select s).FirstOrDefault();
                if (select != null)
                {           
                    txtMaH.IsEnabled = true;
                    btnSP.IsEnabled = true;
                    txtTenNCC.Text = select.TenNCC;
                }
                else
                {
                    txtTenNCC.Text = "";
                    txtMaH.Text = "";
                    btnSP.IsEnabled = false;
                    txtMaH.IsEnabled = false;
                }
            }
        }

        void SelectSP()
        {
            if (txtMaH.Text == "")
            {
                txtTenH.Text = "";
                txtDG.Text = "";
                txtSL.Text = "";
                txtSL.IsEnabled = false;
                txtDG.IsEnabled = false;
            }
            else
            {            
                var select = (from p in db.NCC_SP
                              join a in db.SANPHAMs on p.MaSP equals a.MaSP
                              where p.KichHoat == true && a.KichHoat == true
                              && p.MaNCC.ToString().ToLower().Contains(txtMaNCC.Text.ToLower())
                              && p.MaSP.ToString().ToLower().Contains(txtMaH.Text.ToLower())
                              select a).FirstOrDefault();
                if(select != null)
                {
                    txtSL.Text = "1";
                    txtSL.IsEnabled = true;
                    txtDG.IsEnabled = true;
                    txtTenH.Text = select.TenSP;
                    if (select.GiaMuaVao != null)
                        txtDG.Text = ((int)select.GiaMuaVao).ToString();
                    else
                        txtDG.Text = "";
                }
                else
                {
                    txtTenH.Text = "";
                    txtDG.Text = "";
                    txtSL.Text = "";
                    txtSL.IsEnabled = false;
                    txtDG.IsEnabled = false;
                }
            }
        }

        private void BtnNCC_Click(object sender, RoutedEventArgs e)
        {
            ListDS list = new ListDS();
            list.ShowDialog();
            txtMaNCC.Text = list.MA;
            txtMaH.Text = "";
        }

        private void BtnSP_Click(object sender, RoutedEventArgs e)
        {
            ListDS list = new ListDS(txtMaNCC.Text);
            list.ShowDialog();
            txtMaH.Text = list.MA;
        }

        private void TxtSL_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSL.Text == "" || txtDG.Text == "")
            {
                txtTT.Text = "";
            }
            else
            {
                decimal a = decimal.Parse(txtSL.Text);
                decimal b = decimal.Parse(txtDG.Text);
                txtTT.Text = String.Format("{0:n0} ", a * b);
            }
        }

        private void TxtSL_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtDG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtSL.Text == "" || txtDG.Text == "")
            {
                txtTT.Text = "";
            }
            else
            {
                decimal a = decimal.Parse(txtSL.Text);
                decimal b = decimal.Parse(txtDG.Text);
                txtTT.Text = String.Format("{0:n0} ", a * b);
            }
        }

        private void TxtDG_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {

            if (txtTenNCC.Text == "" && txtMaNCC.IsEnabled == true)
                MessageBox.Show("Vui Lòng Nhập Nhà Cung Cấp");
            else if(txtTenH.Text == "")
                MessageBox.Show("Vui Lòng Nhập Sản Phẩm");
            else if(txtSL.Text =="" || txtDG.Text  =="")
                MessageBox.Show("Vui Lòng Số Lượng hoặc Đơn Giá");
            else
            {
                txtMaNCC.IsEnabled = false;
                btnNCC.IsEnabled = false;
                var foundDetail = CTPNH.FirstOrDefault(p => p.MaSP == int.Parse(txtMaH.Text));

                if (foundDetail != null)
                {
                    foundDetail.SoLuong = foundDetail.SoLuong + int.Parse(txtSL.Text);
                    foundDetail.ThanhTien = foundDetail.SoLuong * foundDetail.DonGia;
                }
                else
                {
                    var ctpnh = new PhieuNhapHangDetail()
                    {
                        STT = stt,
                        TenSP = txtTenH.Text,
                        MaSP = int.Parse(txtMaH.Text),
                        SoLuong = int.Parse(txtSL.Text),
                        DonGia = decimal.Parse(txtDG.Text),
                        ThanhTien = decimal.Parse(txtTT.Text)
                    };
                    stt++;
                    CTPNH.Add(ctpnh);
                }
                orderListView.ItemsSource = CTPNH;
                TTien.Content = String.Format("{0:n0}đ ", FinalTotal);
            }
        }

        private void DeleteSP_Click(object sender, RoutedEventArgs e)
        {

            var row = orderListView.SelectedItem as PhieuNhapHangDetail;

            if (row != null)
            {
                for (int i = row.STT + 1; i <= CTPNH.Count; i++)
                {
                    var foundDetail = CTPNH.FirstOrDefault(p => p.STT == i);
                    foundDetail.STT = foundDetail.STT - 1;
                }
                stt--;
                CTPNH.Remove(row);
                orderListView.ItemsSource = CTPNH;
                TTien.Content = String.Format("{0:n0}đ ", FinalTotal);

                if (CTPNH.Count() == 0)
                {
                    txtMaNCC.IsEnabled = true;
                    btnNCC.IsEnabled = true;
                }
            }
        }

        private void BtnMua_Click(object sender, RoutedEventArgs e)
        {
            if (CTPNH.Count() == 0)
            {
                MessageBox.Show("Vui Lòng Thêm Sản Phẩm");
            }
            else
            {
                var order = new PHIEUNHAPHANG()
                {
                    MaNV = maNV,
                    NgayLapPhieu = DateTime.Now,
                    TongTien = decimal.Parse(TTien.Content.ToString().Replace("đ","").Replace(",","")),
                    MaNCC= int.Parse(txtMaNCC.Text),
                    TrangThai = 1
                };
                db.PHIEUNHAPHANGs.Add(order);
                db.SaveChanges();

                foreach (var ctpnh in CTPNH)
                {
                    var orderDetail = new CHITIETPHIEUNHAPHANG()
                    {
                        MaPhieuNhapHang = order.MaPhieuNhapHang,
                        MaSP = ctpnh.MaSP,
                        SoLuong = ctpnh.SoLuong,
                        DonGia = ctpnh.DonGia,
                        ThanhTien = ctpnh.ThanhTien
                    };
                    db.CHITIETPHIEUNHAPHANGs.Add(orderDetail);
                }

                db.SaveChanges();

                CTPNH = new BindingList<PhieuNhapHangDetail>();
                orderListView.ItemsSource = CTPNH;
                TTien.Content = null;

                txtMaH.Text = "";
                txtMaNCC.Text = "";
                MessageBox.Show("Đơn hàng " + order.MaPhieuNhapHang + " đã tạo thành công");
            }
        }

        private void OrderListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = orderListView.SelectedItem as PhieuNhapHangDetail;

            if (row != null)
            {
                UpdateQuan update = new UpdateQuan(row.SoLuong.ToString());
                update.ShowDialog();

                var foundDetail = CTPNH.FirstOrDefault(p => p.MaSP == row.MaSP);

                foundDetail.SoLuong = int.Parse(update.soLuong);
                foundDetail.ThanhTien = foundDetail.SoLuong * foundDetail.DonGia;

                TTien.Content = String.Format("{0:n0}đ ", FinalTotal);

                if (CTPNH.Count() == 0)
                {
                    txtMaNCC.IsEnabled = true;
                }
            }
        }
    }
}
