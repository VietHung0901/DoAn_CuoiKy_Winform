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

        private void BindGrid(List<CT_LAPDAT> listLAPDAT)
        {
            dgvPhanBo.Rows.Clear();
            foreach (var item in listLAPDAT)
            {
                int index = dgvPhanBo.Rows.Add();
                dgvPhanBo.Rows[index].Cells[0].Value = item.MaPhong;
                dgvPhanBo.Rows[index].Cells[1].Value = item.MaTB;
                dgvPhanBo.Rows[index].Cells[2].Value = item.NgayLap;
                dgvPhanBo.Rows[index].Cells[3].Value = item.SoLuong;
            }
        }

        public void reset()
        {
            txtMP.Text = "";
            txtMTB.Text = "";
            dtpNL.Text = "";
            txtSL.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maTB, maPhong;
            if (int.TryParse(txtMTB.Text, out maTB) && int.TryParse(txtMP.Text, out maPhong))
            {
                DeleteLDTP(maPhong, maTB);
                frmPhanBoThietBi_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho Mã thiết bị và Mã phòng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        public QuanLyPhongTroContextDB GetContext()
        {
            return context;
        }

        public void UpdateLDTB(int maPhong)
        {
            int maTB = int.Parse(txtMTB.Text);
            CT_LAPDAT UpdateTB = context.CT_LAPDATes.FirstOrDefault(p => p.MaPhong == maPhong && p.MaTB == maTB);
            if (UpdateTB != null)
            {
                UpdateTB.MaPhong = maPhong;
                UpdateTB.MaTB = maTB;
                UpdateTB.NgayLap = DateTime.Parse(dtpNL.Text);
                UpdateTB.SoLuong = int.Parse(txtSL.Text); // Cập nhật giá trị mới cho Số lượng
                context.SaveChanges();
                MessageBox.Show("Cập nhật thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                reset();
            }
            else
            {
                MessageBox.Show("Thiết bị không tồn tại", "THÔNG BÁO");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtMP.Text == "" || txtMTB.Text == "" || dtpNL.Text == "" || txtSL.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                else if (txtMTB.TextLength == 0)
                    MessageBox.Show("Vui lòng nhập mã cho thiết bị");
                else if (int.Parse(txtSL.Text) <= 0)
                    MessageBox.Show("Vui lòng nhập số lượng thiết bị");
                else if (txtMP.TextLength == 0)
                    MessageBox.Show("Vui lòng nhập mã phòng");
                else
                {
                    int maPhong;
                    if (int.TryParse(txtMP.Text, out maPhong))
                    {
                        UpdateLDTB(maPhong);
                        frmPhanBoThietBi_Load(sender, e);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMP.Text == "" || txtMTB.Text == "" || dtpNL.Text == "" || txtSL.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                else if (txtMTB.TextLength == 0)
                    MessageBox.Show("Vui lòng nhập mã cho thiết bị");
                else if (int.Parse(txtSL.Text) <= 0)
                    MessageBox.Show("Thiết bị đã hết");
                else if (txtMP.TextLength == 0)
                    MessageBox.Show("Vui lòng nhập mã phòng");
                else
                {
                    ThemTB(int.Parse(txtMP.Text));
                    frmPhanBoThietBi_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhanBoThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
                List<CT_LAPDAT> listLAPDAT = context.CT_LAPDATes.ToList();
                BindGrid(listLAPDAT);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemTB(int maPhong)
        {

            CT_LAPDAT p = new CT_LAPDAT()
            {
                MaPhong = int.Parse(txtMP.Text),
                MaTB = int.Parse(txtMTB.Text),
                NgayLap = DateTime.Parse(dtpNL.Text),
                SoLuong = int.Parse(txtSL.Text)
            };


            context.CT_LAPDATes.Add(p);
            context.SaveChanges();
            MessageBox.Show("Thêm thiết bị mới thành công", "Thông Báo", MessageBoxButtons.OK);
            reset();
        }





        

        private void DeleteLDTP(int maPhong, int maTB)
        {
            CT_LAPDAT DeleteLAPDAT = context.CT_LAPDATes.FirstOrDefault(p => p.MaPhong == maPhong && p.MaTB == maTB);
            if (DeleteLAPDAT != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    context.CT_LAPDATes.Remove(DeleteLAPDAT);
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
    }
}
