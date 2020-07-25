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
			return null;
		}

		public List<string> GetAllUsername()
		{
			return _context.GetAllUsername();
		}

		public Users Get(string id)
		{
			return null;
		}
		public UsersDTO GetDto(string id)
		{
			return null;
		}
		public bool CheckExist(Users user)
		{
			var u = _context.GetUsersBy(user.Username, user.Password);
			return u != null;
		}
		public bool CheckUsername(string Username)
		{
			var list = _context.GetAllUsername();
			return list.Contains(Username);
		}
		public void Add(Users user)
		{
			user.Id = UserIdGenerator();
			_context.InsertUser(user.Id, user.Username, user.Password, user.QuyenHan);
		}
		private string UserIdGenerator()
		{
			var list = _context.GetAllUID();
			string id;
			Random r = new Random();
			do
			{
				id = "US";
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (list.Contains(id));

			return id;
		}
		public void Update(string id, Users entity)
		{

		}
		public void Delete(string id)
		{

		}
	}
}
