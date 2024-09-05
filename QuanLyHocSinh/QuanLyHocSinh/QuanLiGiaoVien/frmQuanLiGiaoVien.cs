using QuanLyHocSinh.QuanLiGiaoVien;
using QuanLyHocSinh.QuanLiTaiKhoan;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace QuanLyHocSinh
{
    public partial class frmQuanLiGiaoVien : Form
    {
        public frmQuanLiGiaoVien()
        {
            InitializeComponent();
            txtTim.KeyDown += new KeyEventHandler(txtTim_KeyDown);
            this.BackColor = Color.LightSteelBlue;
        }
        function fc = new function();
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void frmQuanLiGiaoVien_Load(object sender, EventArgs e)
        {
            try
            {
                string DSGiaoVien = string.Format("SELECT *FROM GV ORDER BY CAST(SUBSTRING(MaGV, 8, LEN(MaGV) - 7) AS INT) DESC");
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();

                    using (SqlCommand cmd = new SqlCommand(DSGiaoVien, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            using (DataTable dsGiaoVien = new DataTable())
                            {
                                dsGiaoVien.Load(ds);
                                dgvGiaoVien.DataSource = dsGiaoVien;
                                ketNoi.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            fc.CustomButton(btnSua);
            fc.CustomButton(btnThem);
            fc.CustomButton(btnXoa);
            fc.CustomButton(btnTim);
            fc.CustomButton(btnXem);
            fc.CustomButton(btnThoat);
            fc.CustomTextBox(txtTim);
            fc.CustomCheckBox(chkMaGV);
            fc.CustomCheckBox(chkTenGV);
            fc.CustomizeDataGridView(dgvGiaoVien);
        }

        private void chkMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaGV.Checked == true)
            {
                chkTenGV.Checked = false;
            }
        }

        private void chkTenGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTenGV.Checked == true)
            {
                chkMaGV.Checked = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (chkMaGV.Checked == false && chkTenGV.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm", "Thông báo", MessageBoxButtons.OK);
            }
            else if (chkMaGV.Checked == true)
            {
                if (txtTim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string chuoiTimKiem = txtTim.Text.Trim();
                        //MessageBox.Show(phuongThucTimKiem.ToString());
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            string DSGiaoVien = string.Format("Select *from GV where MaGV LIKE N'{0}' + '%'", chuoiTimKiem);
                            using (SqlCommand cmd = new SqlCommand(DSGiaoVien, ketNoi))
                            {
                                using (SqlDataReader ds = cmd.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        using (DataTable dsGiaoVienCanTim = new DataTable())
                                        {
                                            dsGiaoVienCanTim.Load(ds);
                                            dgvGiaoVien.DataSource = dsGiaoVienCanTim;
                                            fc.CustomizeDataGridView(dgvGiaoVien);
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
            else if (chkTenGV.Checked == true)
            {
                if (txtTim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string chuoiTimKiem = txtTim.Text.Trim();
                        //MessageBox.Show(phuongThucTimKiem.ToString());
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            string DSGiaoVien = string.Format("Select *from GV where TenGV LIKE N'{0}' + '%'", chuoiTimKiem);
                            using (SqlCommand cmd = new SqlCommand(DSGiaoVien, ketNoi))
                            {
                                using (SqlDataReader ds = cmd.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        using (DataTable dsGiaoVienCanTim = new DataTable())
                                        {
                                            dsGiaoVienCanTim.Load(ds);
                                            dgvGiaoVien.DataSource = dsGiaoVienCanTim;
                                            fc.CustomizeDataGridView(dgvGiaoVien);
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
        }
        string selectedRowIndex_MaGiaoVien_QuanLiGiaoVien;
        string selectedRowIndex_TenGiaoVien_QuanLiGiaoVien;
        string selectedRowIndex_DiaChiGiaoVien_QuanLiGiaoVien;
        string selectedRowIndex_SoDienThoaiGiaoVien_QuanLiGiaoVien;
        string selectedRowIndex_GioiTinh_QuanLiGiaoVien;
        private void dgvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvGiaoVien.Rows[e.RowIndex];

                // Sử dụng ? để tránh lỗi NullReferenceException nếu ô có giá trị null
                selectedRowIndex_MaGiaoVien_QuanLiGiaoVien = row.Cells["MaGiaoVien"].Value?.ToString();
                selectedRowIndex_TenGiaoVien_QuanLiGiaoVien = row.Cells["TenGiaoVien"].Value?.ToString();
                selectedRowIndex_DiaChiGiaoVien_QuanLiGiaoVien = row.Cells["DiaChiGiaoVien"].Value?.ToString();
                selectedRowIndex_SoDienThoaiGiaoVien_QuanLiGiaoVien = row.Cells["SoDienThoai"].Value?.ToString();
                selectedRowIndex_GioiTinh_QuanLiGiaoVien = row.Cells["GioiTinhGiaoVien"].Value?.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (selectedRowIndex_MaGiaoVien_QuanLiGiaoVien == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần sửa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                frmSuaGiaoVien fSuaGV = new frmSuaGiaoVien();
                this.Hide();
                fSuaGV.MaGiaoVienCanSua = selectedRowIndex_MaGiaoVien_QuanLiGiaoVien;
                fSuaGV.TenGiaoVienCanSua = selectedRowIndex_TenGiaoVien_QuanLiGiaoVien;
                fSuaGV.DiaChiGiaoVienCanSua = selectedRowIndex_DiaChiGiaoVien_QuanLiGiaoVien;
                fSuaGV.SoDienThoaiGiaoVienCanSua = selectedRowIndex_SoDienThoaiGiaoVien_QuanLiGiaoVien;
                fSuaGV.FormClosed += (s, args) =>
                {
                    frmQuanLiGiaoVien_Load(sender, e);
                    this.Show();
                };
                fSuaGV.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaGiaoVien_QuanLiGiaoVien == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string maGiaoVien = selectedRowIndex_MaGiaoVien_QuanLiGiaoVien.Trim();
                            ketNoi.Open();
                            string sqlXoaGV = string.Format("delete from GV where MaGV = '{0}'", maGiaoVien);
                            string sqlXoaLienKet = string.Format("update TaiKhoan set MaGV = null where MaGV = '{0}'", maGiaoVien);
                            using (SqlCommand cmdXoaLienKet = new SqlCommand(sqlXoaLienKet, ketNoi))
                            {
                                cmdXoaLienKet.ExecuteNonQuery();
                            }
                            using (SqlCommand cmdXoaGV = new SqlCommand(sqlXoaGV, ketNoi))
                            {
                                cmdXoaGV.ExecuteNonQuery();
                                string sqlXoaTaiKhoanGV = string.Format("delete TaiKhoan where MaGV = '{0}'", maGiaoVien);
                                using (SqlCommand cmdXoaTaiKhoan = new SqlCommand(sqlXoaTaiKhoanGV, ketNoi))
                                {
                                    cmdXoaTaiKhoan.ExecuteNonQuery();
                                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                                    frmQuanLiGiaoVien_Load(sender, e);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Thất Bại ", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                selectedRowIndex_MaGiaoVien_QuanLiGiaoVien = null;
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex_MaGiaoVien_QuanLiGiaoVien == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xem", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                using (frmXemChiTietGiaoVien fXemGV = new frmXemChiTietGiaoVien())
                {
                    this.Hide();
                    fXemGV.MaGiaoVienCanXem = selectedRowIndex_MaGiaoVien_QuanLiGiaoVien;
                    fXemGV.FormClosed += (s, args) =>
                    {
                        frmQuanLiGiaoVien_Load(sender, e);
                        this.Show();
                    };
                    fXemGV.ShowDialog();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemGiaoVien fThemGV = new frmThemGiaoVien();
            this.Hide();
            fThemGV.FormClosed += (s, args) =>
            {
                frmQuanLiGiaoVien_Load(sender, e);
                this.Show();
            };
            fThemGV.ShowDialog();
        }
    }
}
