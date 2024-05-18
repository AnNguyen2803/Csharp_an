namespace QLHD_QC_VB.Forms
{
    partial class frmtimkiemkh
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
            lbllvhd = new Label();
            cbolvhd = new ComboBox();
            btntimkiem = new Button();
            DataGridView = new DataGridView();
            btntimlai = new Button();
            btndong = new Button();
            lblmakh = new Label();
            txtmakh = new TextBox();
            lbltenkh = new Label();
            txttenkh = new TextBox();
            lbldiachi = new Label();
            txtdiachi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // lbllvhd
            // 
            lbllvhd.AutoSize = true;
            lbllvhd.Location = new Point(61, 29);
            lbllvhd.Name = "lbllvhd";
            lbllvhd.Size = new Size(139, 20);
            lbllvhd.TabIndex = 0;
            lbllvhd.Text = "Lĩnh vực hoạt động:";
            // 
            // cbolvhd
            // 
            cbolvhd.FormattingEnabled = true;
            cbolvhd.Location = new Point(206, 25);
            cbolvhd.Name = "cbolvhd";
            cbolvhd.Size = new Size(221, 28);
            cbolvhd.TabIndex = 1;
            // 
            // btntimkiem
            // 
            btntimkiem.Location = new Point(228, 502);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 29);
            btntimkiem.TabIndex = 2;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(52, 154);
            DataGridView.Name = "DataGridView";
            DataGridView.RowHeadersWidth = 51;
            DataGridView.Size = new Size(877, 307);
            DataGridView.TabIndex = 3;
            // 
            // btntimlai
            // 
            btntimlai.Location = new Point(442, 502);
            btntimlai.Name = "btntimlai";
            btntimlai.Size = new Size(94, 29);
            btntimlai.TabIndex = 4;
            btntimlai.Text = "Tìm lại";
            btntimlai.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            btndong.Location = new Point(650, 502);
            btndong.Name = "btndong";
            btndong.Size = new Size(94, 29);
            btndong.TabIndex = 5;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = true;
            // 
            // lblmakh
            // 
            lblmakh.AutoSize = true;
            lblmakh.Location = new Point(507, 29);
            lblmakh.Name = "lblmakh";
            lblmakh.Size = new Size(112, 20);
            lblmakh.TabIndex = 6;
            lblmakh.Text = "Mã khách hàng:";
            // 
            // txtmakh
            // 
            txtmakh.Location = new Point(625, 25);
            txtmakh.Name = "txtmakh";
            txtmakh.Size = new Size(212, 27);
            txtmakh.TabIndex = 7;
            // 
            // lbltenkh
            // 
            lbltenkh.AutoSize = true;
            lbltenkh.Location = new Point(61, 99);
            lbltenkh.Name = "lbltenkh";
            lbltenkh.Size = new Size(114, 20);
            lbltenkh.TabIndex = 8;
            lbltenkh.Text = "Tên khách hàng:";
            // 
            // txttenkh
            // 
            txttenkh.Location = new Point(206, 96);
            txttenkh.Name = "txttenkh";
            txttenkh.Size = new Size(221, 27);
            txttenkh.TabIndex = 9;
            // 
            // lbldiachi
            // 
            lbldiachi.AutoSize = true;
            lbldiachi.Location = new Point(507, 99);
            lbldiachi.Name = "lbldiachi";
            lbldiachi.Size = new Size(58, 20);
            lbldiachi.TabIndex = 10;
            lbldiachi.Text = "Địa chỉ:";
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(625, 96);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(212, 27);
            txtdiachi.TabIndex = 11;
            // 
            // frmtimkiemkh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 554);
            Controls.Add(txtdiachi);
            Controls.Add(lbldiachi);
            Controls.Add(txttenkh);
            Controls.Add(lbltenkh);
            Controls.Add(txtmakh);
            Controls.Add(lblmakh);
            Controls.Add(btndong);
            Controls.Add(btntimlai);
            Controls.Add(DataGridView);
            Controls.Add(btntimkiem);
            Controls.Add(cbolvhd);
            Controls.Add(lbllvhd);
            Name = "frmtimkiemkh";
            Text = "Tìm kiếm khách hàng";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllvhd;
        private ComboBox cbolvhd;
        private Button btntimkiem;
        private DataGridView DataGridView;
        private Button btntimlai;
        private Button btndong;
        private Label lblmakh;
        private TextBox txtmakh;
        private Label lbltenkh;
        private TextBox txttenkh;
        private Label lbldiachi;
        private TextBox txtdiachi;
    }
}