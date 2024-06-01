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
            cbotobao.Enabled = false;
            Class.Functions.Fillcombo("select madv,dichvu from dichvu", cbodichvu, "madv", "dichvu");
            cbodichvu.SelectedIndex = -1;
            cbodichvu.Enabled = false;
            Class.Functions.Fillcombo("select matheloai, theloai from theloai", cbotheloai, "matheloai", "theloai");
            cbotheloai.SelectedIndex = -1;
            cbotheloai.Enabled = false;
            //rdotheongay.Checked = true;
            msktheongay.Enabled = false;
            grbtheokhoang.Enabled = false;
            txttongtien.ReadOnly = true;
            btninbaocao.Enabled = false;
        }
        private void resetvalues()
        {
            cbotobao.SelectedIndex = -1;
            cbodichvu.SelectedIndex = -1;
            cbotheloai.SelectedIndex = -1;
            chkbao.Checked = false;
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
                cbodichvu.SelectedIndex = -1;
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
                cbotheloai.SelectedIndex = -1;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            resetvalues();
            DataGridView.DataSource = null;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql = "";
            //if ((chkbao.Checked == false) && (chkquangcao.Checked == false) && (msktheongay.Text == "  /  /") && (txtdoanhthu.Text == "")
            //    && (chkvietbai.Checked == false) && (msktoingay.Text == "  /  /") && (msktungay.Text == "  /  /"))
            //{
            //    MessageBox.Show("Hãy nhập ít nhất một điều kiện để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            string col, from_dtqc, from_dt, from_dtvb, groupby, where,having;
            where = "";
            groupby = "group by ";
            having = "";
            from_dtqc = ",coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as doanhthu " +
                "from quangcao a join chitietquangcao b on a.maqc=b.maqc " +
                "join bao c on b.mabao=c.mabao join dichvu d on d.madv=b.madv where 1=1 ";

            from_dtvb = ",coalesce(sum(nhuanbut),0) as doanhthu " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "join bao c on b.mabao=c.mabao join theloai d on d.matheloai=b.matheloai where 1=1 ";

            from_dt = ",coalesce(sum(doanhthu),0) as doanhthu from ( " +
                "select ngayky,tenbao,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as doanhthu " +
                "from quangcao a join chitietquangcao b on a.maqc=b.maqc " +
                "join bao c on b.mabao=c.mabao join dichvu d on d.madv=b.madv " +
                "group by tenbao,ngayky " +
                "union " +
                "select ngayky,tenbao,coalesce(sum(nhuanbut),0) as doanhthu " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "join bao c on b.mabao=c.mabao join theloai d on d.matheloai=b.matheloai " +
                "group by tenbao,ngayky) a where 1=1 ";
            if (msktheongay.Text != "  /  /")
            {
                where = where + "and ngayky ='" + Class.Functions.ConvertDate(msktheongay.Text) + "' ";
            }
            if (msktheongay.Text != "  /  /")
            {
                where = where + "and ngayky >='" + Class.Functions.ConvertDate(msktungay.Text) + "' ";
            }
            if (msktoingay.Text != "  /  /")
            {
                where = where + "and ngayky <='" + Class.Functions.ConvertDate(msktoingay.Text) + "' ";
            }
            if (cbotobao.SelectedValue != null)
            {
                where = where + "and tenbao =N'" + cbotobao.Text + "' ";
            }
            if (cbotheloai.SelectedValue != null)
            {
                where = where + "and theloai =N'" + cbotheloai.Text + "' ";
            }
            if (cbodichvu.SelectedValue != null)
            {
                where = where + "and dichvu =N'" + cbodichvu.Text + "' ";
            }
            if (txtdoanhthu.Text != "")
            {
                if (!chkbao.Checked && !chkquangcao.Checked && !chkvietbai.Checked && (!rdotheokhoang.Checked || !rdotheongay.Checked))
                {
                    MessageBox.Show("Hãy chọn một tiêu chí báo cáo","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (chkquangcao.Checked)
                {
                    having = " having coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) >=" + txtdoanhthu.Text;
                }
                else if (chkvietbai.Checked)
                {
                    having = " having coalesce(sum(nhuanbut),0) >=" + txtdoanhthu.Text;
                }
                else
                {
                    having = " having coalesce(sum(doanhthu),0) >=" + txtdoanhthu.Text;
                }
            }
            if (chkbao.Checked)
            {
                if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    col = "ngayky, tenbao";
                }
                else
                {
                    col = "tenbao";
                }
                sql = "select " + col + from_dt + where + groupby + col + having;
            }
            if (rdotheokhoang.Checked || rdotheongay.Checked)
            {
                col = "ngayky";
                sql = "select " + col + from_dt + where + groupby + col + having;
            }
            if (chkquangcao.Checked)
            {
                if (chkbao.Checked && (rdotheongay.Checked || rdotheokhoang.Checked))
                {
                    col = "ngayky,tenbao,dichvu";
                }
                else if (chkbao.Checked)
                {
                    col = "tenbao, dichvu";
                }
                else if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    col = "ngayky, dichvu";
                }
                else
                {
                    col = "dichvu";
                }
                sql = "select " + col + from_dtqc + where + groupby + col + having;
            }
            if (chkvietbai.Checked)
            {
                if (chkbao.Checked && (rdotheongay.Checked || rdotheokhoang.Checked))
                {
                    col = "ngayky,tenbao,theloai";
                }
                else if (chkbao.Checked)
                {
                    col = "tenbao, theloai";
                }
                else if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    col = "ngayky, theloai";
                }
                else
                {
                    col = "theloai";
                }
                sql = "select " + col + from_dtvb + where + groupby + col + having;
            }
            tblbaocaodt = Class.Functions.GetDataToTable(sql);
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
            //DataGridView.Columns[1].HeaderText = "Dịch vụ";
            //DataGridView.Columns[2].HeaderText = "Doanh thu";
            //DataGridView.Columns[0].Width = 170;
            //DataGridView.Columns[1].Width = 170;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void chkbao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbao.Checked)
            {
                cbotobao.Enabled = true;
            }
            else
            {
                cbotobao.Enabled = false;
            }
        }

        private void rdotheongay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdotheongay.Checked)
            {
                msktheongay.Enabled = true;
            }
            else
            {
                msktheongay.Enabled = false;
            }
        }

        private void rdotheokhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdotheokhoang.Checked)
            {
                grbtheokhoang.Enabled = true;
            }
            else
            {
                grbtheokhoang.Enabled = false;
            }
        }

        private void txtdoanhthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar)) == 8)
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
