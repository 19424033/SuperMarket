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
    
    public partial class PHANCA
    {
        public int MaPhanCa { get; set; }
        public Nullable<int> MaNV { get; set; }
        public Nullable<System.DateTime> NgayLam { get; set; }
        public Nullable<int> Ca { get; set; }
    
        public virtual CALAM CALAM { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
