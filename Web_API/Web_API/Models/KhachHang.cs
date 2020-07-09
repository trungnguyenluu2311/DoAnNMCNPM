using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            Ctbcnocong = new HashSet<Ctbcnocong>();
            HoaDon = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public decimal? TienNo { get; set; }

        public virtual ICollection<Ctbcnocong> Ctbcnocong { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
