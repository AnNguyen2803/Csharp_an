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
using COMExcel = Microsoft.Office.Interop.Excel;

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
            txttongtien.Text = "";
            lblbangchu.Text = "Bằng chữ:";
            DataGridView.DataSource = null;
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
            btninbaocao.Enabled = false;
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql = "";
            if ((!chkbao.Checked) && (!chkquangcao.Checked) && (!chkvietbai.Checked) && !rdotheokhoang.Checked && !rdotheongay.Checked)
            {
                MessageBox.Show("Hãy nhập ít nhất một điều kiện để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string col, from_dtqc, from_dt, from_dtvb, groupby, where, having;
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
                "join bao c on b.mabao=c.mabao " +
                "group by tenbao,ngayky " +
                "union " +
                "select ngayky,tenbao,coalesce(sum(nhuanbut),0) as doanhthu " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                "join bao c on b.mabao=c.mabao " +
                "group by tenbao,ngayky) a where 1=1 ";
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
            if (msktheongay.Text != "  /  /" && msktheongay.Text.Length == 10 && msktheongay.Text.IndexOf(' ') == -1)
            {
                where = where + "and ngayky ='" + Class.Functions.ConvertDate(msktheongay.Text) + "' ";
            }
            if (msktungay.Text != "  /  /" && msktungay.Text.Length == 10 && msktungay.Text.IndexOf(' ') == -1)
            {
                where = where + "and ngayky >='" + Class.Functions.ConvertDate(msktungay.Text) + "' ";
            }
            if (msktoingay.Text != "  /  /" && msktoingay.Text.Length == 10 && msktoingay.Text.IndexOf(' ') == -1)
            {
                where = where + "and ngayky <='" + Class.Functions.ConvertDate(msktoingay.Text) + "' ";
            }
            if (msktoingay.Text != "  /  /" && msktungay.Text != "  /  /" && Class.Functions.DateDiff(msktungay.Text, msktoingay.Text) < 0)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                msktoingay.Focus();
                return;
            }
            if (txtdoanhthu.Text != "")
            {
                if (!chkbao.Checked && !chkquangcao.Checked && !chkvietbai.Checked && !rdotheokhoang.Checked && !rdotheongay.Checked)
                {
                    MessageBox.Show("Hãy chọn một tiêu chí báo cáo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if ((rdotheokhoang.Checked || rdotheongay.Checked) && !chkbao.Checked)
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
                btninbaocao.Enabled = true;
            }
            txttongtien.Text = Convert.ToString(Class.Functions.GetFieldValues("select coalesce(sum(doanhthu),0) as doanhthu from(" + sql + ") a"));
            lblbangchu.Text = "Bằng chữ: " + Class.Functions.ConvertNumberToString(txttongtien.Text);
        }
        private void load_data()
        {
            if (chkbao.Checked)
            {
                if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    DataGridView.Columns[0].HeaderText = "Ngày ký";
                    DataGridView.Columns[1].HeaderText = "Tên báo";
                    DataGridView.Columns[2].HeaderText = "Doanh thu";
                }
                else
                {
                    DataGridView.Columns[0].HeaderText = "Tên báo";
                    DataGridView.Columns[1].HeaderText = "Doanh thu";
                }
            }
            if ((rdotheokhoang.Checked || rdotheongay.Checked) && !chkbao.Checked)
            {
                DataGridView.Columns[0].HeaderText = "Ngày ký";
                DataGridView.Columns[1].HeaderText = "Doanh thu";
            }
            if (chkquangcao.Checked)
            {
                if (chkbao.Checked && (rdotheongay.Checked || rdotheokhoang.Checked))
                {
                    DataGridView.Columns[0].HeaderText = "Ngày ký";
                    DataGridView.Columns[1].HeaderText = "Tên báo";
                    DataGridView.Columns[2].HeaderText = "Dịch vụ";
                    DataGridView.Columns[3].HeaderText = "Doanh thu";
                }
                else if (chkbao.Checked)
                {
                    DataGridView.Columns[0].HeaderText = "Tên báo";
                    DataGridView.Columns[1].HeaderText = "Dịch vụ";
                    DataGridView.Columns[2].HeaderText = "Doanh thu";
                }
                else if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    DataGridView.Columns[0].HeaderText = "Ngày ký";
                    DataGridView.Columns[1].HeaderText = "Dịch vụ";
                    DataGridView.Columns[2].HeaderText = "Doanh thu";
                }
                else
                {
                    DataGridView.Columns[0].HeaderText = "Dịch vụ";
                    DataGridView.Columns[1].HeaderText = "Doanh thu";
                }
            }
            if (chkvietbai.Checked)
            {
                if (chkbao.Checked && (rdotheongay.Checked || rdotheokhoang.Checked))
                {
                    DataGridView.Columns[0].HeaderText = "Ngày ký";
                    DataGridView.Columns[1].HeaderText = "Tên báo";
                    DataGridView.Columns[2].HeaderText = "Thể loại";
                    DataGridView.Columns[3].HeaderText = "Doanh thu";
                }
                else if (chkbao.Checked)
                {
                    DataGridView.Columns[0].HeaderText = "Tên báo";
                    DataGridView.Columns[1].HeaderText = "Thể loại";
                    DataGridView.Columns[2].HeaderText = "Doanh thu";
                }
                else if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    DataGridView.Columns[0].HeaderText = "Ngày ký";
                    DataGridView.Columns[1].HeaderText = "Thể loại";
                    DataGridView.Columns[2].HeaderText = "Doanh thu";
                }
                else
                {
                    DataGridView.Columns[0].HeaderText = "Thể loại";
                    DataGridView.Columns[1].HeaderText = "Doanh thu";
                }
            }
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
                msktheongay.Text = "";
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
                msktoingay.Text = "";
                msktungay.Text = "";
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

        private void btninbaocao_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            int row = 0, col = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["A1:E1"].MergeCells = true;
            exRange.Range["A1:E1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:E1"].Value = "Báo cáo doanh thu";
            exRange.Range["A1:E1"].Font.ColorIndex = 3;

            exRange.Range["A2:A2"].Value = "STT";
            if (chkbao.Checked)
            {
                if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    exRange.Range["B2:B2"].Value = "Ngày ký";
                    exRange.Range["C2:C2"].Value = "Tên báo";
                    exRange.Range["D2:D2"].Value = "Doanh thu";
                }
                else
                {
                    exRange.Range["B2:B2"].Value = "Tên báo";
                    exRange.Range["C2:C2"].Value = "Doanh thu";
                }
            }
            if ((rdotheokhoang.Checked || rdotheongay.Checked) && !chkbao.Checked)
            {
                exRange.Range["B2:B2"].Value = "Ngày ký";
                exRange.Range["C2:C2"].Value = "Doanh thu";
            }
            if (chkquangcao.Checked)
            {
                if (chkbao.Checked && (rdotheongay.Checked || rdotheokhoang.Checked))
                {
                    exRange.Range["B2:B2"].Value = "Ngày ký";
                    exRange.Range["C2:C2"].Value = "Tên báo";
                    exRange.Range["D2:D2"].Value = "Dịch vụ";
                    exRange.Range["E2:E2"].Value = "Doanh thu";
                }
                else if (chkbao.Checked)
                {
                    exRange.Range["B2:B2"].Value = "Tên báo";
                    exRange.Range["C2:C2"].Value = "Dịch vụ";
                    exRange.Range["D2:D2"].Value = "Doanh thu";
                }
                else if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    exRange.Range["B2:B2"].Value = "Ngày ký";
                    exRange.Range["C2:C2"].Value = "Dịch vụ";
                    exRange.Range["D2:D2"].Value = "Doanh thu";
                }
                else
                {
                    exRange.Range["B2:B2"].Value = "Dịch vụ";
                    exRange.Range["C2:C2"].Value = "Doanh thu";
                }
            }
            if (chkvietbai.Checked)
            {
                if (chkbao.Checked && (rdotheongay.Checked || rdotheokhoang.Checked))
                {
                    exRange.Range["B2:B2"].Value = "Ngày ký";
                    exRange.Range["C2:C2"].Value = "Tên báo";
                    exRange.Range["D2:D2"].Value = "Thể loại";
                    exRange.Range["E2:E2"].Value = "Doanh thu";
                }
                else if (chkbao.Checked)
                {
                    exRange.Range["B2:B2"].Value = "Tên báo";
                    exRange.Range["C2:C2"].Value = "Thể loại";
                    exRange.Range["D2:D2"].Value = "Doanh thu";
                }
                else if (rdotheongay.Checked || rdotheokhoang.Checked)
                {
                    exRange.Range["B2:B2"].Value = "Ngày ký";
                    exRange.Range["C2:C2"].Value = "Thể loại";
                    exRange.Range["D2:D2"].Value = "Doanh thu";
                }
                else
                {
                    exRange.Range["B2:B2"].Value = "Thể loại";
                    exRange.Range["C2:C2"].Value = "Doanh thu";
                }
            }
            for (row = 0; row <= tblbaocaodt.Rows.Count - 1; row++)
            {
                exSheet.Cells[1][row + 3] = row + 1; //điền số thứ tự vào ô đầu tiên trong mỗi hàng
                for (col = 0; col <= tblbaocaodt.Columns.Count - 1; col++)
                {
                    if (tblbaocaodt.Columns[col].ColumnName == "ngayky")
                    {
                        exSheet.Cells[col + 2][row + 3] = Convert.ToDateTime(tblbaocaodt.Rows[row]["ngayky"]);
                    }
                    else
                    {
                        exSheet.Cells[col + 2][row + 3] = tblbaocaodt.Rows[row][col].ToString();
                    }
                }
            }
            exRange.Range["G3:G3"].MergeCells = true;
            exRange.Range["G3:G3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["G3:G3"].Value = "Tổng doanh thu";
            exRange.Range["G3:G3"].Font.Bold = true;

            exRange.Range["H3:H3"].MergeCells = true;
            exRange.Range["H3:H3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["H3:H3"].Value = txttongtien.Text;

            exApp.Visible = true;
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
