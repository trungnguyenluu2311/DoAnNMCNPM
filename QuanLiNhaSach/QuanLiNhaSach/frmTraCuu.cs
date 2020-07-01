using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using QuanLiNhaSach.Models;
using Newtonsoft;

namespace QuanLiNhaSach
{
	public partial class frmTracuu : Form
	{
		public frmTracuu()
		{
			InitializeComponent();
		}

        private void Button2_Click(object sender, EventArgs e)
        {
			GetSearchResult();
		}

		private async Task GetSearchResult()
		{
			string masach, tensach, theloai, tacgia;
			masach = textBox1.Text != "" ? textBox1.Text : "_";
			tensach = textBox2.Text != "" ? textBox2.Text : "_";
			theloai = textBox3.Text != "" ? textBox3.Text : "_";
			tacgia = textBox4.Text != "" ? textBox4.Text : "_";

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44393/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync(
					string.Format("api/sach/id={0};ten={1};theloai={2};tacgia={3}", masach, tensach, theloai, tacgia)
					);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<List<Sach>>();
					ShowData(data);
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}

		}

		private void ShowData(List<Sach> data)
		{
			if (data == null) return;
			dataGridView1.Rows.Clear();
			foreach(var sach in data)
			{
				dataGridView1.Rows.Add(sach.TenSach, sach.TheLoai, sach.TacGia, sach.SoLuong, sach.DonGia);
			}
			dataGridView1.Refresh();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
