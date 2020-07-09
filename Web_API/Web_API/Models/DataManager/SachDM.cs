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
		public void Add(Sach sach)
		{
			_context.InsertSach(sach.MaSach, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia, sach.SoLuong);
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
