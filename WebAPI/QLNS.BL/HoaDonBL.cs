using QLNS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.BL
{
	public class HoaDonBL
	{
		public bool Insert(HoaDon hoadon, KhachHang khachhang, List<Sach> saches)
		{
			using (QLNHASACHEntities entities = new QLNHASACHEntities())
			{
				var hdids = entities.GetAllMaHoaDon().ToList();
				hoadon.MaHD = HDIdGenerator(hdids);

				KhachHangBL khbl = new KhachHangBL();

				if (khachhang.MaKH == "Khong")
				{
					var khids = entities.GetAllMaKhachHang().ToList();
					khachhang.MaKH = khbl.KHIdGenerator(khids);
					khbl.Insert(khachhang);
				}


				entities.InsertHoaDon(hoadon.MaHD, khachhang.MaKH, hoadon.NgayLap, hoadon.ThanhTien);

				foreach (Sach s in saches)
				{
					entities.InsertCTHD(hoadon.MaHD, s.MaSach, s.SoLuong, s.DonGia);
				}

				return true;
			}
		}

		private string HDIdGenerator(List<string> hdids)
		{
			string id = "HD";
			Random r = new Random();
			do
			{
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
				id += r.Next(0, 9);
			}
			while (hdids.BinarySearch(id) >= 0);

			return id;
		}
	}
}
