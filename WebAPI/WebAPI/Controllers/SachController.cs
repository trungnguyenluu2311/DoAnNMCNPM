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
    public class SachController : ApiController
    {
        // GET: api/Sach
        public IEnumerable<SachDTO> Get()
        {
            SachBLL bll = new SachBLL();
            return bll.GetAll();
        }

        // GET: api/Sach/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sach
        public void Post([FromBody]SachDTO value)
        {
            SachBLL bll = new SachBLL();
            bll.Insert(value);
        }

        // PUT: api/Sach/5
        public void Put(string id, [FromBody]SachDTO value)
        {
            SachBLL bll = new SachBLL();
            bll.Update(id, value);
        }

        // DELETE: api/Sach/5
        public void Delete(string id)
        {
            SachBLL bll = new SachBLL();
            bll.Delete(id);
        }
    }
}
