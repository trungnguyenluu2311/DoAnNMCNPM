using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Cthd
    {
        public string MaHd { get; set; }
        public string MaSach { get; set; }
        public int? SoLuongBan { get; set; }
        public decimal? DonGiaBan { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }
    }
}
