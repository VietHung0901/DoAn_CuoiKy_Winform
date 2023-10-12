
using DoAn_CuoiKy.QuanLyPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class frmHeThong : Form
    {
        private QuanLyPhongContextDB context;
        public frmHeThong()
        {

            InitializeComponent();
            context = new QuanLyPhongContextDB();
        }
        private void BindGrid(List<PHONG> p, List<LOAIPHONG> lp)
        {
            dgvDSPhong.Rows.Clear();
            foreach (var item in p)
            {
                int index = dgvDSPhong.Rows.Add();
                dgvDSPhong.Rows[index].Cells[0].Value = item.MaPhong;
                dgvDSPhong.Rows[index].Cells[2].Value = item.Tang;
                dgvDSPhong.Rows[index].Cells[3].Value = item.TinhTrang;

                LOAIPHONG loaiPhong = lp.FirstOrDefault(lpItem => lpItem.MaLoaiPhong == item.MaLoaiPhong);
                if (loaiPhong != null)
                {
                    dgvDSPhong.Rows[index].Cells[1].Value = loaiPhong.TenLoaiPhong;
                    dgvDSPhong.Rows[index].Cells[4].Value = loaiPhong.DonGia;
                }
            }
        }

        private bool KiemTrahHien = false;
        private void tsbDanhSachphong_Click(object sender, EventArgs e)
        {

            KiemTrahHien = !KiemTrahHien;
            dgvDSPhong.Visible = KiemTrahHien;
            btnXoa.Visible = KiemTrahHien;
            btnLuu.Visible = KiemTrahHien;
            List<PHONG> p = context.PHONGs.ToList();
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
            BindGrid(p, lp);
        }



        private void tsbTimPhong_Click(object sender, EventArgs e)
        {
            TimKiem tk = new TimKiem();
            tk.ShowDialog();
            
        }

        private void tstThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhong tp = new ThemPhong();
            tp.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSPhong.SelectedRows.Count > 0)
            {
                int rowIndex = dgvDSPhong.SelectedRows[0].Index;
                int maPhong = int.Parse(dgvDSPhong.Rows[rowIndex].Cells[0].Value.ToString());
                dgvDSPhong.Rows.RemoveAt(rowIndex);
                PHONG ph = context.PHONGs.FirstOrDefault(s => s.MaPhong == maPhong);
                if (ph != null)
                {
                    context.PHONGs.Remove(ph);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
        }
        private void tsbThongTinPhong_Click(object sender, EventArgs e)
        {
            CaiDatLoaiPhong lp = new CaiDatLoaiPhong();
            lp.Show();
     
        }
    }
}
