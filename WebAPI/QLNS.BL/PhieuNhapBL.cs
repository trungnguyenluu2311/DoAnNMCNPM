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
		public bool Insert(HoaDon hoadon, KhachHang khachhang, List<Sach> saches)
		{
			return false;
		}
		private string HDIdGenerator(List<string> pnids)
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
