namespace QLHD_QC_VB.Forms
{
    partial class frmctvb
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
            DataGridView = new DataGridView();
            lblchitiethopdong = new Label();
            lblmactvb = new Label();
            lbltieude = new Label();
            lblnoidung = new Label();
            lblmabao = new Label();
            lblmatheloai = new Label();
            lbltenbao = new Label();
            lbltheloai = new Label();
            lblngaydang = new Label();
            lblkichdup = new Label();
            lblbangchu = new Label();
            lblnhuanbut = new Label();
            txtmactvb = new TextBox();
            txttieude = new TextBox();
            txtnoidung = new TextBox();
            cbomatheloai = new ComboBox();
            cbomabao = new ComboBox();
            txttenbao = new TextBox();
            txtnhuanbut = new TextBox();
            mskngaydang = new MaskedTextBox();
            txttheloai = new TextBox();
            lbltongtien = new Label();
            txttongtien = new TextBox();
            btnthem = new Button();
            btncapnhat = new Button();
            btnluu = new Button();
            btnboqua = new Button();
            btndong = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(37, 261);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(944, 270);
            DataGridView.TabIndex = 0;
            DataGridView.Click += DataGridView_Click;
            DataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // lblchitiethopdong
            // 
            lblchitiethopdong.AutoSize = true;
            lblchitiethopdong.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblchitiethopdong.Location = new Point(370, 9);
            lblchitiethopdong.Name = "lblchitiethopdong";
            lblchitiethopdong.Size = new Size(276, 38);
            lblchitiethopdong.TabIndex = 1;
            lblchitiethopdong.Text = "CHI TIẾT HỢP ĐỒNG";
            // 
            // lblmactvb
            // 
            lblmactvb.AutoSize = true;
            lblmactvb.Location = new Point(37, 84);
            lblmactvb.Name = "lblmactvb";
            lblmactvb.Size = new Size(72, 20);
            lblmactvb.TabIndex = 2;
            lblmactvb.Text = "Mã CTVB:";
            // 
            // lbltieude
            // 
            lbltieude.AutoSize = true;
            lbltieude.Location = new Point(37, 143);
            lbltieude.Name = "lbltieude";
            lbltieude.Size = new Size(61, 20);
            lbltieude.TabIndex = 3;
            lbltieude.Text = "Tiêu đề:";
            // 
            // lblnoidung
            // 
            lblnoidung.AutoSize = true;
            lblnoidung.Location = new Point(37, 198);
            lblnoidung.Name = "lblnoidung";
            lblnoidung.Size = new Size(74, 20);
            lblnoidung.TabIndex = 4;
            lblnoidung.Text = "Nội dung:";
            // 
            // lblmabao
            // 
            lblmabao.AutoSize = true;
            lblmabao.Location = new Point(292, 64);
            lblmabao.Name = "lblmabao";
            lblmabao.Size = new Size(63, 20);
            lblmabao.TabIndex = 5;
            lblmabao.Text = "Mã báo:";
            // 
            // lblmatheloai
            // 
            lblmatheloai.AutoSize = true;
            lblmatheloai.Location = new Point(292, 104);
            lblmatheloai.Name = "lblmatheloai";
            lblmatheloai.Size = new Size(87, 20);
            lblmatheloai.TabIndex = 6;
            lblmatheloai.Text = "Mã thể loại:";
            // 
            // lbltenbao
            // 
            lbltenbao.AutoSize = true;
            lbltenbao.Location = new Point(486, 64);
            lbltenbao.Name = "lbltenbao";
            lbltenbao.Size = new Size(65, 20);
            lbltenbao.TabIndex = 7;
            lbltenbao.Text = "Tên báo:";
            // 
            // lbltheloai
            // 
            lbltheloai.AutoSize = true;
            lbltheloai.Location = new Point(486, 104);
            lbltheloai.Name = "lbltheloai";
            lbltheloai.Size = new Size(65, 20);
            lbltheloai.TabIndex = 8;
            lbltheloai.Text = "Thể loại:";
            // 
            // lblngaydang
            // 
            lblngaydang.AutoSize = true;
            lblngaydang.Location = new Point(765, 64);
            lblngaydang.Name = "lblngaydang";
            lblngaydang.Size = new Size(85, 20);
            lblngaydang.TabIndex = 9;
            lblngaydang.Text = "Ngày đăng:";
            // 
            // lblkichdup
            // 
            lblkichdup.AutoSize = true;
            lblkichdup.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblkichdup.ForeColor = Color.Red;
            lblkichdup.Location = new Point(37, 546);
            lblkichdup.Name = "lblkichdup";
            lblkichdup.Size = new Size(170, 20);
            lblkichdup.TabIndex = 10;
            lblkichdup.Text = "Kích đúp bài viết cần xóa";
            // 
            // lblbangchu
            // 
            lblbangchu.AutoSize = true;
            lblbangchu.Location = new Point(37, 584);
            lblbangchu.Name = "lblbangchu";
            lblbangchu.Size = new Size(74, 20);
            lblbangchu.TabIndex = 11;
            lblbangchu.Text = "Bằng chữ:";
            // 
            // lblnhuanbut
            // 
            lblnhuanbut.AutoSize = true;
            lblnhuanbut.Location = new Point(765, 104);
            lblnhuanbut.Name = "lblnhuanbut";
            lblnhuanbut.Size = new Size(81, 20);
            lblnhuanbut.TabIndex = 12;
            lblnhuanbut.Text = "Nhuận bút:";
            // 
            // txtmactvb
            // 
            txtmactvb.Location = new Point(115, 81);
            txtmactvb.Name = "txtmactvb";
            txtmactvb.Size = new Size(171, 27);
            txtmactvb.TabIndex = 13;
            // 
            // txttieude
            // 
            txttieude.Location = new Point(115, 140);
            txttieude.Name = "txttieude";
            txttieude.Size = new Size(866, 27);
            txttieude.TabIndex = 14;
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(117, 181);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(864, 60);
            txtnoidung.TabIndex = 15;
            // 
            // cbomatheloai
            // 
            cbomatheloai.FormattingEnabled = true;
            cbomatheloai.Location = new Point(385, 101);
            cbomatheloai.Name = "cbomatheloai";
            cbomatheloai.Size = new Size(95, 28);
            cbomatheloai.TabIndex = 16;
            cbomatheloai.TextChanged += cbomatheloai_TextChanged;
            // 
            // cbomabao
            // 
            cbomabao.FormattingEnabled = true;
            cbomabao.Location = new Point(385, 61);
            cbomabao.Name = "cbomabao";
            cbomabao.Size = new Size(95, 28);
            cbomabao.TabIndex = 17;
            cbomabao.TextChanged += cbomabao_TextChanged;
            // 
            // txttenbao
            // 
            txttenbao.Location = new Point(557, 61);
            txttenbao.Name = "txttenbao";
            txttenbao.Size = new Size(202, 27);
            txttenbao.TabIndex = 18;
            // 
            // txtnhuanbut
            // 
            txtnhuanbut.Location = new Point(856, 101);
            txtnhuanbut.Name = "txtnhuanbut";
            txtnhuanbut.Size = new Size(125, 27);
            txtnhuanbut.TabIndex = 19;
            // 
            // mskngaydang
            // 
            mskngaydang.Location = new Point(856, 61);
            mskngaydang.Mask = "00/00/0000";
            mskngaydang.Name = "mskngaydang";
            mskngaydang.Size = new Size(125, 27);
            mskngaydang.TabIndex = 20;
            mskngaydang.ValidatingType = typeof(DateTime);
            // 
            // txttheloai
            // 
            txttheloai.Location = new Point(557, 101);
            txttheloai.Name = "txttheloai";
            txttheloai.Size = new Size(202, 27);
            txttheloai.TabIndex = 21;
            // 
            // lbltongtien
            // 
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(771, 546);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(75, 20);
            lbltongtien.TabIndex = 22;
            lbltongtien.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(856, 543);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(125, 27);
            txttongtien.TabIndex = 23;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(240, 542);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(115, 29);
            btnthem.TabIndex = 24;
            btnthem.Text = "Thêm bài viết";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // btncapnhat
            // 
            btncapnhat.Location = new Point(386, 542);
            btncapnhat.Name = "btncapnhat";
            btncapnhat.Size = new Size(94, 29);
            btncapnhat.TabIndex = 25;
            btncapnhat.Text = "Cập nhật";
            btncapnhat.UseVisualStyleBackColor = true;
            btncapnhat.Click += btncapnhat_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(515, 542);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 26;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnboqua
            // 
            btnboqua.Location = new Point(642, 542);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(94, 29);
            btnboqua.TabIndex = 27;
            btnboqua.Text = "Bỏ qua";
            btnboqua.UseVisualStyleBackColor = true;
            btnboqua.Click += btnboqua_Click;
            // 
            // btndong
            // 
            btndong.Location = new Point(887, 580);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 28;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // frmctvb
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 625);
            Controls.Add(btndong);
            Controls.Add(btnboqua);
            Controls.Add(btnluu);
            Controls.Add(btncapnhat);
            Controls.Add(btnthem);
            Controls.Add(txttongtien);
            Controls.Add(lbltongtien);
            Controls.Add(txttheloai);
            Controls.Add(mskngaydang);
            Controls.Add(txtnhuanbut);
            Controls.Add(txttenbao);
            Controls.Add(cbomabao);
            Controls.Add(cbomatheloai);
            Controls.Add(txtnoidung);
            Controls.Add(txttieude);
            Controls.Add(txtmactvb);
            Controls.Add(lblnhuanbut);
            Controls.Add(lblbangchu);
            Controls.Add(lblkichdup);
            Controls.Add(lblngaydang);
            Controls.Add(lbltheloai);
            Controls.Add(lbltenbao);
            Controls.Add(lblmatheloai);
            Controls.Add(lblmabao);
            Controls.Add(lblnoidung);
            Controls.Add(lbltieude);
            Controls.Add(lblmactvb);
            Controls.Add(lblchitiethopdong);
            Controls.Add(DataGridView);
            Name = "frmctvb";
            Text = "Chi tiết hợp đồng viết bài";
            Load += frmctvb_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private Label lblchitiethopdong;
        private Label lblmactvb;
        private Label lbltieude;
        private Label lblnoidung;
        private Label lblmabao;
        private Label lblmatheloai;
        private Label lbltenbao;
        private Label lbltheloai;
        private Label lblngaydang;
        private Label lblkichdup;
        private Label lblbangchu;
        private Label lblnhuanbut;
        private TextBox txtmactvb;
        private TextBox txttieude;
        private TextBox txtnoidung;
        private ComboBox cbomatheloai;
        private ComboBox cbomabao;
        private TextBox txttenbao;
        private TextBox txtnhuanbut;
        private MaskedTextBox mskngaydang;
        private TextBox txttheloai;
        private Label lbltongtien;
        private TextBox txttongtien;
        private Button btnthem;
        private Button btncapnhat;
        private Button btnluu;
        private Button btnboqua;
        private Button btndong;
    }
}