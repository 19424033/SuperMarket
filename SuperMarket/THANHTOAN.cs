//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperMarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class THANHTOAN
    {
        public int MaThanhToan { get; set; }
        public Nullable<int> MaHD { get; set; }
        public Nullable<int> MaHinhThucTT { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public Nullable<System.DateTime> NgayThanhToan { get; set; }
    
        public virtual HINHTHUCTHANHTOAN HINHTHUCTHANHTOAN { get; set; }
        public virtual HOADON HOADON { get; set; }
    }
}
