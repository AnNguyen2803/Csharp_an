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
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }
        private void resetvalues()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            mskdienthoai.Text = "";
            cbolvhd.Text = "";
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnlammoi.Enabled = false;
            btnluu.Enabled = false;
            load_data();
            Class.Functions.Fillcombo("Select malvhd,linhvuchoatdong from linhvuchoatdong", cbolvhd, "malvhd", "linhvuchoatdong");
            cbolvhd.SelectedIndex = -1;
        }
        DataTable tblkhachhang;
        private void load_data()
        {
            string sql;
            sql = "select makh,tenkh,malvhd,diachi,dienthoai,email from khachhang";
            tblkhachhang = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblkhachhang;
            DataGridView.Columns[0].HeaderText = "Mã khách hàng";
            DataGridView.Columns[1].HeaderText = "Tên khách hàng";
            DataGridView.Columns[2].HeaderText = "Mã lĩnh vực hoạt động";
            DataGridView.Columns[3].HeaderText = "Địa chỉ";
            DataGridView.Columns[4].HeaderText = "Điện thoại";
            DataGridView.Columns[5].HeaderText = "Email";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 150;
            DataGridView.Columns[2].Width = 125;
            DataGridView.Columns[3].Width = 150;
            DataGridView.Columns[4].Width = 150;
            DataGridView.Columns[5].Width = 220;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnthemmoi.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tblkhachhang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn tại trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtmakh.Text = DataGridView.CurrentRow.Cells["makh"].Value.ToString();
            txttenkh.Text = DataGridView.CurrentRow.Cells["tenkh"].Value.ToString();
            txtdiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            txtemail.Text = DataGridView.CurrentRow.Cells["email"].Value.ToString();
            mskdienthoai.Text = DataGridView.CurrentRow.Cells["dienthoai"].Value.ToString();
            string ma;
            ma = DataGridView.CurrentRow.Cells["malvhd"].Value.ToString();
            cbolvhd.Text = Class.Functions.GetFieldValues("select linhvuchoatdong from linhvuchoatdong where malvhd = '" + ma + "'");
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnlammoi.Enabled = true;
            txtmakh.ReadOnly = true;
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            btnthemmoi.Enabled = false;
            btnluu.Enabled = true;
            resetvalues();
            txtmakh.Focus();
            btnlammoi.Enabled = true;
            txtmakh.ReadOnly = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            resetvalues();
            btnthemmoi.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakh.Focus();
                return;
            }
            if (txttenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkh.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            if (cbolvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn lĩnh vực hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbolvhd.Focus();
                return;
            }
            string sql;
            sql = "select makh from khachhang where makh = '" + txtmakh.Text + "'";
            if (Class.Functions.Checkkey(sql))
            {
                MessageBox.Show("Đã tồn tại khách hàng " + txtmakh.Text + " trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmakh.Text = "";
                txtmakh.Focus();
                return;
            }
            sql = "insert into khachhang (makh,tenkh,diachi,email,dienthoai,malvhd) values ('" + txtmakh.Text + "',N'" +
                txttenkh.Text + "',N'" + txtdiachi.Text + "','" + txtemail.Text + "','" +
                mskdienthoai.Text + "','" + cbolvhd.SelectedValue.ToString() + "')";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnluu.Enabled = false;
            btnthemmoi.Enabled = true;
            btnlammoi.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakh.Focus();
                return;
            }
            if (txttenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkh.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }
            if (mskdienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            if (cbolvhd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn lĩnh vực hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbolvhd.Focus();
                return;
            }
            string sql;
            sql = "update khachhang set tenkh = N'" + txttenkh.Text + "', diachi = N'" + txtdiachi.Text + "', dienthoai = '" + mskdienthoai.Text +
                "',email = '" + txtemail.Text + "', malvhd = '" + cbolvhd.SelectedValue.ToString() + "' where makh = '" + txtmakh.Text + "'";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnlammoi.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if(MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng " + txttenkh.Text + " khỏi bảng?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete from khachhang where makh = '" + txtmakh.Text + "'";
                Class.Functions.Runsqldel(sql);
                load_data();
                resetvalues();
                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                btnlammoi.Enabled = false;
            }
        }
    }
}
