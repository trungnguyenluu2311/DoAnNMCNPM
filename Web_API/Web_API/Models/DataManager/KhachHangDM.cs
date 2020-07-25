using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class KhachHangDM : IDataRepository<KhachHang, KhachHangDTO>
	{
		readonly QLNHASACHContext _context;

		public KhachHangDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<KhachHang> GetAll()
		{
			return _context.GetAllKhachHang();
		}
		public KhachHang Get(string id)
		{
			return _context.GetKhachHang(id);
		}
		public List<string> GetAllMaKH()
		{
			return _context.GetAllMaKhachHang();
		}
		public KhachHangDTO GetDto(string id)
		{
			return null;
		}
		public bool CheckExist(string id)
		{
			var l = _context.GetAllMaKhachHang();
			return l.Contains(id);
		}
		public void Add(KhachHang kh)
		{
			kh.MaKh = KHIdGenerator();
			_context.InsertKhachHang(kh.MaKh, kh.TenKh, kh.DiaChi, kh.DienThoai, kh.Email);
		}

		private string KHIdGenerator()
		{
			var list = _context.GetAllMaKhachHang();
			string id;
			Random r = new Random();
			do
			{
				id = "KH";
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (list.Contains(id));

			return id;
		}
		public void Update(string id, KhachHang kh)
		{
			_context.UpdateKhachHang(id, kh.TenKh, kh.DiaChi, kh.DienThoai, kh.Email);
		}
		public void Delete(string id)
		{
			_context.DeleteKhachHang(id);
		}
	}
}
