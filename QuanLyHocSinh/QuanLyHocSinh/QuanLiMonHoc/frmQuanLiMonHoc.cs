using QuanLyHocSinh.QuanLiMonHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmQuanLiMonHoc : Form
    {
        public frmQuanLiMonHoc()
        {
            InitializeComponent();
            txtTim.ForeColor = Color.Gray;
            txtTim.Enter += txtTim_Enter;
            txtTim.Leave += txtTim_Leave;
            this.BackColor = Color.LightSteelBlue;

        }
        string textTimKiem = "";
        private void chkMa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMa.Checked == true)
            {
                chkTen.Checked = false;
                textTimKiem = "Nhập mã môn học cần tìm";
                txtTim.Text = textTimKiem;
            }
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
            {
                chkMa.Checked = false;
                textTimKiem = "Nhập tên môn học cần tìm";
                txtTim.Text = textTimKiem;
            }
        }
        function fc = new function();
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void txtTim_Enter(object sender, EventArgs e)
        {
            if (txtTim.Text == textTimKiem)
            {
                txtTim.Text = "";
                txtTim.ForeColor = Color.Black;
            }
        }
        private void txtTim_Leave(object sender,EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTim.Text))
            {
                txtTim.Text = textTimKiem;
                txtTim.ForeColor = Color.Gray;
            }
        }
        private void frmQuanLiMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanDSMonHoc = string.Format("select *from MonHoc");
                    using (SqlCommand DSMonHoc = new SqlCommand(truyVanDSMonHoc, ketNoi))
                    {
                        SqlDataReader ds = DSMonHoc.ExecuteReader();
                        DataTable dsMonHoc = new DataTable();
                        dsMonHoc.Load(ds);
                        dgvDanhSachMonHoc.DataSource = dsMonHoc;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            fc.CustomButton(btnThem);
            fc.CustomButton(btnTim);
            fc.CustomButton(btnSua);
            fc.CustomButton(btnXoa);
            fc.CustomButton(btnThoat);
            fc.CustomizeDataGridView(dgvDanhSachMonHoc);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string loaiTimKiem = "";
            
            if (chkMa.Checked == false && chkTen.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (chkMa.Checked == true)
            {
                loaiTimKiem = "MaMH";
                if (txtTim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin môn học cần tìm", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            string timTheoMa = string.Format("select *from MonHoc where {0} = '{1}'", loaiTimKiem, txtTim.Text.Trim());
                            using (SqlCommand DSMonHocCanTim = new SqlCommand())
                            {
                                using (SqlDataReader ds = DSMonHocCanTim.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        DataTable dsMonHocCanTim = new DataTable();
                                        dsMonHocCanTim.Load(ds);
                                        dgvDanhSachMonHoc.DataSource = dsMonHocCanTim;
                                        fc.CustomizeDataGridView(dgvDanhSachMonHoc);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không tồn tại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            else if (chkTen.Checked == true)
            {
                loaiTimKiem = "TenMon";
                if (txtTim.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin môn học cần tìm", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            string timTheoMa = string.Format("select *from MonHoc where {0} = N'{1}'", loaiTimKiem, txtTim.Text.Trim());
                            using (SqlCommand DSMonHocCanTim = new SqlCommand())
                            {
                                using (SqlDataReader ds = DSMonHocCanTim.ExecuteReader())
                                {
                                    if (ds.HasRows)
                                    {
                                        DataTable dsMonHocCanTim = new DataTable();
                                        dsMonHocCanTim.Load(ds);
                                        dgvDanhSachMonHoc.DataSource = dsMonHocCanTim;
                                        fc.CustomizeDataGridView(dgvDanhSachMonHoc);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không tồn tại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemMonHoc fThemMH = new frmThemMonHoc();
            this.Hide();
            fThemMH.FormClosed += (s, agrs) =>
            {
                frmQuanLiMonHoc_Load(sender,e);
                this.Show();
            };
            fThemMH.ShowDialog();
        }
        private string SelectRowIndex_MaMon_QuanLiMonHoc;
        private string SelectRowIndex_TenMon_QuanLiMonHoc;
        private void dgvDanhSachMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvDanhSachMonHoc.Rows[e.RowIndex];

                // Sử dụng ? để tránh lỗi NullReferenceException nếu ô có giá trị null
                SelectRowIndex_MaMon_QuanLiMonHoc = row.Cells["MaMH"].Value?.ToString().Trim();
                SelectRowIndex_TenMon_QuanLiMonHoc = row.Cells["TenMH"].Value?.ToString().Trim();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (SelectRowIndex_MaMon_QuanLiMonHoc == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa","Thông Báo",MessageBoxButtons.OK);
            }
            else
            {
                frmSuaMonHoc fSuaMH = new frmSuaMonHoc();
                this.Hide();
                fSuaMH.MaMonHocCanSua = SelectRowIndex_MaMon_QuanLiMonHoc;
                fSuaMH.TenMonHocCanSua = SelectRowIndex_TenMon_QuanLiMonHoc;
                fSuaMH.FormClosed += (s, agrs) =>
                {
                    frmQuanLiMonHoc_Load(sender, e);
                    this.Show();
                };
                fSuaMH.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SelectRowIndex_MaMon_QuanLiMonHoc == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông Báo",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string maMonHoc = SelectRowIndex_MaMon_QuanLiMonHoc;
                            ketNoi.Open();
                            string lenhXoa = string.Format("delete MonHoc where MaMon = '{0}'", maMonHoc);
                            using (SqlCommand cmdXoa = new SqlCommand(lenhXoa, ketNoi))
                            {
                                cmdXoa.ExecuteNonQuery();
                                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            SelectRowIndex_MaMon_QuanLiMonHoc = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
