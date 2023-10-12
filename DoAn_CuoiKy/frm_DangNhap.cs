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
    public partial class frm_DangNhap : Form
    {
        static QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        private string username;
        private string password;


        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_ĐangNhap_Click(object sender, EventArgs e)
        {
            username = txt_TenDangNhap.Text;
            password = txt_MatKhau.Text;
            // Thực hiện kiểm tra thông tin đăng nhập tại đây
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (KiemTraDangNhap(username, password))
            {
                // Đăng nhập thành công, hiển thị Form2 và ẩn Form1
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông Báo");
                ClearPass();
            }
        }

        // Khi nhập pass sai tự động reset về null
        public void ClearPass()
        {
            txt_MatKhau.Text = string.Empty;
        }

        private bool KiemTraDangNhap(string username, string password)
        {
            var chutro = context.DANGNHAPs.FirstOrDefault(c => c.UserName == username && c.PassWord == password);
            return chutro != null;
        }

        // hiển thị mật khẩu bằng Combobox
        private void chb_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_HienThi.Checked == true)
            {
                txt_MatKhau.PasswordChar = '\0';
            }
            else
            {
                txt_MatKhau.PasswordChar = '*';
            }
        }

        // Nút hủy đăng nhập
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }


        private void lbl_QuenMatKhau_Click(object sender, EventArgs e)
        {
            frm_QuenMatKhau quenMatKhau = new frm_QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
    }
    
}
