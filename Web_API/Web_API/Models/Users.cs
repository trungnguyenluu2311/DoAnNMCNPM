using System;
using System.Collections.Generic;

namespace Web_API.Models
{
    public partial class Users
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? QuyenHan { get; set; }
    }
}
