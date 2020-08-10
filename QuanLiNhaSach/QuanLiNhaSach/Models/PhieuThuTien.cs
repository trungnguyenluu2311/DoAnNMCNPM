using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.Models
{
	public class PhieuThuTien
	{
        public string MaPt { get; set; }
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public DateTime? NgayThuTien { get; set; }
        public decimal? TienThu { get; set; }
    }
}
