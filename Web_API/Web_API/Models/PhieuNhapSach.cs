using System;
using System.Collections.Generic;

namespace Web_API.Models

{
    public partial class PhieuNhapSach
    {
        public PhieuNhapSach()
        {
            Ctpns = new HashSet<Ctpns>();
        }

        public string MaPn { get; set; }
        public DateTime? NgayNhap { get; set; }

        public virtual ICollection<Ctpns> Ctpns { get; set; }
    }
}
