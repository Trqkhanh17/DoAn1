using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyHocSinh.QuanLiTaiKhoan;
using QuanLyHocSinh.QuanLiGiaoVien;
using QuanLyHocSinh.QuanLiHocSinh;

namespace QuanLyHocSinh
{
    public partial class frmQuanLiTaiKhoan : Form
    {
        public frmQuanLiTaiKhoan()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        function fc = new function();
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmQuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string DSTaiKhoan = string.Format("Select *from TaiKhoan");
                    using (SqlCommand cmd = new SqlCommand(DSTaiKhoan, ketNoi))
                    {
                        SqlDataReader ds = cmd.ExecuteReader();
                        DataTable dsTaiKhoan = new DataTable();
                        dsTaiKhoan.Load(ds);
                        dgvDanhSachTaiKhoan.DataSource = dsTaiKhoan;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            fc.CustomButton(btnTimTK);
            fc.CustomButton(btnThemTK);
            fc.CustomButton(btnXoaTK);
            fc.CustomButton(btnSuaTK);
            fc.CustomButton(btnThoat);
            fc.CustomizeDataGridView(dgvDanhSachTaiKhoan);
        }
        private void btnTimTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui Lòng Nhập Tài Khoản Cần Tìm", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    SqlConnection ketNoi = new SqlConnection(chuoiKN);
                    ketNoi.Open();
                    string DSTaiKhoanCanTim = string.Format("select *from TaiKhoan where TKDangNhap LIKE '{0}' + '%'", txtTim.Text);
                    SqlCommand cmd = new SqlCommand(DSTaiKhoanCanTim, ketNoi);
                    SqlDataReader ds = cmd.ExecuteReader();
                    if (ds.HasRows)
                    {
                        DataTable dsTaiKhoanCanTim = new DataTable();
                        dsTaiKhoanCanTim.Load(ds);
                        ds.Close();
                        dgvDanhSachTaiKhoan.DataSource = dsTaiKhoanCanTim;
                        ketNoi.Close();
                        fc.CustomizeDataGridView(dgvDanhSachTaiKhoan);
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        string selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan;
        string selectedRowIndex_MatKhau_QuanLiTaiKhoan;
        string selectedRowIndex_LoaiTaiKhoan_QuanLiTaiKhoan;
        string selectedRowIndex_MaGV_QuanLiTaiKhoan;
        string selectedRowIndex_MaHS_QuanLiTaiKhoan;
        //hàm chọn lấy giá trị khi click vào phần tử trong datagidview
        private void dgvDanhSachTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvDanhSachTaiKhoan.Rows[e.RowIndex];

                // Sử dụng ? để tránh lỗi NullReferenceException nếu ô có giá trị null
                selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan = row.Cells["TaiKhoanDangNhap"].Value?.ToString();
                selectedRowIndex_MatKhau_QuanLiTaiKhoan = row.Cells["mkhau"].Value?.ToString();
                selectedRowIndex_LoaiTaiKhoan_QuanLiTaiKhoan = row.Cells["LoaiTaiKhoan"].Value?.ToString();
                selectedRowIndex_MaGV_QuanLiTaiKhoan = row.Cells["MaGiaoVien"].Value?.ToString();
                selectedRowIndex_MaHS_QuanLiTaiKhoan = row.Cells["MaHocSinh"].Value?.ToString();
            }
        }
        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                frmSuaTaiKhoan fSuaTK = new frmSuaTaiKhoan();
                this.Hide();
                fSuaTK.TaiKhoanCanSua = selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan;
                fSuaTK.MatKhauCanSua = selectedRowIndex_MatKhau_QuanLiTaiKhoan;
                fSuaTK.LoaiTaiKhoan = selectedRowIndex_LoaiTaiKhoan_QuanLiTaiKhoan;
                fSuaTK.FormClosed += (s, args) =>
                {
                    frmQuanLiTaiKhoan_Load(sender, e);
                    this.Show();
                };
                fSuaTK.ShowDialog();
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    try
                    {
                        string maGiaoVien = selectedRowIndex_MaGV_QuanLiTaiKhoan.Trim();
                        string maHocSinh = selectedRowIndex_MaHS_QuanLiTaiKhoan.Trim();
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            // Xóa tài khoản
                            string tk = selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan.Trim();
                            string sqlXoa = string.Format("delete from TaiKhoan where TKDangNhap = '{0}'", tk);
                            using (SqlCommand cmdXoaTaiKhoan = new SqlCommand(sqlXoa, ketNoi))
                            {
                                cmdXoaTaiKhoan.ExecuteNonQuery();
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                                frmQuanLiTaiKhoan_Load(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xoá Thất Bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                selectedRowIndex_TaiKhoanDangNhap_QuanLiTaiKhoan = null;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan fThemTK = new frmThemTaiKhoan();
            this.Hide();
            fThemTK.FormClosed += (s, asgr) =>
            {
                frmQuanLiTaiKhoan_Load(sender, e);
                this.Show();
            };
            fThemTK.ShowDialog();
        }
    }
}
