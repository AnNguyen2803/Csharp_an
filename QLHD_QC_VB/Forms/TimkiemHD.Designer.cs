namespace QLHD_QC_VB.Forms
{
    partial class frmtimkiemhd
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
            lbltkhd = new Label();
            lblmahd = new Label();
            lblmanv = new Label();
            lbltungay = new Label();
            lbltoingay = new Label();
            lblgiatri = new Label();
            lblmakh = new Label();
            lblloaihd = new Label();
            txtmahd = new TextBox();
            txtmakh = new TextBox();
            txtmanv = new TextBox();
            msktungay = new MaskedTextBox();
            msktoingay = new MaskedTextBox();
            txtgiatri = new TextBox();
            DataGridView = new DataGridView();
            btntimkiem = new Button();
            btntimlai = new Button();
            btndong = new Button();
            cboloaihd = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbltkhd
            // 
            lbltkhd.Anchor = AnchorStyles.Top;
            lbltkhd.AutoSize = true;
            lbltkhd.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltkhd.Location = new Point(322, 9);
            lbltkhd.Name = "lbltkhd";
            lbltkhd.Size = new Size(286, 38);
            lbltkhd.TabIndex = 0;
            lbltkhd.Text = "TÌM KIẾM HỢP ĐỒNG";
            // 
            // lblmahd
            // 
            lblmahd.Anchor = AnchorStyles.Top;
            lblmahd.AutoSize = true;
            lblmahd.Location = new Point(26, 62);
            lblmahd.Name = "lblmahd";
            lblmahd.Size = new Size(102, 20);
            lblmahd.TabIndex = 1;
            lblmahd.Text = "Mã hợp đồng:";
            // 
            // lblmanv
            // 
            lblmanv.Anchor = AnchorStyles.Top;
            lblmanv.AutoSize = true;
            lblmanv.Location = new Point(650, 62);
            lblmanv.Name = "lblmanv";
            lblmanv.Size = new Size(100, 20);
            lblmanv.TabIndex = 2;
            lblmanv.Text = "Mã nhân viên:";
            // 
            // lbltungay
            // 
            lbltungay.Anchor = AnchorStyles.Top;
            lbltungay.AutoSize = true;
            lbltungay.Location = new Point(82, 117);
            lbltungay.Name = "lbltungay";
            lbltungay.Size = new Size(65, 20);
            lbltungay.TabIndex = 3;
            lbltungay.Text = "Từ ngày:";
            // 
            // lbltoingay
            // 
            lbltoingay.Anchor = AnchorStyles.Top;
            lbltoingay.AutoSize = true;
            lbltoingay.Location = new Point(284, 117);
            lbltoingay.Name = "lbltoingay";
            lbltoingay.Size = new Size(69, 20);
            lbltoingay.TabIndex = 4;
            lbltoingay.Text = "Tới ngày:";
            // 
            // lblgiatri
            // 
            lblgiatri.Anchor = AnchorStyles.Top;
            lblgiatri.AutoSize = true;
            lblgiatri.Location = new Point(490, 117);
            lblgiatri.Name = "lblgiatri";
            lblgiatri.Size = new Size(52, 20);
            lblgiatri.TabIndex = 5;
            lblgiatri.Text = "Giá trị:";
            // 
            // lblmakh
            // 
            lblmakh.Anchor = AnchorStyles.Top;
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(333, 62);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 6;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // lblloaihd
            // 
            lblloaihd.Anchor = AnchorStyles.Top;
            lblloaihd.AutoSize = true;
            lblloaihd.Location = new Point(679, 117);
            lblloaihd.Name = "lblloaihd";
            lblloaihd.Size = new Size(109, 20);
            lblloaihd.TabIndex = 7;
            lblloaihd.Text = "Loại hợp đồng:";
            // 
            // txtmahd
            // 
            txtmahd.Anchor = AnchorStyles.Top;
            txtmahd.Location = new Point(134, 59);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(193, 27);
            txtmahd.TabIndex = 8;
            // 
            // txtmakh
            // 
            txtmakh.Anchor = AnchorStyles.Top;
            txtmakh.Location = new Point(451, 59);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(193, 27);
            txtmakh.TabIndex = 9;
            // 
            // txtmanv
            // 
            txtmanv.Anchor = AnchorStyles.Top;
            txtmanv.Location = new Point(756, 59);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(193, 27);
            txtmanv.TabIndex = 10;
            // 
            // msktungay
            // 
            msktungay.Anchor = AnchorStyles.Top;
            msktungay.Location = new Point(153, 114);
            msktungay.Mask = "00/00/0000";
            msktungay.Name = "msktungay";
            msktungay.Size = new Size(125, 27);
            msktungay.TabIndex = 11;
            msktungay.ValidatingType = typeof(DateTime);
            // 
            // msktoingay
            // 
            msktoingay.Anchor = AnchorStyles.Top;
            msktoingay.Location = new Point(359, 114);
            msktoingay.Mask = "00/00/0000";
            msktoingay.Name = "msktoingay";
            msktoingay.Size = new Size(125, 27);
            msktoingay.TabIndex = 12;
            msktoingay.ValidatingType = typeof(DateTime);
            // 
            // txtgiatri
            // 
            txtgiatri.Anchor = AnchorStyles.Top;
            txtgiatri.Location = new Point(548, 114);
            txtgiatri.Name = "txtgiatri";
            txtgiatri.Size = new Size(125, 27);
            txtgiatri.TabIndex = 13;
            // 
            // DataGridView
            // 
            DataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(146, 177);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(685, 201);
            DataGridView.TabIndex = 15;
            // 
            // btntimkiem
            // 
            btntimkiem.Anchor = AnchorStyles.Bottom;
            btntimkiem.Location = new Point(246, 398);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 16;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btntimlai
            // 
            btntimlai.Anchor = AnchorStyles.Bottom;
            btntimlai.Location = new Point(442, 398);
            btntimlai.Name = "btntimlai";
            btntimlai.Size = new Size(94, 29);
            btntimlai.TabIndex = 17;
            btntimlai.Text = "Tìm lại";
            btntimlai.UseVisualStyleBackColor = true;
            btntimlai.Click += btntimlai_Click;
            // 
            // btndong
            // 
            btndong.Anchor = AnchorStyles.Bottom;
            btndong.Location = new Point(636, 398);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 18;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            btndong.Click += btndong_Click;
            // 
            // cboloaihd
            // 
            cboloaihd.FormattingEnabled = true;
            cboloaihd.Location = new Point(794, 114);
            cboloaihd.Name = "cboloaihd";
            cboloaihd.Size = new Size(82, 28);
            cboloaihd.TabIndex = 19;
            // 
            // frmtimkiemhd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 448);
            Controls.Add(cboloaihd);
            Controls.Add(btndong);
            Controls.Add(btntimlai);
            Controls.Add(btntimkiem);
            Controls.Add(DataGridView);
            Controls.Add(txtgiatri);
            Controls.Add(msktoingay);
            Controls.Add(msktungay);
            Controls.Add(txtmanv);
            Controls.Add(txtmakh);
            Controls.Add(txtmahd);
            Controls.Add(lblloaihd);
            Controls.Add(lblmakh);
            Controls.Add(lblgiatri);
            Controls.Add(lbltoingay);
            Controls.Add(lbltungay);
            Controls.Add(lblmanv);
            Controls.Add(lblmahd);
            Controls.Add(lbltkhd);
            Name = "frmtimkiemhd";
            Text = "Tìm kiếm hợp đồng";
            Load += frmtimkiemhd_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltkhd;
        private Label lblmahd;
        private Label lblmanv;
        private Label lbltungay;
        private Label lbltoingay;
        private Label lblgiatri;
        private Label lblmakh;
        private Label lblloaihd;
        private TextBox txtmahd;
        private TextBox txtmakh;
        private TextBox txtmanv;
        private MaskedTextBox msktungay;
        private MaskedTextBox msktoingay;
        private TextBox txtgiatri;
        private DataGridView DataGridView;
        private Button btntimkiem;
        private Button btntimlai;
        private Button btndong;
        private ComboBox cboloaihd;
    }
}