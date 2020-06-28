using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_DAL;
using QLNS_DTO;

namespace QLNS_BLL
{
	public class UserBLL
	{
		private UserDAL dal;

		public UserBLL()
		{
			dal = new UserDAL();
		}

		public List<UserDTO> GetAll()
		{
			return dal.GetAll();
		}

		public void Insert(UserDTO user)
		{
			dal.Insert(user);
		}

		public void Update(string id, UserDTO user)
		{
			dal.Update(id, user);
		}

		public void Delete(string id)
		{
			dal.Delete(id);
		}
	}
}
