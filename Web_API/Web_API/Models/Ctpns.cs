using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Ctpns
    {
        public string MaPn { get; set; }
        public string MaSach { get; set; }
        public int? SoLuongNhap { get; set; }
        public decimal? DonGiaNhap { get; set; }

        public virtual PhieuNhapSach MaPnNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }
    }
}
