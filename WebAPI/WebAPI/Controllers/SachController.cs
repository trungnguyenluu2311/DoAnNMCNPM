using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLNS.BL;
using QLNS.DL;

namespace WebAPI.Controllers
{
    public class SachController : ApiController
    {
        // GET: api/Sach
        public IEnumerable<Sach> Get()
        {
            SachBL bl = new SachBL();
            return bl.GetAll();
        }

        //GET: api/Sach/5
        public Sach Get(string id)
        {
            SachBL bl = new SachBL();
            return bl.Get(id);
        }

        //GET: api/Sach/id={id};tensach={tensach};theloai={theloai};tacgia={tacgia}
        [Route("api/Sach/id={id};tensach={tensach};theloai={theloai};tacgia={tacgia}")]
        [HttpGet]
        public List<Sach> Get(string id = "", string tensach = "", string theloai = "", string tacgia = "")
		{
			SachBL bl = new SachBL();
			return bl.GetBy(id, tensach, theloai, tacgia);
		}

		// POST: api/Sach
		public void Post([FromBody]Sach value)
        {
            SachBL bl = new SachBL();
            bl.Insert(value);
        }

        // PUT: api/Sach/5
        public void Put(string id, [FromBody]Sach value)
        {
            SachBL bl = new SachBL();
            bl.Update(id, value);
        }

        // DELETE: api/Sach/5
        public void Delete(string id)
        {
            SachBL bl = new SachBL();
            bl.Delete(id);
        }
    }
}
