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
        public bool Post([FromBody]Models.HoaDon value)
        {
            HoaDonBL bl = new HoaDonBL();

            HoaDon hoadon = new HoaDon();
            hoadon.MaHD = value.MaHD;
            hoadon.NgayLap = value.NgayLap;
            hoadon.ThanhTien = value.ThanhTien;

            List<Sach> saches = new List<Sach>();
            foreach(Models.Sach s in value.Saches)
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

            KhachHang khachhang = new KhachHang(); 
            khachhang.MaKH = value.MaKH;
            khachhang.TenKH = value.TenKH;
            khachhang.DiaChi = value.DiaChi;
            khachhang.DienThoai = value.DienThoai;
            khachhang.Email = value.Email;

            return bl.Insert(hoadon, khachhang, saches);
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
