using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHD_QC_VB.Forms
{
    public partial class frmbaocaodt : Form
    {
        public frmbaocaodt()
        {
            InitializeComponent();
        }
        DataTable tblbaocaodt;
        private void frmbaocaodt_Load(object sender, EventArgs e)
        {
            Class.Functions.Fillcombo("select mabao, tenbao from bao", cbotobao, "mabao", "tenbao");
            cbotobao.SelectedIndex = -1;
            Class.Functions.Fillcombo("select madv,dichvu from dichvu", cbodichvu, "madv", "dichvu");
            cbodichvu.SelectedIndex = -1;
            cbodichvu.Enabled = false;
            Class.Functions.Fillcombo("select matheloai, theloai from theloai", cbotheloai, "matheloai", "theloai");
            cbotheloai.SelectedIndex = -1;
            cbotheloai.Enabled = false;
            //rdotheongay.Checked = true;
            //msktheongay.Enabled = false;
            //grbtheokhoang.Enabled = false;
            txttongtien.ReadOnly = true;
            btninbaocao.Enabled = false;
        }
        private void resetvalues()
        {
            cbotobao.SelectedIndex = -1;
            cbodichvu.SelectedIndex = -1;
            cbotheloai.SelectedIndex = -1;
            chkquangcao.Checked = false;
            chkvietbai.Checked = false;
            txtdoanhthu.Text = "";
            msktheongay.Text = "";
            msktoingay.Text = "";
            msktungay.Text = "";
            rdotheokhoang.Checked = false;
            rdotheongay.Checked = false;
        }

        private void chkquangcao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkquangcao.Checked)
            {
                cbotheloai.Enabled = false;
                chkvietbai.Checked = false;
                cbodichvu.Enabled = true;
            }
            else
            {
                cbodichvu.Enabled = false;
            }
        }

        private void chkvietbai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkvietbai.Checked)
            {
                cbodichvu.Enabled = false;
                chkquangcao.Checked = false;
                cbotheloai.Enabled = true;
            }
            else
            {
                cbotheloai.Enabled = false;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            resetvalues();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cbotobao.SelectedValue == null) && (cbotheloai.SelectedValue == null) && (msktheongay.Text == "  /  /") && (txtdoanhthu.Text == "")
                && (cbodichvu.SelectedValue == null) && (msktoingay.Text == "  /  /") && (msktungay.Text == "  /  /"))
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string col, where, groupby, having;
            col = "";
            where = "";
            groupby = "";
            having = "";
            if (chkbao.Checked)
            {
                col = "tenbao,";
                groupby = "group by tenbao";
            }
            if (msktheongay.Text != "  /  /")
            {
                where = " where ngayky ='" + Class.Functions.ConvertDate(msktheongay.Text) + "'";
            }
            if (msktungay.Text != "  /  /")
            {
                where = " where ngayky >='" + Class.Functions.ConvertDate(msktheongay.Text) + "'";
            }
            if (msktungay.Text != "  /  /")
            {
                where = where + " and ngayky <='" + Class.Functions.ConvertDate(msktheongay.Text) + "'";
            }
            if (txtdoanhthu.Text != "")
            {
                having = " having coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) >=" + txtdoanhthu.Text;
            }
            if (chkquangcao.Checked)
            {
                col = col + "dichvu,";
                groupby = groupby + ",dichvu";
                sql = "select " + col + "coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as doanhthu " +
                "from quangcao a join chitietquangcao b on a.maqc=b.maqc " +
                "join bao c on b.mabao=c.mabao join dichvu d on d.madv=b.madv " + where + groupby + having;
            }
            if (chkvietbai.Checked)
            {
                col = col + "theloai,";
                groupby = groupby + ",theloai";
                sql = "select " + col + "coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as doanhthu " +
                    "from quangcao a join chitietquangcao b on a.maqc=b.maqc " + 
                    "join bao c on b.mabao=c.mabao join dichvu d on d.madv=b.madv " + where + groupby + having;
            }
            //tblbaocaodt = Class.Functions.GetDataToTable(sql);
            if (tblbaocaodt.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetvalues();
            }
            else
            {
                MessageBox.Show("Có " + tblbaocaodt.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridView.DataSource = tblbaocaodt;
                load_data();
            }
        }
        private void load_data()
        {
            DataGridView.Columns[0].HeaderText = "Báo";
            DataGridView.Columns[1].HeaderText = "Dịch vụ";
            DataGridView.Columns[2].HeaderText = "Doanh thu";
            //DataGridView.Columns[0].Width = 170;
            //DataGridView.Columns[1].Width = 170;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
