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
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.HOADONs = new HashSet<HOADON>();
            this.KIEMKEKHOes = new HashSet<KIEMKEKHO>();
            this.PHANCAs = new HashSet<PHANCA>();
            this.PHIEUNHAPHANGs = new HashSet<PHIEUNHAPHANG>();
        }
    
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string QueQuan { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<int> MaChucVu { get; set; }
        public string MatKhau { get; set; }
        public Nullable<bool> KichHoat { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KIEMKEKHO> KIEMKEKHOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCA> PHANCAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAPHANG> PHIEUNHAPHANGs { get; set; }
    }
}
