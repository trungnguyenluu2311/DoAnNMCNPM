using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS_DAL;
using QLNS_DTO;

namespace QLNS_BLL
{
	public class PhieuThuTienBLL
	{
		private PhieuThuTienDAL dal;
		public PhieuThuTienBLL()
		{
			dal = new PhieuThuTienDAL();
		}
	}
}
