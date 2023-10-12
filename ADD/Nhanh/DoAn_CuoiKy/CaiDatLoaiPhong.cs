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
    public partial class CaiDatLoaiPhong : Form
    {
        private QuanLyPhongContextDB context;
        public CaiDatLoaiPhong()
        {
            InitializeComponent();
            context = new QuanLyPhongContextDB();
        }
        private void BindGrid(List<LOAIPHONG> lp)
        {
            try
            {
                dgvDSLoaiPhong.Rows.Clear();
                foreach (var item in lp)
                {
                    int index = dgvDSLoaiPhong.Rows.Add();
                    dgvDSLoaiPhong.Rows[index].Cells[0].Value = item.MaLoaiPhong;
                    dgvDSLoaiPhong.Rows[index].Cells[1].Value = item.TenLoaiPhong;
                    dgvDSLoaiPhong.Rows[index].Cells[2].Value = item.DonGia;

                }
            }
            catch
            {

            }
        }

        private void CaiDatLoaiPhong_Load(object sender, EventArgs e)
        {
            List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
            BindGrid(lp);
        }

        private void lblTroVe_Click(object sender, EventArgs e)
        {
            frmHeThong ht = new frmHeThong();
            ht.Show();
            this.Close();
        }


        private bool LuuThayDoiVaoCSDL (int maLoaiPhong)
        {
            LOAIPHONG loaiPhong = context.LOAIPHONGs.Find(maLoaiPhong);

            if (loaiPhong != null)
            {
                // Xóa loại phòng từ cơ sở dữ liệu
                context.LOAIPHONGs.Remove(loaiPhong);

                // Lưu thay đổi vào cơ sở dữ liệu
                context.SaveChanges();
            }
            return true;
        }

        private void btnThemLoaiPhong_Click(object sender, EventArgs e)
        {
            try
            {
                List<LOAIPHONG> lp = context.LOAIPHONGs.ToList();
                if (txtDonGia.Text != "" && txtMaLoaiPhong.Text != "" && txtTenloaiphong.Text != "")
                {
                    int maLoaiPhong = int.Parse(txtMaLoaiPhong.Text);
                    string tenLoaiPhong = txtTenloaiphong.Text;
                    decimal donGia = decimal.Parse(txtDonGia.Text);

                    // Kiểm tra mã loại phòng trùng lặp
                    if (lp.Any(p => p.MaLoaiPhong == maLoaiPhong))
                    {
                        MessageBox.Show("Mã loại phòng đã tồn tại!", "Thông báo");
                    }
                    else
                    {
                        LOAIPHONG newPhong = new LOAIPHONG()
                        {
                            MaLoaiPhong = maLoaiPhong,
                            TenLoaiPhong = tenLoaiPhong,
                            DonGia = donGia
                        };

                        context.LOAIPHONGs.Add(newPhong);
                        context.SaveChanges();

                        MessageBox.Show("Phòng đã được thêm thành công!");
                    }
                }
                else
                {
                    if (txtMaLoaiPhong.Text == "" && txtDonGia.Text != "" && txtTenloaiphong.Text != "")
                    {
                        MessageBox.Show("Vui lòng nhập mã loại phòng!", "Thông báo");
                    }

                    else if (txtTenloaiphong.Text == "" && txtDonGia.Text != "" && txtMaLoaiPhong.Text != "")
                    {
                        MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo");
                    }
                    else if (txtDonGia.Text == "" && txtTenloaiphong.Text != "" && txtMaLoaiPhong.Text != "")
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá!", "Thông báo");
                    }
                    else if (txtDonGia.Text == "" && txtTenloaiphong.Text == "" && txtMaLoaiPhong.Text != "")
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá và tên loai phòng!", "Thông báo");
                    }
                    else if (txtDonGia.Text == "" && txtTenloaiphong.Text != "" && txtMaLoaiPhong.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đơn giá và mã loai phòng!", "Thông báo");
                    }
                    else if (txtDonGia.Text != "" && txtTenloaiphong.Text == "" && txtMaLoaiPhong.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập mã loai phòng và tên loai phòng!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập các thông tin!", "Thông báo");
                    }

                }
                List<LOAIPHONG> loaiphong = context.LOAIPHONGs.ToList();
                BindGrid(loaiphong);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phòng: ", "Lỗi");
            }

        }

        private void btnXoaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (dgvDSLoaiPhong.SelectedRows.Count > 0)
            {
                DataGridViewRow hienHang = dgvDSLoaiPhong.SelectedRows[0];

                int maLoaiPhong = Convert.ToInt32(hienHang.Cells[0].Value);
                dgvDSLoaiPhong.Rows.Remove(hienHang);

                LuuThayDoiVaoCSDL(maLoaiPhong);

                MessageBox.Show("Đã xóa hàng thành công và lưu vào cơ sở dữ liệu!");

                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo");
            }
        }

        private void btnSuaLoaiPhong_Click(object sender, EventArgs e)
        {
            if (dgvDSLoaiPhong.SelectedRows.Count > 0)
            {
                // Chọn dòng
                DataGridViewRow selectedRow = dgvDSLoaiPhong.SelectedRows[0];
                int maLoaiPhong = Convert.ToInt32(selectedRow.Cells[0].Value);
                string tenLoaiPhong = txtTenloaiphong.Text;
                decimal donGia;
                LOAIPHONG loaiPhong = context.LOAIPHONGs.Find(maLoaiPhong);

                if (loaiPhong != null)
                {
                    // phai la so
                    if (decimal.TryParse(txtDonGia.Text, out donGia))
                    {
                        //neu am hoac = 0 thi bao sai gia tri
                        if (donGia > 0)
                        {
                            // ktr donGia co giong DonGia trong csdl
                            if (donGia != loaiPhong.DonGia)
                            {
                                loaiPhong.DonGia = donGia;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập giá trị đúng cho đơn giá!", "Thông báo");
                            return;
                        }
                    }

                    // ktr co nhap vao txtTenLoaiPhong khong
                    if (!string.IsNullOrEmpty(tenLoaiPhong))
                    {
                        // ktr tenLoaiPhong ten cu trong csdl khong
                        if (tenLoaiPhong != loaiPhong.TenLoaiPhong)
                        {
                            loaiPhong.TenLoaiPhong = tenLoaiPhong;
                        }
                        else
                        {
                            MessageBox.Show("Tên loại phong bị trùng!", "Thông báo");
                            return;
                        }
                    }
                    context.SaveChanges();
                    selectedRow.Cells[1].Value = loaiPhong.TenLoaiPhong;
                    selectedRow.Cells[2].Value = loaiPhong.DonGia;
                    MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa!", "Thông báo");
            }
        }
    }
}
