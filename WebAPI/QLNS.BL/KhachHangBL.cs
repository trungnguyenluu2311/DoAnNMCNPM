using QLNS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DL;

namespace QLNS.BL
{
	public class KhachHangBL
	{
		public List<GetAllKhachHang_Result> GetAll()
		{
			using(QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetAllKhachHang().ToList();
			}
		}

		public GetKhachHang_Result Get(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetKhachHang(id).ToList().FirstOrDefault();
			}
		}

		public List<string> GetALLMaKH()
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				var list = entities.GetAllMaKhachHang().ToList();
				list.Insert(0, "Không");
				return list;
			}
		}

		public List<GetKhachHangBy_Result> GetBy(string makh, string tenkh, string diachi, string sdt, string email)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetKhachHangBy(makh, tenkh, diachi, sdt, email).ToList();
			}
		}

		public void Insert(KhachHang khachhang)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.InsertKhachHang(khachhang.MaKH, khachhang.TenKH, khachhang.DiaChi, khachhang.DienThoai, khachhang.Email);
			}
		}

		public void Update(string id, KhachHang khachhang)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.UpdateKhachHang(khachhang.MaKH, khachhang.TenKH, khachhang.DiaChi, khachhang.DienThoai, khachhang.Email);
			}
		}

		public void Delete(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.DeleteKhachHang(id);
			}
		}

		public string KHIdGenerator(List<string> khids)
		{
			string id = "KH";
			Random r = new Random();
			do
			{
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (khids.BinarySearch(id) >= 0);

			return id;
		}
	}
}
