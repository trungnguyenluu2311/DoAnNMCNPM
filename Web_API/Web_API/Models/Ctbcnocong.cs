using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Ctbcnocong
    {
        public string MaBc { get; set; }
        public string MaKh { get; set; }
        public decimal? NoDau { get; set; }
        public decimal? NoCuoi { get; set; }
        public decimal? PhatSinh { get; set; }

        public virtual BaoCao MaBcNavigation { get; set; }
        public virtual KhachHang MaKhNavigation { get; set; }
    }
}
