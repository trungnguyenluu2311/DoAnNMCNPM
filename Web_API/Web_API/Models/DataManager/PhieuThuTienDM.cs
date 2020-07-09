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
			return _context.PhieuThuTien.ToList();
		}
		public PhieuThuTien Get(string id)
		{
			return null;
		}
		public PhieuThuTienDTO GetDto(string id)
		{
			return null;
		}
		public void Add(PhieuThuTien entity)
		{
		}
		public void Update(string id, PhieuThuTien entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
