using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class HoaDonDM : IDataRepository<HoaDon, HoaDonDTO>
	{
		readonly QLNHASACHContext _context;

		public HoaDonDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<HoaDon> GetAll()
		{
			return _context.HoaDon.ToList();
		}
		public HoaDon Get(string id)
		{
			return null;
		}
		public HoaDonDTO GetDto(string id)
		{
			return null;
		}
		public bool CheckExist(string id)
		{
			var l = _context.GetAllMaHoaDon();
			return l.Contains(id);
		}
		public void Add(HoaDonDTO hoadon)
		{
			hoadon.MaHd = HDIdGenerator();
			if (hoadon.KhachHang.MaKh == "Khong")
			{
				KhachHang kh = new KhachHang();
				kh.MaKh = hoadon.KhachHang.MaKh;
				kh.TenKh = hoadon.KhachHang.TenKh;
				kh.DiaChi = hoadon.KhachHang.DiaChi;
				kh.DienThoai = hoadon.KhachHang.DienThoai;
				kh.Email = hoadon.KhachHang.Email;
				kh.TienNo = hoadon.KhachHang.TienNo;
				new KhachHangDM(_context).Add(kh);
				hoadon.MaKh = kh.MaKh;
			}
			_context.InsertHoaDon(hoadon.MaHd, hoadon.MaKh, hoadon.NgayLap, hoadon.ThanhTien);

			foreach (SachDTO sach in hoadon.Saches)
			{
				_context.InsertCTHD(hoadon.MaHd, sach.MaSach, sach.SoLuong, sach.DonGia);
			}
		}
		private string HDIdGenerator()
		{
			var list = _context.GetAllMaHoaDon();
			string id;
			Random r = new Random();
			do
			{
				id = "HD";
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (list.Contains(id));

			return id;
		}
		public void Add(HoaDon entity)
		{
		}
		public void Update(string id, HoaDon entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
