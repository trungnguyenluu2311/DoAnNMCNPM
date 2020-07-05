using QLNS.BL;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QLNS.BL;
using QLNS.DL;

namespace WebAPI.Controllers
{
    public class PhieuNhapSachController : ApiController
    {
        // GET: api/PhieuNhapSach
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PhieuNhapSach/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PhieuNhapSach
        public bool Post([FromBody]Models.PhieuNhapSach value)
        {
            PhieuNhapBL bl = new PhieuNhapBL();

            PhieuNhapSach phieunhap = new PhieuNhapSach();
            phieunhap.MaPN = value.MaPN;
            phieunhap.NgayNhap = value.NgayNhap;

            List<Sach> saches = new List<Sach>();
            foreach (Models.Sach s in value.Saches)
            {
                Sach ss = new Sach();
                ss.MaSach = s.MaSach;
                ss.TenSach = s.TenSach;
                ss.TheLoai = s.TheLoai;
                ss.TacGia = s.TacGia;
                ss.DonGia = s.DonGia;
                ss.SoLuong = s.SoLuong;
                saches.Add(ss);
            }

            return bl.Insert(phieunhap, saches);
        }

        // PUT: api/PhieuNhapSach/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PhieuNhapSach/5
        public void Delete(int id)
        {
        }
    }
}
