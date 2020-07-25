using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class PhieuThuTienDM : IDataRepository<PhieuThuTien, PhieuThuTienDTO>
	{
		readonly QLNHASACHContext _context;

		public PhieuThuTienDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<PhieuThuTien> GetAll()
		{
			return _context.GetAllPhieuThuTien();
		}
		public PhieuThuTien Get(string id)
		{
			return _context.GetPhieuThuTien(id);
		}
		public PhieuThuTienDTO GetDto(string id)
		{
			return null;
		}
		public bool CheckExist(string id)
		{
			var l = _context.GetAllMaPhieuThuTien();
			return l.Contains(id);
		}
		public void Add(PhieuThuTien phieu)
		{
			phieu.MaPt = PTIdGenerator();
			_context.InsertPhieuThuTien(phieu.MaPt, phieu.MaKh, phieu.TenKh, phieu.DiaChi, phieu.DienThoai, phieu.Email, phieu.NgayThuTien, phieu.TienThu);
		}
		private string PTIdGenerator()
		{
			var list = _context.GetAllMaPhieuThuTien();
			string id;
			Random r = new Random();
			do
			{
				id = "PT";
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (list.Contains(id));

			return id;
		}
		public void Update(string id, PhieuThuTien phieu)
		{
			_context.UpdatePhieuThuTien(id, phieu.MaKh, phieu.TenKh, phieu.DiaChi, phieu.DienThoai, phieu.Email, phieu.NgayThuTien, phieu.TienThu);
		}
		public void Delete(string id)
		{
			_context.DeletePhieuThuTien(id);
		}
	}
}
