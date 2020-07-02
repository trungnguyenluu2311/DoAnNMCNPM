using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DL;

namespace QLNS.BL
{
	public class PhieuThuTienBL
	{
		public List<GetAllPhieuThuTien_Result> GetAll()
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetAllPhieuThuTien().ToList();
			}
		}

		public GetPhieuThuTien_Result Get(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				return entities.GetPhieuThuTien(id).ToList().FirstOrDefault();
			}
		}

		public bool Insert(PhieuThuTien phieu)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				if(phieu.MaKH == "Khong")
				{
					var ptids = entities.GetAllMaPhieuThu().ToList();
					phieu.MaKH = PTIdGenerator(ptids);
				}

				entities.InsertPhieuThuTien(phieu.MaKH, phieu.MaKH, phieu.TenKH, phieu.DiaChi, phieu.DienThoai, phieu.Email, phieu.NgayThuTien, phieu.TienThu);
				return true;
			}
		}

		public void Update(string id, PhieuThuTien phieu)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.UpdatePhieuThuTien(id, phieu.MaKH, phieu.TenKH, phieu.DiaChi, phieu.DienThoai, phieu.Email, phieu.NgayThuTien, phieu.TienThu);
			}
		}

		public void Delete(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.DeletePhieuThuTien(id);
			}
		}

		private string PTIdGenerator(List<string> ptids)
		{
			string id = "PT";
			Random r = new Random();
			do
			{
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (ptids.BinarySearch(id) >= 0);

			return id;
		}
	}
}
