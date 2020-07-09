using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            Cthd = new HashSet<Cthd>();
        }

        public string MaHd { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MaKh { get; set; }
        public decimal? ThanhTien { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual ICollection<Cthd> Cthd { get; set; }
    }
}
