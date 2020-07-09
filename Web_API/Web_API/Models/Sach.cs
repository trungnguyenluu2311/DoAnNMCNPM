using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Sach
    {
        public Sach()
        {
            Ctbcton = new HashSet<Ctbcton>();
            Cthd = new HashSet<Cthd>();
            Ctpns = new HashSet<Ctpns>();
        }

        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public decimal? DonGia { get; set; }
        public int? SoLuong { get; set; }

        public virtual ICollection<Ctbcton> Ctbcton { get; set; }
        public virtual ICollection<Cthd> Cthd { get; set; }
        public virtual ICollection<Ctpns> Ctpns { get; set; }
    }
}
