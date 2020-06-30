﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
	public class KhachHang
	{
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> TienNo { get; set; }
    }
}