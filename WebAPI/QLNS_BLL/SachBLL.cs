using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_DAL;
using QLNS_DTO;

namespace QLNS_BLL
{
	public class SachBLL
	{
		private SachDAL dal;
		public SachBLL()
		{
			dal = new SachDAL();
		}

		public List<SachDTO> GetAll()
		{
			return dal.GetAll();
		}

		public void Insert(SachDTO sach)
		{
			dal.Insert(sach);
		}

		public void Update(string id, SachDTO sach)
		{
			dal.Update(id, sach);
		}

		public void Delete(string id)
		{
			dal.Delete(id);
		}
	}
}
