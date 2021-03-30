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
    /// Interaction logic for BanHang.xaml
    /// </summary>
    public partial class BanHang : UserControl
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        List<HoaDonClass> list = new List<HoaDonClass>();
        List<HoaDonDetail> listdetail = new List<HoaDonDetail>();

        public BanHang()
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

                var select = from s in db.HOADONs
                             join p in db.KHACHHANGs on s.MaKH equals p.MaKH
                             join t in db.THANHTOANs on s.MaHD equals t.MaHD
                             join i in db.HINHTHUCTHANHTOANs on t.MaHinhThucTT equals i.MaHinhThucTT
                             where s.NgayLapHD >= ngbd && s.NgayLapHD <= ngkt
                             select new { s.MaHD, s.NgayLapHD, s.ThanhTien, i.TenHinhThucTT, p.TenKH, s.MaKH, s.DiemThuong };
                foreach(var data in select)
                {
                    var a = new HoaDonClass
                    {
                        MaHD = data.MaHD,
                        NgayLapHD = data.NgayLapHD.Value,
                        ThanhTien = String.Format("{0:n0}đ ", (int)data.ThanhTien),
                        TenHinhThucTT = data.TenHinhThucTT,
                        TenKH = data.TenKH,
                        DiemThuong = data.MaKH == 0 ? "" : data.DiemThuong.ToString()
                    };
                    list.Add(a);
                }

                LV.ItemsSource = list;
            }
        }
        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = LV.SelectedItem as HoaDonClass;

            if(item != null)
            {
                LVDetail.ItemsSource = null;
                listdetail.Clear();

                int i = 1;
                var select = from s in db.CHITIETHOADONs
                             join p in db.SANPHAMs on s.MaSP equals p.MaSP
                             where s.MaHD == item.MaHD
                             select new { p.TenSP, s.SoLuong, s.ThanhTien, s.DonGia, s.Discount };

                foreach(var data in select)
                {
                    var a = new HoaDonDetail
                    {
                        STT =i,
                        tenSP = data.TenSP,
                        soLuong = (int)data.SoLuong,
                        donGia = (int)data.DonGia,
                        thanhTien = (int)data.ThanhTien,
                        discount = (int)data.Discount,
                    };
                    listdetail.Add(a);
                }
                LVDetail.ItemsSource = listdetail;
               
            }
        }
    }
}
