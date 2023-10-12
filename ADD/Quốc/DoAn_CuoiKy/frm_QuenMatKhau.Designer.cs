
namespace DoAn_CuoiKy
{
    partial class frm_QuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuenMatKhau));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TenDangNhap_QMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_KetQua = new System.Windows.Forms.Label();
            this.btn_LayLaiMatKhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_TenDangNhap_QMK
            // 
            this.txt_TenDangNhap_QMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap_QMK.Location = new System.Drawing.Point(149, 190);
            this.txt_TenDangNhap_QMK.Multiline = true;
            this.txt_TenDangNhap_QMK.Name = "txt_TenDangNhap_QMK";
            this.txt_TenDangNhap_QMK.Size = new System.Drawing.Size(100, 30);
            this.txt_TenDangNhap_QMK.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // lbl_KetQua
            // 
            this.lbl_KetQua.AutoSize = true;
            this.lbl_KetQua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KetQua.Location = new System.Drawing.Point(43, 253);
            this.lbl_KetQua.Name = "lbl_KetQua";
            this.lbl_KetQua.Size = new System.Drawing.Size(52, 15);
            this.lbl_KetQua.TabIndex = 3;
            this.lbl_KetQua.Text = "Kết quả:";
            // 
            // btn_LayLaiMatKhau
            // 
            this.btn_LayLaiMatKhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_LayLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LayLaiMatKhau.Location = new System.Drawing.Point(99, 309);
            this.btn_LayLaiMatKhau.Name = "btn_LayLaiMatKhau";
            this.btn_LayLaiMatKhau.Size = new System.Drawing.Size(121, 37);
            this.btn_LayLaiMatKhau.TabIndex = 4;
            this.btn_LayLaiMatKhau.Text = "Lấy lại mật khẩu";
            this.btn_LayLaiMatKhau.UseVisualStyleBackColor = false;
            this.btn_LayLaiMatKhau.Click += new System.EventHandler(this.btn_LayLaiMatKhau_Click);
            // 
            // frm_QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 377);
            this.Controls.Add(this.btn_LayLaiMatKhau);
            this.Controls.Add(this.lbl_KetQua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenDangNhap_QMK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_QuenMatKhau";
            this.Text = "Quên Mật Khảu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TenDangNhap_QMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_KetQua;
        private System.Windows.Forms.Button btn_LayLaiMatKhau;
    }
}