using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
	public class Sach
	{
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TheLoai { get; set; }
        public string TacGia { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
    }
}