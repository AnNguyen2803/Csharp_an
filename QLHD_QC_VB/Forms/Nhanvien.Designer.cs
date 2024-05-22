namespace QLHD_QC_VB.Forms
{
    partial class frmnhanvien
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
            lbldmnv = new Label();
            lblmanv = new Label();
            lbltennv = new Label();
            lblgioitinh = new Label();
            lbldiachi = new Label();
            lbldienthoai = new Label();
            lblemail = new Label();
            lblngaysinh = new Label();
            lblchuyenmon = new Label();
            lbltrinhdo = new Label();
            lblchucvu = new Label();
            lblphongban = new Label();
            DataGridView = new DataGridView();
            btnthemmoi = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnluu = new Button();
            btnlammoi = new Button();
            btndong = new Button();
            txtmanv = new TextBox();
            txttennv = new TextBox();
            txtdiachi = new TextBox();
            txtemail = new TextBox();
            mskdienthoai = new MaskedTextBox();
            mskngaysinh = new MaskedTextBox();
            cbochuyenmon = new ComboBox();
            cbophongban = new ComboBox();
            cbotrinhdo = new ComboBox();
            cbochucvu = new ComboBox();
            chkgioitinh = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbldmnv
            // 
            lbldmnv.AutoSize = true;
            lbldmnv.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldmnv.Location = new Point(387, 9);
            lbldmnv.Name = "lbldmnv";
            lbldmnv.Size = new Size(320, 38);
            lbldmnv.TabIndex = 0;
            lbldmnv.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // lblmanv
            // 
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(54, 63);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(100, 20);
            lblmanv.TabIndex = 1;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lbltennv
            // 
            lbltennv.AutoSize = true;
            lbltennv.Location = new Point(52, 120);
            lbltennv.Name = "lbltennv";
            lbltennv.Size = new Size(102, 20);
            lbltennv.TabIndex = 2;
            lbltennv.Text = "Tên nhân viên:";
            // 
            // lblgioitinh
            // 
            lblgioitinh.AutoSize = true;
            lblgioitinh.Location = new Point(52, 231);
            lblgioitinh.Name = "lblgioitinh";
            lblgioitinh.Size = new Size(68, 20);
            lblgioitinh.TabIndex = 3;
            lblgioitinh.Text = "Giới tính:";
            // 
            // lbldiachi
            // 
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(52, 180);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 4;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // lbldienthoai
            // 
            lbldienthoai.AutoSize = true;
            lbldienthoai.Location = new Point(401, 63);
            lbldienthoai.Name = "lbldienthoai";
            lbldienthoai.Size = new Size(81, 20);
            lbldienthoai.TabIndex = 5;
            lbldienthoai.Text = "Điện thoại:";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(401, 180);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(49, 20);
            lblemail.TabIndex = 6;
            lblemail.Text = "Email:";
            // 
            // lblngaysinh
            // 
            lblngaysinh.AutoSize = true;
            lblngaysinh.Location = new Point(401, 120);
            lblngaysinh.Name = "lblngaysinh";
            lblngaysinh.Size = new Size(77, 20);
            lblngaysinh.TabIndex = 7;
            lblngaysinh.Text = "Ngày sinh:";
            // 
            // lblchuyenmon
            // 
            lblchuyenmon.AutoSize = true;
            lblchuyenmon.Location = new Point(738, 63);
            lblchuyenmon.Name = "lblchuyenmon";
            lblchuyenmon.Size = new Size(94, 20);
            lblchuyenmon.TabIndex = 8;
            lblchuyenmon.Text = "Chuyên môn:";
            // 
            // lbltrinhdo
            // 
            lbltrinhdo.AutoSize = true;
            lbltrinhdo.Location = new Point(736, 180);
            lbltrinhdo.Name = "lbltrinhdo";
            lbltrinhdo.Size = new Size(66, 20);
            lbltrinhdo.TabIndex = 9;
            lbltrinhdo.Text = "Trình độ:";
            // 
            // lblchucvu
            // 
            lblchucvu.AutoSize = true;
            lblchucvu.Location = new Point(738, 231);
            lblchucvu.Name = "lblchucvu";
            lblchucvu.Size = new Size(64, 20);
            lblchucvu.TabIndex = 10;
            lblchucvu.Text = "Chức vụ:";
            // 
            // lblphongban
            // 
            lblphongban.AutoSize = true;
            lblphongban.Location = new Point(738, 120);
            lblphongban.Name = "lblphongban";
            lblphongban.Size = new Size(83, 20);
            lblphongban.TabIndex = 11;
            lblphongban.Text = "Phòng ban:";
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(40, 283);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(1031, 411);
            DataGridView.TabIndex = 12;
            DataGridView.Click += DataGridView_Click;
            // 
            // btnthemmoi
            // 
            btnthemmoi.Location = new Point(57, 715);
            btnthemmoi.Name = "btnthemmoi";
            btnthemmoi.Size = new Size(94, 29);
            btnthemmoi.TabIndex = 13;
            btnthemmoi.Text = "Thêm mới";
            btnthemmoi.UseVisualStyleBackColor = true;
            btnthemmoi.Click += btnthemmoi_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(232, 715);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 14;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(412, 715);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 15;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(592, 715);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(94, 29);
            btnluu.TabIndex = 16;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(776, 715);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(94, 29);
            btnlammoi.TabIndex = 17;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btndong
            // 
            btndong.Location = new Point(953, 715);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 18;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // txtmanv
            // 
            txtmanv.Location = new Point(157, 60);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(218, 27);
            txtmanv.TabIndex = 19;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(157, 117);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(218, 27);
            txttennv.TabIndex = 20;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(157, 177);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(218, 27);
            txtdiachi.TabIndex = 21;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(485, 177);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(222, 27);
            txtemail.TabIndex = 22;
            // 
            // mskdienthoai
            // 
            mskdienthoai.Location = new Point(485, 60);
            mskdienthoai.Mask = "(999) 000-0000";
            mskdienthoai.Name = "mskdienthoai";
            mskdienthoai.Size = new Size(222, 27);
            mskdienthoai.TabIndex = 23;
            // 
            // mskngaysinh
            // 
            mskngaysinh.Location = new Point(485, 117);
            mskngaysinh.Mask = "00/00/0000";
            mskngaysinh.Name = "mskngaysinh";
            mskngaysinh.Size = new Size(222, 27);
            mskngaysinh.TabIndex = 24;
            mskngaysinh.ValidatingType = typeof(DateTime);
            // 
            // cbochuyenmon
            // 
            cbochuyenmon.FormattingEnabled = true;
            cbochuyenmon.Location = new Point(835, 60);
            cbochuyenmon.Name = "cbochuyenmon";
            cbochuyenmon.Size = new Size(212, 28);
            cbochuyenmon.TabIndex = 25;
            // 
            // cbophongban
            // 
            cbophongban.FormattingEnabled = true;
            cbophongban.Location = new Point(835, 117);
            cbophongban.Name = "cbophongban";
            cbophongban.Size = new Size(212, 28);
            cbophongban.TabIndex = 26;
            // 
            // cbotrinhdo
            // 
            cbotrinhdo.FormattingEnabled = true;
            cbotrinhdo.Location = new Point(835, 177);
            cbotrinhdo.Name = "cbotrinhdo";
            cbotrinhdo.Size = new Size(212, 28);
            cbotrinhdo.TabIndex = 27;
            // 
            // cbochucvu
            // 
            cbochucvu.FormattingEnabled = true;
            cbochucvu.Location = new Point(835, 228);
            cbochucvu.Name = "cbochucvu";
            cbochucvu.Size = new Size(212, 28);
            cbochucvu.TabIndex = 28;
            // 
            // chkgioitinh
            // 
            chkgioitinh.AutoSize = true;
            chkgioitinh.Location = new Point(157, 230);
            chkgioitinh.Name = "chkgioitinh";
            chkgioitinh.Size = new Size(63, 24);
            chkgioitinh.TabIndex = 29;
            chkgioitinh.Text = "Nam";
            chkgioitinh.UseVisualStyleBackColor = true;
            // 
            // frmnhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 761);
            Controls.Add(chkgioitinh);
            Controls.Add(cbochucvu);
            Controls.Add(cbotrinhdo);
            Controls.Add(cbophongban);
            Controls.Add(cbochuyenmon);
            Controls.Add(mskngaysinh);
            Controls.Add(mskdienthoai);
            Controls.Add(txtemail);
            Controls.Add(txtdiachi);
            Controls.Add(txttennv);
            Controls.Add(txtmanv);
            Controls.Add(btndong);
            Controls.Add(btnlammoi);
            Controls.Add(btnluu);
            Controls.Add(btnxoa);
            Controls.Add(btnsua);
            Controls.Add(btnthemmoi);
            Controls.Add(DataGridView);
            Controls.Add(lblphongban);
            Controls.Add(lblchucvu);
            Controls.Add(lbltrinhdo);
            Controls.Add(lblchuyenmon);
            Controls.Add(lblngaysinh);
            Controls.Add(lblemail);
            Controls.Add(lbldienthoai);
            Controls.Add(lbldiachi);
            Controls.Add(lblgioitinh);
            Controls.Add(lbltennv);
            Controls.Add(lblmanv);
            Controls.Add(lbldmnv);
            Name = "frmnhanvien";
            Text = "Danh mục nhân viên";
            Load += frmnhanvien_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldmnv;
        private Label lblmanv;
        private Label lbltennv;
        private Label lblgioitinh;
        private Label lbldiachi;
        private Label lbldienthoai;
        private Label lblemail;
        private Label lblngaysinh;
        private Label lblchuyenmon;
        private Label lbltrinhdo;
        private Label lblchucvu;
        private Label lblphongban;
        private DataGridView DataGridView;
        private Button btnthemmoi;
        private Button btnsua;
        private Button btnxoa;
        private Button btnluu;
        private Button btnlammoi;
        private Button btndong;
        private TextBox txtmanv;
        private TextBox txttennv;
        private TextBox txtdiachi;
        private TextBox txtemail;
        private MaskedTextBox mskdienthoai;
        private MaskedTextBox mskngaysinh;
        private ComboBox cbochuyenmon;
        private ComboBox cbophongban;
        private ComboBox cbotrinhdo;
        private ComboBox cbochucvu;
        private CheckBox chkgioitinh;
    }
}