//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS.DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTPN
    {
        public string MaPN { get; set; }
        public string MaSach { get; set; }
        public Nullable<int> SoLuongNhap { get; set; }
        public Nullable<decimal> DonGiaNhap { get; set; }
    
        public virtual PhieuNhapSach PhieuNhapSach { get; set; }
        public virtual Sach Sach { get; set; }
    }
}