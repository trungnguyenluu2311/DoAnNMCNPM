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
			return _context.KhachHang.ToList();
		}
		public KhachHang Get(string id)
		{
			return null;
		}
		public KhachHangDTO GetDto(string id)
		{
			return null;
		}
		public void Add(KhachHang entity)
		{
		}
		public void Update(string id, KhachHang entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
