using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.Models
{
	class PhieuNhapSach
	{
		public string MaPn { get; set; }
		public DateTime? NgayNhap { get; set; }
		public List<Sach> Saches { get; set; }
	}
}
