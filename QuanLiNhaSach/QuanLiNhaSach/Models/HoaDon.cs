using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.Models
{
	public class HoaDon
	{
		public string MaHD { get; set; }
		public Nullable<System.DateTime> NgayLap { get; set; }
		public string MaKH { get; set; }
		public string TenKH { get; set; }
		public string DiaChi { get; set; }
		public string DienThoai { get; set; }
		public string Email { get; set; }
		public Nullable<decimal> ThanhTien { get; set; }
		public List<Sach> Saches { get; set; }
	}
}
