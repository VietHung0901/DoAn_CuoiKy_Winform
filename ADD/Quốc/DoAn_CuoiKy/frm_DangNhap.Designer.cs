
namespace DoAn_CuoiKy
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.chb_HienThi = new System.Windows.Forms.CheckBox();
            this.btn_ĐangNhap = new System.Windows.Forms.Button();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.lbl_QuenMatKhau = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chb_HienThi
            // 
            this.chb_HienThi.AutoSize = true;
            this.chb_HienThi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_HienThi.Location = new System.Drawing.Point(389, 140);
            this.chb_HienThi.Name = "chb_HienThi";
            this.chb_HienThi.Size = new System.Drawing.Size(69, 17);
            this.chb_HienThi.TabIndex = 20;
            this.chb_HienThi.Text = "Hiển Thị ";
            this.chb_HienThi.UseVisualStyleBackColor = true;
            this.chb_HienThi.CheckedChanged += new System.EventHandler(this.chb_HienThi_CheckedChanged);
            // 
            // btn_ĐangNhap
            // 
            this.btn_ĐangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ĐangNhap.Location = new System.Drawing.Point(358, 167);
            this.btn_ĐangNhap.Name = "btn_ĐangNhap";
            this.btn_ĐangNhap.Size = new System.Drawing.Size(100, 39);
            this.btn_ĐangNhap.TabIndex = 19;
            this.btn_ĐangNhap.Text = "Đăng Nhập";
            this.btn_ĐangNhap.UseVisualStyleBackColor = true;
            this.btn_ĐangNhap.Click += new System.EventHandler(this.btn_ĐangNhap_Click);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(340, 88);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(118, 29);
            this.txt_MatKhau.TabIndex = 18;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Location = new System.Drawing.Point(340, 47);
            this.txt_TenDangNhap.Multiline = true;
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(118, 29);
            this.txt_TenDangNhap.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tên Đăng Nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đăng Nhập";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(223, 168);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(100, 39);
            this.btn_Huy.TabIndex = 22;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // lbl_QuenMatKhau
            // 
            this.lbl_QuenMatKhau.AutoSize = true;
            this.lbl_QuenMatKhau.Location = new System.Drawing.Point(287, 140);
            this.lbl_QuenMatKhau.Name = "lbl_QuenMatKhau";
            this.lbl_QuenMatKhau.Size = new System.Drawing.Size(86, 13);
            this.lbl_QuenMatKhau.TabIndex = 23;
            this.lbl_QuenMatKhau.Text = "Quên mật khẩu?";
            this.lbl_QuenMatKhau.Click += new System.EventHandler(this.lbl_QuenMatKhau_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(497, 218);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_QuenMatKhau);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.chb_HienThi);
            this.Controls.Add(this.btn_ĐangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb_HienThi;
        private System.Windows.Forms.Button btn_ĐangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Label lbl_QuenMatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}