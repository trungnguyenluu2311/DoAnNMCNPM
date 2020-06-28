using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLNS_BLL;
using QLNS_DTO;

namespace WebAPI.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/User
        public IEnumerable<UserDTO> Get()
        {
            UserBLL bll = new UserBLL();
            return bll.GetAll();
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]UserDTO value)
        {
            UserBLL bll = new UserBLL();
            bll.Insert(value);
        }

        // PUT: api/User/5
        public void Put(string id, [FromBody]UserDTO value)
        {
            UserBLL bll = new UserBLL();
            bll.Update(id, value);
        }

        // DELETE: api/User/5
        public void Delete(string id)
        {
            UserBLL bll = new UserBLL();
            bll.Delete(id);
        }
    }
}
