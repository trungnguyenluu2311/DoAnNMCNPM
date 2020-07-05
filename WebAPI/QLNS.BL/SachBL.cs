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
		public List<GetAllSach_Result> GetAll()
		{
			using(QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetAllSach().ToList();
			}
		}

		public GetSach_Result Get(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetSach(id).ToList().FirstOrDefault();
			}
		}

		public List<string> GetAllMaSach()
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				var list = entities.GetAllMaSach().ToList();
				list.Insert(0,"Không");
				return list;
			}
		}

		public List<GetSachBy_Result> GetBy(string id, string tensach, string theloai, string tacgia)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetSachBy(id, tensach, theloai, tacgia).ToList();
			}
		}

		public void Insert(Sach sach)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.InsertSach(sach.MaSach, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia, sach.SoLuong);
			}
		}

		public void Update(string id, Sach sach)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.UpdateSach(id, sach.TenSach, sach.TheLoai, sach.TacGia, sach.DonGia);
			}
		}

		public void Delete(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.DeleteSach(id);
			}
		}

		public string SIdGenerator(List<string> sids)
		{
			string id = "SA";
			Random r = new Random();
			do
			{
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (sids.BinarySearch(id) >= 0);

			return id;
		}
	}
}
