namespace QLHD_QC_VB.Forms
{
    partial class frmkhachhang
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
            lbldmkh = new Label();
            lblmakh = new Label();
            lbltenkh = new Label();
            lbllvhd = new Label();
            lbldiachi = new Label();
            lblemail = new Label();
            lbldienthoai = new Label();
            txtmakh = new TextBox();
            txttenkh = new TextBox();
            txtdiachi = new TextBox();
            txtemail = new TextBox();
            mskdienthoai = new MaskedTextBox();
            cbolvhd = new ComboBox();
            DataGridView = new DataGridView();
            btnthemmoi = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnluu = new Button();
            btnlammoi = new Button();
            btndong = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbldmkh
            // 
            lbldmkh.Anchor = AnchorStyles.Top;
            lbldmkh.AutoSize = true;
            lbldmkh.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldmkh.Location = new Point(324, 9);
            lbldmkh.Name = "lbldmkh";
            lbldmkh.Size = new Size(351, 38);
            lbldmkh.TabIndex = 0;
            lbldmkh.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // lblmakh
            // 
            lblmakh.Anchor = AnchorStyles.Top;
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(63, 67);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 1;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // lbltenkh
            // 
            lbltenkh.Anchor = AnchorStyles.Top;
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(63, 125);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 2;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // lbllvhd
            // 
            lbllvhd.Anchor = AnchorStyles.Top;
            lbllvhd.AutoSize = true;
            lbllvhd.Location = new Point(63, 187);
            lbllvhd.Name = "lbllvhd";
            lbllvhd.Size = new Size(139, 20);
            lbllvhd.TabIndex = 3;
            lbllvhd.Text = "Lĩnh vực hoạt động:";
            // 
            // lbldiachi
            // 
            lbldiachi.Anchor = AnchorStyles.Top;
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(543, 67);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 4;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // lblemail
            // 
            lblemail.Anchor = AnchorStyles.Top;
            lblemail.AutoSize = true;
            lblemail.Location = new Point(543, 125);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(49, 20);
            lblemail.TabIndex = 5;
            lblemail.Text = "Email:";
            // 
            // lbldienthoai
            // 
            lbldienthoai.Anchor = AnchorStyles.Top;
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(543, 183);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(81, 20);
            lbldienthoai.TabIndex = 6;
            lbldienthoai.Text = "Điện thoại:";
            // 
            // txtmakh
            // 
            txtmakh.Anchor = AnchorStyles.Top;
            txtmakh.Location = new Point(221, 64);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(237, 27);
            txtmakh.TabIndex = 7;
            // 
            // txttenkh
            // 
            txttenkh.Anchor = AnchorStyles.Top;
            txttenkh.Location = new Point(221, 122);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(237, 27);
            txttenkh.TabIndex = 8;
            // 
            // txtdiachi
            // 
            txtdiachi.Anchor = AnchorStyles.Top;
            txtdiachi.Location = new Point(633, 64);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(264, 27);
            txtdiachi.TabIndex = 9;
            // 
            // txtemail
            // 
            txtemail.Anchor = AnchorStyles.Top;
            txtemail.Location = new Point(633, 122);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(264, 27);
            txtemail.TabIndex = 10;
            // 
            // mskdienthoai
            // 
            mskdienthoai.Anchor = AnchorStyles.Top;
            mskdienthoai.Location = new Point(633, 180);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(264, 27);
            mskdienthoai.TabIndex = 11;
            // 
            // cbolvhd
            // 
            cbolvhd.Anchor = AnchorStyles.Top;
            cbolvhd.FormattingEnabled = true;
            cbolvhd.Location = new Point(221, 180);
            cbolvhd.Name = "cbolvhd";
            cbolvhd.Size = new Size(237, 28);
            cbolvhd.TabIndex = 12;
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(34, 245);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(945, 313);
            DataGridView.TabIndex = 13;
            DataGridView.Click += DataGridView_Click;
            // 
            // btnthemmoi
            // 
            btnthemmoi.Anchor = AnchorStyles.Bottom;
            btnthemmoi.Location = new Point(63, 591);
            btnthemmoi.Name = "btnthemmoi";
            btnthemmoi.Size = new Size(94, 29);
            btnthemmoi.TabIndex = 14;
            btnthemmoi.Text = "Thêm mới";
            btnthemmoi.UseVisualStyleBackColor = true;
            btnthemmoi.Click += btnthemmoi_Click;
            // 
            // btnsua
            // 
            btnsua.Anchor = AnchorStyles.Bottom;
            btnsua.Location = new Point(221, 591);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 15;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Anchor = AnchorStyles.Bottom;
            btnxoa.Location = new Point(380, 591);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 16;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnluu
            // 
            btnluu.Anchor = AnchorStyles.Bottom;
            btnluu.Location = new Point(540, 591);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 17;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Anchor = AnchorStyles.Bottom;
            btnlammoi.Location = new Point(694, 591);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(94, 29);
            btnlammoi.TabIndex = 18;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(849, 591);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 19;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // frmkhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 645);
            Controls.Add(btndong);
            Controls.Add(btnlammoi);
            Controls.Add(btnluu);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthemmoi);
            Controls.Add(DataGridView);
            Controls.Add(cbolvhd);
            Controls.Add(mskdienthoai);
            Controls.Add(txtemail);
            Controls.Add(txtdiachi);
            Controls.Add(txttenkh);
            Controls.Add(txtmakh);
            Controls.Add(lbldienthoai);
            Controls.Add(lblemail);
            Controls.Add(lbldiachi);
            Controls.Add(lbllvhd);
            Controls.Add(lbltenkh);
            Controls.Add(lblmakh);
            Controls.Add(lbldmkh);
            Name = "frmkhachhang";
            Text = "Danh mục khách hàng";
            Load += frmkhachhang_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldmkh;
        private Label lblmakh;
        private Label lbltenkh;
        private Label lbllvhd;
        private Label lbldiachi;
        private Label lblemail;
        private Label lbldienthoai;
        private TextBox txtmakh;
        private TextBox txttenkh;
        private TextBox txtdiachi;
        private TextBox txtemail;
        private MaskedTextBox mskdienthoai;
        private ComboBox cbolvhd;
        private DataGridView DataGridView;
        private Button btnthemmoi;
        private Button btnsua;
        private Button btnxoa;
        private Button btnluu;
        private Button btnlammoi;
        private Button btndong;
    }
}