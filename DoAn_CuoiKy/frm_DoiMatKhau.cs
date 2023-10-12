using DoAn_CuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class frm_DoiMatKhau : Form
    {
        static QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        private string username;
        private string password;

        private string userName;
        private string currentPassword;
        private string newPassword;
        private string confirmNewPassword;

        public frm_DoiMatKhau(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            userName = txt_TenDangNhapCu.Text;
            currentPassword = txt_MatKhauCu.Text;
            newPassword = txt_MatKhauMoi.Text;
            confirmNewPassword = txt_XacNhanMatKhau.Text;

            //Xử lý chức năng nếu thông tin bỏ trống thì hiện thông báo
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!", "Thông Báo");
            }

            if (newPassword == confirmNewPassword)
            {
                try
                {
                    var chuTro = context.DANGNHAPs.FirstOrDefault(c => c.UserName == userName && c.PassWord == currentPassword);

                    if (chuTro != null)
                    {
                        chuTro.PassWord = newPassword;
                        context.SaveChanges();

                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo");
                        // sau khi đăng nhập thành công, thì ẩn tắt form Cập nhật mật khẩu
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu cũ không chính xác. Vui lòng kiểm tra lại.", "Thông Báo");
                        clearPassword();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp. Vui lòng kiểm tra lại.", "Thông Báo");
                clearPassword();
            }
        }

        public void clearPassword()
        {
            txt_TenDangNhapCu.Text = string.Empty;
            txt_MatKhauCu.Text = string.Empty;
            txt_MatKhauMoi.Text = string.Empty;
            txt_XacNhanMatKhau.Text = string.Empty;
        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_TenDangNhapCu.Text = userName;
            txt_MatKhauCu.Text = currentPassword;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn hủy đổi mật khẩu mới?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void chb_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_HienThi.Checked == true)
            {
                txt_MatKhauCu.PasswordChar = '\0';
                txt_MatKhauMoi.PasswordChar = '\0';
                txt_XacNhanMatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhauCu.PasswordChar = '*';
                txt_MatKhauMoi.PasswordChar = '*';
                txt_XacNhanMatKhau.PasswordChar = '*';
            }
        }   
    }
}
