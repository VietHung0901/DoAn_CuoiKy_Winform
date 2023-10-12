namespace DoAn_CuoiKy
{
    partial class TimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiem));
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.rdbTatCaPhong = new System.Windows.Forms.RadioButton();
            this.rdbTimDaThue = new System.Windows.Forms.RadioButton();
            this.rdbTimPhongTrong = new System.Windows.Forms.RadioButton();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.cobGiaToi = new System.Windows.Forms.ComboBox();
            this.cobGiaTu = new System.Windows.Forms.ComboBox();
            this.cobTimTheoLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDSPhongTim = new System.Windows.Forms.DataGridView();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongTim)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grbTimKiem.BackgroundImage")));
            this.grbTimKiem.Controls.Add(this.rdbTatCaPhong);
            this.grbTimKiem.Controls.Add(this.rdbTimDaThue);
            this.grbTimKiem.Controls.Add(this.rdbTimPhongTrong);
            this.grbTimKiem.Controls.Add(this.btnTroVe);
            this.grbTimKiem.Controls.Add(this.btnTim);
            this.grbTimKiem.Controls.Add(this.cobGiaToi);
            this.grbTimKiem.Controls.Add(this.cobGiaTu);
            this.grbTimKiem.Controls.Add(this.cobTimTheoLoaiPhong);
            this.grbTimKiem.Controls.Add(this.label2);
            this.grbTimKiem.Controls.Add(this.label1);
            this.grbTimKiem.Controls.Add(this.label4);
            this.grbTimKiem.Location = new System.Drawing.Point(38, 50);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(404, 357);
            this.grbTimKiem.TabIndex = 4;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm phòng";
            // 
            // rdbTatCaPhong
            // 
            this.rdbTatCaPhong.AutoSize = true;
            this.rdbTatCaPhong.Location = new System.Drawing.Point(35, 220);
            this.rdbTatCaPhong.Name = "rdbTatCaPhong";
            this.rdbTatCaPhong.Size = new System.Drawing.Size(152, 24);
            this.rdbTatCaPhong.TabIndex = 5;
            this.rdbTatCaPhong.TabStop = true;
            this.rdbTatCaPhong.Text = "Tìm tất cả phòng";
            this.rdbTatCaPhong.UseVisualStyleBackColor = true;
            // 
            // rdbTimDaThue
            // 
            this.rdbTimDaThue.AutoSize = true;
            this.rdbTimDaThue.Location = new System.Drawing.Point(35, 181);
            this.rdbTimDaThue.Name = "rdbTimDaThue";
            this.rdbTimDaThue.Size = new System.Drawing.Size(234, 24);
            this.rdbTimDaThue.TabIndex = 5;
            this.rdbTimDaThue.TabStop = true;
            this.rdbTimDaThue.Text = "Tìm phòng đã có khách thuê";
            this.rdbTimDaThue.UseVisualStyleBackColor = true;
            // 
            // rdbTimPhongTrong
            // 
            this.rdbTimPhongTrong.AutoSize = true;
            this.rdbTimPhongTrong.Location = new System.Drawing.Point(35, 137);
            this.rdbTimPhongTrong.Name = "rdbTimPhongTrong";
            this.rdbTimPhongTrong.Size = new System.Drawing.Size(149, 24);
            this.rdbTimPhongTrong.TabIndex = 5;
            this.rdbTimPhongTrong.TabStop = true;
            this.rdbTimPhongTrong.Text = "Tìm phòng trống";
            this.rdbTimPhongTrong.UseVisualStyleBackColor = true;
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(55, 263);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(94, 41);
            this.btnTroVe.TabIndex = 6;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(199, 260);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 44);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // cobGiaToi
            // 
            this.cobGiaToi.FormattingEnabled = true;
            this.cobGiaToi.Items.AddRange(new object[] {
            "500000",
            "1000000",
            "1500000",
            "2000000",
            "3000000",
            "4000000",
            "5000000",
            "trên 5000000"});
            this.cobGiaToi.Location = new System.Drawing.Point(283, 76);
            this.cobGiaToi.Name = "cobGiaToi";
            this.cobGiaToi.Size = new System.Drawing.Size(103, 28);
            this.cobGiaToi.TabIndex = 2;
            // 
            // cobGiaTu
            // 
            this.cobGiaTu.FormattingEnabled = true;
            this.cobGiaTu.Items.AddRange(new object[] {
            "0",
            "500000",
            "1000000",
            "1500000",
            "2000000",
            "3000000"});
            this.cobGiaTu.Location = new System.Drawing.Point(130, 76);
            this.cobGiaTu.Name = "cobGiaTu";
            this.cobGiaTu.Size = new System.Drawing.Size(103, 28);
            this.cobGiaTu.TabIndex = 2;
            // 
            // cobTimTheoLoaiPhong
            // 
            this.cobTimTheoLoaiPhong.FormattingEnabled = true;
            this.cobTimTheoLoaiPhong.Items.AddRange(new object[] {
            "Phong Gia DInh",
            "Phong Sinh Vien"});
            this.cobTimTheoLoaiPhong.Location = new System.Drawing.Point(167, 35);
            this.cobTimTheoLoaiPhong.Name = "cobTimTheoLoaiPhong";
            this.cobTimTheoLoaiPhong.Size = new System.Drawing.Size(189, 28);
            this.cobTimTheoLoaiPhong.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm theo giá từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm theo loại phòng";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đã đặt phòng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tầng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên loại phòng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // clmMaPhong
            // 
            this.clmMaPhong.HeaderText = "Mã phòng";
            this.clmMaPhong.MinimumWidth = 8;
            this.clmMaPhong.Name = "clmMaPhong";
            this.clmMaPhong.ReadOnly = true;
            this.clmMaPhong.Width = 150;
            // 
            // dgvDSPhongTim
            // 
            this.dgvDSPhongTim.AllowUserToAddRows = false;
            this.dgvDSPhongTim.AllowUserToDeleteRows = false;
            this.dgvDSPhongTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhongTim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaPhong,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDSPhongTim.Location = new System.Drawing.Point(448, 33);
            this.dgvDSPhongTim.Name = "dgvDSPhongTim";
            this.dgvDSPhongTim.ReadOnly = true;
            this.dgvDSPhongTim.RowHeadersWidth = 62;
            this.dgvDSPhongTim.RowTemplate.Height = 28;
            this.dgvDSPhongTim.Size = new System.Drawing.Size(1032, 386);
            this.dgvDSPhongTim.TabIndex = 2;
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1492, 463);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.dgvDSPhongTim);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhongTim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cobTimTheoLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobGiaToi;
        private System.Windows.Forms.ComboBox cobGiaTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaPhong;
        private System.Windows.Forms.DataGridView dgvDSPhongTim;
        private System.Windows.Forms.RadioButton rdbTimDaThue;
        private System.Windows.Forms.RadioButton rdbTimPhongTrong;
        private System.Windows.Forms.RadioButton rdbTatCaPhong;
    }
}