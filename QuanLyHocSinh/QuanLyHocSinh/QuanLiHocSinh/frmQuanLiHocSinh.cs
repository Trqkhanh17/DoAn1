using QuanLyHocSinh.QuanLiHocSinh;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmQuanLiHocSinh : Form
    {
        public frmQuanLiHocSinh()
        {
            InitializeComponent();
            txtTim.KeyDown += new KeyEventHandler(txtTim_KeyDown);
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        function fc = new function();
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemHocSinh fThemHS = new frmThemHocSinh();
            this.Hide();
            fThemHS.FormClosed += (s, args) =>
            {
                frmQuanLiHocSinh_Load(sender, e);
                this.Show();
            };
            fThemHS.ShowDialog();
        }

        private void frmQuanLiHocSinh_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string DSHocSinh = string.Format("SELECT *FROM HocSinh ORDER BY CAST(SUBSTRING(MaHS, 8, LEN(MaHS) - 7) AS INT) DESC");
                    using (SqlCommand cmd = new SqlCommand(DSHocSinh, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            using (DataTable dsHocSinh = new DataTable())
                            {
                                dsHocSinh.Load(ds);
                                dgvDanhSachHocSinh.DataSource = dsHocSinh;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra ", "Thông báo", MessageBoxButtons.OK);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            fc.CustomizeDataGridView(dgvDanhSachHocSinh);
            fc.CustomTextBox(txtTim);
            fc.CustomButton(btnSua);
            fc.CustomButton(btnThem);
            fc.CustomButton(btnXoa);
            fc.CustomButton(btnXem);
            fc.CustomButton(btnThoat);
        }
        private void chkMaSo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaSo.Checked == true)
            {
                chkLop.Checked = false;
                chkTen.Checked = false;
            }
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                chkMaSo.Checked = false;
                chkLop.Checked = false;
            }
        }

        private void chkLop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLop.Checked == true)
            {
                chkMaSo.Checked = false;
                chkTen.Checked = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string phuongThucTimKiem = "";
            if (chkMaSo.Checked == false && chkTen.Checked == false && chkLop.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            }
            else if (chkMaSo.Checked == true)
            {
                phuongThucTimKiem = "MaHS";
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        //MessageBox.Show(phuongThucTimKiem.ToString());
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string chuoiTimKiem = txtTim.Text.Trim();
                            ketNoi.Open();
                            string DSHocSinh = string.Format("Select *from HocSinh where {0} LIKE N'{1}' + '%'", phuongThucTimKiem, chuoiTimKiem);
                            using (SqlCommand cmd = new SqlCommand(DSHocSinh, ketNoi))
                            {
                                using (SqlDataReader ds = cmd.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        using (DataTable dsHocSinhCanTim = new DataTable())
                                        {
                                            dsHocSinhCanTim.Load(ds);
                                            dgvDanhSachHocSinh.DataSource = dsHocSinhCanTim;
                                            fc.CustomizeDataGridView(dgvDanhSachHocSinh);
                                        }
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
            else if (chkTen.Checked == true)
            {
                phuongThucTimKiem = "TenHS";
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        //MessageBox.Show(phuongThucTimKiem.ToString());
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string chuoiTimKiem = txtTim.Text.Trim();
                            ketNoi.Open();
                            string DSHocSinh = string.Format("Select *from HocSinh where {0} LIKE N'{1}' + '%'", phuongThucTimKiem, chuoiTimKiem);
                            using (SqlCommand cmd = new SqlCommand(DSHocSinh, ketNoi))
                            {
                                using (SqlDataReader ds = cmd.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        using (DataTable dsHocSinhCanTim = new DataTable())
                                        {
                                            dsHocSinhCanTim.Load(ds);
                                            dgvDanhSachHocSinh.DataSource = dsHocSinhCanTim;
                                            fc.CustomizeDataGridView(dgvDanhSachHocSinh);
                                        }
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
            else if (chkLop.Checked == true)
            {
                phuongThucTimKiem = "MaLop";
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        //MessageBox.Show(phuongThucTimKiem.ToString());
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string chuoiTimKiem = txtTim.Text.Trim();
                            ketNoi.Open();
                            string DSHocSinh = string.Format("Select *from HocSinh where {0} LIKE N'{1}' + '%'", phuongThucTimKiem, chuoiTimKiem);
                            using (SqlCommand cmd = new SqlCommand(DSHocSinh, ketNoi))
                            {
                                using (SqlDataReader ds = cmd.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        using (DataTable dsHocSinhCanTim = new DataTable())
                                        {
                                            dsHocSinhCanTim.Load(ds);
                                            dgvDanhSachHocSinh.DataSource = dsHocSinhCanTim;
                                            fc.CustomizeDataGridView(dgvDanhSachHocSinh);
                                        }
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
                        MessageBox.Show("Đã có lỗi xảy ra " + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            dgvDanhSachHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDanhSachHocSinh.ReadOnly = true;
        }
        string selectedRowIndex_MaHocSinh_QuanLiHocSinh;
        string selectedRowIndex_TenHocSinh_QuanLiHocSinh;
        string selectedRowIndex_DiaChiHocSinh_QuanLiHocSinh;
        string selectedRowIndex_SoDienThoaiHocSinh_QuanLiHocSinh;
        string selectedRowIndex_GioiTinh_QuanLiHocSinh;
        string selectedRowIndex_NgaySinh_QuanLiHocSinh;
        string selectedRowIndex_MaLop_QuanLiHocSinh;
        string selectedRowIndex_NamHoc_QuanLiHocSinh;
        private void dgvDanhSachHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvDanhSachHocSinh.Rows[e.RowIndex];

                // Sử dụng ? để tránh lỗi NullReferenceException nếu ô có giá trị null
                selectedRowIndex_MaHocSinh_QuanLiHocSinh = row.Cells["MaHocSinh"].Value?.ToString();
                selectedRowIndex_TenHocSinh_QuanLiHocSinh = row.Cells["TenHocSinh"].Value?.ToString();
                selectedRowIndex_NgaySinh_QuanLiHocSinh = row.Cells["NgayThangNamSinh"].Value?.ToString();
                selectedRowIndex_SoDienThoaiHocSinh_QuanLiHocSinh = row.Cells["SoDienThoai"].Value?.ToString();
                selectedRowIndex_GioiTinh_QuanLiHocSinh = row.Cells["GioiTinhHocSinh"].Value?.ToString();
                selectedRowIndex_DiaChiHocSinh_QuanLiHocSinh = row.Cells["DiaChiHocSinh"].Value?.ToString();
                selectedRowIndex_NamHoc_QuanLiHocSinh = row.Cells["NamDangHoc"].Value?.ToString();
                selectedRowIndex_MaLop_QuanLiHocSinh = row.Cells["MaLopCuaHocSinh"].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaHocSinh_QuanLiHocSinh == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                frmSuaHocSinh fSuaHS = new frmSuaHocSinh();
                this.Hide();
                fSuaHS.MaHocSinhCanSua = selectedRowIndex_MaHocSinh_QuanLiHocSinh;
                fSuaHS.TenHocSinhCanSua = selectedRowIndex_TenHocSinh_QuanLiHocSinh;
                fSuaHS.NgaySinhCanSua = selectedRowIndex_NgaySinh_QuanLiHocSinh;
                fSuaHS.GioiTinhHocSinhCanSua = selectedRowIndex_GioiTinh_QuanLiHocSinh;
                fSuaHS.SoDienThoaiHocSinhCanSua = selectedRowIndex_SoDienThoaiHocSinh_QuanLiHocSinh;
                fSuaHS.DiaChiHocSinhCanSua = selectedRowIndex_DiaChiHocSinh_QuanLiHocSinh;
                fSuaHS.MaLopCanSua = selectedRowIndex_MaLop_QuanLiHocSinh;
                fSuaHS.NamHocCanSua = selectedRowIndex_NamHoc_QuanLiHocSinh;
                fSuaHS.FormClosed += (s, args) =>
                {
                    frmQuanLiHocSinh_Load(sender, e);
                    this.Show();
                };
                fSuaHS.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaHocSinh_QuanLiHocSinh == null || selectedRowIndex_MaHocSinh_QuanLiHocSinh == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string maHocSinh = selectedRowIndex_MaHocSinh_QuanLiHocSinh.Trim();
                            ketNoi.Open();
                            string sqlXoaHS = string.Format("delete from HocSinh where MaHS = '{0}'", maHocSinh);
                            string sqlXoaLienKet = string.Format("update TaiKhoan set MaHS = null where MaHS = '{0}'", maHocSinh);
                            using (SqlCommand cmdXoaLienKet = new SqlCommand(sqlXoaLienKet, ketNoi))
                            {
                                cmdXoaLienKet.ExecuteNonQuery();
                            }
                            using (SqlCommand cmdXoaGV = new SqlCommand(sqlXoaHS, ketNoi))
                            {
                                cmdXoaGV.ExecuteNonQuery();
                                string sqlXoaTaiKhoanGV = string.Format("delete TaiKhoan where MaHS = '{0}'", maHocSinh);
                                using (SqlCommand cmdXoaTaiKhoan = new SqlCommand(sqlXoaTaiKhoanGV, ketNoi))
                                {
                                    cmdXoaTaiKhoan.ExecuteNonQuery();
                                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                                    frmQuanLiHocSinh_Load(sender, e);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Thất Bại ", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                selectedRowIndex_MaHocSinh_QuanLiHocSinh = null;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaHocSinh_QuanLiHocSinh == null)
            {
                MessageBox.Show("Vui lòng chọn học sinh cần xem", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                frmXemChiTietHocSinh fXemChiTietHS = new frmXemChiTietHocSinh();
                this.Hide();
                fXemChiTietHS.MaHocSinhCanXem = selectedRowIndex_MaHocSinh_QuanLiHocSinh;
                fXemChiTietHS.FormClosed += (s, args) =>
                {
                    frmQuanLiHocSinh_Load(sender, e);
                    this.Show();
                };
                fXemChiTietHS.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThemHocSinh fThemHS = new frmThemHocSinh();
            this.Hide();
            fThemHS.FormClosed += (s, args) =>
            {
                frmQuanLiHocSinh_Load(sender, e);
                this.Show();
            };
            fThemHS.ShowDialog();
        }
    }
}

