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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            load_data();
            Class.Functions.Fillcombo("select macm,chuyenmon from chuyenmon", cbochuyenmon, "macm", "chuyenmon");
            cbochuyenmon.SelectedIndex = -1;
            Class.Functions.Fillcombo("select mapb,phongban from phongban", cbophongban, "mapb", "phongban");
            cbophongban.SelectedIndex = -1;
            Class.Functions.Fillcombo("select macv,chucvu from chucvu", cbochucvu, "macv", "chucvu");
            cbochucvu.SelectedIndex = -1;
            Class.Functions.Fillcombo("select matd,trinhdo from trinhdo", cbotrinhdo, "matd", "trinhdo");
            cbotrinhdo.SelectedIndex = -1;
            btnlammoi.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = false;
        }
        DataTable tblnhanvien;
        private void load_data()
        {
            string sql;
            sql = "select manv,tennv,gioitinh,diachi,dienthoai,email,ngaysinh from nhanvien";
            tblnhanvien = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblnhanvien;
            DataGridView.Columns[0].HeaderText = "Mã nhân viên";
            DataGridView.Columns[1].HeaderText = "Tên nhân viên";
            DataGridView.Columns[2].HeaderText = "Giới tính";
            DataGridView.Columns[3].HeaderText = "Địa chỉ";
            DataGridView.Columns[4].HeaderText = "Điện thoại";
            DataGridView.Columns[5].HeaderText = "Email";
            DataGridView.Columns[6].HeaderText = "Ngày sinh";
            //DataGridView.Columns[7].HeaderText = "Mã chuyên môn";
            //DataGridView.Columns[8].HeaderText = "Mã trình độ";
            //DataGridView.Columns[9].HeaderText = "Mã chức vụ";
            //DataGridView.Columns[10].HeaderText = "Mã phòng ban";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 150;
            DataGridView.Columns[2].Width = 75;
            DataGridView.Columns[3].Width = 200;
            DataGridView.Columns[4].Width = 125;
            DataGridView.Columns[5].Width = 130;
            DataGridView.Columns[6].Width = 120;
            //DataGridView.Columns[7].Width = 150;
            //DataGridView.Columns[8].Width = 150;
            //DataGridView.Columns[9].Width = 150;
            //DataGridView.Columns[10].Width = 150;
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

        private void resetvalues()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            mskdienthoai.Text = "";
            mskngaysinh.Text = "";
            cbochucvu.Text = "";
            cbochuyenmon.Text = "";
            cbophongban.Text = "";
            cbotrinhdo.Text = "";
            chkgioitinh.Checked = false;
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            btnthemmoi.Enabled = false;
            btnluu.Enabled = true;
            resetvalues();
            txtmanv.Focus();
            btnlammoi.Enabled = true;
            txtmanv.ReadOnly = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (tblnhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnthemmoi.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (DataGridView.CurrentRow.Cells["gioitinh"].Value.ToString() == "Nam")
            {
                chkgioitinh.Checked = true;
            }
            else chkgioitinh.Checked = false;
            txtmanv.Text = DataGridView.CurrentRow.Cells["manv"].Value.ToString();
            txttennv.Text = DataGridView.CurrentRow.Cells["tennv"].Value.ToString();
            txtdiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            txtemail.Text = DataGridView.CurrentRow.Cells["email"].Value.ToString();
            mskdienthoai.Text = DataGridView.CurrentRow.Cells["dienthoai"].Value.ToString();
            mskngaysinh.Text = DataGridView.CurrentRow.Cells["ngaysinh"].Value.ToString();
            string macm, matd, macv, mapb;
            macm = Class.Functions.GetFieldValues("select macm from nhanvien where manv = '" + txtmanv.Text + "'");
            cbochuyenmon.Text = Class.Functions.GetFieldValues("select chuyenmon from chuyenmon where macm = '" + macm + "'");
            matd = Class.Functions.GetFieldValues("select matd from nhanvien where manv = '" + txtmanv.Text + "'");
            cbotrinhdo.Text = Class.Functions.GetFieldValues("select trinhdo from trinhdo where matd = '" + matd + "'");
            macv = Class.Functions.GetFieldValues("select macv from nhanvien where manv = '" + txtmanv.Text + "'");
            cbochucvu.Text = Class.Functions.GetFieldValues("select chucvu from chucvu where macv = '" + macv + "'");
            mapb = Class.Functions.GetFieldValues("select mapb from nhanvien where manv = '" + txtmanv.Text + "'");
            cbophongban.Text = Class.Functions.GetFieldValues("select phongban from phongban where mapb = '" + mapb + "'");
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnlammoi.Enabled = true;
            txtmanv.ReadOnly = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
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
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaysinh.Text))
            {
                MessageBox.Show("Sai định dạng ngày sinh, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                mskngaysinh.Text = "";
                return;
            }
            string gt;
            if (chkgioitinh.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";
            if (cbochucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbochucvu.Focus();
                return;
            }
            if (cbochuyenmon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbochuyenmon.Focus();
                return;
            }
            if (cbophongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbophongban.Focus();
                return;
            }
            if (cbotrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbotrinhdo.Focus();
                return;
            }
            string sql;
            sql = "select manv from nhanvien where manv = '" + txtmanv.Text + "'";
            if (Class.Functions.Checkkey(sql))
            {
                MessageBox.Show("Đã tồn tại nhân viên " + txtmanv.Text + " trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmanv.Text = "";
                txtmanv.Focus();
                return;
            }
            sql = "insert into nhanvien (manv,tennv,gioitinh,diachi,dienthoai,email,ngaysinh,macm,matd,macv,mapb) values ('" + txtmanv.Text +
                "',N'" + txttennv.Text + "',N'" + gt + "',N'" + txtdiachi.Text + "','" + mskdienthoai.Text + "','" + txtemail.Text + "','" +
                Class.Functions.ConvertDate(mskngaysinh.Text) + "','" + cbochuyenmon.SelectedValue.ToString() + "','" + cbotrinhdo.SelectedValue.ToString() +
                "','" + cbochucvu.SelectedValue.ToString() + "','" + cbophongban.SelectedValue.ToString() + "')";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnluu.Enabled = false;
            btnthemmoi.Enabled = true;
            btnlammoi.Enabled = false;
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanv.Focus();
                return;
            }
            if (txttennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennv.Focus();
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
            if (mskngaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaysinh.Text))
            {
                MessageBox.Show("Sai định dạng ngày sinh, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                mskngaysinh.Text = "";
                return;
            }
            string gt;
            if (chkgioitinh.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";
            if (cbochucvu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbochucvu.Focus();
                return;
            }
            if (cbochuyenmon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn chuyên môn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbochuyenmon.Focus();
                return;
            }
            if (cbophongban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbophongban.Focus();
                return;
            }
            if (cbotrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn trình độ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbotrinhdo.Focus();
                return;
            }
            string sql;
            sql = "update nhanvien set tennv = N'" + txttennv.Text + "', gioitinh = N'" + gt + "', diachi = N'" + txtdiachi.Text + "', dienthoai = '" +
                mskdienthoai.Text + "', email = '" + txtemail.Text + "', ngaysinh = '" + Class.Functions.ConvertDate(mskngaysinh.Text) + "', macm = '" + cbochuyenmon.SelectedValue.ToString() +
                "', matd = '" + cbotrinhdo.SelectedValue.ToString() + "', macv = '" + cbochucvu.SelectedValue.ToString() + "', mapb = '" +
                cbophongban.SelectedValue.ToString() + "' where manv = '" + txtmanv.Text + "'";
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
            if (MessageBox.Show("Bạn chắc chắn muốn xóa mã nhân viên " + txtmanv.Text + " khỏi bảng?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete from nhanvien where manv = '" + txtmanv.Text + "'";
                Class.Functions.Runsqldel(sql);
                load_data();
                resetvalues();
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                btnlammoi.Enabled = false;
            }
        }
    }
}
