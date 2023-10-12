namespace DoAn_CuoiKy
{
    partial class CaiDatLoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaiDatLoaiPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenloaiphong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSLoaiPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTroVe = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaLoaiPhong);
            this.groupBox1.Controls.Add(this.btnXoaLoaiPhong);
            this.groupBox1.Controls.Add(this.btnThemLoaiPhong);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenloaiphong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaLoaiPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(96, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại phòng";
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(288, 257);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(101, 44);
            this.btnSuaLoaiPhong.TabIndex = 2;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(172, 257);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(101, 44);
            this.btnXoaLoaiPhong.TabIndex = 2;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(56, 257);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(101, 44);
            this.btnThemLoaiPhong.TabIndex = 2;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(228, 187);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(284, 26);
            this.txtDonGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // txtTenloaiphong
            // 
            this.txtTenloaiphong.Location = new System.Drawing.Point(228, 126);
            this.txtTenloaiphong.Name = "txtTenloaiphong";
            this.txtTenloaiphong.Size = new System.Drawing.Size(284, 26);
            this.txtTenloaiphong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại phòng";
            // 
            // txtMaLoaiPhong
            // 
            this.txtMaLoaiPhong.Location = new System.Drawing.Point(228, 67);
            this.txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            this.txtMaLoaiPhong.Size = new System.Drawing.Size(284, 26);
            this.txtMaLoaiPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại phòng";
            // 
            // dgvDSLoaiPhong
            // 
            this.dgvDSLoaiPhong.AllowUserToAddRows = false;
            this.dgvDSLoaiPhong.AllowUserToDeleteRows = false;
            this.dgvDSLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDSLoaiPhong.Location = new System.Drawing.Point(753, 86);
            this.dgvDSLoaiPhong.Name = "dgvDSLoaiPhong";
            this.dgvDSLoaiPhong.ReadOnly = true;
            this.dgvDSLoaiPhong.RowHeadersWidth = 62;
            this.dgvDSLoaiPhong.RowTemplate.Height = 28;
            this.dgvDSLoaiPhong.Size = new System.Drawing.Size(581, 354);
            this.dgvDSLoaiPhong.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã loại phòng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên loại phòng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // lblTroVe
            // 
            this.lblTroVe.AutoSize = true;
            this.lblTroVe.BackColor = System.Drawing.Color.White;
            this.lblTroVe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroVe.Location = new System.Drawing.Point(12, 9);
            this.lblTroVe.Name = "lblTroVe";
            this.lblTroVe.Size = new System.Drawing.Size(84, 31);
            this.lblTroVe.TabIndex = 0;
            this.lblTroVe.Text = "Trở về";
            this.lblTroVe.Click += new System.EventHandler(this.lblTroVe_Click);
            // 
            // CaiDatLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1364, 595);
            this.Controls.Add(this.dgvDSLoaiPhong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTroVe);
            this.Name = "CaiDatLoaiPhong";
            this.Text = "CaiDatLoaiPhong";
            this.Load += new System.EventHandler(this.CaiDatLoaiPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenloaiphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Label lblTroVe;
    }
}