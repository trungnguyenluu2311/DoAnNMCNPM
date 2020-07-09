using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models.DTO;
using Web_API.Models.Repository;

namespace Web_API.Models.DataManager
{
	public class UsersDM : IDataRepository<Users, UsersDTO>
	{
		readonly QLNHASACHContext _context;

		public UsersDM(QLNHASACHContext context)
		{
			_context = context;
		}
		public IEnumerable<Users> GetAll()
		{
			return _context.Users.ToList();
		}
		public Users Get(string id)
		{
			return null;
		}
		public UsersDTO GetDto(string id)
		{
			return null;
		}
		public void Add(Users entity)
		{
		}
		public void Update(string id, Users entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
