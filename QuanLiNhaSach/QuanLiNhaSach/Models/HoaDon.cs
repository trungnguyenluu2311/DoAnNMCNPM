using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.Models
{
	public class HoaDon
	{
		public string MaHd { get; set; }
		public DateTime? NgayLap { get; set; }
		public string MaKh { get; set; }
		public decimal? ThanhTien { get; set; }
		public KhachHang KhachHang { get; set; }
		public List<Sach> Saches { get; set; }
	}
}
