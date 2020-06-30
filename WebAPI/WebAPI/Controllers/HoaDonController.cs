using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class HoaDonController : ApiController
    {
        // GET: api/HoaDon
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/HoaDon/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/HoaDon
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/HoaDon/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/HoaDon/5
        public void Delete(int id)
        {
        }
    }
}
