using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class SachDM : IDataRepository<Sach, SachDTO>
	{
		readonly QLNHASACHContext _context;

		public SachDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<Sach> GetAll()
		{
			return _context.GetAllSach();
		}
		public Sach Get(string id)
		{
			return _context.GetSach(id);
		}
		public SachDTO GetDto(string id)
		{
			return null;
		}
		public List<string> GetAllMaSach()
		{
			return _context.GetAllMaSach();
		}
		public bool CheckExist(string id)
		{
			var l = _context.GetAllMaSach();
			return l.Contains(id);
		}
		public void Add(Sach sach)
		{
			sach.MaSach = SachIdGenerator();
			_context.InsertSach(sach.MaSach, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia, sach.SoLuong);
		}
		private string SachIdGenerator()
		{
			var list = _context.GetAllMaSach();
			string id;
			Random r = new Random();
			do
			{
				id = "SA";
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (list.Contains(id));

			return id;
		}
		public void Update(string id, Sach sach)
		{
			_context.UpdateSach(id, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia);
		}
		public void Delete(string id)
		{
			_context.DeleteSach(id);
		}
	}
}
