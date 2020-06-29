using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DL;

namespace QLNS.BL
{
	public class SachBL
	{
		public List<Sach> GetAll()
		{
			using(QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				string cmd = "GetAllSach";
				var result = entities.Database.SqlQuery<Sach>(cmd);
				return result.ToList();
			}
		}
		public Sach Get(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				string cmd = string.Format("GetSach @masach='{0}'", id);
				var result = entities.Database.SqlQuery<Sach>(cmd);
				return result.ToList().FirstOrDefault();
			}
		}


		public List<Sach> GetBy(string id, string tensach, string theloai, string tacgia)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				string cmd = string.Format("GetSachBy @masach='{0}',@tensach='{1}',@theloai='{2}',@tacgia='{3}'",
					id, tensach, theloai, tacgia);

				var result = entities.Database.SqlQuery<Sach>(cmd);
				return result.ToList();
			}
		}

		public void Insert(Sach sach)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				string cmd = String.Format("InsertSach @masach='{0}',@tensach='{1}',@theloai='{2}',@tacgia='{3}',@dongia='{4}',@soluong='{5}'",
					sach.MaSach, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia, sach.SoLuong);

				entities.Database.ExecuteSqlCommand(cmd);
			}
		}

		public void Update(string id, Sach sach)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				string cmd = String.Format("UpdateSach @masach='{0}',@tensach='{1}',@theloai='{2}',@tacgia='{3}',@dongia='{4}'",
					id, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia);

				entities.Database.ExecuteSqlCommand(cmd);
			}
		}

		public void Delete(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				string cmd = String.Format("DeleteSach @masach='{0}'", id);

				entities.Database.ExecuteSqlCommand(cmd);
			}
		}
	}
}
