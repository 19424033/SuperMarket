using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Class
{
    class HoaDonDetail : INotifyPropertyChanged
    {
        private int _stt;
        private int _soLuong;
        private decimal _thanhTien;
        private decimal _discount;

        public int STT
        {
            get => _stt; set
            {
                _stt = value;
                NotifyChange("STT");
            }
        }
        public int maSP { get; set; }
        public string tenSP { get; set; }
        public decimal donGia { get; set; }
        public decimal giacost { get; set; }
        public decimal khuyenMai { get; set; }
        public int soLuong
        {
            get => _soLuong; set
            {
                _soLuong = value;
                NotifyChange("soLuong");
            }
        }
        public decimal thanhTien
        {
            get => _thanhTien; set
            {
                _thanhTien = soLuong * donGia;
                NotifyChange("thanhTien");
            }
        }
        public decimal discount
        {
            get => _discount; set
            {
                _discount = donGia * soLuong * khuyenMai / 100;
                NotifyChange("discount");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
