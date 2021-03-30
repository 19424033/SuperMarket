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
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for NhapHang.xaml
    /// </summary>
    public partial class NhapHang : Window
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        List<PhieuNhapHangDetail> CTPNH = new List<PhieuNhapHangDetail>();

        public int maNV;

        public NhapHang(int manv)
        {
            InitializeComponent();

            maNV = manv;

            SelectMaPhieu();
        }

        public decimal FinalTotal { get => CTPNH.Sum(detail => (decimal)detail.ThanhTien); }

        void SelectMaPhieu()
        {
            var select = from s in db.PHIEUNHAPHANGs
                         where s.TrangThai == 1
                         select s;

            LVMaPhieu.ItemsSource = select.ToList();
        }

        private void LVMaPhieu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var row = LVMaPhieu.SelectedItem as PHIEUNHAPHANG;
            CTPNH.Clear();
            if (row != null)
            {
                var select = from s in db.CHITIETPHIEUNHAPHANGs
                             join p in db.SANPHAMs on s.MaSP equals p.MaSP
                             where s.MaPhieuNhapHang == row.MaPhieuNhapHang
                             select new { s.MaSP, s.SoLuong, s.ThanhTien, s.DonGia, p.TenSP };
                int i = 1;
                foreach (var data in select)
                {
                    var a = new PhieuNhapHangDetail()
                    {
                        STT = i,
                        MaSP = (int)data.MaSP,
                        TenSP = data.TenSP,
                        DonGia = (int)data.DonGia,
                        SoLuong = (int)data.SoLuong,
                        ThanhTien = (decimal)data.ThanhTien 
                    };
                    i++;
                    CTPNH.Add(a);
                }

                orderListView.ItemsSource = CTPNH.ToList();
                TTien.Content = String.Format("{0:n0}đ ", FinalTotal);
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
            }
        }

        private async void Mua_Click(object sender, RoutedEventArgs e)
        {
            var row = LVMaPhieu.SelectedItem as PHIEUNHAPHANG;

            if (row != null)
            {
                if (MessageBox.Show("Bạn Có Chắc Nhập Hàng ? ", "Thông Báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    var update = (from s in db.PHIEUNHAPHANGs
                                  where s.MaPhieuNhapHang == row.MaPhieuNhapHang
                                  select s).FirstOrDefault();

                    update.MaNV = maNV;
                    update.NgayNhapHang = DateTime.Now;
                    update.TongTien = FinalTotal;
                    if (FinalTotal == 0)
                        update.TrangThai = 3;
                    else
                        update.TrangThai = 2;
                    await db.SaveChangesAsync();

                    foreach (var ctpnh in CTPNH)
                    {
                        var updateCT = (from s in db.CHITIETPHIEUNHAPHANGs
                                        where s.MaPhieuNhapHang == row.MaPhieuNhapHang && s.MaSP == ctpnh.MaSP
                                        select s).FirstOrDefault();
                        updateCT.SoLuong = ctpnh.SoLuong;
                        updateCT.ThanhTien = ctpnh.ThanhTien;

                        var updateSP = (from s in db.SANPHAMs
                                        where s.MaSP == ctpnh.MaSP
                                        select s).FirstOrDefault();

                        updateSP.SoLuong = updateSP.SoLuong + ctpnh.SoLuong;
                        if (ctpnh.SoLuong != 0)
                            updateSP.GiaMuaVao = ctpnh.DonGia;

                        await db.SaveChangesAsync();
                    }
                    MessageBox.Show("Nhập Hàng Thành Công");
                    SelectMaPhieu();
                    orderListView.ItemsSource = null;

                    CTPNH.Clear();
                    TTien.Content = String.Format("{0:n0}đ ", FinalTotal);
                }         
            }
        }
    }
}
