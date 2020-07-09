using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models.DTO
{
	public class KhachHangDTO
    {
        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public decimal? TienNo { get; set; }
    }
}
