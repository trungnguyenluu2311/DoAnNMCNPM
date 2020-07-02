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

namespace QuanLiNhaSach
{
	public partial class frmLapPhieuThu : Form
	{
		public frmLapPhieuThu()
		{
			InitializeComponent();
		}

		private void frmLapPhieuThu_Load(object sender, EventArgs e)
		{
			GetMaKH();
		}

		private async void GetMaKH()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44393/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/khachhang/getallmakh");

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<List<string>>();
					comboBox1.DataSource = data;
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			comboBox1.Text = "Không";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox4.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox6.Text == "") 
			{
				MessageBox.Show("Hãy điền đầy đủ thông tin", "Lưu phiếu thất bại", MessageBoxButtons.OK);
				return;
			}

			string makh, tenkh, diachi, sdt, email;
			DateTime ngaythu;
			int tienthu;
			makh = comboBox1.Text != "Không" ? comboBox1.Text : "Khong";
			tenkh = textBox1.Text;
			sdt = textBox2.Text;
			ngaythu = dateTimePicker1.Value;
			diachi = textBox4.Text;
			email = textBox5.Text;
			tienthu = Convert.ToInt32(textBox6.Text);

			PostPhieuThuTien(makh, tenkh, diachi, sdt, email, ngaythu, tienthu);
		}

		private async void PostPhieuThuTien(string makh, string tenkh, string diachi, string sdt, string email, DateTime ngaythu, int tienthu)
		{
			PhieuThuTien phieu = new PhieuThuTien();
			phieu.TenKH = tenkh;
			phieu.DiaChi = diachi;
			phieu.DienThoai = sdt;
			phieu.Email = email;
			phieu.NgayThuTien = ngaythu;
			phieu.TienThu = tienthu;

			StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(phieu), Encoding.UTF8, "application/json");

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44393/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.PostAsync("api/phieuthutien", content);

				if (response.IsSuccessStatusCode)
				{
					var check = await response.Content.ReadAsAsync<bool>();
					if (check)
					{
						MessageBox.Show("Lưu phiếu thành công", "Lưu phiếu thành công", MessageBoxButtons.OK);
						textBox1.Clear();
						textBox2.Clear();
						textBox4.Clear();
						textBox5.Clear();
						textBox6.Clear();
					}
					else
					{
						MessageBox.Show("Lưu phiếu thất bại", "Lưu phiếu thất bại", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ComboBox).Text == "Không") return;
			AutoFillInfo();
		}

		private async void AutoFillInfo()
		{
			string makh = comboBox1.Text;
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44393/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/khachhang/" + makh);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<KhachHang>();
					textBox1.Text = data.TenKH;
					textBox2.Text = data.DienThoai;
					textBox4.Text = data.DiaChi;
					textBox5.Text = data.Email;
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}
	}
}
