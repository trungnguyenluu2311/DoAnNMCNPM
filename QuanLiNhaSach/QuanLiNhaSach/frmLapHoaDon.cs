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
using System.Security.Cryptography;

namespace QuanLiNhaSach
{
	public partial class frmLapHoaDon : Form
	{
		List<Sach> saches;
		public frmLapHoaDon()
		{
			InitializeComponent();
			saches = new List<Sach>();
		}

		private void frmLapHoaDon_Load(object sender, EventArgs e)
		{
			GetMaKH();
			GetMaSach();
		}

		private async void GetMaKH()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:5001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/khachhang/getallmakhachhang");

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

		private async void GetMaSach()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:5001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/sach/getallmasach");

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<List<string>>();
					comboBox2.DataSource = data;
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ComboBox).Text == "Không")
			{
				textBox2.ReadOnly = textBox3.ReadOnly = textBox4.ReadOnly = textBox7.ReadOnly = false;
				return;
			}
			textBox2.ReadOnly = textBox3.ReadOnly = textBox4.ReadOnly = textBox7.ReadOnly = true;

			AutoFillKhachHangInfo();
		}
		private async void AutoFillKhachHangInfo()
		{
			string makh = comboBox1.Text;
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:5001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/khachhang/" + makh);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<KhachHang>();
					textBox2.Text = data.TenKH;
					textBox3.Text = data.DiaChi;
					textBox4.Text = data.DienThoai;
					textBox7.Text = data.Email;
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((sender as ComboBox).Text == "Không")
			{
				textBox5.ReadOnly = textBox6.ReadOnly = textBox8.ReadOnly = textBox1.ReadOnly = false;
				return;
			}
			textBox5.ReadOnly = textBox6.ReadOnly = textBox8.ReadOnly = textBox1.ReadOnly = true;
			AutoFillSachInfo();
		}

		private async void AutoFillSachInfo()
		{
			string masach = comboBox2.Text;
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:50001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/sach/" + masach);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<Sach>();
					textBox6.Text = data.TenSach;
					textBox5.Text = data.TheLoai;
					textBox1.Text = data.TacGia;
					numericUpDown1.Value = 1;
					textBox8.Text = Convert.ToInt32(data.DonGia).ToString();
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox6.Text == "" || textBox5.Text == "" || textBox1.Text == "" || textBox8.Text == "") return;
			Sach sach = new Sach();
			sach.MaSach = comboBox2.Text;
			sach.TenSach = textBox6.Text;
			sach.TheLoai = textBox5.Text;
			sach.TacGia = textBox1.Text;
			sach.DonGia = int.Parse(textBox8.Text);
			sach.SoLuong = (int?)numericUpDown1.Value;
			saches.Add(sach);
			ShowData(saches);
			comboBox2.Text = "Không";
			numericUpDown1.Value = 0;
			textBox5.Clear();
			textBox6.Clear();
			textBox1.Clear();
			textBox8.Clear();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int i = dataGridView1.Rows.IndexOf(dataGridView1.CurrentRow);
			if (i < 0 || i>= saches.Count) return;
			saches.RemoveAt(i);
			ShowData(saches);
		}

		private void ShowData(List<Sach> data)
		{
			if (data == null) return;
			int thanhtien = 0;
			dataGridView1.Rows.Clear();
			foreach (var sach in data)
			{
				dataGridView1.Rows.Add(sach.TenSach, sach.TheLoai, sach.TacGia, sach.SoLuong, sach.DonGia);
				thanhtien += Convert.ToInt32(sach.SoLuong) * Convert.ToInt32(sach.DonGia);
			}
			label10.Text = thanhtien.ToString();
			label14.Text = thanhtien.ToString();
			dataGridView1.Refresh();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox7.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || saches.Count == 0) 
			{
				return;
			}
			PostHoaDon();
		}

		private async void PostHoaDon()
		{
			HoaDon hoadon = new HoaDon();
			hoadon.MaKH = comboBox1.Text != "Không" ? comboBox1.Text : "Khong";
			hoadon.TenKH = textBox2.Text;
			hoadon.DiaChi = textBox3.Text;
			hoadon.DienThoai = textBox4.Text;
			hoadon.Email = textBox7.Text;
			hoadon.NgayLap = dateTimePicker1.Value;
			hoadon.ThanhTien = Convert.ToInt32(label10.Text);
			hoadon.Saches = saches;

			StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(hoadon), Encoding.UTF8, "application/json");

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:5001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.PostAsync("api/hoadon", content);

				if (response.IsSuccessStatusCode)
				{
					if (response.StatusCode == System.Net.HttpStatusCode.OK)
					{
						MessageBox.Show("Lưu phiếu thành công", "Lưu phiếu thành công", MessageBoxButtons.OK);
						button1_Click(null, null);
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

		private void button1_Click(object sender, EventArgs e)
		{
			comboBox1.Text = comboBox2.Text = "Không";
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			numericUpDown1.Value = 0;
			saches.Clear();
			ShowData(saches);
		}
	}
}
