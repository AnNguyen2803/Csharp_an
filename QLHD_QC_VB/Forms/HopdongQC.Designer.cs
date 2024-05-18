namespace QLHD_QC_VB.Forms
{
    partial class frmhdquangcao
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
            lblmaquangcao = new Label();
            lblHDQC = new Label();
            lblngayky = new Label();
            lblmanv = new Label();
            lbltennv = new Label();
            txtmaqc = new TextBox();
            mskngayky = new MaskedTextBox();
            cbomanv = new ComboBox();
            txttennv = new TextBox();
            lblmakh = new Label();
            lbltenkh = new Label();
            lbldiachi = new Label();
            lbldienthoai = new Label();
            cbomakh = new ComboBox();
            txttenkh = new TextBox();
            txtdiachi = new TextBox();
            mskdienthoai = new MaskedTextBox();
            DataGridView = new DataGridView();
            btnthem = new Button();
            btnhuy = new Button();
            btnsua = new Button();
            btnluu = new Button();
            btnlammoi = new Button();
            lblmaqctk = new Label();
            cbotkmaqc = new ComboBox();
            btntimkiem = new Button();
            btnxuathopdong = new Button();
            btndong = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblmaquangcao
            // 
            lblmaquangcao.AutoSize = true;
            lblmaquangcao.Location = new Point(61, 77);
            lblmaquangcao.Name = "lblmaquangcao";
            lblmaquangcao.Size = new Size(107, 20);
            lblmaquangcao.TabIndex = 1;
            lblmaquangcao.Text = "Mã quảng cáo:";
            // 
            // lblHDQC
            // 
            lblHDQC.AutoSize = true;
            lblHDQC.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHDQC.Location = new Point(259, 9);
            lblHDQC.Name = "lblHDQC";
            lblHDQC.Size = new Size(335, 38);
            lblHDQC.TabIndex = 2;
            lblHDQC.Text = "HỢP ĐỒNG QUẢNG CÁO";
            // 
            // lblngayky
            // 
            lblngayky.AutoSize = true;
            lblngayky.Location = new Point(61, 120);
            lblngayky.Name = "lblngayky";
            lblngayky.Size = new Size(65, 20);
            lblngayky.TabIndex = 3;
            lblngayky.Text = "Ngày ký:";
            // 
            // lblmanv
            // 
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(61, 164);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(100, 20);
            lblmanv.TabIndex = 5;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lbltennv
            // 
            lbltennv.AutoSize = true;
            lbltennv.Location = new Point(61, 207);
            lbltennv.Name = "lbltennv";
            lbltennv.Size = new Size(102, 20);
            lbltennv.TabIndex = 6;
            lbltennv.Text = "Tên nhân viên:";
            // 
            // txtmaqc
            // 
            txtmaqc.Location = new Point(174, 74);
            txtmaqc.Name = "txtmaqc";
            txtmaqc.Size = new Size(183, 27);
            txtmaqc.TabIndex = 25;
            // 
            // mskngayky
            // 
            mskngayky.Location = new Point(174, 117);
            mskngayky.Mask = "00/00/0000";
            mskngayky.Name = "mskngayky";
            mskngayky.Size = new Size(183, 27);
            mskngayky.TabIndex = 26;
            mskngayky.ValidatingType = typeof(DateTime);
            // 
            // cbomanv
            // 
            cbomanv.FormattingEnabled = true;
            cbomanv.Location = new Point(174, 161);
            cbomanv.Name = "cbomanv";
            cbomanv.Size = new Size(183, 28);
            cbomanv.TabIndex = 27;
            cbomanv.TextChanged += cbomanv_TextChanged;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(174, 204);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(183, 27);
            txttennv.TabIndex = 28;
            // 
            // lblmakh
            // 
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(504, 77);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 29;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // lbltenkh
            // 
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(504, 120);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 30;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // lbldiachi
            // 
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(504, 164);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 31;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // lbldienthoai
            // 
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(504, 207);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(81, 20);
            lbldienthoai.TabIndex = 32;
            lbldienthoai.Text = "Điện thoại:";
            // 
            // cbomakh
            // 
            cbomakh.FormattingEnabled = true;
            cbomakh.Location = new Point(622, 74);
            cbomakh.Name = "cbomakh";
            cbomakh.Size = new Size(177, 28);
            cbomakh.TabIndex = 33;
            cbomakh.TextChanged += cbomakh_TextChanged;
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(622, 117);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(177, 27);
            txttenkh.TabIndex = 34;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(622, 161);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(177, 27);
            txtdiachi.TabIndex = 35;
            // 
            // mskdienthoai
            // 
            mskdienthoai.Location = new Point(622, 204);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(177, 27);
            mskdienthoai.TabIndex = 36;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(61, 247);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(738, 218);
            DataGridView.TabIndex = 37;
            DataGridView.Click += DataGridView_Click;
            DataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(109, 503);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(123, 29);
            btnthem.TabIndex = 38;
            btnthem.Text = "Thêm hợp đồng";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btnhuy
            // 
            btnhuy.Location = new Point(267, 503);
            btnhuy.Name = "btnhuy";
            btnhuy.Size = new Size(123, 29);
            btnhuy.TabIndex = 39;
            btnhuy.Text = "Hủy hợp đồng";
            btnhuy.UseVisualStyleBackColor = true;
            btnhuy.Click += btnhuy_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(425, 503);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(87, 29);
            btnsua.TabIndex = 40;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(540, 503);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(87, 29);
            btnluu.TabIndex = 41;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(662, 503);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(87, 29);
            btnlammoi.TabIndex = 42;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // lblmaqctk
            // 
            lblmaqctk.AutoSize = true;
            lblmaqctk.Location = new Point(27, 556);
            lblmaqctk.Name = "lblmaqctk";
            lblmaqctk.Size = new Size(107, 20);
            lblmaqctk.TabIndex = 43;
            lblmaqctk.Text = "Mã quảng cáo:";
            // 
            // cbotkmaqc
            // 
            cbotkmaqc.FormattingEnabled = true;
            cbotkmaqc.Location = new Point(140, 553);
            cbotkmaqc.Name = "cbotkmaqc";
            cbotkmaqc.Size = new Size(177, 28);
            cbotkmaqc.TabIndex = 44;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(341, 552);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(87, 29);
            btntimkiem.TabIndex = 45;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnxuathopdong
            // 
            btnxuathopdong.Location = new Point(504, 552);
            btnxuathopdong.Name = "btnxuathopdong";
            btnxuathopdong.Size = new Size(123, 29);
            btnxuathopdong.TabIndex = 46;
            btnxuathopdong.Text = "Xuất hợp đồng";
            btnxuathopdong.UseVisualStyleBackColor = true;
            btnxuathopdong.Click += btnxuathopdong_Click;
            // 
            // btndong
            // 
            btndong.Location = new Point(662, 552);
            btndong.Name = "btndong";
            btndong.Size = new Size(87, 29);
            btndong.TabIndex = 47;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(61, 475);
            label1.Name = "label1";
            label1.Size = new Size(199, 17);
            label1.TabIndex = 48;
            label1.Text = "Kích đúp để xem chi tiết hợp đồng";
            // 
            // frmhdquangcao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 593);
            Controls.Add(label1);
            Controls.Add(btndong);
            Controls.Add(btnxuathopdong);
            Controls.Add(btntimkiem);
            Controls.Add(cbotkmaqc);
            Controls.Add(lblmaqctk);
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
            Controls.Add(txtmaqc);
            Controls.Add(lbltennv);
            Controls.Add(lblmanv);
            Controls.Add(lblngayky);
            Controls.Add(lblHDQC);
            Controls.Add(lblmaquangcao);
            Name = "frmhdquangcao";
            Text = "Hợp đồng quảng cáo";
            Load += frmhdquangcao_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmaquangcao;
        private Label lblHDQC;
        private Label lblngayky;
        private Label lblmanv;
        private Label lbltennv;
        private TextBox txtmaqc;
        private MaskedTextBox mskngayky;
        private ComboBox cbomanv;
        private TextBox txttennv;
        private Label lblmakh;
        private Label lbltenkh;
        private Label lbldiachi;
        private Label lbldienthoai;
        private ComboBox cbomakh;
        private TextBox txttenkh;
        private TextBox txtdiachi;
        private MaskedTextBox mskdienthoai;
        private DataGridView DataGridView;
        private Button btnthem;
        private Button btnhuy;
        private Button btnsua;
        private Button btnluu;
        private Button btnlammoi;
        private Label lblmaqctk;
        private ComboBox cbotkmaqc;
        private Button btntimkiem;
        private Button btnxuathopdong;
        private Button btndong;
        private Label label1;
    }
}