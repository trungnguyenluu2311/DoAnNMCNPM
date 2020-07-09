using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models.DTO
{
	public class HoaDonDTO
    {
        public string MaHd { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MaKh { get; set; }
        public decimal? ThanhTien { get; set; }
    }
}
