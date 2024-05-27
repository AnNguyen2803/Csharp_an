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
    public partial class frmctvb : Form
    {
        DataTable tblcthopdong;
        public frmctvb()
        {
            InitializeComponent();
        }
        string mavb;
        public void GetValue(string value)
        {
            mavb = value;
        }
        public void resetvalues()
        {
            txtmactvb.Text = "";
            cbomabao.Text = "";
            cbomatheloai.Text = "";
            mskngaydang.Text = "";
            txtnhuanbut.Text = "";
            txttieude.Text = "";
            txtnoidung.Text = "";
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb where a.mavb='" + mavb + "' " + "group by a.mavb"));
            if (txttongtien.Text != "0")
            {
                lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: Không đồng";
            }
        }

        private void frmctvb_Load(object sender, EventArgs e)
        {
            txtmactvb.ReadOnly = true;
            Class.Functions.Fillcombo("select mabao, tenbao from bao", cbomabao, "mabao", "mabao");
            cbomabao.SelectedIndex = -1;
            txttenbao.ReadOnly = true;
            Class.Functions.Fillcombo("select matheloai, theloai from theloai", cbomatheloai, "matheloai", "matheloai");
            cbomatheloai.SelectedIndex = -1;
            txttheloai.ReadOnly = true;
            txtnhuanbut.ReadOnly = true;
            load_data();
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            btndong.Enabled = true;
            txttongtien.ReadOnly = true;
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb where a.mavb='" + mavb + "' " + "group by a.mavb"));
            if (txttongtien.Text != "0")
            {
                lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: Không đồng";
            }
        }
        private void load_data()
        {
            string sql;
            sql = "select mactvb,mabao,matheloai,tieude,noidung,ngaydang,nhuanbut from chitietvietbai where mavb = '" + mavb + "'";
            tblcthopdong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblcthopdong;
            DataGridView.Columns[0].HeaderText = "Mã CTVB";
            DataGridView.Columns[1].HeaderText = "Mã báo";
            DataGridView.Columns[2].HeaderText = "Mã thể loại";
            DataGridView.Columns[3].HeaderText = "Tiêu đề";
            DataGridView.Columns[4].HeaderText = "Nội dung";
            DataGridView.Columns[5].HeaderText = "Ngày đăng";
            DataGridView.Columns[6].HeaderText = "Nhuận bút";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 90;
            DataGridView.Columns[2].Width = 150;
            DataGridView.Columns[3].Width = 200;
            DataGridView.Columns[4].Width = 200;
            DataGridView.Columns[5].Width = 130;
            DataGridView.Columns[6].Width = 90;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbomabao_TextChanged(object sender, EventArgs e)
        {
            if (cbomabao.Text == "")
            {
                txttenbao.Text = "";
            }
            else
            {
                txttenbao.Text = Class.Functions.GetFieldValues("select tenbao from bao where mabao ='" + cbomabao.SelectedValue + "'");
                txtnhuanbut.Text = Class.Functions.GetFieldValues("select nhuanbut from banggiavb where mabao = '" + cbomabao.SelectedValue + "' and matheloai = '" + cbomatheloai.SelectedValue + "'");
            }
        }

        private void cbomatheloai_TextChanged(object sender, EventArgs e)
        {
            if (cbomatheloai.Text == "")
            {
                txttheloai.Text = "";
            }
            else
            {
                txttheloai.Text = Class.Functions.GetFieldValues("select theloai from theloai where matheloai ='" + cbomatheloai.SelectedValue + "'");
                txtnhuanbut.Text = Class.Functions.GetFieldValues("select nhuanbut from banggiavb where mabao = '" + cbomabao.SelectedValue + "' and matheloai = '" + cbomatheloai.SelectedValue + "'");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btncapnhat.Enabled = false;
            txtmactvb.Text = Class.Functions.CreateKey("CTVB");
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cbomabao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                return;
            }
            if (cbomatheloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomatheloai.Focus();
                return;
            }
            if (mskngaydang.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày đăng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaydang.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaydang.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaydang.Focus();
                mskngaydang.Text = "";
                return;
            }
            if (txttieude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa điền tiêu đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttieude.Focus();
                return;
            }
            if (txtnoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa điền nội dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnoidung.Focus();
                return;
            }
            string sql;
            sql = "insert into chitietvietbai (mactvb,mabao,matheloai,tieude,noidung,ngaydang,nhuanbut,mavb) values ('" + txtmactvb.Text + "','" + cbomabao.SelectedValue.ToString() + "','" +
                cbomatheloai.SelectedValue.ToString() + "',N'" + txttieude.Text + "',N'" + txtnoidung.Text + "','" + Class.Functions.ConvertDate(mskngaydang.Text) + "'," +
                txtnhuanbut.Text + ",'" + mavb + "')";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnluu.Enabled = false;
            btnthem.Enabled = true;
            btnboqua.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (cbomabao.Text == "" && cbomatheloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mskngaydang.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày đăng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaydang.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaydang.Text))
            {
                MessageBox.Show("Sai định dạng ngày tháng, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaydang.Focus();
                mskngaydang.Text = "";
                return;
            }
            if (txttieude.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa điền tiêu đề!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttieude.Focus();
                return;
            }
            if (txtnoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnoidung.Focus();
                return;
            }
            string sql;
            sql = "update chitietvietbai set mabao ='" + cbomabao.SelectedValue.ToString() + "', matheloai ='" + cbomatheloai.SelectedValue.ToString() + "', noidung =N'" +
                txtnoidung.Text + "', ngaydang ='" + Class.Functions.ConvertDate(mskngaydang.Text) + "', tieude =N'" +
                txttieude.Text + "', nhuanbut ='" + txtnhuanbut.Text + "' where mactvb ='" + txtmactvb.Text + "'";
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btncapnhat.Enabled = false;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (tblcthopdong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtmactvb.Text = DataGridView.CurrentRow.Cells["mactvb"].Value.ToString();
            string mabao, matheloai;
            mabao = DataGridView.CurrentRow.Cells["mabao"].Value.ToString();
            cbomabao.Text = Class.Functions.GetFieldValues("select mabao from bao where mabao ='" + mabao + "'");
            matheloai = DataGridView.CurrentRow.Cells["matheloai"].Value.ToString();
            cbomatheloai.Text = Class.Functions.GetFieldValues("select matheloai from theloai where matheloai ='" + matheloai + "'");
            txttieude.Text = DataGridView.CurrentRow.Cells["tieude"].Value.ToString();
            txtnoidung.Text = DataGridView.CurrentRow.Cells["noidung"].Value.ToString();
            txtnhuanbut.Text = Class.Functions.GetFieldValues("Select nhuanbut from banggiavb where mabao ='" + mabao + "' and matheloai = '" + matheloai + "'");
            mskngaydang.Text = DataGridView.CurrentRow.Cells["ngaydang"].Value.ToString();
            btncapnhat.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bài viết này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                sql = "delete from chitietvietbai where mactvb = '" + txtmactvb.Text + "'";
                Class.Functions.Runsqldel(sql);
                load_data();
                resetvalues();
                btnboqua.Enabled = false;
                btncapnhat.Enabled = false;
            }
        }
    }
}
