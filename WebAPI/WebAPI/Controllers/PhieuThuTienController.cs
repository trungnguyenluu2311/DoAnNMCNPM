using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Web.Infrastructure.DynamicValidationHelper;
using QLNS.BL;
using QLNS.DL;

namespace WebAPI.Controllers
{
    public class PhieuThuTienController : ApiController
    {
        // GET: api/PhieuThuTien
        public IEnumerable<GetAllPhieuThuTien_Result> Get()
        {
            PhieuThuTienBL bl = new PhieuThuTienBL();
            return bl.GetAll();
        }

        // GET: api/PhieuThuTien/5
        public GetPhieuThuTien_Result Get(string id)
        {
            PhieuThuTienBL bl = new PhieuThuTienBL();
            return bl.Get(id);
        }

        // POST: api/PhieuThuTien
        public bool Post([FromBody]Models.PhieuThuTien value)
        {
            PhieuThuTienBL bl = new PhieuThuTienBL();

            PhieuThuTien phieu = new PhieuThuTien();
            phieu.MaPT = value.MaPT;
            phieu.MaKH = value.MaKH;
            phieu.TenKH = value.TenKH;
            phieu.DiaChi = value.DiaChi;
            phieu.DienThoai = value.DienThoai;
            phieu.Email = value.Email;
            phieu.NgayThuTien = value.NgayThuTien;
            phieu.TienThu = value.TienThu;

            return bl.Insert(phieu);
        }

        // PUT: api/PhieuThuTien/5
        public void Put(string id, [FromBody]Models.PhieuThuTien value)
        {
            PhieuThuTienBL bl = new PhieuThuTienBL();

            PhieuThuTien phieu = new PhieuThuTien();
            phieu.MaPT = value.MaPT;
            phieu.MaKH = value.MaKH;
            phieu.TenKH = value.TenKH;
            phieu.DiaChi = value.DiaChi;
            phieu.DienThoai = value.DienThoai;
            phieu.Email = value.Email;
            phieu.NgayThuTien = value.NgayThuTien;
            phieu.TienThu = value.TienThu;

            bl.Update(id, phieu);
        }

        // DELETE: api/PhieuThuTien/5
        public void Delete(string id)
        {
            PhieuThuTienBL bl = new PhieuThuTienBL();
            bl.Delete(id);
        }
    }
}
