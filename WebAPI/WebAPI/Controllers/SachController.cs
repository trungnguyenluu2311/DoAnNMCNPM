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
        public IEnumerable<GetAllSach_Result> Get()
        {
            SachBL bl = new SachBL();
            return bl.GetAll();
        }

        // GET: api/Sach/5
        public GetSach_Result Get(string id)
        {
            SachBL bl = new SachBL();
            return bl.Get(id);
        }

        // GET: api/Sach/id={id};ten={tensach};theloai={theloai};tacgia={tacgia}
        [Route("api/Sach/id={id};ten={tensach};theloai={theloai};tacgia={tacgia}")]
        [HttpGet]
        public List<GetSachBy_Result> Get(string id = "", string tensach = "", string theloai = "", string tacgia = "")
		{
			SachBL bl = new SachBL();
			return bl.GetBy(id, tensach, theloai, tacgia);
		}

		// POST: api/Sach
		public void Post([FromBody]Models.Sach value)
        {
            SachBL bl = new SachBL();

            Sach sach = new Sach();
            sach.MaSach = value.MaSach;
            sach.TenSach = value.TenSach;
            sach.TacGia = value.TacGia;
            sach.TheLoai = value.TheLoai;
            sach.DonGia = value.DonGia;
            sach.SoLuong = value.SoLuong;

            bl.Insert(sach);
        }

        // PUT: api/Sach/5
        public void Put(string id, [FromBody]Models.Sach value)
        {
            SachBL bl = new SachBL();

            Sach sach = new Sach();
            sach.MaSach = value.MaSach;
            sach.TenSach = value.TenSach;
            sach.TacGia = value.TacGia;
            sach.TheLoai = value.TheLoai;
            sach.DonGia = value.DonGia;
            sach.SoLuong = value.SoLuong;

            bl.Update(id, sach);
        }

        // DELETE: api/Sach/5
        public void Delete(string id)
        {
            SachBL bl = new SachBL();
            bl.Delete(id);
        }
    }
}
