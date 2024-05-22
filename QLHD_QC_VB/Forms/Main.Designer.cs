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
            mnuthoat = new ToolStripMenuItem();
            lblnoidung = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnudanhmuc, mnuhopdong, mnubaocao, mnutimkiem, mnuthoat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(926, 28);
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
            mnunhanvien.Name = "mnunhanvien";
            mnunhanvien.Size = new Size(224, 26);
            mnunhanvien.Text = "Nhân viên";
            mnunhanvien.Click += mnunhanvien_Click;
            // 
            // mnukhachhang
            // 
            mnukhachhang.Name = "mnukhachhang";
            mnukhachhang.Size = new Size(224, 26);
            mnukhachhang.Text = "Khách hàng";
            mnukhachhang.Click += mnukhachhang_Click;
            // 
            // mnubao
            // 
            mnubao.Name = "mnubao";
            mnubao.Size = new Size(224, 26);
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
            mnutimkiem.DropDownItems.AddRange(new ToolStripItem[] { mnutkkhachhang });
            mnutimkiem.Name = "mnutimkiem";
            mnutimkiem.Size = new Size(84, 24);
            mnutimkiem.Text = "Tìm kiếm";
            // 
            // mnutkkhachhang
            // 
            mnutkkhachhang.Name = "mnutkkhachhang";
            mnutkkhachhang.Size = new Size(169, 26);
            mnutkkhachhang.Text = "Khách hàng";
            mnutkkhachhang.Click += mnutkkhachhang_Click;
            // 
            // mnuthoat
            // 
            mnuthoat.Name = "mnuthoat";
            mnuthoat.Size = new Size(61, 24);
            mnuthoat.Text = "Thoát";
            mnuthoat.Click += mnuthoat_Click;
            // 
            // lblnoidung
            // 
            lblnoidung.AutoSize = true;
            lblnoidung.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblnoidung.Location = new Point(137, 225);
            lblnoidung.Name = "lblnoidung";
            lblnoidung.Size = new Size(621, 46);
            lblnoidung.TabIndex = 1;
            lblnoidung.Text = "Quản lý Hợp đồng Quảng cáo và Viết bài";
            // 
            // frmQLHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(926, 522);
            Controls.Add(lblnoidung);
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
        private Label lblnoidung;
    }
}