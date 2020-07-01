using QLNS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLNS.BL;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User/checkuser/username={username};password={password}
        [Route("api/User/checkuser/username={username};password={password}")]
        [HttpGet]
        public bool Get(string username, string password)
        {
            UserBL bl = new UserBL();
            return bl.CheckUser(username, password);
        }

        // POST: api/User
        public bool Post([FromBody]Models.User value)
        {
            UserBL bl = new UserBL();

            User user = new User();
            user.Username = value.Username;
            user.Password = value.Password;
            user.QuyenHan = value.QuyenHan;

            return bl.Insert(user);
        }
    }
}
