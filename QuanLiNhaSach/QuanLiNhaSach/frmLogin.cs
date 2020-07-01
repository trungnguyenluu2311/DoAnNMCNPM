using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using QuanLiNhaSach.Models;
using Newtonsoft;

namespace QuanLiNhaSach
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			panel5.Visible = false;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel4.Visible = false;
			panel5.Visible = true;
			textBox1.Clear();
			textBox2.Clear();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			panel5.Visible = false;
			panel4.Visible = true;
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string username, password;
			username = textBox1.Text;
			password = textBox2.Text;

			CheckUser(username, password);
		}

		private async void CheckUser(string username, string password)
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44393/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.GetAsync(string.Format("api/user/CheckUser/username={0};password={1}", username, password));

				if (response.IsSuccessStatusCode)
				{
					var check = await response.Content.ReadAsAsync<bool>();
					if(check)
					{
						DialogResult = DialogResult.OK;
						this.Close();
					}
					else
					{
						MessageBox.Show("Sai username hoặc password","Đăng nhập không thành công", MessageBoxButtons.OK);
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
			string username, password;
			int loaitk;
			username = textBox4.Text;
			password = textBox3.Text;
			loaitk = comboBox1.Text == "Administrator" ? 0 : comboBox1.Text == "Quản lí" ? 1 : 2;

			RegistUser(username, password, loaitk);
		}

		private async void RegistUser(string username, string password, int loaitk)
		{
			if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
			{
				MessageBox.Show("Hãy điền đầy đủ các thông tin", "Đăng kí thất bại", MessageBoxButtons.OK);
				return;
			}

			if(textBox3.Text != textBox5.Text)
			{
				MessageBox.Show("Verify password không khớp với password", "Đăng kí thất bại", MessageBoxButtons.OK);
				return;
			}

			User u = new User();
			u.Username = username;
			u.Password = password;
			u.QuyenHan = loaitk;

			StringContent content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(u), Encoding.UTF8, "application/json");

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://localhost:44393/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				HttpResponseMessage response = await client.PostAsync("api/user", content);

				if (response.IsSuccessStatusCode)
				{
					var check = await response.Content.ReadAsAsync<bool>();
					if(check)
					{
						MessageBox.Show("Đăng kí thành công", "Đăng kí thành công", MessageBoxButtons.OK);
						textBox3.Clear();
						textBox4.Clear();
						textBox5.Clear();
					}
					else
					{
						MessageBox.Show("Username đã tồn tại", "Đăng kí thất bại", MessageBoxButtons.OK);
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
