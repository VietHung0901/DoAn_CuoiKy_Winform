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
    public partial class frmHeThong : Form
    {
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            frm_DangNhap dangNhap = new frm_DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void tsb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(cc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsb_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn đăng xuất ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cc == DialogResult.Yes)
            {
                this.Hide();
                frm_DangNhap dangNhap = new frm_DangNhap();
                dangNhap.ShowDialog();
            }
        }

        private void tsb_DoiMatKhau_Click(object sender, EventArgs e)
        {
            string newPassword = ""; // Thay thế bằng tên đăng nhập hiện tại
            string confirmNewPassword = ""; // Thay thế bằng mật khẩu hiện tại
            frm_DoiMatKhau doiMatKhau = new frm_DoiMatKhau(newPassword, confirmNewPassword);
            //this.Hide();
            doiMatKhau.ShowDialog();
        }

        private string TenChuTro = "Nhà Trọ Nhóm 3";
        private string DiaChiChuTro = "Khu Công nghệ cao TP.HCM, Xa lộ Hà Nội, P.Hiệp Phú, TP.Thủ Đức, TP.HCM";
        private string SDTChuTro = "(+84) 123456789";
        private string ChamNgon = "----------- An toàn - Tiện dụng - Vừa ý -----------";
        private void tsb_ThongTin_Click_1(object sender, EventArgs e)
        {
            string thongTinHienTai = $"Tên chủ trọ: {TenChuTro}\nĐịa chỉ: {DiaChiChuTro}\nSố điện thoại: {SDTChuTro}\n {ChamNgon}";
            MessageBox.Show(thongTinHienTai, "Thông tin phòng trọ");
        }
    }
}
