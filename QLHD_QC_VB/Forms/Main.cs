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
    public partial class frmQLHD : Form
    {
        public frmQLHD()
        {
            InitializeComponent();
        }

        private void frmQLHD_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnukhachhang_Click(object sender, EventArgs e)
        {
            frmkhachhang a = new frmkhachhang();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            frmnhanvien a = new frmnhanvien();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnubao_Click(object sender, EventArgs e)
        {
            frmbao a = new frmbao();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnutkkhachhang_Click(object sender, EventArgs e)
        {
            frmtimkiemkh a = new frmtimkiemkh();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnuhopdong_Click(object sender, EventArgs e)
        {
            frmhopdong a = new frmhopdong();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnutkhopdong_Click(object sender, EventArgs e)
        {
            frmtimkiemhd a = new frmtimkiemhd();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }

        private void mnubaocao_Click(object sender, EventArgs e)
        {
            frmbaocaodt a = new frmbaocaodt();
            a.FormBorderStyle = FormBorderStyle.None;
            a.Dock = DockStyle.Fill;
            a.TopLevel = false;
            a.TopMost = true;
            pnlcontent.Controls.Clear();
            pnlcontent.Controls.Add(a);
            a.Show();
        }
    }
}
