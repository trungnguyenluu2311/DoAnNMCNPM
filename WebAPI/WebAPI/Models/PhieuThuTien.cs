using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
	public class PhieuThuTien
	{
		public string MaPT { get; set; }
		public string MaKH { get; set; }
		public Nullable<System.DateTime> NgayThuTien { get; set; }
		public Nullable<decimal> TienThu { get; set; }
	}
}