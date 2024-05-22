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
    public partial class frmtimkiemkh : Form
    {
        public frmtimkiemkh()
        {
            InitializeComponent();
        }
        DataTable tbltkkh;

        private void frmtimkiemkh_Load(object sender, EventArgs e)
        {
            resetvalues();
            DataGridView.DataSource = null;
            Class.Functions.Fillcombo("Select malvhd,linhvuchoatdong from linhvuchoatdong", cbolvhd, "malvhd", "linhvuchoatdong");
            cbolvhd.SelectedIndex = -1;
        }
        private void resetvalues()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }
            }
            txtmakh.Focus();
            cbolvhd.Text = "";
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmakh.Text == "") && (txttenkh.Text == "") && (txtdiachi.Text == "") && (cbolvhd.Text == null))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "select distinct b.makh,tenkh,diachi,dienthoai,email,solanky,ngaykygannhat,tonggiatri " +
                "from quangcao a join khachhang b on a.makh=b.makh join linhvuchoatdong c on b.malvhd=c.malvhd join " +
                "(select a.makh,count(distinct a.maqc) as solanky,max(ngayky) as ngaykygannhat," +
                "coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tonggiatri " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc group by a.makh) d on a.makh=d.makh " +
                "where 1=1";
            if (txtmakh.Text != "")
            {
                sql = sql + " and b.makh like N'%" + txtmakh.Text + "%'";
            }
            if (txttenkh.Text != "")
            {
                sql = sql + " and tenkh like N'%" + txttenkh.Text + "%'";
            }
            if (txtdiachi.Text != "")
            {
                sql = sql + " and diachi like N'%" + txtdiachi.Text + "%'";
            }
            if (cbolvhd.Text != null)
            {
                sql = sql + " and linhvuchoatdong like N'%" + cbolvhd.Text + "%'";
            }
            tbltkkh = Class.Functions.GetDataToTable(sql);
            if (tbltkkh.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
            {
                MessageBox.Show("Có " + tbltkkh.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridView.DataSource = tbltkkh;
                load_data();
            }
        }
        private void load_data()
        {
            DataGridView.Columns[0].HeaderText = "Mã khách hàng";
            DataGridView.Columns[1].HeaderText = "Tên khách hàng";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            DataGridView.Columns[4].HeaderText = "Email";
            DataGridView.Columns[5].HeaderText = "Số lần ký";
            DataGridView.Columns[6].HeaderText = "Ngày ký gần nhất";
            DataGridView.Columns[7].HeaderText = "Tổng giá trị hợp đồng đã ký";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 150;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 150;
            DataGridView.Columns[4].Width = 90;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 225;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
            DataGridView.DataSource = null;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
