using DoAn_CuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_CuoiKy
{
    public partial class frm_QuenMatKhau : Form
    {
        static QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        private string username;

        public frm_QuenMatKhau()
        {
            InitializeComponent();
            lbl_KetQua.Text = "";
        }
        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            username = txt_TenDangNhap_QMK.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông Báo");
            }
            else
            {
                var chutro = context.DANGNHAPs.FirstOrDefault(c => c.UserName == username);
                if (chutro != null)
                {
                    lbl_KetQua.ForeColor = Color.Blue;
                    lbl_KetQua.Text = "Kết Quả: " + chutro.PassWord;
                }
                else
                {
                    lbl_KetQua.ForeColor = Color.Red;
                    lbl_KetQua.Text = "Tài khoàn này không tồn tại!!!";
                }
            }
        }
    }
}
