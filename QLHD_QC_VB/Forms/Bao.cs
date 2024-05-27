using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHD_QC_VB.Forms
{
    public partial class frmbao : Form
    {
        DataTable tblbao;
        public frmbao()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtmabao.Text = "";
            txttenbao.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            mskdienthoai.Text = "";
        }

        private void frmbao_Load(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = false;
            btnlammoi.Enabled = false;
            load_data();
        }
        private void load_data()
        {
            string sql;
            sql = "select mabao, tenbao, diachi, sdt, email from bao";
            tblbao = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblbao;
            DataGridView.Columns[0].HeaderText = "Mã báo";
            DataGridView.Columns[1].HeaderText = "Tên báo";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Số điện thoại";
            DataGridView.Columns[4].HeaderText = "Email";
            DataGridView.Columns[0].Width = 75;
            DataGridView.Columns[1].Width = 175;
            DataGridView.Columns[2].Width = 400;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 200;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnthemmoi.Enabled = false;
            txtmabao.Focus();
            btnlammoi.Enabled = true;
            btnluu.Enabled = true;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            resetvalues();
            btnthemmoi.Enabled = true;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthemmoi.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmabao.Focus();
                return;
            }
            if (tblbao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn tại trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtmabao.Text = DataGridView.CurrentRow.Cells["mabao"].Value.ToString();
            txttenbao.Text = DataGridView.CurrentRow.Cells["tenbao"].Value.ToString();
            txtdiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            txtemail.Text = DataGridView.CurrentRow.Cells["email"].Value.ToString();
            mskdienthoai.Text = DataGridView.CurrentRow.Cells["sdt"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnlammoi.Enabled = true;
            txtmabao.ReadOnly = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmabao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmabao.Focus();
                return;
            }
            if (txttenbao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenbao.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            string sql;
            sql = "select mabao from bao where mabao = '" + txtmabao.Text + "'";
            if (Class.Functions.Checkkey(sql))
            {
                MessageBox.Show("Đã tồn tại mã báo " + txtmabao.Text + " trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmabao.Text = "";
                txtmabao.Focus();
                return;
            }
            sql = "insert into bao (mabao,tenbao,diachi,sdt,email) values ('" + txtmabao.Text + "',N'" +
                txttenbao.Text + "',N'" + txtdiachi.Text + "','" + mskdienthoai.Text + "','" + txtemail.Text + "')";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnthemmoi.Enabled = true;
            btnluu.Enabled = false;
            btnlammoi.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa " + txttenbao.Text + " không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete from bao where mabao = '" + txtmabao.Text + "'";
                Class.Functions.Runsqldel(sql);
                load_data();
                resetvalues();
                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnlammoi.Enabled = false;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "update bao set tenbao = N'" + txttenbao.Text + "', diachi = N'" + txtdiachi.Text + "', sdt = '" + 
                mskdienthoai.Text + "', email = '" + txtemail.Text + "' where mabao = '" + txtmabao.Text + "'";
            Class.Functions.Runsql(sql);
            load_data(); 
            resetvalues();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnlammoi.Enabled = false;
        }
    }
}
