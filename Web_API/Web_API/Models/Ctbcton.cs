using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Ctbcton
    {
        public string MaBc { get; set; }
        public string MaSach { get; set; }
        public int? TonDau { get; set; }
        public int? TonCuoi { get; set; }
        public int? PhatSinh { get; set; }

        public virtual BaoCao MaBcNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }
    }
}
