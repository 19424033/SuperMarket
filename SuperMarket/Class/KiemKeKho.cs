using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket.Class
{
    class KiemKeKho : INotifyPropertyChanged
    {
        private string _slKK;
        private int _slCL;
        
        public int MaLSP { get; set; }
        public string TenLoaiSP { get; set; }
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string GiaMuaVao { get; set; }
        public int SoLuong { get; set; }

        public string SLKK
        {
            get => _slKK; set
            {
                _slKK = value;
                NotifyChange("SLKK");
                NotifyChange("SLCL");
            }
        }

        public int SLCL
        {
            get => _slCL; set
            {
                _slCL = SLKK == "" ? 0 : int.Parse(SLKK) - SoLuong;
                NotifyChange("SLKK");
                NotifyChange("SLCL");
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
