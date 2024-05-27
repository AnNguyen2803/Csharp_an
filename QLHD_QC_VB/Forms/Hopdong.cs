using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLHD_QC_VB.Forms
{
    public partial class frmhopdong : Form
    {
        public frmhopdong()
        {
            InitializeComponent();
        }
        DataTable tblhopdong;
        public void resetvalues()
        {
            txtmahd.Text = "";
            mskngayky.Text = "";
            cbomakh.Text = "";
            cbomanv.Text = "";
        }
        string makh = "";
        public void GetValue(string value)
        {
            makh = value;
        }

        private void Hopdong_Load(object sender, EventArgs e)
        {
            load_data();
            txtmahd.ReadOnly = true;
            txttenkh.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txttenkh.ReadOnly = true;
            mskdienthoai.ReadOnly = true;
            txttennv.ReadOnly = true;
            Class.Functions.Fillcombo("select manv,tennv from nhanvien", cbomanv, "manv", "manv");
            cbomanv.SelectedIndex = -1;
            Class.Functions.Fillcombo("select makh,tenkh from khachhang", cbomakh, "makh", "makh");
            cbomakh.SelectedIndex = -1;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btnlammoi.Enabled = false;
            btnxuathopdong.Enabled = false;
            Class.Functions.Fillcombo("select maqc as mahd ,ngayky from quangcao union select mavb as mahd,ngayky from vietbai", cbotkmahd, "mahd", "mahd");
            cbotkmahd.SelectedIndex = -1;
        }
        private void load_data()
        {
            string sql;
            if (makh == "")
            {
                sql = "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien from vietbai a full join chitietvietbai b on a.mavb=b.mavb " +
                    "group by a.mavb,a.manv,a.makh,ngayky " +
                    "union " +
                    "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                    "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " +
                    "group by a.maqc,manv,makh,ngayky";
            }
            else
            {
                sql = "select a.mavb as mahd,a.manv,a.makh,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                    "from vietbai a full join chitietvietbai b on a.mavb=b.mavb " + "where a.makh = '" + makh + "' " +
                    "group by a.mavb,a.manv,a.makh,ngayky " +
                    "union " +
                    "select a.maqc as mahd,manv,makh,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                    "from quangcao a full join chitietquangcao b on a.maqc=b.maqc " + "where a.makh = '" + makh + "' " +
                    "group by a.maqc,manv,makh,ngayky";
            }
            tblhopdong = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblhopdong;
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
        private void load_data_txt()
        {
            mskngayky.Text = Class.Functions.GetFieldValues("select ngayky from (select maqc as mahd ,ngayky from quangcao union select mavb as mahd,ngayky from vietbai) a" +
                " where mahd = '" + txtmahd.Text + "'");
            string manv, makh;
            manv = Class.Functions.GetFieldValues("select manv from (select maqc as mahd ,ngayky,manv,makh from quangcao union select mavb as mahd,ngayky,manv,makh from vietbai) a" +
                " where mahd = '" + txtmahd.Text + "'");
            cbomanv.Text = Class.Functions.GetFieldValues("select manv from nhanvien where manv = '" + manv + "'");
            makh = Class.Functions.GetFieldValues("select makh from (select maqc as mahd ,ngayky,manv,makh from quangcao union select mavb as mahd,ngayky,manv,makh from vietbai) a" +
                " where mahd = '" + txtmahd.Text + "'");
            cbomakh.Text = Class.Functions.GetFieldValues("select makh from khachhang where makh = '" + makh + "'");
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (tblhopdong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (btnthemhdqc.Enabled == false || btnthemhdvb.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtmahd.Text = DataGridView.CurrentRow.Cells["mahd"].Value.ToString();
            load_data_txt();
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnlammoi.Enabled = true;
            btnxuathopdong.Enabled = true;
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmctvb a = new frmctvb();
            frmcthopdong b = new frmcthopdong();
            if (txtmahd.Text.Substring(0, 2) == "VB")
            {
                a.GetValue(txtmahd.Text);
                a.StartPosition = FormStartPosition.CenterScreen;
                a.Show();
            }
            else
            {
                b.GetValue(txtmahd.Text);
                b.StartPosition = FormStartPosition.CenterScreen;
                b.Show();
            }
        }

        private void cbomanv_TextChanged(object sender, EventArgs e)
        {
            if (cbomanv.Text == "")
            {
                txttennv.Text = "";
            }
            else
            {
                txttennv.Text = Class.Functions.GetFieldValues("select tennv from nhanvien where manv = '" + cbomanv.SelectedValue + "'");
            }
        }

        private void cbomakh_TextChanged(object sender, EventArgs e)
        {
            if (cbomakh.Text == "")
            {
                txttenkh.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
            }
            else
            {
                txttenkh.Text = Class.Functions.GetFieldValues("select tenkh from khachhang where makh = '" + cbomakh.SelectedValue + "'");
                txtdiachi.Text = Class.Functions.GetFieldValues("Select diachi from khachhang where makh = '" + cbomakh.SelectedValue + "'");
                mskdienthoai.Text = Class.Functions.GetFieldValues("select dienthoai from khachhang where makh = '" + cbomakh.SelectedValue + "'");
            }
        }

        private void btnthemhdqc_Click(object sender, EventArgs e)
        {
            btnthemhdqc.Enabled = false;
            btnthemhdvb.Enabled = false;
            btnlammoi.Enabled = true;
            btnluu.Enabled = true;
            resetvalues();
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            txtmahd.Text = Class.Functions.CreateKey("QC");
        }

        private void btnthemhdvb_Click(object sender, EventArgs e)
        {
            btnthemhdvb.Enabled = false;
            btnthemhdqc.Enabled = false;
            btnlammoi.Enabled = true;
            btnluu.Enabled = true;
            resetvalues();
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            txtmahd.Text = Class.Functions.CreateKey("VB");
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnlammoi.Enabled = false;
            resetvalues();
            btnthemhdqc.Enabled = true;
            btnthemhdvb.Enabled = true;
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            load_data();
            btnxuathopdong.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (mskngayky.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngayky.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngayky.Text))
            {
                MessageBox.Show("Sai định dạng ngày ký, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngayky.Focus();
                mskngayky.Text = "";
                return;
            }
            if (cbomanv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanv.Focus();
                return;
            }
            if (cbomakh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakh.Focus();
                return;
            }
            string sql;
            if (txtmahd.Text.Substring(0, 2) == "VB")
            {
                sql = "insert into vietbai (mavb,manv,makh,ngayky) values ('" + txtmahd.Text + "','" + cbomanv.SelectedValue.ToString() + "','" +
                cbomakh.SelectedValue.ToString() + "','" + Class.Functions.ConvertDate(mskngayky.Text) + "')";
            }
            else
            {
                sql = "insert into quangcao (maqc,manv,makh,ngayky) values ('" + txtmahd.Text + "','" + cbomanv.SelectedValue.ToString() + "','" +
                cbomakh.SelectedValue.ToString() + "','" + Class.Functions.ConvertDate(mskngayky.Text) + "')";
            }
            Class.Functions.GetDataToTable(sql);
            load_data();
            resetvalues();
            btnluu.Enabled = false;
            btnthemhdvb.Enabled = true;
            btnthemhdqc.Enabled = true;
            btnlammoi.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa hợp đồng " + txtmahd.Text + " khỏi bảng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql;
                if (txtmahd.Text.Substring(0, 2) == "VB")
                {
                    sql = "delete from vietbai where mavb ='" + txtmahd.Text + "'";
                }
                else
                {
                    sql = "delete from quangcao where maqc ='" + txtmahd.Text + "'";
                }
                Class.Functions.Runsql(sql);
                load_data();
                resetvalues();
                btnsua.Enabled = false;
                btnlammoi.Enabled = false;
                btnxuathopdong.Enabled = false;
                btnhuy.Enabled = false;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (mskngayky.Text == "  /  /")
            {
                MessageBox.Show("Bạn chưa nhập ngày ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngayky.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngayky.Text))
            {
                MessageBox.Show("Sai định dạng ngày ký, hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngayky.Focus();
                mskngayky.Text = "";
                return;
            }
            if (cbomanv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomanv.Focus();
                return;
            }
            if (cbomakh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomakh.Focus();
                return;
            }
            string sql;
            if (txtmahd.Text.Substring(0, 2) == "VB")
            {
                sql = "update vietbai set ngayky = '" + Class.Functions.ConvertDate(mskngayky.Text) + "', manv ='" + cbomanv.SelectedValue + "', makh ='" +
                cbomakh.SelectedValue + "' where mavb ='" + txtmahd.Text + "'";
            }
            else
            {
                sql = "update quangcao set ngayky = '" + Class.Functions.ConvertDate(mskngayky.Text) + "', manv ='" + cbomanv.SelectedValue + "', makh ='" +
                cbomakh.SelectedValue + "' where maqc ='" + txtmahd.Text + "'";
            }
            Class.Functions.Runsql(sql);
            load_data();
            resetvalues();
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            btnxuathopdong.Enabled = false;
            btnlammoi.Enabled = false;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (cbotkmahd.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hợp đồng để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbotkmahd.Focus();
                return;
            }
            txtmahd.Text = cbotkmahd.Text;
            load_data_txt();
            cbotkmahd.SelectedIndex = -1;
        }

        private void btnxuathopdong_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select tongtien from (select coalesce(sum(nhuanbut),0) as tongtien,a.mavb as mahd from vietbai a full join chitietvietbai b on a.mavb=b.mavb group by a.mavb " +
                "union " +
                "select coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien, a.maqc as mahd " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc group by a.maqc) a where mahd='" + txtmahd.Text + "'";
            if (Class.Functions.GetFieldValues(sql) == "0")
            {
                MessageBox.Show("Hợp đồng chưa có nội dung, hãy ấn đúp vào hợp đồng " + txtmahd.Text + " để thêm nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            int row = 0, col = 0;
            DataTable tblhd, tblctqc, tblctvb;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];

            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:H1"].Value = "Cộng hòa xã hội chủ nghĩa Việt Nam";

            exRange.Range["A2:H2"].MergeCells = true;
            exRange.Range["A2:H2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:H2"].Value = "Độc lập - Tự do - Hạnh phúc";

            exRange.Range["A3:H3"].MergeCells = true;
            exRange.Range["A3:H3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:H3"].Value = "------------------------------------------";

            exRange.Range["A7:H7"].MergeCells = true;
            exRange.Range["A7:H7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            if (txtmahd.Text.Substring(0, 2) == "VB")
            {
                exRange.Range["A7:H7"].Value = "HỢP ĐỒNG VIẾT BÀI";
            }
            else
            {
                exRange.Range["A7:H7"].Value = "HỢP ĐỒNG QUẢNG CÁO";
            }

            sql = "select a.mavb as mahd,chucvu,c.dienthoai,ngayky,coalesce(sum(nhuanbut),0) as tongtien " +
                "from vietbai a full join chitietvietbai b on a.mavb=b.mavb join nhanvien c on c.manv = a.manv join chucvu d on d.macv = c.macv " +
                "group by a.mavb,a.manv,makh,ngayky,tennv,chucvu,c.dienthoai " +
                "union " +
                "select a.maqc as mahd,chucvu,c.dienthoai,ngayky,coalesce(sum(dongia * abs(datediff(day,ngaykt,ngaybd))),0) as tongtien " +
                "from quangcao a full join chitietquangcao b on a.maqc=b.maqc join nhanvien c on c.manv = a.manv join chucvu d on d.macv = c.macv " +
                "group by a.maqc,a.manv,makh,ngayky,tennv,chucvu,c.dienthoai";
            tblhd = Class.Functions.GetDataToTable(sql);
            exRange.Range["A8:H8"].MergeCells = true;
            exRange.Range["A8:H8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A8:H8"].Value = "Số: " + tblhd.Rows[0][0].ToString();

            exRange.Range["A9:H9"].MergeCells = true;
            exRange.Range["A9:H9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A9:H9"].Value = "Căn cứ Bộ Luật Dân Sự được Quốc hội nước Cộng hòa xã hội chủ nghĩa Việt Nam thông qua ngày 24 tháng 11 năm 2015";
            exRange.Range["A9:H9"].WrapText = true;

            exRange.Range["A10:H10"].MergeCells = true;
            exRange.Range["A10:H10"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A10:H10"].Value = "Căn cứ Luật Thương mại 2015";

            exRange.Range["A11:H11"].MergeCells = true;
            exRange.Range["A11:H11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A11:H11"].Value = "Căn cứ Luật Quảng cáo 2012";

            exRange.Range["A12:H12"].MergeCells = true;
            exRange.Range["A12:H12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A12:H12"].Value = "Căn cứ nhu cầu và khả năng của hai bên:";

            exRange.Range["A13:H13"].MergeCells = true;
            exRange.Range["A13:H13"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            DateTime d = Convert.ToDateTime(tblhd.Rows[0][3].ToString());
            exRange.Range["A13:H13"].Value = "Hôm nay, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;

            exRange.Range["A14:H14"].MergeCells = true;
            exRange.Range["A14:H14"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A14:H14"].Value = "BÊN A:";
            exRange.Range["A14:H14"].Font.Bold = true;

            exRange.Range["A15:H15"].MergeCells = true;
            exRange.Range["A15:H15"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A15:H15"].Value = "Ông/bà: " + txttenkh.Text;

            exRange.Range["A16:H16"].MergeCells = true;
            exRange.Range["A16:H16"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A16:H16"].Value = "Địa chỉ: " + txtdiachi.Text;

            exRange.Range["A17:H17"].MergeCells = true;
            exRange.Range["A17:H17"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A17:H17"].Value = "Số điện thoại: " + mskdienthoai.Text;

            exRange.Range["A18:H18"].MergeCells = true;
            exRange.Range["A18:H18"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A18:H18"].Value = "BÊN B:";
            exRange.Range["A18:H18"].Font.Bold = true;

            exRange.Range["A19:H19"].MergeCells = true;
            exRange.Range["A19:H19"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A19:H19"].Value = "Ông/bà: " + txttennv.Text;

            exRange.Range["A20:H20"].MergeCells = true;
            exRange.Range["A20:H20"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A20:H20"].Value = "Số điện thoại: " + tblhd.Rows[0][2];

            exRange.Range["A21:H21"].MergeCells = true;
            exRange.Range["A21:H21"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A21:H21"].Value = "Chức vụ: " + tblhd.Rows[0][1];

            exRange.Range["A22:H22"].MergeCells = true;
            exRange.Range["A22:H22"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A22:H22"].Value = "Sau khi bàn bạc, thỏa thuận các bên thống nhất các nội dung sau:";

            exRange.Range["A25:H25"].MergeCells = true;
            exRange.Range["A25:H25"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A25:H25"].Value = "Bên A chịu trách nhiệm đưa ra ý tưởng kịch bản và các thông tin cần viết bài cho Bên B";

            exRange.Range["A26:H26"].MergeCells = true;
            exRange.Range["A26:H26"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A26:H26"].Value = "Bên B chịu trách nhiệm đưa thông tin của Bên A dưới hình thức viết bài:";

            exRange.Range["A27:H27"].Font.Bold = true;
            exRange.Range["A27:H27"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["D27:H27"].ColumnWidth = 12;
            if (txtmahd.Text.Substring(0, 2) == "VB")
            {
                sql = "select mabao,matheloai,tieude,noidung,ngaydang,nhuanbut from chitietvietbai where mavb = '" + txtmahd.Text + "'";
                tblctvb = Class.Functions.GetDataToTable(sql);
                exRange.Range["A27:A27"].Value = "STT";
                exRange.Range["B27:B27"].Value = "Báo";
                exRange.Range["C27:C27"].Value = "Thể loại";
                exRange.Range["D27:D27"].Value = "Tiêu đề";
                exRange.Range["E27:E27"].Value = "Nội dung";
                exRange.Range["F27:F27"].Value = "Ngày đăng";
                exRange.Range["G27:G27"].Value = "Nhuận bút";
                for (row = 0; row <= tblctvb.Rows.Count - 1; row++)
                {
                    exSheet.Cells[1][row + 28] = row + 1; //điền số thứ tự vào ô đầu tiên trong mỗi hàng
                    for (col = 0; col <= tblctvb.Columns.Count - 1; col++)
                    {
                        if (tblctvb.Columns[col].ColumnName == "ngaydang")
                        {
                            exSheet.Cells[col + 2][row + 28] = Convert.ToDateTime(tblctvb.Rows[row]["ngaydang"]);
                        }
                        else
                        {
                            exSheet.Cells[col + 2][row + 28] = tblctvb.Rows[row][col].ToString();
                        }
                    }
                }
            }
            else
            {
                sql = "select madv,mabao,ngaybd,ngaykt,dongia,(dongia * abs(datediff(day,ngaykt,ngaybd))) as thanhtien,noidung from chitietquangcao where maqc = '" + txtmahd.Text + "'";
                tblctqc = Class.Functions.GetDataToTable(sql);
                exRange.Range["A27:A27"].Value = "STT";
                exRange.Range["B27:B27"].Value = "Dịch vụ";
                exRange.Range["C27:C27"].Value = "Báo";
                exRange.Range["D27:D27"].Value = "Ngày bắt đầu";
                exRange.Range["E27:E27"].Value = "Ngày kết thúc ";
                exRange.Range["F27:F27"].Value = "Đơn giá";
                exRange.Range["G27:G27"].Value = "Thành tiền";
                exRange.Range["H27:H27"].Value = "Nội dung";
                for (row = 0; row <= tblctqc.Rows.Count - 1; row++)
                {
                    exSheet.Cells[1][row + 28] = row + 1; //điền số thứ tự vào ô đầu tiên trong mỗi hàng
                    for (col = 0; col <= tblctqc.Columns.Count - 1; col++)
                    {
                        if (tblctqc.Columns[col].ColumnName == "ngaybd")
                        {
                            exSheet.Cells[col + 2][row + 28] = Convert.ToDateTime(tblctqc.Rows[row]["ngaybd"]);
                        }
                        else if (tblctqc.Columns[col].ColumnName == "ngaykt")
                        {
                            exSheet.Cells[col + 2][row + 28] = Convert.ToDateTime(tblctqc.Rows[row]["ngaykt"]);
                        }
                        else
                        {
                            exSheet.Cells[col + 2][row + 28] = tblctqc.Rows[row][col].ToString();
                        }
                    }
                }
            }

            exRange = exSheet.Cells[1][row + 29];
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:H1"].Value = "ĐIỀU 2: GIÁ TRỊ HỢP ĐỒNG";
            exRange.Range["A1:H1"].Font.Bold = true;

            exRange = exSheet.Cells[1][row + 30];
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:H1"].Value = "Chi phí cho việc thực hiện nội dung công việc tại Điều 1 của hợp đồng này là: " + tblhd.Rows[0][4].ToString() +
                " (Bằng chữ: " + Class.Functions.ConvertNumberToString(tblhd.Rows[0][4].ToString()) + ")"; ;
            exRange.Range["A1:H1"].WrapText = true;

            exRange = exSheet.Cells[1][row + 31];
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:H1"].Value = "ĐIỀU 3: Bên A phải trả tiền đầy đủ cho bên B 01 (một) lần bằng tiền mặt và bên A phải cấp cho bên B hợp đồng đẩy đủ để có cơ sở thanh toán chi phí cho đợt quảng cáo";
            exRange.Range["A1:H1"].Font.Bold = true;
            exRange.Range["A1:H1"].WrapText = true;

            exRange = exSheet.Cells[1][row + 32];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "ĐẠI DIỆN BÊN A";
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            string[] Name_KH = txttenkh.Text.Split(" ");
            exRange.Range["A2:C2"].Value = Name_KH[2];
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = txttenkh.Text;

            exRange = exSheet.Cells[6][row + 32];
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:C1"].Value = "ĐẠI DIỆN BÊN B";
            exRange.Range["A1:C1"].Font.Bold = true;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            string[] Name_NV = txttenkh.Text.Split(" ");
            exRange.Range["A2:C2"].Value = Name_NV[2];
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = txttennv.Text;
            exApp.Visible = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng chương trình?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
