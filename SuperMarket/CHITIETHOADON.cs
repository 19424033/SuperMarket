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
    
    public partial class CHITIETHOADON
    {
        public int Id { get; set; }
        public Nullable<int> MaHD { get; set; }
        public Nullable<int> MaSP { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TienVon { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
