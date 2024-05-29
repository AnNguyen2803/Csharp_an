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
            rdoquangcao = new RadioButton();
            rdovietbai = new RadioButton();
            rdotheongay = new RadioButton();
            msktheongay = new MaskedTextBox();
            rdotheokhoang = new RadioButton();
            lbltungay = new Label();
            grbtheokhoang = new GroupBox();
            msktungay = new MaskedTextBox();
            lbltoingay = new Label();
            msktoingay = new MaskedTextBox();
            lbldoanhthu = new Label();
            txtdoanhthu = new TextBox();
            btnhienthi = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            grbtheokhoang.SuspendLayout();
            SuspendLayout();
            // 
            // lbltieudebaocao
            // 
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
            lblbangchu.AutoSize = true;
            lblbangchu.Location = new Point(120, 451);
            lblbangchu.Name = "lblbangchu";
            lblbangchu.Size = new Size(74, 20);
            lblbangchu.TabIndex = 2;
            lblbangchu.Text = "Bằng chữ:";
            // 
            // lbltongtien
            // 
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(612, 451);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(75, 20);
            lbltongtien.TabIndex = 3;
            lbltongtien.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(693, 448);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(125, 27);
            txttongtien.TabIndex = 4;
            // 
            // btninbaocao
            // 
            btninbaocao.Location = new Point(724, 481);
            btninbaocao.Name = "btninbaocao";
            btninbaocao.Size = new Size(94, 29);
            btninbaocao.TabIndex = 5;
            btninbaocao.Text = "In báo cáo";
            btninbaocao.UseVisualStyleBackColor = true;
            // 
            // cbotobao
            // 
            cbotobao.FormattingEnabled = true;
            cbotobao.Location = new Point(191, 63);
            cbotobao.Name = "cbotobao";
            cbotobao.Size = new Size(222, 28);
            cbotobao.TabIndex = 6;
            // 
            // lbldichvu
            // 
            lbldichvu.AutoSize = true;
            lbldichvu.Location = new Point(596, 66);
            lbldichvu.Name = "lbldichvu";
            lbldichvu.Size = new Size(61, 20);
            lbldichvu.TabIndex = 7;
            lbldichvu.Text = "Dịch vụ:";
            // 
            // lblbao
            // 
            lblbao.AutoSize = true;
            lblbao.Location = new Point(120, 66);
            lblbao.Name = "lblbao";
            lblbao.Size = new Size(59, 20);
            lblbao.TabIndex = 8;
            lblbao.Text = "Tờ Báo:";
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(120, 245);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(698, 191);
            DataGridView.TabIndex = 0;
            // 
            // lbltheloai
            // 
            lbltheloai.AutoSize = true;
            lbltheloai.Location = new Point(596, 124);
            lbltheloai.Name = "lbltheloai";
            lbltheloai.Size = new Size(65, 20);
            lbltheloai.TabIndex = 9;
            lbltheloai.Text = "Thể loại:";
            // 
            // cbodichvu
            // 
            cbodichvu.FormattingEnabled = true;
            cbodichvu.Location = new Point(667, 63);
            cbodichvu.Name = "cbodichvu";
            cbodichvu.Size = new Size(151, 28);
            cbodichvu.TabIndex = 10;
            // 
            // cbotheloai
            // 
            cbotheloai.FormattingEnabled = true;
            cbotheloai.Location = new Point(667, 119);
            cbotheloai.Name = "cbotheloai";
            cbotheloai.Size = new Size(151, 28);
            cbotheloai.TabIndex = 11;
            // 
            // rdoquangcao
            // 
            rdoquangcao.AutoSize = true;
            rdoquangcao.Location = new Point(461, 64);
            rdoquangcao.Name = "rdoquangcao";
            rdoquangcao.Size = new Size(102, 24);
            rdoquangcao.TabIndex = 12;
            rdoquangcao.TabStop = true;
            rdoquangcao.Text = "Quảng cáo";
            rdoquangcao.UseVisualStyleBackColor = true;
            // 
            // rdovietbai
            // 
            rdovietbai.AutoSize = true;
            rdovietbai.Location = new Point(461, 120);
            rdovietbai.Name = "rdovietbai";
            rdovietbai.Size = new Size(81, 24);
            rdovietbai.TabIndex = 13;
            rdovietbai.TabStop = true;
            rdovietbai.Text = "Viết bài";
            rdovietbai.UseVisualStyleBackColor = true;
            // 
            // rdotheongay
            // 
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
            msktheongay.Location = new Point(242, 119);
            msktheongay.Mask = "00/00/0000";
            msktheongay.Name = "msktheongay";
            msktheongay.Size = new Size(171, 27);
            msktheongay.TabIndex = 15;
            msktheongay.ValidatingType = typeof(DateTime);
            // 
            // rdotheokhoang
            // 
            rdotheokhoang.AutoSize = true;
            rdotheokhoang.Location = new Point(120, 173);
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
            grbtheokhoang.Controls.Add(msktoingay);
            grbtheokhoang.Controls.Add(lbltoingay);
            grbtheokhoang.Controls.Add(msktungay);
            grbtheokhoang.Controls.Add(lbltungay);
            grbtheokhoang.Location = new Point(242, 155);
            grbtheokhoang.Name = "grbtheokhoang";
            grbtheokhoang.Size = new Size(365, 54);
            grbtheokhoang.TabIndex = 18;
            grbtheokhoang.TabStop = false;
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
            // lbltoingay
            // 
            lbltoingay.AutoSize = true;
            lbltoingay.Location = new Point(193, 19);
            lbltoingay.Name = "lbltoingay";
            lbltoingay.Size = new Size(33, 20);
            lbltoingay.TabIndex = 20;
            lbltoingay.Text = "Tới:";
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
            // lbldoanhthu
            // 
            lbldoanhthu.AutoSize = true;
            lbldoanhthu.Location = new Point(613, 176);
            lbldoanhthu.Name = "lbldoanhthu";
            lbldoanhthu.Size = new Size(95, 20);
            lbldoanhthu.TabIndex = 19;
            lbldoanhthu.Text = "Doanh thu ≥:";
            // 
            // txtdoanhthu
            // 
            txtdoanhthu.Location = new Point(709, 171);
            txtdoanhthu.Name = "txtdoanhthu";
            txtdoanhthu.Size = new Size(109, 27);
            txtdoanhthu.TabIndex = 20;
            // 
            // btnhienthi
            // 
            btnhienthi.Location = new Point(612, 481);
            btnhienthi.Name = "btnhienthi";
            btnhienthi.Size = new Size(94, 29);
            btnhienthi.TabIndex = 21;
            btnhienthi.Text = "Hiển thị";
            btnhienthi.UseVisualStyleBackColor = true;
            // 
            // frmbaocaodt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 524);
            Controls.Add(btnhienthi);
            Controls.Add(txtdoanhthu);
            Controls.Add(lbldoanhthu);
            Controls.Add(grbtheokhoang);
            Controls.Add(rdotheokhoang);
            Controls.Add(msktheongay);
            Controls.Add(rdotheongay);
            Controls.Add(rdovietbai);
            Controls.Add(rdoquangcao);
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
        private RadioButton rdoquangcao;
        private RadioButton rdovietbai;
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
    }
}