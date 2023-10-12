using DoAn_CuoiKy.QuanLyPhong;
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
    public partial class TimKiem : Form
    {
        private QuanLyPhongContextDB context;
        public TimKiem()
        {
            InitializeComponent();
            context = new QuanLyPhongContextDB(); 
            List<PHONG> p = context.PHONGs.ToList();
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();

        }
        private void BindGrid(List<PHONG> p, List<LOAIPHONG> lp)
        {
            try
            {
                dgvDSPhongTim.Rows.Clear();
                foreach (var item in p)
                {
                    int index = dgvDSPhongTim.Rows.Add();
                    dgvDSPhongTim.Rows[index].Cells[0].Value = item.MaPhong;
                    dgvDSPhongTim.Rows[index].Cells[2].Value = item.Tang;
                    dgvDSPhongTim.Rows[index].Cells[3].Value = item.TinhTrang;

                    LOAIPHONG loaiPhong = lp.FirstOrDefault(lpItem => lpItem.MaLoaiPhong == item.MaLoaiPhong);
                    if (loaiPhong != null)
                    {
                        dgvDSPhongTim.Rows[index].Cells[1].Value = loaiPhong.TenLoaiPhong;
                        dgvDSPhongTim.Rows[index].Cells[4].Value = loaiPhong.DonGia;
                    }
                }
            }
            catch
            {

            }
        }
        private void FillLoaiPhongCombobox(List<LOAIPHONG> lp)
        {
            cobTimTheoLoaiPhong.DataSource = lp;
            cobTimTheoLoaiPhong.DisplayMember = "TenLoaiPhong";
            cobTimTheoLoaiPhong.ValueMember = "MaLoaiphong";
        }
        private void TimKiem_Load(object sender, EventArgs e)
        {
            List<PHONG> p = context.PHONGs.ToList();
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
            FillLoaiPhongCombobox(lp);
            rdbTimPhongTrong.Checked = false;
            rdbTimDaThue.Checked = false;
            cobTimTheoLoaiPhong.Text = "";

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<PHONG> p = context.PHONGs.ToList();
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
            dgvDSPhongTim.Rows.Clear();

            
                if (rdbTimDaThue.Checked)
                {
                    var DSphongDaThue = context.PHONGs.Where(item => item.TinhTrang == 1).ToList();
                    BindGrid(DSphongDaThue, lp);
                }
                if (rdbTimPhongTrong.Checked)
                {
                    var DSphongChuaThue = context.PHONGs.Where(item => item.TinhTrang == 0).ToList();
                    BindGrid(DSphongChuaThue, lp);
                }
                if (rdbTatCaPhong.Checked)
                {
                    BindGrid(p,lp);
                }

        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
