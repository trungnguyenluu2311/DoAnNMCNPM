using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNS.DL;

namespace QLNS.BL
{
	public class PhieuNhapBL
	{
		public bool Insert(PhieuNhapSach phieunhap, List<Sach> saches)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				var pnids = entities.GetAllMaPhieuNhap().ToList();
				phieunhap.MaPN = PNIdGenerator(pnids);

				entities.InsertPhieuNhap(phieunhap.MaPN, phieunhap.NgayNhap);

				foreach (Sach s in saches)
				{
					SachBL sbl = new SachBL();

					if (s.MaSach == "Khong")
					{
						var sids = entities.GetAllMaSach().ToList();
						s.MaSach = sbl.SIdGenerator(sids);
						sbl.Insert(s);
					}

					entities.InsertCTPNS(phieunhap.MaPN, s.MaSach, s.SoLuong, s.DonGia);
				}

				return true;
			}
		}
		private string PNIdGenerator(List<string> pnids)
		{
			string id = "PN";
			Random r = new Random();
			do
			{
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (pnids.BinarySearch(id) >= 0);

			return id;
		}
	}
}
