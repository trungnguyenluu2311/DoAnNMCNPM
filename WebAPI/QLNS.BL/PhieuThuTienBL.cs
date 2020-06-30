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

		public void Insert(PhieuThuTien phieu)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.InsertPhieuThuTien(phieu.MaPT, phieu.MaKH, phieu.NgayThuTien, phieu.TienThu);
			}
		}

		public void Update(string id, PhieuThuTien phieu)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.UpdatePhieuThuTien(id, phieu.MaKH, phieu.NgayThuTien, phieu.TienThu);
			}
		}

		public void Delete(string id)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				entities.DeletePhieuThuTien(id);
			}
		}
	}
}
