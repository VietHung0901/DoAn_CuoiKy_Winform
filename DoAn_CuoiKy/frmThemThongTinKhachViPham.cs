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
using static System.Net.WebRequestMethods;

namespace DoAn_CuoiKy
{
    public partial class frmThemThongTinKhachViPham : Form
    {
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        public delegate void truyenThongTin(string maKH, string hoTen, string tenViPham, DateTime thoiDiem, string ghiChu);
        public truyenThongTin truyenTT;
        public frmThemThongTinKhachViPham()
        {
            InitializeComponent();
        }

        public void quanLyPhieuPhat(List<PHIEUPHAT> listPhieuPhat)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (var item in listPhieuPhat)
            {
                auto.Add(item.KHACHHANG.HoTen);
            }
            txtHoTen.AutoCompleteCustomSource = auto;
            txtHoTen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtHoTen.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public bool checkNull()
        {
            if(txtMaKH.Text == "" || txtHoTen.Text == "" || txtTenViPham.Text == "" || dtpThoiDiem.Text == "")
                return true;
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNull())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
            }
            else if (DateTime.Compare(dtpThoiDiem.Value.Date, DateTime.Now) > 0)
            {
                MessageBox.Show("Thời gian sai quy định", "Thông báo");
            }
            else
            {
                if (truyenTT != null)
                {
                    truyenTT(txtMaKH.Text, txtHoTen.Text, txtTenViPham.Text, dtpThoiDiem.Value.Date, txtGhiChu.Text);
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }

        private void frmThemThongTinKhachViPham_Load(object sender, EventArgs e)
        {
            List<PHIEUPHAT> listPhieuPhat = context.PHIEUPHATs.ToList();
            quanLyPhieuPhat(listPhieuPhat);
        }
    }
}
    