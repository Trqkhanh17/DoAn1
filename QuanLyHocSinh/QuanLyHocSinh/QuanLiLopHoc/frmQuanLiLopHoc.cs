using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.QuanLiLopHoc
{
    public partial class frmQuanLiLopHoc : Form
    {
        public frmQuanLiLopHoc()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        function fc = new function();
        private void frmQuanLiLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string DanhSachLopHoc = string.Format("Select *from Lop");
                    using (SqlCommand cmd = new SqlCommand(DanhSachLopHoc, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable dsLopHoc = new DataTable();
                            dsLopHoc.Load(ds);
                            dgvDanhSachLopHoc.DataSource = dsLopHoc;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra ", "Thông báo", MessageBoxButtons.OK);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            fc.CustomButton(btnThem);
            fc.CustomButton(btnSua);
            fc.CustomButton(btnXem);
            fc.CustomButton(btnXoa);
            fc.CustomButton(btnTim);
            fc.CustomTextBox(txtTim);
            fc.CustomizeDataGridView(dgvDanhSachLopHoc);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "" || txtTim.Text == null)
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    string chuoiTimKiem = txtTim.Text.Trim();
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        string DSLop = string.Format("Select *from Lop where MaLop LIKE N'{0}' + '%'", chuoiTimKiem);
                        using (SqlCommand cmd = new SqlCommand(DSLop, ketNoi))
                        {
                            using (SqlDataReader ds = cmd.ExecuteReader())
                            {
                                if (ds.HasRows)
                                {
                                    DataTable dsLopCanTim = new DataTable();
                                    dsLopCanTim.Load(ds);
                                    dgvDanhSachLopHoc.DataSource = dsLopCanTim;
                                    fc.CustomizeDataGridView(dgvDanhSachLopHoc);
                                }
                                else
                                {
                                    MessageBox.Show("Không tồn tại", "Thông Báo", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra ", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemLopHoc fThemLop = new frmThemLopHoc();
            this.Hide();
            fThemLop.FormClosed += (s, args) =>
            {
                frmQuanLiLopHoc_Load(sender, e);
                this.Show();
            };
            fThemLop.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaLop_QuanLiLopHoc == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                frmSuaLopHoc fSuaLop = new frmSuaLopHoc();
                this.Hide();
                fSuaLop.maLop = selectedRowIndex_MaLop_QuanLiLopHoc;
                fSuaLop.SiSo = selectedRowIndex_SiSo_QuanLiLopHoc;
                fSuaLop.giaoVienCN = selectedRowIndex_GiaoVienCN_QuanLiLopHoc;
                fSuaLop.FormClosed += (s, args) =>
                {
                    frmQuanLiLopHoc_Load(sender, e);
                    this.Show();
                };
                fSuaLop.ShowDialog();
            }
        }
        string selectedRowIndex_MaLop_QuanLiLopHoc;
        string selectedRowIndex_SiSo_QuanLiLopHoc;
        string selectedRowIndex_GiaoVienCN_QuanLiLopHoc;
        private void dgvDanhSachLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvDanhSachLopHoc.Rows[e.RowIndex];

                // Sử dụng ? để tránh lỗi NullReferenceException nếu ô có giá trị null
                selectedRowIndex_MaLop_QuanLiLopHoc = row.Cells["MaLopHoc"].Value?.ToString();
                selectedRowIndex_SiSo_QuanLiLopHoc = row.Cells["SoLuongHocSinh"].Value?.ToString();
                selectedRowIndex_GiaoVienCN_QuanLiLopHoc = row.Cells["GiaoVienChuNhiem"].Value?.ToString();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaLop_QuanLiLopHoc == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần Xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                string maLop = selectedRowIndex_MaLop_QuanLiLopHoc.ToString().Trim();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            string sqlSua = string.Format("DELETE Lop WHERE MaLop = '{0}'", maLop);
                            using (SqlCommand lenhSua = new SqlCommand(sqlSua, ketNoi))
                            {
                                lenhSua.ExecuteNonQuery();
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                                frmQuanLiLopHoc_Load(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                selectedRowIndex_MaLop_QuanLiLopHoc = null;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaLop_QuanLiLopHoc == null)
            {
                MessageBox.Show("Vui lòng chọn lớp cần xem chi tiết", "Thông báo");
            }
            else
            {
                frmXemChiTietLop fXemChiTiet = new frmXemChiTietLop();
                this.Hide();
                fXemChiTiet.MaLop = selectedRowIndex_MaLop_QuanLiLopHoc;
                fXemChiTiet.FormClosed += (s, args) =>
                {
                    frmQuanLiLopHoc_Load(sender, e);
                    this.Show();
                };
                fXemChiTiet.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
