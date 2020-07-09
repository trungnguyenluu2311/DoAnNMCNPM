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
