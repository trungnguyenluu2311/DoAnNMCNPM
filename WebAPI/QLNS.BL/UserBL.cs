using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DL;

namespace QLNS.BL
{
	public class UserBL
	{
		public bool CheckUser(string username, string password)
		{
			using(QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				GetUserBy_Result result = entities.GetUserBy(username, password).ToList().FirstOrDefault();
				return result != null;
			}
		}

		public bool Insert(User user)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				var usernames = entities.GetAllUsername().ToList();
				int check = usernames.BinarySearch(user.Username);
				if (check >= 0) return false;

				var uids = entities.GetAllUID().ToList();
				user.Id = UserIdGenerator(uids);

				entities.InsertUser(user.Id, user.Username, user.Password, user.QuyenHan);
				return true;
			}
		}

		private string UserIdGenerator(List<string> uids)
		{
			string id = "US";
			Random r = new Random();
			do
			{
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (uids.BinarySearch(id) >= 0);

			return id;
		}
	}
}
