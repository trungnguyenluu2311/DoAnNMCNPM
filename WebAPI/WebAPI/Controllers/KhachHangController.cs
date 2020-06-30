using QLNS.BL;
using QLNS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace WebAPI.Controllers
{
    public class KhachHangController : ApiController
    {
        // GET: api/KhachHang
        public IEnumerable<GetAllKhachHang_Result> Get()
        {
            KhachHangBL bl = new KhachHangBL();
            return bl.GetAll();
        }

        // GET: api/KhachHang/5
        public GetKhachHang_Result Get(string id)
        {
            KhachHangBL bl = new KhachHangBL();
            return bl.Get(id);
        }

        // GET: api/KhachHang/id={makh};ten={tenkh};diachi={diachi};sdt={sdt};email={email}
        [Route("api/KhachHang/id={makh};ten={tenkh};diachi={diachi};sdt={sdt};email={email}")]
        [HttpGet]
        public List<GetKhachHangBy_Result> Get(string makh = "", string tenkh = "", string diachi = "", string sdt = "", string email = "")
        {
            KhachHangBL bl = new KhachHangBL();
            return bl.GetBy(makh, tenkh, diachi, sdt, email);
        }

        // POST: api/KhachHang
        public void Post([FromBody]Models.KhachHang value)
        {
            KhachHangBL bl = new KhachHangBL();

            KhachHang khachhang = new KhachHang();
            khachhang.MaKH = value.MaKH;
            khachhang.TenKH = value.TenKH;
            khachhang.DiaChi = value.DiaChi;
            khachhang.Email = value.Email;
            khachhang.TienNo = value.TienNo;

            bl.Insert(khachhang);
        }

        // PUT: api/KhachHang/5
        public void Put(string id, [FromBody] Models.KhachHang value)
        {
            KhachHangBL bl = new KhachHangBL();

            KhachHang khachhang = new KhachHang();
            khachhang.MaKH = value.MaKH;
            khachhang.TenKH = value.TenKH;
            khachhang.DiaChi = value.DiaChi;
            khachhang.Email = value.Email;
            khachhang.TienNo = value.TienNo;

            bl.Update(id, khachhang);
        }

        // DELETE: api/KhachHang/5
        public void Delete(string id)
        {
            KhachHangBL bl = new KhachHangBL();
            bl.Delete(id);
        }
    }
}
