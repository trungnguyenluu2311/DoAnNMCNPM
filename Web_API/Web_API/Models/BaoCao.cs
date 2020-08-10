using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class BaoCao
    {
        public BaoCao()
        {
            Ctbcnocong = new HashSet<Ctbcnocong>();
            Ctbcton = new HashSet<Ctbcton>();
        }

        public string MaBc { get; set; }
        public int? Thang { get; set; }

        public virtual ICollection<Ctbcnocong> Ctbcnocong { get; set; }
        public virtual ICollection<Ctbcton> Ctbcton { get; set; }
    }
}
