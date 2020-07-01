using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaSach.Models
{
	public class User
	{
		public string Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public Nullable<int> QuyenHan { get; set; }
	}
}
