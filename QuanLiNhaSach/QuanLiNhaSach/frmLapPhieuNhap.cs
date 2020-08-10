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
	public partial class frmLapPhieuNhap : Form
	{
		List<Sach> saches;
		public frmLapPhieuNhap()
		{
			InitializeComponent();
			saches = new List<Sach>();
		}
		private void frmLapPhieuNhap_Load(object sender, EventArgs e)
		{
			GetMaSach();
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
					data.Insert(0, "Không");
					comboBox1.DataSource = data;
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
				textBox1.ReadOnly = textBox2.ReadOnly = textBox3.ReadOnly = false;
				return;
			}
			textBox1.ReadOnly = textBox2.ReadOnly = textBox3.ReadOnly = true;

			AutoFillInfo();
		}
		private async void AutoFillInfo()
		{
			string masach = comboBox1.Text;
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:5001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync("api/sach/" + masach);

				if (response.IsSuccessStatusCode)
				{
					var data = await response.Content.ReadAsAsync<Sach>();
					textBox3.Text = data.TenSach;
					textBox2.Text = data.TheLoai;
					textBox1.Text = data.TacGia;
				}
				else
				{
					MessageBox.Show(string.Format("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase));
				}
			}
		}

		private void button3_Click(object sender, EventArgs e)
        {
			if (textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "") return;
			Sach sach = new Sach();
			sach.MaSach = comboBox1.Text;
			sach.TenSach = textBox3.Text;
			sach.TheLoai = textBox2.Text;
			sach.TacGia = textBox1.Text;
			sach.DonGia = (decimal?)numericUpDown1.Value;
			sach.SoLuong = (int?)numericUpDown1.Value;
			saches.Add(sach);
			ShowData(saches);
			comboBox1.Text = "Không";
			numericUpDown1.Value = numericUpDown1.Minimum;
			numericUpDown2.Value = numericUpDown2.Minimum;
			textBox3.Clear();
			textBox2.Clear();
			textBox1.Clear();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int i = dataGridView1.Rows.IndexOf(dataGridView1.CurrentRow);
			if (i < 0 || i >= saches.Count) return;
			saches.RemoveAt(i);
			ShowData(saches);
		}

		private void ShowData(List<Sach> data)
		{
			if (data == null) return;
			dataGridView1.Rows.Clear();
			foreach (var sach in data)
			{
				dataGridView1.Rows.Add(sach.TenSach, sach.TheLoai, sach.TacGia, sach.SoLuong, sach.DonGia);
			}
			dataGridView1.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			comboBox1.Text = "Không";
			numericUpDown1.Value = numericUpDown1.Minimum;
			numericUpDown2.Value = numericUpDown1.Minimum;
			textBox3.Clear();
			textBox2.Clear();
			textBox1.Clear();
			saches.Clear();
			ShowData(saches);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "")
			{
				return;
			}
			PostPhieuNhap();
		}

		private async void PostPhieuNhap()
		{
			PhieuNhapSach pn = new PhieuNhapSach();
			pn.NgayNhap = dateTimePicker1.Value;
			pn.Saches = saches;

			StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(pn), Encoding.UTF8, "application/json");

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:5001/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.PostAsync("api/phieunhapsach", content);

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
	}
}
