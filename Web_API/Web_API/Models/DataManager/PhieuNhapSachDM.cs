using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class PhieuNhapSachDM : IDataRepository<PhieuNhapSach, PhieuNhapSachDTO>
	{
		readonly QLNHASACHContext _context;

		public PhieuNhapSachDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<PhieuNhapSach> GetAll()
		{
			return _context.PhieuNhapSach.ToList();
		}
		public PhieuNhapSach Get(string id)
		{
			return null;
		}
		public PhieuNhapSachDTO GetDto(string id)
		{
			return null;
		}
		public bool CheckExist(string id)
		{
			var l = _context.GetAllMaPhieuNhapSach();
			return l.Contains(id);
		}
		public void Add(PhieuNhapSachDTO phieu)
		{
			phieu.MaPn = PNIdGenerator();
			_context.InsertPhieuNhap(phieu.MaPn,phieu.NgayNhap);

			foreach (SachDTO sach in phieu.Saches)
			{
				if(sach.MaSach =="Khong")
				{
					Sach s = new Sach();
					s.MaSach = sach.MaSach;
					s.TenSach = sach.TenSach;
					s.TheLoai = sach.TheLoai;
					s.TacGia = sach.TacGia;
					s.SoLuong = sach.SoLuong;
					new SachDM(_context).Add(s);
					sach.MaSach = s.MaSach;
				}
				_context.InsertCTHD(phieu.MaPn, sach.MaSach, sach.SoLuong, sach.DonGia);
			}
		}
		private string PNIdGenerator()
		{
			var list = _context.GetAllMaPhieuNhapSach();
			string id;
			Random r = new Random();
			do
			{
				id = "PN";
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (list.Contains(id));

			return id;
		}
		public void Add(PhieuNhapSach entity)
		{
		}
		public void Update(string id, PhieuNhapSach entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
