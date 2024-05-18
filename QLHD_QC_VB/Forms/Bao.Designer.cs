namespace QLHD_QC_VB.Forms
{
    partial class frmbao
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
            lbldmbao = new Label();
            lblmabao = new Label();
            lbltenbao = new Label();
            lbldiachi = new Label();
            lbldienthoai = new Label();
            lblemail = new Label();
            DataGridView = new DataGridView();
            btnthemmoi = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnluu = new Button();
            btnlammoi = new Button();
            btndong = new Button();
            txttenbao = new TextBox();
            txtdiachi = new TextBox();
            txtmabao = new TextBox();
            mskdienthoai = new MaskedTextBox();
            txtemail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbldmbao
            // 
            lbldmbao.AutoSize = true;
            lbldmbao.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldmbao.Location = new Point(406, 9);
            lbldmbao.Name = "lbldmbao";
            lbldmbao.Size = new Size(227, 38);
            lbldmbao.TabIndex = 0;
            lbldmbao.Text = "DANH MỤC BÁO";
            // 
            // lblmabao
            // 
            lblmabao.AutoSize = true;
            lblmabao.Location = new Point(74, 70);
            lblmabao.Name = "lblmabao";
            lblmabao.Size = new Size(60, 20);
            lblmabao.TabIndex = 1;
            lblmabao.Text = "Mã báo";
            // 
            // lbltenbao
            // 
            lbltenbao.AutoSize = true;
            lbltenbao.Location = new Point(74, 126);
            lbltenbao.Name = "lbltenbao";
            lbltenbao.Size = new Size(62, 20);
            lbltenbao.TabIndex = 2;
            lbltenbao.Text = "Tên báo";
            // 
            // lbldiachi
            // 
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(74, 185);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(55, 20);
            lbldiachi.TabIndex = 3;
            lbldiachi.Text = "Địa chỉ";
            // 
            // lbldienthoai
            // 
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(558, 70);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(78, 20);
            lbldienthoai.TabIndex = 4;
            lbldienthoai.Text = "Điện thoại";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(558, 126);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 5;
            lblemail.Text = "Email";
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(43, 225);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(927, 294);
            DataGridView.TabIndex = 7;
            DataGridView.Click += DataGridView_Click;
            // 
            // btnthemmoi
            // 
            btnthemmoi.Location = new Point(73, 543);
            btnthemmoi.Name = "btnthemmoi";
            btnthemmoi.Size = new Size(94, 29);
            btnthemmoi.TabIndex = 8;
            btnthemmoi.Text = "Thêm mới";
            btnthemmoi.TextAlign = ContentAlignment.BottomCenter;
            btnthemmoi.UseVisualStyleBackColor = true;
            btnthemmoi.Click += btnthemmoi_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(223, 543);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 9;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(381, 543);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 10;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(539, 543);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 11;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(692, 543);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(94, 29);
            btnlammoi.TabIndex = 12;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btndong
            // 
            btndong.Location = new Point(841, 543);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 13;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // txttenbao
            // 
            txttenbao.Location = new Point(142, 123);
            txttenbao.Name = "txttenbao";
            txttenbao.Size = new Size(308, 27);
            txttenbao.TabIndex = 14;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(142, 182);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(765, 27);
            txtdiachi.TabIndex = 15;
            // 
            // txtmabao
            // 
            txtmabao.Location = new Point(142, 67);
            txtmabao.Name = "txtmabao";
            txtmabao.Size = new Size(308, 27);
            txtmabao.TabIndex = 16;
            // 
            // mskdienthoai
            // 
            mskdienthoai.Location = new Point(642, 67);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(265, 27);
            mskdienthoai.TabIndex = 17;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(642, 123);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(265, 27);
            txtemail.TabIndex = 18;
            // 
            // frmbao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 594);
            Controls.Add(txtemail);
            Controls.Add(mskdienthoai);
            Controls.Add(txtmabao);
            Controls.Add(txtdiachi);
            Controls.Add(txttenbao);
            Controls.Add(btndong);
            Controls.Add(btnlammoi);
            Controls.Add(btnluu);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthemmoi);
            Controls.Add(DataGridView);
            Controls.Add(lblemail);
            Controls.Add(lbldienthoai);
            Controls.Add(lbldiachi);
            Controls.Add(lbltenbao);
            Controls.Add(lblmabao);
            Controls.Add(lbldmbao);
            Name = "frmbao";
            Text = "Danh mục Báo";
            Load += frmbao_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldmbao;
        private Label lblmabao;
        private Label lbltenbao;
        private Label lbldiachi;
        private Label lbldienthoai;
        private Label lblemail;
        private DataGridView DataGridView;
        private Button btnthemmoi;
        private Button btnsua;
        private Button btnxoa;
        private Button btnluu;
        private Button btnlammoi;
        private Button btndong;
        private TextBox txttenbao;
        private TextBox txtdiachi;
        private TextBox txtmabao;
        private MaskedTextBox mskdienthoai;
        private TextBox txtemail;
    }
}