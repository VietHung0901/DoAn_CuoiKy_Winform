namespace DoAn_CuoiKy
{
    partial class ThemPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cobThemTrangThai = new System.Windows.Forms.ComboBox();
            this.cobThemTinhTrang = new System.Windows.Forms.ComboBox();
            this.cobThemTang = new System.Windows.Forms.ComboBox();
            this.cobThemTenLoaiPhong = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhichus = new System.Windows.Forms.TextBox();
            this.txtThemMaPhong = new System.Windows.Forms.TextBox();
            this.dgvDSPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.cobThemTrangThai);
            this.groupBox1.Controls.Add(this.cobThemTinhTrang);
            this.groupBox1.Controls.Add(this.cobThemTang);
            this.groupBox1.Controls.Add(this.cobThemTenLoaiPhong);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGhichus);
            this.groupBox1.Controls.Add(this.txtThemMaPhong);
            this.groupBox1.Location = new System.Drawing.Point(39, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phòng";
            // 
            // cobThemTrangThai
            // 
            this.cobThemTrangThai.FormattingEnabled = true;
            this.cobThemTrangThai.Items.AddRange(new object[] {
            "Hoat Dong",
            "Sua Chua"});
            this.cobThemTrangThai.Location = new System.Drawing.Point(159, 255);
            this.cobThemTrangThai.Name = "cobThemTrangThai";
            this.cobThemTrangThai.Size = new System.Drawing.Size(279, 28);
            this.cobThemTrangThai.TabIndex = 3;
            // 
            // cobThemTinhTrang
            // 
            this.cobThemTinhTrang.FormattingEnabled = true;
            this.cobThemTinhTrang.Items.AddRange(new object[] {
            "Trống",
            "Đã được thuê"});
            this.cobThemTinhTrang.Location = new System.Drawing.Point(159, 200);
            this.cobThemTinhTrang.Name = "cobThemTinhTrang";
            this.cobThemTinhTrang.Size = new System.Drawing.Size(279, 28);
            this.cobThemTinhTrang.TabIndex = 3;
            // 
            // cobThemTang
            // 
            this.cobThemTang.FormattingEnabled = true;
            this.cobThemTang.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cobThemTang.Location = new System.Drawing.Point(159, 152);
            this.cobThemTang.Name = "cobThemTang";
            this.cobThemTang.Size = new System.Drawing.Size(279, 28);
            this.cobThemTang.TabIndex = 3;
            // 
            // cobThemTenLoaiPhong
            // 
            this.cobThemTenLoaiPhong.FormattingEnabled = true;
            this.cobThemTenLoaiPhong.Location = new System.Drawing.Point(159, 102);
            this.cobThemTenLoaiPhong.Name = "cobThemTenLoaiPhong";
            this.cobThemTenLoaiPhong.Size = new System.Drawing.Size(279, 28);
            this.cobThemTenLoaiPhong.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(444, 102);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 40);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(6, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thêm ghi chú";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(6, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thêm trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thêm tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(6, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thêm tầng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm tên loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm mã phòng";
            // 
            // txtGhichus
            // 
            this.txtGhichus.Location = new System.Drawing.Point(159, 303);
            this.txtGhichus.Name = "txtGhichus";
            this.txtGhichus.Size = new System.Drawing.Size(279, 26);
            this.txtGhichus.TabIndex = 0;
            // 
            // txtThemMaPhong
            // 
            this.txtThemMaPhong.Location = new System.Drawing.Point(159, 56);
            this.txtThemMaPhong.Name = "txtThemMaPhong";
            this.txtThemMaPhong.Size = new System.Drawing.Size(279, 26);
            this.txtThemMaPhong.TabIndex = 0;
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.AllowUserToAddRows = false;
            this.dgvDSPhong.AllowUserToDeleteRows = false;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDSPhong.Location = new System.Drawing.Point(764, 59);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.ReadOnly = true;
            this.dgvDSPhong.RowHeadersWidth = 62;
            this.dgvDSPhong.RowTemplate.Height = 28;
            this.dgvDSPhong.Size = new System.Drawing.Size(1059, 367);
            this.dgvDSPhong.TabIndex = 2;
            this.dgvDSPhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSPhong_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Loại Phòng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tầng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Đã đặt phòng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng Thái";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ghi Chú";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // ThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1869, 564);
            this.Controls.Add(this.dgvDSPhong);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemPhong";
            this.Text = "ThemPhong";
            this.Load += new System.EventHandler(this.ThemPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThemMaPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhichus;
        private System.Windows.Forms.ComboBox cobThemTrangThai;
        private System.Windows.Forms.ComboBox cobThemTinhTrang;
        private System.Windows.Forms.ComboBox cobThemTang;
        private System.Windows.Forms.ComboBox cobThemTenLoaiPhong;
        private System.Windows.Forms.DataGridView dgvDSPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}