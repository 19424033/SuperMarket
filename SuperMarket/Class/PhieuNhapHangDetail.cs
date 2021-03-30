using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Class
{
    class PhieuNhapHangDetail : INotifyPropertyChanged
    {
        private int _stt;
        private int _soLuong;
        private decimal _thanhTien;

        public int STT
        {
            get => _stt; set
            {
                _stt = value;
                NotifyChange("STT");
            }
        }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong
        {
            get => _soLuong; set
            {
                _soLuong = value;
                NotifyChange("SoLuong");
                NotifyChange("ThanhTien");
            }
        }
        public decimal ThanhTien
        {
            get => _thanhTien; set
            {
                _thanhTien = SoLuong * DonGia;
                NotifyChange("SoLuong");
                NotifyChange("ThanhTien");
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
