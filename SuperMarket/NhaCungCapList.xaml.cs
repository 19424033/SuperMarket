using System;
using System.Collections.Generic;
using System.Data;
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

namespace SuperMarket
{
    /// <summary>
    /// Interaction logic for NhaCungCapList.xaml
    /// </summary>
    public partial class NhaCungCapList : Window
    {
        QLSieuThiMiNiEntities db = new QLSieuThiMiNiEntities();

        List<NHACUNGCAP> list1 = new List<NHACUNGCAP>();
        List<NHACUNGCAP> list2 = new List<NHACUNGCAP>();

        int maSP;

        public NhaCungCapList(int masp)
        {
            InitializeComponent();

            maSP = masp;

            dataNCCSP.ItemsSource = null;

            var NCC = from s in db.NHACUNGCAPs
                      where s.KichHoat == true
                      select s;
            var NccSP = from s in db.NCC_SP
                        from n in db.NHACUNGCAPs
                        from p in db.SANPHAMs
                        where s.KichHoat == true && p.KichHoat == true && s.MaNCC == n.MaNCC && p.MaSP == s.MaSP && s.MaSP == maSP && n.KichHoat == true
                        select n;

            var sel = NCC.Except(NccSP);

            list1 = sel.ToList();

            list2 = NccSP.ToList();

            dataNCC.ItemsSource = list1;
            dataNCCSP.ItemsSource = list2;
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            var row = dataNCC.SelectedItem as NHACUNGCAP;

            if (row != null)
            {
                dataNCC.ItemsSource = null;
                dataNCCSP.ItemsSource = null;
                list2.Add(row);
                list1.Remove(row);
                dataNCC.ItemsSource = list1;
                dataNCCSP.ItemsSource = list2;
            }
        }

        private void BtnOKALL_Click(object sender, RoutedEventArgs e)
        {
            dataNCC.ItemsSource = null;
            dataNCCSP.ItemsSource = null;

           while(list1.Count > 0)
            {
                list2.Add(list1[0]);
                list1.Remove(list1[0]);
            }
            dataNCC.ItemsSource = list1;
            dataNCCSP.ItemsSource = list2;
        }


        private void BtnCan_Click(object sender, RoutedEventArgs e)
        {
            var row = dataNCCSP.SelectedItem as NHACUNGCAP;

            if (row != null)
            {
                dataNCC.ItemsSource = null;
                dataNCCSP.ItemsSource = null;
                list2.Remove(row);
                list1.Add(row);
                dataNCC.ItemsSource = list1;
                dataNCCSP.ItemsSource = list2;
            }
        }

        private void BtnCanALL_Click(object sender, RoutedEventArgs e)
        {
            dataNCC.ItemsSource = null;
            dataNCCSP.ItemsSource = null;

            while (list2.Count > 0)
            {
                list1.Add(list2[0]);
                list2.Remove(list2[0]);
            }
            dataNCC.ItemsSource = list1;
            dataNCCSP.ItemsSource = list2;
        }

        private void BtnCN_Click(object sender, RoutedEventArgs e)
        {
            var update = (from s in db.NCC_SP
                          where s.MaSP == maSP
                          select s);
            foreach(var data in update)
            {
                data.KichHoat = false;
            }
            foreach(var dataNCC in list2)
            {
                int dem = 0;
                foreach (var data in update)
                {
                    if(dataNCC.MaNCC == data.MaNCC)
                    {
                        data.KichHoat = true;
                        dem++;
                    }
                }
                if (dem == 0)
                {
                    var a = new NCC_SP
                    {
                        MaSP = maSP,
                        MaNCC = dataNCC.MaNCC,
                        KichHoat = true
                    };
                    db.NCC_SP.Add(a);
                }
            }
            MessageBox.Show("Cập Nhật Thành Công");
            db.SaveChanges();
            this.Close();
        }

    }
}
