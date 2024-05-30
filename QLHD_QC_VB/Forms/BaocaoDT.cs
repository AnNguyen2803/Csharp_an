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
    public partial class frmbaocaodt : Form
    {
        public frmbaocaodt()
        {
            InitializeComponent();
        }

        private void frmbaocaodt_Load(object sender, EventArgs e)
        {
            Class.Functions.Fillcombo("select mabao, tenbao from bao", cbotobao, "mabao", "tenbao");
            cbotobao.SelectedIndex = -1;
            rdoquangcao.Checked = true;
            Class.Functions.Fillcombo("select madv,dichvu from dichvu", cbodichvu, "madv", "dichvu");
            cbodichvu.SelectedIndex = -1;
            Class.Functions.Fillcombo("select matheloai, theloai from theloai", cbotheloai, "matheloai", "theloai");
            rdotheongay.Checked = true;
            txttongtien.ReadOnly = true;
            btninbaocao.Enabled = false;
            
        }
    }
}
