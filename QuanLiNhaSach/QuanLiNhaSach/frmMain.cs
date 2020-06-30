using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLiNhaSach
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
            if (login.DialogResult != DialogResult.OK)
                this.Close();

            lapphieusubpanel.Visible = false;
        }

        private Form activeform = null;

        private void OpenForm(Form form)
        {
            if (activeform != null)
                activeform.Close();

            activeform = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            childformpanel.Controls.Add(form);
            childformpanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void tracuubutton_Click(object sender, EventArgs e)
        {
            OpenForm(new frmTracuu());
        }

        private void lapphieubutton_Click(object sender, EventArgs e)
        {
            lapphieusubpanel.Visible = !lapphieusubpanel.Visible;
        }

        private void quanlibutton_Click(object sender, EventArgs e)
        {
            OpenForm(new frmQuanlinhanvien());
        }

        private void lapbaocaobutton_Click(object sender, EventArgs e)
        {
            OpenForm(new frmLapBaoCao());
        }

        private void quydinhbutton_Click(object sender, EventArgs e)
        {
            OpenForm(new frmQuyDinh());
        }

        private void Menupanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenForm(new frmTracuu());
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmLapPhieuNhap());

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenForm(new frmLapHoaDon());

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenForm(new frmLapPhieuThu());
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
