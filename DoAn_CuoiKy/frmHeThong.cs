using DoAn_CuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class frmHeThong : Form
    {
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        public frmHeThong()
        {
            InitializeComponent();
        }

        

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            //Đăng nhập
            frm_DangNhap dangNhap = new frm_DangNhap();
            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }

            List<THIETBI> listTHIETBI = context.THIETBIs.ToList();
            BindGridQuanLyThietBi(listTHIETBI);
        }


        //********************ĐĂNG NHẬP - HỆ THÔNG*********************
        private void tsb_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //button Đăng xuất tài khoản
        private void tsb_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("Bạn có muốn đăng xuất ứng dụng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (cc == DialogResult.Yes)
            {
                this.Hide();
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
        }

        //Button Đổi mật khẩu
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
        //Xem thông tin của chủ trọ
        private void tsb_ThongTin_Click_1(object sender, EventArgs e)
        {
            string thongTinHienTai = $"Tên chủ trọ: {TenChuTro}\nĐịa chỉ: {DiaChiChuTro}\nSố điện thoại: {SDTChuTro}\n {ChamNgon}";
            MessageBox.Show(thongTinHienTai, "Thông tin phòng trọ");
        }

        //********************QUẢN LÝ PHÒNG********************

        

        //********************QUẢN LÝ THIẾT BỊ********************
        //reset lại các textbox
        public void resetQuanLyThietBi()
        {
            txtMTB.Text = "";
            txtTTB.Text = "";
            txtSL.Text = "";
        }
        //Trả về số lượng tồn trong kho
        private int SoLuongTonKho(int maTB)
        {
            int SLTK = 0;
            var result = from t in context.THIETBIs
                         where t.MaTB == maTB
                         select t;
            if (result.ToList().Count > 0)
            {
                foreach (var t in result)
                {
                    SLTK = int.Parse(t.SoLuongThietBi.ToString()) - SoLuongDaSai(maTB);
                }
            }
            return SLTK;
        }
        
        //Trả về số lượng thiết bị đã sử dụng
        private int SoLuongDaSai(int maTB)
        {
            int SLDS = 0;
            var result = from t in context.CT_LAPDAT
                         where t.MaTB == maTB
                         select t;
            if (result.ToList().Count > 0)
            {
                foreach (var t in result)
                {
                    SLDS += int.Parse(t.SoLuongLapDat.ToString());
                }
            }
            return SLDS;
        }
        //Load dữ liệu lên datagridview
        private void BindGridQuanLyThietBi(List<THIETBI> listTHIETBI)
        {
            dgvThemThietBi.Rows.Clear();
            foreach (var item in listTHIETBI)
            {
                int index = dgvThemThietBi.Rows.Add();
                dgvThemThietBi.Rows[index].Cells[0].Value = item.MaTB;
                dgvThemThietBi.Rows[index].Cells[1].Value = item.TenTB;
                dgvThemThietBi.Rows[index].Cells[2].Value = item.SoLuongThietBi;
                dgvThemThietBi.Rows[index].Cells[3].Value = SoLuongDaSai(item.MaTB).ToString();
                dgvThemThietBi.Rows[index].Cells[4].Value = SoLuongTonKho(item.MaTB).ToString();
            }
        }
        
        //Thêm thông tin thiết bị
        private void ThemTB(int maTB)
        {
            THIETBI thietbi = context.THIETBIs.FirstOrDefault(t => t.MaTB == maTB);
            if (thietbi == null)
            {
                THIETBI t = new THIETBI()
                { MaTB = int.Parse(txtMTB.Text), TenTB = txtTTB.Text, SoLuongThietBi = int.Parse(txtSL.Text) };


                context.THIETBIs.Add(t);
                context.SaveChanges();
                MessageBox.Show("Thêm thiết bị mới thành công", "Thông Báo", MessageBoxButtons.OK);
                resetQuanLyThietBi();
            }
            else
            {
                MessageBox.Show("Trùng mã số sinh viên", "Thông báo");
            }
        }
        //Button thêm thông tin thiết bị
        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMTB.Text == "" || txtTTB.Text == "" || txtSL.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                else if (txtMTB.TextLength == 0)
                    MessageBox.Show("Vui lòng nhập mã cho thiết bị");
                else if (int.Parse(txtSL.Text) <= 0)
                    MessageBox.Show("Thiết bị đã hết");
                else
                {
                    ThemTB(int.Parse(txtMTB.Text)); 
                    List<THIETBI> listTHIETBI = context.THIETBIs.ToList();
                    BindGridQuanLyThietBi(listTHIETBI);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm sửa thông tin thiết bị
        public void UpdateTB(int maTB)
        {
            THIETBI UpdateTB = context.THIETBIs.FirstOrDefault(t => t.MaTB == maTB);
            if (UpdateTB != null)
            {
                UpdateTB.MaTB = int.Parse(txtMTB.Text);
                UpdateTB.TenTB = txtTTB.Text;
                UpdateTB.SoLuongThietBi = int.Parse(txtSL.Text);
                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                resetQuanLyThietBi();
            }
            else
            {
                MessageBox.Show("Thiết bị không tồn tại", "THÔNG BÁO");
            }
        }

        //Button Sửa thông tin thiết bị 
        private void btnSuaThongTinThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMTB.Text == "" || txtTTB.Text == "" || txtSL.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                else if (txtMTB.TextLength == 0)
                    MessageBox.Show("Vui lòng nhập mã cho thiết bị");
                else if (int.Parse(txtSL.Text) <= 0)
                    MessageBox.Show("Thiết bị đã hết");
                else
                {
                    UpdateTB(int.Parse(txtMTB.Text));
                    List<THIETBI> listTHIETBI = context.THIETBIs.ToList();
                    BindGridQuanLyThietBi(listTHIETBI);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTB(int maTB)
        {
            THIETBI DeleteTB = context.THIETBIs.FirstOrDefault(t => t.MaTB == maTB);
            if (DeleteTB != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    context.THIETBIs.Remove(DeleteTB);
                    context.SaveChanges();
                    MessageBox.Show("Xóa  thiết bị thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else return;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thiết bị cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaThongTinThietBi_Click(object sender, EventArgs e)
        {   
            DeleteTB(int.Parse(txtMTB.Text));
            List<THIETBI> listTHIETBI = context.THIETBIs.ToList();
            BindGridQuanLyThietBi(listTHIETBI);
        }
        private void dgvThemThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMTB.Text = dgvThemThietBi.Rows[index].Cells[0].Value.ToString();
            txtTTB.Text = dgvThemThietBi.Rows[index].Cells[1].Value.ToString();
            txtSL.Text = dgvThemThietBi.Rows[index].Cells[2].Value.ToString();
        }

        private void tsbPhanBoThietBi_Click(object sender, EventArgs e)
        {
            frmPhanBoThietBi frmPhanBoThietBi = new frmPhanBoThietBi();
            frmPhanBoThietBi.ShowDialog();
            List<THIETBI> listTHIETBI = context.THIETBIs.ToList();
            BindGridQuanLyThietBi(listTHIETBI);
        }

        //********************QUẢN LÝ VI PHẠM********************
        //Load dữ liệu lên datagridview
        public void BindGridQuanLyViPham(List<PHIEUPHAT> listPhieuPhat)
        {
            try
            {
                dgvDanhSachKhachViPham.Rows.Clear();
                foreach (var item in listPhieuPhat)
                {

                    int index = dgvDanhSachKhachViPham.Rows.Add();
                    dgvDanhSachKhachViPham.Rows[index].Cells[0].Value = item.MaPP;

                    dgvDanhSachKhachViPham.Rows[index].Cells[1].Value = item.MaKH;

                    var hoten = context.KHACHHANGs.SingleOrDefault(p => p.MaKH == item.MaKH);
                    dgvDanhSachKhachViPham.Rows[index].Cells[2].Value = hoten.HoTen;

                    var tenphong = context.PHIEUDANGKies.SingleOrDefault(p => p.MaKH == item.MaKH);
                    dgvDanhSachKhachViPham.Rows[index].Cells[3].Value = tenphong.MaPhong.ToString();

                    dgvDanhSachKhachViPham.Rows[index].Cells[4].Value = item.TenViPham;
                    dgvDanhSachKhachViPham.Rows[index].Cells[5].Value = item.NgayViPham;
                    dgvDanhSachKhachViPham.Rows[index].Cells[6].Value = item.GhiChu;
                    dgvDanhSachKhachViPham.Rows[index].Cells[7].Value = (item.TinhTrang == 1) ? true : false;
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
        }

        //nhấn vào button danh sách vi phạm ẩn hiện dgv
        private void tsbDanhSachKhachViPham_Click(object sender, EventArgs e)
        {
            if(gbxDSViPham.Visible == false)
            {
                //Quản lý vi phạm
                var listPhieuPhat = context.PHIEUPHATs.ToList();
                BindGridQuanLyViPham(listPhieuPhat);
                gbxDSViPham.Visible = true;
            }
            else
                gbxDSViPham.Visible = false;

        }

        // Dùng để kiểm tra xem thông tin khách hàng nhập vào có tồn tại trong csdl hay chưa ?
        public KHACHHANG checkTT(string maKH)
        {
            return context.KHACHHANGs.FirstOrDefault(p => p.MaKH == maKH);
        }

        //Luu thông tin vào database
        public void loadThongTin(string maKH, string hoTen, string tenViPham, DateTime thoiDiem, string ghiChu)
        {
            try
            {
                KHACHHANG khachhang = checkTT(maKH);
                if (khachhang == null || khachhang.HoTen != hoTen)
                    MessageBox.Show("Khách hàng không tồn tại!", "Thông báo");
                else
                {
                    //Lưu thông tin vào database
                    PHIEUPHAT pp = new PHIEUPHAT()
                    {
                        MaKH = maKH,
                        TenViPham = tenViPham,
                        NgayViPham = thoiDiem,
                        GhiChu = ghiChu
                    };
                    context.PHIEUPHATs.Add(pp);
                    context.SaveChanges();

                    var listPhieuPhat = context.PHIEUPHATs.ToList();
                    BindGridQuanLyViPham(listPhieuPhat);
                    MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Mở form thêm phiếu phạt
        private void btnThemQuanLyViPham_Click(object sender, EventArgs e)
        {
            frmThemThongTinKhachViPham frm = new frmThemThongTinKhachViPham();
            frm.truyenTT = new frmThemThongTinKhachViPham.truyenThongTin(loadThongTin);
            frm.ShowDialog();
        }

        //Tìm mã phiếu phạt
        public PHIEUPHAT findPP(int maPP)
        {
            return context.PHIEUPHATs.FirstOrDefault(p => p.MaPP == maPP);
        }

        //Xóa phiếu phạt
        private void btnXoaQuanLyViPham_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDanhSachKhachViPham.CurrentCell.RowIndex; // Lấy dòng hiện tại đang click
            int mapp = int.Parse(dgvDanhSachKhachViPham.Rows[selectedRow].Cells[0].Value.ToString());
            PHIEUPHAT pHIEUPHAT = findPP(mapp);
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                context.PHIEUPHATs.Remove(pHIEUPHAT);
                context.SaveChanges();
                var listPhieuPhat = context.PHIEUPHATs.ToList();
                BindGridQuanLyViPham(listPhieuPhat);
                MessageBox.Show("Xóa phiếu thành công", "Thông báo");
            }
            else return;
        }

        //Luu file về dạng txt
        public void luuFile()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT File (*.txt)| *.txt";
            save.Title = "Thong tin";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(save.FileName))
                {
                    int selectedRow = dgvDanhSachKhachViPham.CurrentCell.RowIndex;
                    int mapp = int.Parse(dgvDanhSachKhachViPham.Rows[selectedRow].Cells[0].Value.ToString());
                    PHIEUPHAT pHIEUPHAT = findPP(mapp);
                    writer.WriteLine("Mã HD: " + pHIEUPHAT.MaPP);
                    writer.WriteLine("Mã khách hàng: " + pHIEUPHAT.MaKH);

                    var hoten = context.KHACHHANGs.SingleOrDefault(p => p.MaKH == pHIEUPHAT.MaKH);
                    writer.Write("Tên khách hàng: " + hoten.HoTen + "   ");

                    var tenphong = context.PHIEUDANGKies.SingleOrDefault(p => p.MaKH == pHIEUPHAT.MaKH);
                    writer.WriteLine("Phòng: " + tenphong.MaPhong);

                    writer.WriteLine("Lỗi vi phạm: " + pHIEUPHAT.TenViPham);
                    writer.WriteLine("Thời gian vi phạm: " + pHIEUPHAT.NgayViPham);

                    writer.WriteLine("Ghi chú: " + pHIEUPHAT.GhiChu);

                    MessageBox.Show("Lưu văn bản thành công", "Thông báo");
                }
            }
        }

        //button in phiếu
        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            luuFile();
        }

        //Lưu phiếu đã xử lý vi phạm
        private void btnLuuXuLyViPham_Click(object sender, EventArgs e)
        {
            int selectedRow = dgvDanhSachKhachViPham.CurrentCell.RowIndex;
            int mapp = int.Parse(dgvDanhSachKhachViPham.Rows[selectedRow].Cells[0].Value.ToString());
            PHIEUPHAT pHIEUPHAT = findPP(mapp);
            pHIEUPHAT.TinhTrang = 1;
            context.SaveChanges();
            var listPhieuPhat = context.PHIEUPHATs.ToList();
            BindGridQuanLyViPham(listPhieuPhat);
        }

        private void tsbThongTinPhong_Click(object sender, EventArgs e)
        {
            frm_CaiDatLoaiPhong lp = new frm_CaiDatLoaiPhong();
            lp.Show();
        }
    }
}
