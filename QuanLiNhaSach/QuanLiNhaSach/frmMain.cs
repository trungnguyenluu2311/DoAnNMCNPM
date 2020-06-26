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
            OpenForm(new frmLapPhieuNhap());
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

    }
}
