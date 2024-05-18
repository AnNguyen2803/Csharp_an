namespace QLHD_QC_VB.Forms
{
    partial class frmhopdongvietbai
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
            lblHDVB = new Label();
            mskdienthoai = new MaskedTextBox();
            txtdiachi = new TextBox();
            txttenkh = new TextBox();
            cbomakh = new ComboBox();
            lbldienthoai = new Label();
            lbldiachi = new Label();
            lbltenkh = new Label();
            lblmakh = new Label();
            txttennv = new TextBox();
            cbomanv = new ComboBox();
            mskngayky = new MaskedTextBox();
            txtmavb = new TextBox();
            lbltennv = new Label();
            lblmanv = new Label();
            lblngayky = new Label();
            lblmavb = new Label();
            label1 = new Label();
            btndong = new Button();
            btnxuathopdong = new Button();
            btntimkiem = new Button();
            cbotkmavb = new ComboBox();
            lbltkmavb = new Label();
            btnlammoi = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnhuy = new Button();
            btnthem = new Button();
            DataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblHDVB
            // 
            lblHDVB.AutoSize = true;
            lblHDVB.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHDVB.Location = new Point(290, 9);
            lblHDVB.Name = "lblHDVB";
            lblHDVB.Size = new Size(275, 38);
            lblHDVB.TabIndex = 2;
            lblHDVB.Text = "HỢP ĐỒNG VIẾT BÀI";
            // 
            // mskdienthoai
            // 
            mskdienthoai.Location = new Point(619, 195);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(177, 27);
            mskdienthoai.TabIndex = 52;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(619, 152);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(177, 27);
            txtdiachi.TabIndex = 51;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(619, 108);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(177, 27);
            txttenkh.TabIndex = 50;
            // 
            // cbomakh
            // 
            cbomakh.FormattingEnabled = true;
            cbomakh.Location = new Point(619, 65);
            cbomakh.Name = "cbomakh";
            cbomakh.Size = new Size(177, 28);
            cbomakh.TabIndex = 49;
            cbomakh.TextChanged += cbomakh_TextChanged;
            // 
            // lbldienthoai
            // 
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(501, 198);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(81, 20);
            lbldienthoai.TabIndex = 48;
            lbldienthoai.Text = "Điện thoại:";
            // 
            // lbldiachi
            // 
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(501, 155);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 47;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // lbltenkh
            // 
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(501, 111);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 46;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // lblmakh
            // 
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(501, 68);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 45;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // txttennv
            // 
            txttennv.Location = new Point(171, 195);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(183, 27);
            txttennv.TabIndex = 44;
            // 
            // cbomanv
            // 
            cbomanv.FormattingEnabled = true;
            cbomanv.Location = new Point(171, 152);
            cbomanv.Name = "cbomanv";
            cbomanv.Size = new Size(183, 28);
            cbomanv.TabIndex = 43;
            cbomanv.TextChanged += cbomanv_TextChanged;
            // 
            // mskngayky
            // 
            mskngayky.Location = new Point(171, 108);
            mskngayky.Mask = "00/00/0000";
            mskngayky.Name = "mskngayky";
            mskngayky.Size = new Size(183, 27);
            mskngayky.TabIndex = 42;
            mskngayky.ValidatingType = typeof(DateTime);
            // 
            // txtmavb
            // 
            txtmavb.Location = new Point(171, 65);
            txtmavb.Name = "txtmavb";
            txtmavb.Size = new Size(183, 27);
            txtmavb.TabIndex = 41;
            // 
            // lbltennv
            // 
            lbltennv.AutoSize = true;
            lbltennv.Location = new Point(58, 198);
            lbltennv.Name = "lbltennv";
            lbltennv.Size = new Size(102, 20);
            lbltennv.TabIndex = 40;
            lbltennv.Text = "Tên nhân viên:";
            // 
            // lblmanv
            // 
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(58, 155);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(100, 20);
            lblmanv.TabIndex = 39;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lblngayky
            // 
            lblngayky.AutoSize = true;
            lblngayky.Location = new Point(58, 111);
            lblngayky.Name = "lblngayky";
            lblngayky.Size = new Size(65, 20);
            lblngayky.TabIndex = 38;
            lblngayky.Text = "Ngày ký:";
            // 
            // lblmavb
            // 
            lblmavb.AutoSize = true;
            lblmavb.Location = new Point(58, 68);
            lblmavb.Name = "lblmavb";
            lblmavb.Size = new Size(86, 20);
            lblmavb.TabIndex = 37;
            lblmavb.Text = "Mã viết bài:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(58, 473);
            label1.Name = "label1";
            label1.Size = new Size(199, 17);
            label1.TabIndex = 64;
            label1.Text = "Kích đúp để xem chi tiết hợp đồng";
            // 
            // btndong
            // 
            btndong.Location = new Point(659, 550);
            btndong.Name = "btndong";
            btndong.Size = new Size(87, 29);
            btndong.TabIndex = 63;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // btnxuathopdong
            // 
            btnxuathopdong.Location = new Point(501, 550);
            btnxuathopdong.Name = "btnxuathopdong";
            btnxuathopdong.Size = new Size(123, 29);
            btnxuathopdong.TabIndex = 62;
            btnxuathopdong.Text = "Xuất hợp đồng";
            btnxuathopdong.UseVisualStyleBackColor = true;
            btnxuathopdong.Click += btnxuathopdong_Click;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(338, 550);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(87, 29);
            btntimkiem.TabIndex = 61;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // cbotkmavb
            // 
            cbotkmavb.FormattingEnabled = true;
            cbotkmavb.Location = new Point(137, 551);
            cbotkmavb.Name = "cbotkmavb";
            cbotkmavb.Size = new Size(177, 28);
            cbotkmavb.TabIndex = 60;
            // 
            // lbltkmavb
            // 
            lbltkmavb.AutoSize = true;
            lbltkmavb.Location = new Point(24, 554);
            lbltkmavb.Name = "lbltkmavb";
            lbltkmavb.Size = new Size(107, 20);
            lbltkmavb.TabIndex = 59;
            lbltkmavb.Text = "Mã quảng cáo:";
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(659, 501);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(87, 29);
            btnlammoi.TabIndex = 58;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(537, 501);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(87, 29);
            btnluu.TabIndex = 57;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(422, 501);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(87, 29);
            btnsua.TabIndex = 56;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(264, 501);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(123, 29);
            btnhuy.TabIndex = 55;
            btnhuy.Text = "Hủy hợp đồng";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(106, 501);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(123, 29);
            btnthem.TabIndex = 54;
            btnthem.Text = "Thêm hợp đồng";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(58, 245);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(738, 218);
            DataGridView.TabIndex = 53;
            DataGridView.Click += DataGridView_Click;
            DataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // frmhopdongvietbai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 601);
            Controls.Add(label1);
            Controls.Add(btndong);
            Controls.Add(btnxuathopdong);
            Controls.Add(btntimkiem);
            Controls.Add(cbotkmavb);
            Controls.Add(lbltkmavb);
            Controls.Add(btnlammoi);
            Controls.Add(btnluu);
            Controls.Add(btnsua);
            Controls.Add(btnhuy);
            Controls.Add(btnthem);
            Controls.Add(DataGridView);
            Controls.Add(mskdienthoai);
            Controls.Add(txtdiachi);
            Controls.Add(txttenkh);
            Controls.Add(cbomakh);
            Controls.Add(lbldienthoai);
            Controls.Add(lbldiachi);
            Controls.Add(lbltenkh);
            Controls.Add(lblmakh);
            Controls.Add(txttennv);
            Controls.Add(cbomanv);
            Controls.Add(mskngayky);
            Controls.Add(txtmavb);
            Controls.Add(lbltennv);
            Controls.Add(lblmanv);
            Controls.Add(lblngayky);
            Controls.Add(lblmavb);
            Controls.Add(lblHDVB);
            Name = "frmhopdongvietbai";
            Text = "Hợp đồng Viết bài";
            Load += frmhopdongvietbai_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHDVB;
        private MaskedTextBox mskdienthoai;
        private TextBox txtdiachi;
        private TextBox txttenkh;
        private ComboBox cbomakh;
        private Label lbldienthoai;
        private Label lbldiachi;
        private Label lbltenkh;
        private Label lblmakh;
        private TextBox txttennv;
        private ComboBox cbomanv;
        private MaskedTextBox mskngayky;
        private TextBox txtmavb;
        private Label lbltennv;
        private Label lblmanv;
        private Label lblngayky;
        private Label lblmavb;
        private Label label1;
        private Button btndong;
        private Button btnxuathopdong;
        private Button btntimkiem;
        private ComboBox cbotkmavb;
        private Label lbltkmavb;
        private Button btnlammoi;
        private Button btnluu;
        private Button btnsua;
        private Button btnhuy;
        private Button btnthem;
        private DataGridView DataGridView;
    }
}