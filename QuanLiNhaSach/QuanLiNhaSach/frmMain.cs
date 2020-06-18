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

            //form
            this.DoubleBuffered = true;

            lapphieuSubMenuPanel.Visible = false;
            lapbaocaoSubMenuPanel.Visible = false;
            quanliSubMenuPanel.Visible = false;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void HideSubMenu()
        {
            if (lapphieuSubMenuPanel.Visible == true) lapphieuSubMenuPanel.Visible = false;
            if (lapbaocaoSubMenuPanel.Visible == true) lapbaocaoSubMenuPanel.Visible = false;
            if (quanliSubMenuPanel.Visible == true) quanliSubMenuPanel.Visible = false;
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
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.BringToFront();
            form.Show();
        }

		#region LapPhieu
		private void lapphieuButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(lapphieuSubMenuPanel);
        }

        private void nhapsachButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new frmLapPhieuNhapSach());
        }

        private void hoadonButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new frmLapHoaDon());
        }

        private void thutienButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new frmLapPhieuThuTien());
        }

		#endregion

		#region TraCuu
		private void tracuuButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenForm(new frmTraCuu());
        }

		#endregion

		#region LapBaoCao
		private void lapbaocaoButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(lapbaocaoSubMenuPanel);
        }

        private void baocaotonButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void baocaocongnoButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

		#endregion

		#region QuanLi

		private void quanliButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(quanliSubMenuPanel);
        }

        private void phancongButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void xemthongtinButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }


        #endregion

        #region TaiKhoan
        private void taikhoanButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();

        }

        #endregion

        #region HoTro
        private void hotroButton_Click(object sender, EventArgs e)
        {
            HideSubMenu();

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
    }
}
