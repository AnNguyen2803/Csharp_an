using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHD_QC_VB.Forms
{
    public partial class frmtimkiemhd : Form
    {
        public frmtimkiemhd()
        {
            InitializeComponent();
        }
        DataTable tbltkhd;

        private void frmtimkiemhd_Load(object sender, EventArgs e)
        {
            resetvalues();
            DataGridView.DataSource = null;
            string tiento;
            tiento = "select distinct(SUBSTRING(mahd,1,2)) as tiento from (" +
                "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "group by a.mavb,a.manv,a.makh,ngayky " +
                "union " +
                "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                "group by a.maqc,manv,makh,ngayky) a";
            Class.Functions.Fillcombo(tiento, cboloaihd, "tiento", "tiento");
            cboloaihd.SelectedIndex = -1;
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
            txtmahd.Focus();
            msktungay.Text = "";
            msktoingay.Text = "";
            cboloaihd.SelectedIndex = -1;
            DataGridView.DataSource = null;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmakh.Text == "") && (txtmahd.Text == "") && (txtmanv.Text == "") && (txtgiatri.Text == "")
                && (cboloaihd.SelectedValue == null) && (msktoingay.Text == "  /  /") && (msktungay.Text == "  /  /"))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select * from (" +
                "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "group by a.mavb,a.manv,a.makh,ngayky " +
                "union " +
                "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                "group by a.maqc,manv,makh,ngayky) a where 1=1";
            if (txtmahd.Text != "")
            {
                sql = sql + " and mahd like N'%" + txtmahd.Text + "%'";
            }
            if (txtmanv.Text != "")
            {
                sql = sql + " and manv like N'%" + txtmanv.Text + "%'";
            }
            if (txtmakh.Text != "")
            {
                sql = sql + " and makh like N'%" + txtmakh.Text + "%'";
            }
            if (cboloaihd.SelectedValue != null)
            {
                sql = sql + " and SUBSTRING(mahd,1,2) ='" + cboloaihd.Text + "'";
            }
            if (msktungay.Text != "  /  /")
            {
                sql = sql + " and ngayky >='" + Class.Functions.ConvertDate(msktungay.Text) + "'";
            }
            if (msktoingay.Text != "  /  /")
            {
                sql = sql + " and ngayky <='" + Class.Functions.ConvertDate(msktoingay.Text) + "'";
            }
            if (txtgiatri.Text != "")
            {
                sql = sql + " and tongtien <=" + txtgiatri.Text + "";
            }
            tbltkhd = Class.Functions.GetDataToTable(sql);
            if (tbltkhd.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
            {
                MessageBox.Show("Có " + tbltkhd.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridView.DataSource = tbltkhd;
                load_data();
            }
        }
        private void load_data()
        {
            DataGridView.Columns[0].HeaderText = "Mã hợp đồng";
            DataGridView.Columns[1].HeaderText = "Mã nhân viên";
            DataGridView.Columns[2].HeaderText = "Mã khách hàng";
            DataGridView.Columns[3].HeaderText = "Ngày ký";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].Width = 170;
            DataGridView.Columns[1].Width = 170;
            DataGridView.Columns[2].Width = 170;
            DataGridView.Columns[3].Width = 125;
            DataGridView.Columns[4].Width = 110;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
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

        private void txtgiatri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >='0') && (e.KeyChar <='9')) || (Convert.ToInt32(e.KeyChar))==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
