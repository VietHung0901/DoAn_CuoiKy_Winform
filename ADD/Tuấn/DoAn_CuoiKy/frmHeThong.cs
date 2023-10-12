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
using DoAn_CuoiKy.Models;

namespace DoAn_CuoiKy
{
    public partial class frmHeThong : Form
    {
        QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
        public frmHeThong()
        {
            InitializeComponent();
        }

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
                    SLTK = int.Parse(t.SoLuong.ToString()) - SoLuongDaSai(maTB);
                }
            }
            return SLTK;
        }

        private int SoLuongDaSai(int maTB)
        {
            int SLDS = 0;
            var result = from t in context.CT_LAPDATes
                         where t.MaTB == maTB
                         select t;
            if (result.ToList().Count > 0)
            {
                foreach(var t in result)
                {
                    SLDS += int.Parse(t.SoLuong.ToString());
                }
            }
            return SLDS;
        }

        private void BindGrid(List<THIETBI> listTHIETBI)
        {
        dgvThemThietBi.Rows.Clear();
        foreach (var item in listTHIETBI)
            {
            int index = dgvThemThietBi.Rows.Add();
            dgvThemThietBi.Rows[index].Cells[0].Value = item.MaTB;
            dgvThemThietBi.Rows[index].Cells[1].Value = item.TenTB;
            dgvThemThietBi.Rows[index].Cells[2].Value = item.SoLuong;
            dgvThemThietBi.Rows[index].Cells[3].Value = SoLuongDaSai(item.MaTB).ToString();
            dgvThemThietBi.Rows[index].Cells[4].Value = SoLuongTonKho(item.MaTB).ToString();
            }
        }
        public void reset()
        {
            txtMTB.Text = "";
            txtTTB.Text = "";
            txtTTB.Text = "";
        }

        private void tabQuanLyThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                QuanLyPhongTroContextDB context = new QuanLyPhongTroContextDB();
                List<THIETBI> listTHIETBI = context.THIETBIs.ToList();
                BindGrid(listTHIETBI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThemTB(int maTB)
        {
            THIETBI thietbi = context.THIETBIs.FirstOrDefault(t => t.MaTB == maTB);
            if (thietbi == null)
            {
                THIETBI t = new THIETBI()
                { MaTB = int.Parse(txtMTB.Text), TenTB = txtTTB.Text, SoLuong = int.Parse(txtSL.Text) };


                context.THIETBIs.Add(t);
                context.SaveChanges();
                MessageBox.Show("Thêm thiết bị mới thành công", "Thông Báo", MessageBoxButtons.OK);
                reset();


            }
            else
            {
                MessageBox.Show("Trùng mã số sinh viên", "Thông báo");
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
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
                    tabQuanLyThietBi_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTB(int maTB)
        {
            THIETBI UpdateTB = context.THIETBIs.FirstOrDefault(t => t.MaTB == maTB);
            if (UpdateTB != null)
            {
                UpdateTB.MaTB = int.Parse(txtMTB.Text);
                UpdateTB.TenTB = txtTTB.Text;
                UpdateTB.SoLuong = int.Parse(txtSL.Text);
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
                    tabQuanLyThietBi_Click(sender, e);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteTB(int.Parse(txtMTB.Text));
            tabQuanLyThietBi_Click(sender, e);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            frmPhanBoThietBi frmPhanBoThietBi = new frmPhanBoThietBi();
            frmPhanBoThietBi.ShowDialog();
            tabQuanLyThietBi_Click(sender, e);
        }
    }
}
