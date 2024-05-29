namespace QLHD_QC_VB.Forms
{
    partial class frmctqc
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
            lblcthd = new Label();
            lblkickdup = new Label();
            txttongtien = new TextBox();
            btnboqua = new Button();
            lbltongtien = new Label();
            btncapnhat = new Button();
            btnthem = new Button();
            DataGridView = new DataGridView();
            txtnoidung = new TextBox();
            lblmabao = new Label();
            lblnoidung = new Label();
            lbltenbao = new Label();
            cbomabao = new ComboBox();
            lblmadichvu = new Label();
            cbomadv = new ComboBox();
            lbldichvu = new Label();
            txttenbao = new TextBox();
            txtthanhtien = new TextBox();
            txtdongia = new TextBox();
            txttendv = new TextBox();
            mskngaykt = new MaskedTextBox();
            lblngaykt = new Label();
            lblngaybd = new Label();
            mskngaybd = new MaskedTextBox();
            lbldongia = new Label();
            lblthanhtien = new Label();
            btnluu = new Button();
            btndong = new Button();
            txtmaCTQC = new TextBox();
            lblCTQC = new Label();
            lblbangchu = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblcthd
            // 
            lblcthd.AutoSize = true;
            lblcthd.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcthd.Location = new Point(407, 9);
            lblcthd.Name = "lblcthd";
            lblcthd.Size = new Size(276, 38);
            lblcthd.TabIndex = 1;
            lblcthd.Text = "CHI TIẾT HỢP ĐỒNG";
            // 
            // lblkickdup
            // 
            lblkickdup.AutoSize = true;
            lblkickdup.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblkickdup.ForeColor = Color.Red;
            lblkickdup.Location = new Point(38, 543);
            lblkickdup.Name = "lblkickdup";
            lblkickdup.Size = new Size(196, 20);
            lblkickdup.TabIndex = 64;
            lblkickdup.Text = "Kích đúp vào dịch vụ cần xóa";
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(856, 539);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(173, 27);
            txttongtien.TabIndex = 48;
            // 
            // btnboqua
            // 
            btnboqua.Location = new Point(648, 539);
            btnboqua.Name = "btnboqua";
            btnboqua.Size = new Size(87, 29);
            btnboqua.TabIndex = 61;
            btnboqua.Text = "Bỏ qua";
            btnboqua.UseVisualStyleBackColor = true;
            btnboqua.Click += btnboqua_Click;
            // 
            // lbltongtien
            // 
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(764, 543);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(75, 20);
            lbltongtien.TabIndex = 47;
            lbltongtien.Text = "Tổng tiền:";
            // 
            // btncapnhat
            // 
            btncapnhat.Location = new Point(407, 539);
            btncapnhat.Name = "btncapnhat";
            btncapnhat.Size = new Size(87, 29);
            btncapnhat.TabIndex = 63;
            btncapnhat.Text = "Cập nhật";
            btncapnhat.UseVisualStyleBackColor = true;
            btncapnhat.Click += btncapnhat_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(249, 539);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(123, 29);
            btnthem.TabIndex = 62;
            btnthem.Text = "Thêm dịch vụ";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(41, 256);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(988, 267);
            DataGridView.TabIndex = 46;
            DataGridView.Click += DataGridView_Click;
            DataGridView.DoubleClick += DataGridView_DoubleClick;
            // 
            // txtnoidung
            // 
            txtnoidung.Location = new Point(381, 158);
            txtnoidung.Multiline = true;
            txtnoidung.Name = "txtnoidung";
            txtnoidung.Size = new Size(624, 75);
            txtnoidung.TabIndex = 60;
            // 
            // lblmabao
            // 
            lblmabao.AutoSize = true;
            lblmabao.Location = new Point(55, 62);
            lblmabao.Name = "lblmabao";
            lblmabao.Size = new Size(63, 20);
            lblmabao.TabIndex = 49;
            lblmabao.Text = "Mã báo:";
            // 
            // lblnoidung
            // 
            lblnoidung.AutoSize = true;
            lblnoidung.Location = new Point(301, 178);
            lblnoidung.Name = "lblnoidung";
            lblnoidung.Size = new Size(74, 20);
            lblnoidung.TabIndex = 59;
            lblnoidung.Text = "Nội dung:";
            // 
            // lbltenbao
            // 
            lbltenbao.AutoSize = true;
            lbltenbao.Location = new Point(301, 66);
            lbltenbao.Name = "lbltenbao";
            lbltenbao.Size = new Size(65, 20);
            lbltenbao.TabIndex = 45;
            lbltenbao.Text = "Tên báo:";
            // 
            // cbomabao
            // 
            cbomabao.FormattingEnabled = true;
            cbomabao.Location = new Point(145, 59);
            cbomabao.Name = "cbomabao";
            cbomabao.Size = new Size(141, 28);
            cbomabao.TabIndex = 56;
            cbomabao.TextChanged += cbomabao_TextChanged;
            // 
            // lblmadichvu
            // 
            lblmadichvu.AutoSize = true;
            lblmadichvu.Location = new Point(55, 116);
            lblmadichvu.Name = "lblmadichvu";
            lblmadichvu.Size = new Size(84, 20);
            lblmadichvu.TabIndex = 51;
            lblmadichvu.Text = "Mã dịch vụ:";
            // 
            // cbomadv
            // 
            cbomadv.FormattingEnabled = true;
            cbomadv.Location = new Point(145, 113);
            cbomadv.Name = "cbomadv";
            cbomadv.Size = new Size(141, 28);
            cbomadv.TabIndex = 50;
            cbomadv.TextChanged += cbomadv_TextChanged;
            // 
            // lbldichvu
            // 
            lbldichvu.AutoSize = true;
            lbldichvu.Location = new Point(301, 116);
            lbldichvu.Name = "lbldichvu";
            lbldichvu.Size = new Size(61, 20);
            lbldichvu.TabIndex = 40;
            lbldichvu.Text = "Dịch vụ:";
            // 
            // txttenbao
            // 
            txttenbao.Location = new Point(381, 59);
            txttenbao.Name = "txttenbao";
            txttenbao.Size = new Size(173, 27);
            txttenbao.TabIndex = 52;
            // 
            // txtthanhtien
            // 
            txtthanhtien.Location = new Point(874, 113);
            txtthanhtien.Name = "txtthanhtien";
            txtthanhtien.Size = new Size(131, 27);
            txtthanhtien.TabIndex = 55;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(874, 59);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(131, 27);
            txtdongia.TabIndex = 54;
            txtdongia.TextChanged += txtdongia_TextChanged;
            // 
            // txttendv
            // 
            txttendv.Location = new Point(381, 113);
            txttendv.Name = "txttendv";
            txttendv.Size = new Size(173, 27);
            txttendv.TabIndex = 53;
            // 
            // mskngaykt
            // 
            mskngaykt.Location = new Point(669, 113);
            mskngaykt.Mask = "00/00/0000";
            mskngaykt.Name = "mskngaykt";
            mskngaykt.Size = new Size(112, 27);
            mskngaykt.TabIndex = 58;
            mskngaykt.ValidatingType = typeof(DateTime);
            mskngaykt.TextChanged += mskngaykt_TextChanged;
            // 
            // lblngaykt
            // 
            lblngaykt.AutoSize = true;
            lblngaykt.Location = new Point(560, 116);
            lblngaykt.Name = "lblngaykt";
            lblngaykt.Size = new Size(103, 20);
            lblngaykt.TabIndex = 43;
            lblngaykt.Text = "Ngày kết thúc:";
            // 
            // lblngaybd
            // 
            lblngaybd.AutoSize = true;
            lblngaybd.Location = new Point(560, 62);
            lblngaybd.Name = "lblngaybd";
            lblngaybd.Size = new Size(102, 20);
            lblngaybd.TabIndex = 42;
            lblngaybd.Text = "Ngày bắt đầu:";
            // 
            // mskngaybd
            // 
            mskngaybd.Location = new Point(669, 59);
            mskngaybd.Mask = "00/00/0000";
            mskngaybd.Name = "mskngaybd";
            mskngaybd.Size = new Size(112, 27);
            mskngaybd.TabIndex = 57;
            mskngaybd.ValidatingType = typeof(DateTime);
            mskngaybd.TextChanged += mskngaybd_TextChanged;
            // 
            // lbldongia
            // 
            lbldongia.AutoSize = true;
            lbldongia.Location = new Point(787, 62);
            lbldongia.Name = "lbldongia";
            lbldongia.Size = new Size(65, 20);
            lbldongia.TabIndex = 44;
            lbldongia.Text = "Đơn giá:";
            // 
            // lblthanhtien
            // 
            lblthanhtien.AutoSize = true;
            lblthanhtien.Location = new Point(787, 116);
            lblthanhtien.Name = "lblthanhtien";
            lblthanhtien.Size = new Size(81, 20);
            lblthanhtien.TabIndex = 41;
            lblthanhtien.Text = "Thành tiền:";
            // 
            // btnluu
            // 
            btnluu.Location = new Point(528, 539);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(87, 29);
            btnluu.TabIndex = 65;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btndong
            // 
            btndong.Location = new Point(942, 577);
            btndong.Name = "btndong";
            btndong.Size = new Size(87, 29);
            btndong.TabIndex = 66;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // txtmaCTQC
            // 
            txtmaCTQC.Location = new Point(145, 175);
            txtmaCTQC.Name = "txtmaCTQC";
            txtmaCTQC.Size = new Size(141, 27);
            txtmaCTQC.TabIndex = 67;
            // 
            // lblCTQC
            // 
            lblCTQC.AutoSize = true;
            lblCTQC.Location = new Point(55, 178);
            lblCTQC.Name = "lblCTQC";
            lblCTQC.Size = new Size(71, 20);
            lblCTQC.TabIndex = 68;
            lblCTQC.Text = "Mã CTQC";
            // 
            // lblbangchu
            // 
            lblbangchu.AutoSize = true;
            lblbangchu.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblbangchu.ForeColor = Color.Black;
            lblbangchu.Location = new Point(38, 581);
            lblbangchu.Name = "lblbangchu";
            lblbangchu.Size = new Size(78, 20);
            lblbangchu.TabIndex = 69;
            lblbangchu.Text = "Bằng chữ: ";
            // 
            // frmctqc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 618);
            Controls.Add(lblbangchu);
            Controls.Add(lblCTQC);
            Controls.Add(txtmaCTQC);
            Controls.Add(btndong);
            Controls.Add(btnluu);
            Controls.Add(lblkickdup);
            Controls.Add(txttongtien);
            Controls.Add(btnboqua);
            Controls.Add(lbltongtien);
            Controls.Add(btncapnhat);
            Controls.Add(btnthem);
            Controls.Add(DataGridView);
            Controls.Add(txtnoidung);
            Controls.Add(lblmabao);
            Controls.Add(lblnoidung);
            Controls.Add(lbltenbao);
            Controls.Add(cbomabao);
            Controls.Add(lblmadichvu);
            Controls.Add(cbomadv);
            Controls.Add(lbldichvu);
            Controls.Add(txttenbao);
            Controls.Add(txtthanhtien);
            Controls.Add(txtdongia);
            Controls.Add(txttendv);
            Controls.Add(mskngaykt);
            Controls.Add(lblngaykt);
            Controls.Add(lblngaybd);
            Controls.Add(mskngaybd);
            Controls.Add(lbldongia);
            Controls.Add(lblthanhtien);
            Controls.Add(lblcthd);
            Name = "frmctqc";
            Text = "Chi tiết hợp đồng quảng cáo";
            Load += CTHopdongQC_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcthd;
        private Label lblkickdup;
        private TextBox txttongtien;
        private Button btnboqua;
        private Label lbltongtien;
        private Button btncapnhat;
        private Button btnthem;
        private DataGridView DataGridView;
        private TextBox txtnoidung;
        private Label lblmabao;
        private Label lblnoidung;
        private Label lbltenbao;
        private ComboBox cbomabao;
        private Label lblmadichvu;
        private ComboBox cbomadv;
        private Label lbldichvu;
        private TextBox txttenbao;
        private TextBox txtthanhtien;
        private TextBox txtdongia;
        private TextBox txttendv;
        private MaskedTextBox mskngaykt;
        private Label lblngaykt;
        private Label lblngaybd;
        private MaskedTextBox mskngaybd;
        private Label lbldongia;
        private Label lblthanhtien;
        private Button btnluu;
        private Button btndong;
        private TextBox txtmaCTQC;
        private Label lblCTQC;
        private Label lblbangchu;
    }
}