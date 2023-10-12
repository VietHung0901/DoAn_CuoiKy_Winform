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
    public partial class frmPhanBoThietBi : Form
    {
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        public frmPhanBoThietBi()
        {
            InitializeComponent();
        }

        private void frmPhanBoThietBi_Load(object sender, EventArgs e)
        {
            List<CT_LAPDAT> listLAPDAT = context.CT_LAPDAT.ToList();
            BindGridPhanBoThietBi(listLAPDAT);
        }
        private void BindGridPhanBoThietBi(List<CT_LAPDAT> listLAPDAT)
        {
            dgvPhanBo.Rows.Clear();
            foreach (var item in listLAPDAT)
            {
                int index = dgvPhanBo.Rows.Add();
                dgvPhanBo.Rows[index].Cells[0].Value = item.MaPhong;
                dgvPhanBo.Rows[index].Cells[1].Value = item.MaTB;
                dgvPhanBo.Rows[index].Cells[2].Value = item.NgayLap;
                dgvPhanBo.Rows[index].Cells[3].Value = item.SoLuongLapDat;
            }
        }

        public void resetPhanBoThietBi()
        {
            txtMP.Text = "";
            txtMTB.Text = "";
            dtpNL.Text = "";
            txtSL.Text = "";
        }

        private void ThemTB()
        {

            CT_LAPDAT p = new CT_LAPDAT()
            {
                MaPhong = int.Parse(txtMP.Text),
                MaTB = int.Parse(txtMTB.Text),
                NgayLap = DateTime.Parse(dtpNL.Text),
                SoLuongLapDat = int.Parse(txtSL.Text)
            };
            context.CT_LAPDAT.Add(p);
            context.SaveChanges();
            resetPhanBoThietBi();
        }
        private void btnThemPhanBoThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMP.Text == "" || txtMTB.Text == "" || dtpNL.Text == "" || txtSL.Text == "")
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                else if (DateTime.Compare(dtpNL.Value.Date, DateTime.Now) > 0)
                {
                    MessageBox.Show("Thời gian sai quy định", "Thông báo");
                }
                else
                {
                    ThemTB();
                    MessageBox.Show("Thêm thiết bị mới thành công", "Thông Báo", MessageBoxButtons.OK);
                    List<CT_LAPDAT> listLAPDAT = context.CT_LAPDAT.ToList();
                    BindGridPhanBoThietBi(listLAPDAT);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateLDTB(int maPhong)
        {
            int maTB = int.Parse(txtMTB.Text);
            CT_LAPDAT UpdateTB = context.CT_LAPDAT.FirstOrDefault(p => p.MaPhong == maPhong && p.MaTB == maTB);
            if (UpdateTB != null)
            {
                //UpdateTB.MaPhong = maPhong;
                //UpdateTB.MaTB = maTB;
                //UpdateTB.NgayLap = DateTime.Parse(dtpNL.Text);
                //UpdateTB.SoLuongLapDat = int.Parse(txtSL.Text); // Cập nhật giá trị mới cho Số lượng
                context.CT_LAPDAT.Remove(UpdateTB);
                ThemTB();
                context.SaveChanges();
                List<CT_LAPDAT> listLAPDAT = context.CT_LAPDAT.ToList();
                BindGridPhanBoThietBi(listLAPDAT);
                MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                resetPhanBoThietBi();
            }
            else
            {
                MessageBox.Show("Thiết bị không tồn tại", "THÔNG BÁO");
            }
        }

        private void btnSuaPhanBoThietBi_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (txtMP.Text == "" || txtMTB.Text == "" || dtpNL.Text == "" || txtSL.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
            else
            {
                int maPhong;
                if (int.TryParse(txtMP.Text, out maPhong))
                {
                    UpdateLDTB(maPhong);
                    List<CT_LAPDAT> listLAPDAT = context.CT_LAPDAT.ToList();
                    BindGridPhanBoThietBi(listLAPDAT);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã phòng", "Thông báo", MessageBoxButtons.OK);
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void DeleteLDTP(int maPhong, int maTB)
        {
            CT_LAPDAT DeleteLAPDAT = context.CT_LAPDAT.FirstOrDefault(p => p.MaPhong == maPhong && p.MaTB == maTB);
            if (DeleteLAPDAT != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    context.CT_LAPDAT.Remove(DeleteLAPDAT);
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
        private void btnXoaPhanBoThietBi_Click(object sender, EventArgs e)
        {
            int maTB, maPhong;
            if (int.TryParse(txtMTB.Text, out maTB) && int.TryParse(txtMP.Text, out maPhong))
            {
                DeleteLDTP(maPhong, maTB);
                List<CT_LAPDAT> listLAPDAT = context.CT_LAPDAT.ToList();
                BindGridPhanBoThietBi(listLAPDAT);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã thiết bị và Mã phòng", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhanBo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtMP.Text = dgvPhanBo.Rows[index].Cells[0].Value.ToString();
            txtMTB.Text = dgvPhanBo.Rows[index].Cells[1].Value.ToString(); 
            dtpNL.Text =  dgvPhanBo.Rows[index].Cells[2].Value.ToString();
            txtSL.Text =  dgvPhanBo.Rows[index].Cells[3].Value.ToString();
        }

        private void timKiemTheoTen()
        {
            int maphong = int.Parse(txtMaPhong.Text);
            var result = from c in context.CT_LAPDAT
                         where c.MaPhong == maphong
                         select c;
            if (result.ToList().Count != 0)
            {
                foreach (var item in result)
                {
                    int index = dgvPhanBo.Rows.Add();
                    dgvPhanBo.Rows[index].Cells[0].Value = item.PHONG.MaPhong;
                    dgvPhanBo.Rows[index].Cells[1].Value = item.THIETBI.MaTB;
                    dgvPhanBo.Rows[index].Cells[2].Value = item.NgayLap;
                    dgvPhanBo.Rows[index].Cells[3].Value = item.SoLuongLapDat;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Thông báo");
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvPhanBo.Rows.Clear();
            timKiemTheoTen();
        }

        private void txtTimMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                var listSach = context.CT_LAPDAT.ToList();
                BindGridPhanBoThietBi(listSach);
            }
        }
    }
}
