using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLHD_QC_VB.Forms
{
    public partial class frmcthopdong : Form
    {
        public frmcthopdong()
        {
            InitializeComponent();
        }
        string maqc;
        public void GetValue(string value)
        {
            maqc = value;
        }
        public void resetvalues()
        {
            cbomabao.Text = "";
            cbomadv.Text = "";
            mskngaybd.Text = "";
            mskngaykt.Text = "";
            txtdongia.Text = "";
            txtnoidung.Text = "";
            txtthanhtien.Text = "0";
            txtmaCTQC.Text = "";
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc where a.maqc='" + maqc + "' " + "group by a.maqc"));
            if (txttongtien.Text != "0")
            {
                lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: Không đồng";
            }

        }
        private void CTHopdongQC_Load(object sender, EventArgs e)
        {
            load_data();
            txttendv.ReadOnly = true;
            txttenbao.ReadOnly = true;
            txtdongia.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            Class.Functions.Fillcombo("select mabao,tenbao from bao", cbomabao, "mabao", "mabao");
            cbomabao.SelectedIndex = -1;
            Class.Functions.Fillcombo("select madv,dichvu from dichvu", cbomadv, "madv", "madv");
            cbomadv.SelectedIndex = -1;
            txtthanhtien.Text = "0";
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc where a.maqc='" + maqc + "' " + "group by a.maqc"));
            if (txttongtien.Text != "0")
            {
                lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
            }
            else
            {
                lblbangchu.Text = "Bằng chữ: Không đồng";
            }

        }
        DataTable tblcthopdong;
        private void load_data()
        {
            string sql;
            sql = "select mactqc,mabao,madv,noidung,ngaybd,ngaykt,dongia,(dongia * abs(datediff(day,ngaykt,ngaybd))) as thanhtien from chitietquangcao where maqc = '" + maqc + "'";
            tblcthopdong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblcthopdong;
            DataGridView.Columns[0].HeaderText = "Mã CTQC";
            DataGridView.Columns[1].HeaderText = "Mã báo";
            DataGridView.Columns[2].HeaderText = "Mã dịch vụ";
            DataGridView.Columns[3].HeaderText = "Nội dung";
            DataGridView.Columns[4].HeaderText = "Ngày bắt đầu";
            DataGridView.Columns[5].HeaderText = "Ngày kết thúc";
            DataGridView.Columns[6].HeaderText = "Đơn giá";
            DataGridView.Columns[7].HeaderText = "Thành tiền";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 90;
            DataGridView.Columns[2].Width = 115;
            DataGridView.Columns[3].Width = 200;
            DataGridView.Columns[4].Width = 130;
            DataGridView.Columns[5].Width = 130;
            DataGridView.Columns[6].Width = 90;
            DataGridView.Columns[7].Width = 90;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
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
            txtmaCTQC.Text = DataGridView.CurrentRow.Cells["mactqc"].Value.ToString();
            string mabao, madv;
            mabao = DataGridView.CurrentRow.Cells["mabao"].Value.ToString();
            cbomabao.Text = Class.Functions.GetFieldValues("select mabao from bao where mabao ='" + mabao + "'");
            madv = DataGridView.CurrentRow.Cells["madv"].Value.ToString();
            cbomadv.Text = Class.Functions.GetFieldValues("select madv from dichvu where madv ='" + madv + "'");
            txtnoidung.Text = DataGridView.CurrentRow.Cells["noidung"].Value.ToString();
            txtdongia.Text = Class.Functions.GetFieldValues("Select dongia from banggiaqc where mabao ='" + mabao + "' and madv = '" + madv + "'");
            mskngaybd.Text = DataGridView.CurrentRow.Cells["ngaybd"].Value.ToString();
            mskngaykt.Text = DataGridView.CurrentRow.Cells["ngaykt"].Value.ToString();
            txtthanhtien.Text = DataGridView.CurrentRow.Cells["thanhtien"].Value.ToString();
            btncapnhat.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void cbomadv_TextChanged(object sender, EventArgs e)
        {
            if (cbomadv.Text == "")
            {
                txttendv.Text = "";
            }
            else
            {
                txttendv.Text = Class.Functions.GetFieldValues("select dichvu from dichvu where madv ='" + cbomadv.SelectedValue + "'");
                txtdongia.Text = Class.Functions.GetFieldValues("select dongia from banggiaqc where mabao = '" + cbomabao.SelectedValue + "' and madv = '" + cbomadv.SelectedValue + "'");
            }
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
                txtdongia.Text = Class.Functions.GetFieldValues("select dongia from banggiaqc where mabao = '" + cbomabao.SelectedValue + "' and madv = '" + cbomadv.SelectedValue + "'");
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
            btnthem.Enabled = true;
            btncapnhat.Enabled = false;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (cbomabao.Text == "" && cbomadv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mskngaybd.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybd.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaybd.Text))
            {
                MessageBox.Show("Sai định dạng ngày tháng, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybd.Focus();
                mskngaybd.Text = "";
                return;
            }
            if (mskngaykt.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaykt.Text))
            {
                MessageBox.Show("Sai định dạng ngày tháng, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                mskngaykt.Text = "";
                return;
            }
            if (Class.Functions.DateDiff(mskngaybd.Text, mskngaykt.Text) < 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                return;
            }
            if (txtnoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập nội dung!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnoidung.Focus();
                return;
            }
            string sql;
            sql = "update chitietquangcao set mabao ='" + cbomabao.SelectedValue.ToString() + "', madv ='" + cbomadv.SelectedValue.ToString() + "', noidung =N'" +
                txtnoidung.Text + "', ngaybd ='" + Class.Functions.ConvertDate(mskngaybd.Text) + "', ngaykt ='" + Class.Functions.ConvertDate(mskngaykt.Text) +
                "', dongia ='" + txtdongia.Text + "' where mactqc ='" + txtmaCTQC.Text + "'";
            Class.Functions.GetDataToTable(sql);
            load_data();
            resetvalues();
            btncapnhat.Enabled = false;
            btnboqua.Enabled = false;
            btnluu.Enabled = false;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            resetvalues();
            btnthem.Enabled = false;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btncapnhat.Enabled = false;
            txtmaCTQC.Text = Class.Functions.CreateKey("CTQC");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cbomabao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomabao.Focus();
                return;
            }
            if (cbomadv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn mã dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomadv.Focus();
                return;
            }
            if (mskngaybd.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybd.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaybd.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaybd.Focus();
                mskngaybd.Text = "";
                return;
            }
            if (mskngaykt.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaykt.Text))
            {
                MessageBox.Show("Sai định dạng ngày, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                mskngaykt.Text = "";
                return;
            }
            if (Class.Functions.DateDiff(mskngaybd.Text, mskngaykt.Text) < 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaykt.Focus();
                return;
            }
            if (txtnoidung.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa điền nội dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnoidung.Focus();
                return;
            }
            string sql;
            sql = "insert into chitietquangcao (mactqc,mabao,madv,noidung,ngaybd,ngaykt,dongia,maqc) values ('" + txtmaCTQC.Text + "','" + cbomabao.SelectedValue.ToString() + "','" +
                cbomadv.SelectedValue.ToString() + "',N'" + txtnoidung.Text + "','" + Class.Functions.ConvertDate(mskngaybd.Text) + "','" +
                Class.Functions.ConvertDate(mskngaykt.Text) + "'," + txtdongia.Text + ",'" + maqc + "')";
            Class.Functions.GetDataToTable(sql);
            load_data();
            resetvalues();
            btnluu.Enabled = false;
            btnthem.Enabled = true;
            btnboqua.Enabled = false;
        }

        private void mskngaybd_TextChanged(object sender, EventArgs e)
        {
            if (mskngaybd.Text.Length == 10 && mskngaybd.Text.IndexOf(' ') == -1 && mskngaykt.Text.Length == 10 && mskngaykt.Text.IndexOf(' ') == -1)
            {
                txtthanhtien.Text = Convert.ToString(Class.Functions.DateDiff(mskngaybd.Text, mskngaykt.Text) * Convert.ToInt32(txtdongia.Text));
            }
            else
            {
                txtthanhtien.Text = "0";
            }
        }

        private void mskngaykt_TextChanged(object sender, EventArgs e)
        {
            if (mskngaykt.Text.Length == 10 && mskngaykt.Text.IndexOf(' ') == -1 && mskngaykt.Text.Length == 10 && mskngaykt.Text.IndexOf(' ') == -1)
            {
                txtthanhtien.Text = Convert.ToString(Class.Functions.DateDiff(mskngaybd.Text, mskngaykt.Text) * Convert.ToInt32(txtdongia.Text));
            }
            else
            {
                txtthanhtien.Text = "0";
            }
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ quảng cáo này?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                sql = "delete from chitietquangcao where mactqc = '" + txtmaCTQC.Text + "'";
                Class.Functions.Runsqldel(sql);
                load_data();
                resetvalues();
                btnboqua.Enabled = false;
                btncapnhat.Enabled = false;
            }
        }
    }
}
