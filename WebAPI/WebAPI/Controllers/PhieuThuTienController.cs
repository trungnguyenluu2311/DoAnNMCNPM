using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class PhieuThuTienController : ApiController
    {
        // GET: api/PhieuThuTien
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PhieuThuTien/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PhieuThuTien
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PhieuThuTien/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PhieuThuTien/5
        public void Delete(int id)
        {
        }
    }
}
