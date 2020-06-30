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
	}
}
