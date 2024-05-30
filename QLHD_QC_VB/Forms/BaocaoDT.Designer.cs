namespace QLHD_QC_VB.Forms
{
    partial class frmbaocaodt
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
            lbltieudebaocao = new Label();
            lblbangchu = new Label();
            lbltongtien = new Label();
            txttongtien = new TextBox();
            btninbaocao = new Button();
            cbotobao = new ComboBox();
            lbldichvu = new Label();
            lblbao = new Label();
            DataGridView = new DataGridView();
            lbltheloai = new Label();
            cbodichvu = new ComboBox();
            cbotheloai = new ComboBox();
            rdotheongay = new RadioButton();
            msktheongay = new MaskedTextBox();
            rdotheokhoang = new RadioButton();
            lbltungay = new Label();
            grbtheokhoang = new GroupBox();
            msktoingay = new MaskedTextBox();
            lbltoingay = new Label();
            msktungay = new MaskedTextBox();
            lbldoanhthu = new Label();
            txtdoanhthu = new TextBox();
            btnhienthi = new Button();
            btnlammoi = new Button();
            btndong = new Button();
            chkquangcao = new CheckBox();
            chkvietbai = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            grbtheokhoang.SuspendLayout();
            SuspendLayout();
            // 
            // lbltieudebaocao
            // 
            lbltieudebaocao.Anchor = AnchorStyles.Top;
            lbltieudebaocao.AutoSize = true;
            lbltieudebaocao.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltieudebaocao.Location = new Point(332, 9);
            lbltieudebaocao.Name = "lbltieudebaocao";
            lbltieudebaocao.Size = new Size(307, 38);
            lbltieudebaocao.TabIndex = 1;
            lbltieudebaocao.Text = "BÁO CÁO DOANH THU";
            // 
            // lblbangchu
            // 
            lblbangchu.Anchor = AnchorStyles.Bottom;
            lblbangchu.AutoSize = true;
            lblbangchu.Location = new Point(120, 451);
            lblbangchu.Name = "lblbangchu";
            lblbangchu.Size = new Size(74, 20);
            lblbangchu.TabIndex = 2;
            lblbangchu.Text = "Bằng chữ:";
            // 
            // lbltongtien
            // 
            lbltongtien.Anchor = AnchorStyles.Bottom;
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(617, 451);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(75, 20);
            lbltongtien.TabIndex = 3;
            lbltongtien.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            txttongtien.Anchor = AnchorStyles.Bottom;
            txttongtien.Location = new Point(698, 448);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(125, 27);
            txttongtien.TabIndex = 4;
            // 
            // btninbaocao
            // 
            btninbaocao.Anchor = AnchorStyles.Bottom;
            btninbaocao.Location = new Point(621, 483);
            btninbaocao.Name = "btninbaocao";
            btninbaocao.Size = new Size(94, 29);
            btninbaocao.TabIndex = 5;
            btninbaocao.Text = "In báo cáo";
            btninbaocao.UseVisualStyleBackColor = true;
            // 
            // cbotobao
            // 
            cbotobao.Anchor = AnchorStyles.Top;
            cbotobao.FormattingEnabled = true;
            cbotobao.Location = new Point(191, 63);
            cbotobao.Name = "cbotobao";
            cbotobao.Size = new Size(222, 28);
            cbotobao.TabIndex = 6;
            // 
            // lbldichvu
            // 
            lbldichvu.Anchor = AnchorStyles.Top;
            lbldichvu.AutoSize = true;
            lbldichvu.Location = new Point(596, 66);
            lbldichvu.Name = "lbldichvu";
            lbldichvu.Size = new Size(61, 20);
            lbldichvu.TabIndex = 7;
            lbldichvu.Text = "Dịch vụ:";
            // 
            // lblbao
            // 
            lblbao.Anchor = AnchorStyles.Top;
            lblbao.AutoSize = true;
            lblbao.Location = new Point(120, 66);
            lblbao.Name = "lblbao";
            lblbao.Size = new Size(59, 20);
            lblbao.TabIndex = 8;
            lblbao.Text = "Tờ Báo:";
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(177, 225);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(578, 211);
            DataGridView.TabIndex = 0;
            // 
            // lbltheloai
            // 
            lbltheloai.Anchor = AnchorStyles.Top;
            lbltheloai.AutoSize = true;
            lbltheloai.Location = new Point(596, 124);
            lbltheloai.Name = "lbltheloai";
            lbltheloai.Size = new Size(65, 20);
            lbltheloai.TabIndex = 9;
            lbltheloai.Text = "Thể loại:";
            // 
            // cbodichvu
            // 
            cbodichvu.Anchor = AnchorStyles.Top;
            cbodichvu.FormattingEnabled = true;
            cbodichvu.Location = new Point(667, 63);
            cbodichvu.Name = "cbodichvu";
            cbodichvu.Size = new Size(151, 28);
            cbodichvu.TabIndex = 10;
            // 
            // cbotheloai
            // 
            cbotheloai.Anchor = AnchorStyles.Top;
            cbotheloai.FormattingEnabled = true;
            cbotheloai.Location = new Point(667, 119);
            cbotheloai.Name = "cbotheloai";
            cbotheloai.Size = new Size(151, 28);
            cbotheloai.TabIndex = 11;
            // 
            // rdotheongay
            // 
            rdotheongay.Anchor = AnchorStyles.Top;
            rdotheongay.AutoSize = true;
            rdotheongay.Location = new Point(120, 119);
            rdotheongay.Name = "rdotheongay";
            rdotheongay.Size = new Size(99, 24);
            rdotheongay.TabIndex = 14;
            rdotheongay.TabStop = true;
            rdotheongay.Text = "Theo ngày";
            rdotheongay.UseVisualStyleBackColor = true;
            // 
            // msktheongay
            // 
            msktheongay.Anchor = AnchorStyles.Top;
            msktheongay.Location = new Point(242, 119);
            msktheongay.Mask = "00/00/0000";
            msktheongay.Name = "msktheongay";
            msktheongay.Size = new Size(171, 27);
            msktheongay.TabIndex = 15;
            msktheongay.ValidatingType = typeof(DateTime);
            // 
            // rdotheokhoang
            // 
            rdotheokhoang.Anchor = AnchorStyles.Top;
            rdotheokhoang.AutoSize = true;
            rdotheokhoang.Location = new Point(120, 175);
            rdotheokhoang.Name = "rdotheokhoang";
            rdotheokhoang.Size = new Size(116, 24);
            rdotheokhoang.TabIndex = 16;
            rdotheokhoang.TabStop = true;
            rdotheokhoang.Text = "Theo khoảng";
            rdotheokhoang.UseVisualStyleBackColor = true;
            // 
            // lbltungay
            // 
            lbltungay.AutoSize = true;
            lbltungay.Location = new Point(11, 21);
            lbltungay.Name = "lbltungay";
            lbltungay.Size = new Size(29, 20);
            lbltungay.TabIndex = 17;
            lbltungay.Text = "Từ:";
            // 
            // grbtheokhoang
            // 
            grbtheokhoang.Anchor = AnchorStyles.Top;
            grbtheokhoang.Controls.Add(msktoingay);
            grbtheokhoang.Controls.Add(lbltoingay);
            grbtheokhoang.Controls.Add(msktungay);
            grbtheokhoang.Controls.Add(lbltungay);
            grbtheokhoang.Location = new Point(242, 157);
            grbtheokhoang.Name = "grbtheokhoang";
            grbtheokhoang.Size = new Size(365, 54);
            grbtheokhoang.TabIndex = 18;
            grbtheokhoang.TabStop = false;
            // 
            // msktoingay
            // 
            msktoingay.Location = new Point(232, 16);
            msktoingay.Mask = "00/00/0000";
            msktoingay.Name = "msktoingay";
            msktoingay.Size = new Size(125, 27);
            msktoingay.TabIndex = 21;
            msktoingay.ValidatingType = typeof(DateTime);
            // 
            // lbltoingay
            // 
            lbltoingay.AutoSize = true;
            lbltoingay.Location = new Point(193, 19);
            lbltoingay.Name = "lbltoingay";
            lbltoingay.Size = new Size(33, 20);
            lbltoingay.TabIndex = 20;
            lbltoingay.Text = "Tới:";
            // 
            // msktungay
            // 
            msktungay.Location = new Point(46, 18);
            msktungay.Mask = "00/00/0000";
            msktungay.Name = "msktungay";
            msktungay.Size = new Size(125, 27);
            msktungay.TabIndex = 19;
            msktungay.ValidatingType = typeof(DateTime);
            // 
            // lbldoanhthu
            // 
            lbldoanhthu.Anchor = AnchorStyles.Top;
            lbldoanhthu.AutoSize = true;
            lbldoanhthu.Location = new Point(613, 178);
            lbldoanhthu.Name = "lbldoanhthu";
            lbldoanhthu.Size = new Size(95, 20);
            lbldoanhthu.TabIndex = 19;
            lbldoanhthu.Text = "Doanh thu ≥:";
            // 
            // txtdoanhthu
            // 
            txtdoanhthu.Anchor = AnchorStyles.Top;
            txtdoanhthu.Location = new Point(709, 173);
            txtdoanhthu.Name = "txtdoanhthu";
            txtdoanhthu.Size = new Size(109, 27);
            txtdoanhthu.TabIndex = 20;
            // 
            // btnhienthi
            // 
            btnhienthi.Anchor = AnchorStyles.Bottom;
            btnhienthi.Location = new Point(512, 483);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 21;
            btnhienthi.Text = "Hiển thị";
            btnhienthi.UseVisualStyleBackColor = true;
            // 
            // btnlammoi
            // 
            btnlammoi.Anchor = AnchorStyles.Bottom;
            btnlammoi.Location = new Point(402, 483);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(94, 29);
            btnlammoi.TabIndex = 22;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(729, 483);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 23;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            // 
            // chkquangcao
            // 
            chkquangcao.AutoSize = true;
            chkquangcao.Location = new Point(461, 65);
            chkquangcao.Name = "chkquangcao";
            chkquangcao.Size = new Size(103, 24);
            chkquangcao.TabIndex = 24;
            chkquangcao.Text = "Quảng cáo";
            chkquangcao.UseVisualStyleBackColor = true;
            // 
            // chkvietbai
            // 
            chkvietbai.AutoSize = true;
            chkvietbai.Location = new Point(461, 123);
            chkvietbai.Name = "chkvietbai";
            chkvietbai.Size = new Size(82, 24);
            chkvietbai.TabIndex = 25;
            chkvietbai.Text = "Viết bài";
            chkvietbai.UseVisualStyleBackColor = true;
            // 
            // frmbaocaodt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 524);
            Controls.Add(chkvietbai);
            Controls.Add(chkquangcao);
            Controls.Add(btndong);
            Controls.Add(btnlammoi);
            Controls.Add(btnhienthi);
            Controls.Add(txtdoanhthu);
            Controls.Add(lbldoanhthu);
            Controls.Add(grbtheokhoang);
            Controls.Add(rdotheokhoang);
            Controls.Add(msktheongay);
            Controls.Add(rdotheongay);
            Controls.Add(cbotheloai);
            Controls.Add(cbodichvu);
            Controls.Add(lbltheloai);
            Controls.Add(lblbao);
            Controls.Add(lbldichvu);
            Controls.Add(cbotobao);
            Controls.Add(btninbaocao);
            Controls.Add(txttongtien);
            Controls.Add(lbltongtien);
            Controls.Add(lblbangchu);
            Controls.Add(lbltieudebaocao);
            Controls.Add(DataGridView);
            Name = "frmbaocaodt";
            Text = "Báo cáo doanh thu";
            Load += frmbaocaodt_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            grbtheokhoang.ResumeLayout(false);
            grbtheokhoang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbltieudebaocao;
        private Label lblbangchu;
        private Label lbltongtien;
        private TextBox txttongtien;
        private Button btninbaocao;
        private ComboBox cbotobao;
        private Label lbldichvu;
        private Label lblbao;
        private DataGridView DataGridView;
        private Label lbltheloai;
        private ComboBox cbodichvu;
        private ComboBox cbotheloai;
        private RadioButton rdotheongay;
        private MaskedTextBox msktheongay;
        private RadioButton rdotheokhoang;
        private Label lbltungay;
        private GroupBox grbtheokhoang;
        private MaskedTextBox msktungay;
        private MaskedTextBox msktoingay;
        private Label lbltoingay;
        private Label lbldoanhthu;
        private TextBox txtdoanhthu;
        private Button btnhienthi;
        private Button btnlammoi;
        private Button btndong;
        private CheckBox chkquangcao;
        private CheckBox chkvietbai;
    }
}