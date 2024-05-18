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
            a.Show();
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            frmnhanvien a = new frmnhanvien();
            a.Show();
        }

        private void mnubao_Click(object sender, EventArgs e)
        {
            frmbao a = new frmbao();
            a.Show();
        }

        private void mnuhopdongquangcao_Click(object sender, EventArgs e)
        {
            frmhdquangcao a = new frmhdquangcao();
            a.Show();
        }

        private void mnuhopdongvietbai_Click(object sender, EventArgs e)
        {
            frmhopdongvietbai a = new frmhopdongvietbai();
            a.Show();
        }
    }
}
