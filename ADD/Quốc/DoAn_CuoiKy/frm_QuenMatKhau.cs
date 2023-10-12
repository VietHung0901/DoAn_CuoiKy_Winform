using DoAn_CuoiKy.Đăng_Nhập;
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
    public partial class frm_QuenMatKhau : Form
    {
        static HeThongDangNhapDB context = new HeThongDangNhapDB();
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
                var chutro = context.ChuTroes.FirstOrDefault(c => c.TenDangNhap == username);
                if (chutro != null)
                {
                    lbl_KetQua.ForeColor = Color.Blue;
                    lbl_KetQua.Text = "Kết Quả: " + chutro.MatKhau;
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
