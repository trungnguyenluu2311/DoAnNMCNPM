using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class ThamSoDM : IDataRepository<ThamSo, ThamSoDTO>
	{
		readonly QLNHASACHContext _context;

		public ThamSoDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<ThamSo> GetAll()
		{
			return _context.ThamSo.ToList();
		}
		public ThamSo Get(string id)
		{
			return null;
		}
		public ThamSoDTO GetDto(string id)
		{
			return null;
		}
		public void Add(ThamSo entity)
		{
		}
		public void Update(string id, ThamSo entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
