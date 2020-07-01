using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
	public class User
	{
		public string Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public Nullable<int> QuyenHan { get; set; }
	}
}