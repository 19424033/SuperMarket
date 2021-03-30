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
    /// Interaction logic for NhapHangBC.xaml
    /// </summary>
    public partial class NhapHangBC : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        List<PhieNhapHangClass> list = new List<PhieNhapHangClass>();
        List<PhieuNhapHangDetail> listdetail = new List<PhieuNhapHangDetail>();

        public NhapHangBC()
        {
            InitializeComponent();
        }

        private void TimeS_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            timeE.Text = null;
            LV.ItemsSource = null;
            LVDetail.ItemsSource = null;
            listdetail.Clear();
            list.Clear();
            LVDetail.ItemsSource = null;
            timeE.DisplayDateStart = new DateTime(timeS.SelectedDate.Value.Year, timeS.SelectedDate.Value.Month, timeS.SelectedDate.Value.Day);
        }

        private void TimeE_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (timeS.SelectedDate == null || timeE.SelectedDate == null)
            {
                timeE.Text = "";
            }
            else
            {
                DateTime ngbd = timeS.SelectedDate.Value;
                DateTime ngkt = timeE.SelectedDate.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

                var select = from s in db.PHIEUNHAPHANGs
                             join p in db.NHACUNGCAPs on s.MaNCC equals p.MaNCC
                             join t in db.NHANVIENs on s.MaNV equals t.MaNV
                             where s.NgayLapPhieu >= ngbd && s.NgayLapPhieu <= ngkt
                             && s.TrangThai == 2
                             select new { s.MaPhieuNhapHang, s.TongTien, s.NgayLapPhieu, s.NgayNhapHang, t.TenNV, p.TenNCC };
                foreach (var data in select)
                {
                    var a = new PhieNhapHangClass
                    {
                        MaPhieuNhapHang = data.MaPhieuNhapHang,
                        NgayLapPhieu = data.NgayLapPhieu.Value,
                        NgayNhanHang = data.NgayLapPhieu.Value,
                        TongTien = String.Format("{0:n0}đ ", (int)data.TongTien),
                        TenNV = data.TenNV,
                        TenNCC = data.TenNCC
                    };
                    list.Add(a);
                }

                LV.ItemsSource = list;
            }
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = LV.SelectedItem as PhieNhapHangClass;

            if (item != null)
            {
                LVDetail.ItemsSource = null;
                listdetail.Clear();

                int i = 1;
                var select = from s in db.CHITIETPHIEUNHAPHANGs
                             join p in db.SANPHAMs on s.MaSP equals p.MaSP
                             where s.MaPhieuNhapHang == item.MaPhieuNhapHang
                             select new { p.TenSP, s.SoLuong, s.ThanhTien, s.DonGia, s.MaSP };

                foreach (var data in select)
                {
                    var a = new PhieuNhapHangDetail
                    {
                        STT = i,
                        MaSP = (int)data.MaSP,
                        TenSP = data.TenSP,
                        SoLuong = (int)data.SoLuong,
                        DonGia = (int)data.DonGia,
                        ThanhTien = (int)data.ThanhTien,
                    };
                    listdetail.Add(a);
                }
                LVDetail.ItemsSource = listdetail;
            }
        }
    }
}
