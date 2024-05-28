namespace QLHD_QC_VB.Forms
{
    partial class frmQLHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnudanhmuc = new ToolStripMenuItem();
            mnunhanvien = new ToolStripMenuItem();
            mnukhachhang = new ToolStripMenuItem();
            mnubao = new ToolStripMenuItem();
            mnuhopdong = new ToolStripMenuItem();
            mnubaocao = new ToolStripMenuItem();
            mnutimkiem = new ToolStripMenuItem();
            mnutkkhachhang = new ToolStripMenuItem();
            mnutkhopdong = new ToolStripMenuItem();
            mnuthoat = new ToolStripMenuItem();
            pnlcontent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(240, 228, 211);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnudanhmuc, mnuhopdong, mnubaocao, mnutimkiem, mnuthoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1082, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnudanhmuc
            // 
            mnudanhmuc.DropDownItems.AddRange(new ToolStripItem[] { mnunhanvien, mnukhachhang, mnubao });
            mnudanhmuc.Name = "mnudanhmuc";
            mnudanhmuc.Size = new Size(73, 24);
            mnudanhmuc.Text = "Quản lý";
            // 
            // mnunhanvien
            // 
            mnunhanvien.BackColor = SystemColors.Control;
            mnunhanvien.Name = "mnunhanvien";
            mnunhanvien.Size = new Size(169, 26);
            mnunhanvien.Text = "Nhân viên";
            mnunhanvien.Click += mnunhanvien_Click;
            // 
            // mnukhachhang
            // 
            mnukhachhang.BackColor = SystemColors.Control;
            mnukhachhang.Name = "mnukhachhang";
            mnukhachhang.Size = new Size(169, 26);
            mnukhachhang.Text = "Khách hàng";
            mnukhachhang.Click += mnukhachhang_Click;
            // 
            // mnubao
            // 
            mnubao.BackColor = SystemColors.Control;
            mnubao.Name = "mnubao";
            mnubao.Size = new Size(169, 26);
            mnubao.Text = "Báo";
            mnubao.Click += mnubao_Click;
            // 
            // mnuhopdong
            // 
            mnuhopdong.Name = "mnuhopdong";
            mnuhopdong.Size = new Size(91, 24);
            mnuhopdong.Text = "Hợp đồng";
            mnuhopdong.Click += mnuhopdong_Click;
            // 
            // mnubaocao
            // 
            mnubaocao.Name = "mnubaocao";
            mnubaocao.Size = new Size(81, 24);
            mnubaocao.Text = "Báo cáo ";
            // 
            // mnutimkiem
            // 
            mnutimkiem.DropDownItems.AddRange(new ToolStripItem[] { mnutkkhachhang, mnutkhopdong });
            mnutimkiem.Name = "mnutimkiem";
            mnutimkiem.Size = new Size(84, 24);
            mnutimkiem.Text = "Tìm kiếm";
            // 
            // mnutkkhachhang
            // 
            mnutkkhachhang.Name = "mnutkkhachhang";
            mnutkkhachhang.Size = new Size(224, 26);
            mnutkkhachhang.Text = "Khách hàng";
            mnutkkhachhang.Click += mnutkkhachhang_Click;
            // 
            // mnutkhopdong
            // 
            mnutkhopdong.Name = "mnutkhopdong";
            mnutkhopdong.Size = new Size(224, 26);
            mnutkhopdong.Text = "Hợp đồng";
            mnutkhopdong.Click += mnutkhopdong_Click;
            // 
            // mnuthoat
            // 
            mnuthoat.Name = "mnuthoat";
            mnuthoat.Size = new Size(61, 24);
            mnuthoat.Text = "Thoát";
            mnuthoat.Click += mnuthoat_Click;
            // 
            // pnlcontent
            // 
            pnlcontent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlcontent.BackColor = Color.FromArgb(250, 248, 238);
            pnlcontent.BackgroundImage = Properties.Resources.quan_ly_hop_dong;
            pnlcontent.BackgroundImageLayout = ImageLayout.Stretch;
            pnlcontent.BorderStyle = BorderStyle.FixedSingle;
            pnlcontent.Location = new Point(0, 28);
            pnlcontent.Name = "pnlcontent";
            pnlcontent.Size = new Size(1082, 625);
            pnlcontent.TabIndex = 1;
            // 
            // frmQLHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1082, 653);
            Controls.Add(pnlcontent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmQLHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Hợp đồng Quảng cáo và Viết bài";
            Load += frmQLHD_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnudanhmuc;
        private ToolStripMenuItem mnunhanvien;
        private ToolStripMenuItem mnukhachhang;
        private ToolStripMenuItem mnubao;
        private ToolStripMenuItem mnuhopdong;
        private ToolStripMenuItem mnubaocao;
        private ToolStripMenuItem mnutimkiem;
        private ToolStripMenuItem mnuthoat;
        private ToolStripMenuItem mnutkkhachhang;
        private Panel pnlcontent;
        private ToolStripMenuItem mnutkhopdong;
    }
}