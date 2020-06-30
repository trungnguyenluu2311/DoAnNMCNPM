using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaSach
{
	public partial class frmQuanlinhanvien : Form
	{
        string flag;
        DataTable dtNV;
        int index;
		public frmQuanlinhanvien()
		{
			InitializeComponent();
		}
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("HoTen");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("DienThoai");
            dt.Columns.Add("NgaySinh");
            return dt;
        }
        public void  LockControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaNV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtGioiTinh.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            btnThem.Focus();
        }
        public void UnLockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtMaNV.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            txtGioiTinh.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtDienThoai.ReadOnly = false;
            txtMaNV.Focus();
        }

        private void FrmQuanlinhanvien_Load(object sender, EventArgs e)
        {
            LockControl();
            dtNV = createTable();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "add";

            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = " ";
            txtDienThoai.Text = "";
            dtpNgaySinh.Text = "";
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            UnLockControl();
            flag = "edit";
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if(flag == "add")
            {
                if (checkData())
                {
                    dtNV.Rows.Add(txtMaNV.Text, txtHoTen.Text, txtGioiTinh.Text ,txtDiaChi.Text, txtDienThoai.Text, dtpNgaySinh.Text);
                    dataGridNV.DataSource = dtNV;
                    dataGridNV.RefreshEdit();
                }
            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    dtNV.Rows[index][0] = txtMaNV.Text;
                    dtNV.Rows[index][1] = txtHoTen.Text;
                    dtNV.Rows[index][2] = txtGioiTinh.Text;
                    dtNV.Rows[index][3] = txtDiaChi.Text;
                    dtNV.Rows[index][4] = txtDienThoai.Text;
                    dtNV.Rows[index][5] = dtpNgaySinh.Text;
                    dataGridNV.DataSource = dtNV;
                    dataGridNV.RefreshEdit();
                }
            }
            LockControl();
        }

        public bool checkData()
        {
            if(string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }

        /*private void DataGridNV_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridNV.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridNV.DataSource; 

            if (dt.Rows != null || dt.Rows.Count > 0 )
            {
                txtMaNV.Text = dataGridNV.Rows[index].Cells[0].Value.ToString();
                txtHoTen.Text = dataGridNV.Rows[index].Cells[1].Value.ToString();
                txtGioiTinh.Text = dataGridNV.Rows[index].Cells[2].Value.ToString();
                txtDiaChi.Text = dataGridNV.Rows[index].Cells[3].Value.ToString();
                txtDienThoai.Text = dataGridNV.Rows[index].Cells[4].Value.ToString();
                dtpNgaySinh.Text = dataGridNV.Rows[index].Cells[5].Value.ToString();           
            }
        }*/

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa nhân viên không?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtNV.Rows.RemoveAt(index);
                dataGridNV.DataSource = dtNV;
                dataGridNV.RefreshEdit();
            }
        }
    }
}
