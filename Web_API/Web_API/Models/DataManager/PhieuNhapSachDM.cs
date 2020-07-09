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
