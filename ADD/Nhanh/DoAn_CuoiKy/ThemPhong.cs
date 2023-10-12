using DoAn_CuoiKy.QuanLyPhong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_CuoiKy
{
    public partial class ThemPhong : Form
    {
        private QuanLyPhongContextDB context;
        public ThemPhong()
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
                dgvDSPhong.Rows[index].Cells[4].Value = item.TrangThai;
                dgvDSPhong.Rows[index].Cells[5].Value = item.GhiChu;

                LOAIPHONG loaiPhong = lp.FirstOrDefault(lpItem => lpItem.MaLoaiPhong == item.MaLoaiPhong);
                if (loaiPhong != null)
                {
                    dgvDSPhong.Rows[index].Cells[1].Value = loaiPhong.TenLoaiPhong;
                }
            }
        }
        private void FillThemTenLoaiPhongCombobox(List<LOAIPHONG> lp)
        {
            cobThemTenLoaiPhong.DataSource = lp;
            cobThemTenLoaiPhong.DisplayMember = "TenLoaiPhong";
            cobThemTenLoaiPhong.ValueMember = "MaLoaiphong";
        }
        private void ThemPhong_Load(object sender, EventArgs e)
        {
            List<PHONG> p = context.PHONGs.ToList();
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
            BindGrid(p, lp);
            FillThemTenLoaiPhongCombobox(lp);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            List<PHONG> p = context.PHONGs.ToList();
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
            BindGrid(p, lp);
        }

        private void dgvDSPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
