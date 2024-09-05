using QuanLyHocSinh.QuanliDiem;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using TextBox = System.Windows.Forms.TextBox;

namespace QuanLyHocSinh
{
    public partial class frmQuanLiDiem : Form
    {
        public frmQuanLiDiem()
        {
            InitializeComponent();
            txtTim.KeyDown += new KeyEventHandler(txtTim_KeyDown);
            this.BackColor = Color.LightSteelBlue; 
        }
        function fc = new function();
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmQuanLiDiem_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanDiemSo = string.Format("SELECT *FROM DiemSo ORDER BY CAST(SUBSTRING(MaDiem, 3, LEN(MaDiem) - 2) AS INT) DESC");
                    using (SqlCommand cmd = new SqlCommand(truyVanDiemSo, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable dsdiemSo = new DataTable();
                            dsdiemSo.Load(ds);
                            dgvDanhSachDiem.DataSource = dsdiemSo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            this.FormBorderStyle = FormBorderStyle.None;
            fc.CustomizeDataGridView(dgvDanhSachDiem);
            fc.CustomButton(btnSua);
            fc.CustomButton(btnThem);
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnTim);
            fc.CustomButton(btnXem);
            fc.CustomButton(btnXoa);
            fc.CustomTextBox(txtTim);
            fc.CustomCheckBox(chkMaDiem);
            fc.CustomCheckBox(chkMaHS);
            fc.CustomCheckBox(chkMaLop);
            fc.CustomCheckBox(chkMaMonHoc);
            dgvDanhSachDiem.Columns["Diem15Phut"].DefaultCellStyle.Format = "N2";
            dgvDanhSachDiem.Columns["DiemCuoiHocKi"].DefaultCellStyle.Format = "N2";
            dgvDanhSachDiem.Columns["DiemGiuaHocKi"].DefaultCellStyle.Format = "N2";
        }

        private void txtTim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
                e.Handled = true;  // Ngăn chặn sự kiện mặc định của phím Enter
                e.SuppressKeyPress = true; 
            }
        }
        private void TimKiem(string loaiTimKiem, string ThongTincanTim)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanTim = string.Format("select *from DiemSo where {0} like '{1}' + '%'", loaiTimKiem, ThongTincanTim);
                    using (SqlCommand cmdTim = new SqlCommand(truyVanTim, ketNoi))
                    {
                        using (SqlDataReader ds = cmdTim.ExecuteReader())
                        {
                            if (ds.HasRows)
                            {
                                DataTable dsDiemCanTim = new DataTable();
                                dsDiemCanTim.Load(ds);
                                dgvDanhSachDiem.DataSource = dsDiemCanTim;
                                dgvDanhSachDiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dgvDanhSachDiem.DefaultCellStyle.Padding = new Padding(4);
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
                MessageBox.Show("Đã có lỗi xảy ra", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (chkMaDiem.Checked == false && chkMaHS.Checked == false && chkMaLop.Checked == false && chkMaMonHoc.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn phương thức tìm kiếm", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (chkMaDiem.Checked == true)
            {
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm");
                }
                else
                {
                    string loaiTimKiem = "MaDiem";
                    string maDiemCanTim = txtTim.Text.Trim();
                    TimKiem(loaiTimKiem, maDiemCanTim);
                    fc.CustomizeDataGridView(dgvDanhSachDiem);
                }
            }
            else if (chkMaHS.Checked == true)
            {
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm");
                }
                else
                {
                    string loaiTimKiem = "MaHS";
                    string maHocSinhCanTim = txtTim.Text.Trim();
                    TimKiem(loaiTimKiem, maHocSinhCanTim);
                    fc.CustomizeDataGridView(dgvDanhSachDiem);
                }
            }
            else if (chkMaLop.Checked == true)
            {
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm");
                }
                else
                {
                    string loaiTimKiem = "MaLop";
                    string maLopCanTim = txtTim.Text.Trim();
                    TimKiem(loaiTimKiem, maLopCanTim);
                    fc.CustomizeDataGridView(dgvDanhSachDiem);
                }
            }
            else if (chkMaMonHoc.Checked == true)
            {
                if (txtTim.Text == "" || txtTim.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm");
                }
                else
                {
                    string loaiTimKiem = "MaMon";
                    string maMonHocCanTim = txtTim.Text.Trim();
                    TimKiem(loaiTimKiem, maMonHocCanTim);
                    fc.CustomizeDataGridView(dgvDanhSachDiem);
                }
            }
        }

        private void chkMaDiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaDiem.Checked == true)
            {
                chkMaHS.Checked = false;
                chkMaLop.Checked = false;
                chkMaMonHoc.Checked = false;
            }
        }

        private void chkMaHS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaHS.Checked == true)
            {
                chkMaDiem.Checked = false;
                chkMaMonHoc.Checked = false;
                chkMaLop.Checked = false;
            }
        }

        private void chkMaLop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaLop.Checked == true)
            {
                chkMaDiem.Checked = false;
                chkMaMonHoc.Checked = false;
                chkMaHS.Checked = false;
            }
        }

        private void chkMaMonHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaMonHoc.Checked == true)
            {
                chkMaDiem.Checked = false;
                chkMaLop.Checked = false;
                chkMaHS.Checked = false;
            }
        }
        private string SelectRowIndex_MaDiem_QuanLiDiem;
        private string SelectRowIndex_MaHS_QuanLiDiem;
        private string SelectRowIndex_MaMon_QuanLiDiem;
        private string SelectRowIndex_MaGV_QuanLiDiem;
        private string SelectRowIndex_MaLop_QuanLiDiem;
        private string SelectRowIndex_Diem15p_QuanLiDiem;
        private string SelectRowIndex_DiemGiuaKi_QuanLiDiem;
        private string SelectRowIndex_DiemCuoiKi_QuanLiDiem;
        private string SelectRowIndex_HocKi_QuanLiDiem;
        private void dgvDanhSachDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvDanhSachDiem.Rows[e.RowIndex];

                SelectRowIndex_MaDiem_QuanLiDiem = row.Cells["MaDiemSo"].Value.ToString();
                SelectRowIndex_MaHS_QuanLiDiem = row.Cells["MaHocSinh"].Value.ToString();
                SelectRowIndex_MaMon_QuanLiDiem = row.Cells["MaMonHoc"].Value.ToString();
                SelectRowIndex_MaGV_QuanLiDiem = row.Cells["MaGiaoVien"].Value.ToString();
                SelectRowIndex_MaLop_QuanLiDiem = row.Cells["MaLopHoc"].Value.ToString();
                SelectRowIndex_Diem15p_QuanLiDiem = row.Cells["Diem15Phut"].Value.ToString();
                SelectRowIndex_DiemGiuaKi_QuanLiDiem = row.Cells["DiemGiuaHocKi"].Value.ToString();
                SelectRowIndex_DiemCuoiKi_QuanLiDiem = row.Cells["DiemCuoiHocKi"].Value.ToString();
                SelectRowIndex_HocKi_QuanLiDiem = row.Cells["HocKiDangHoc"].Value.ToString();
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemDiem fThemDiem = new frmThemDiem();
            this.Hide();
            fThemDiem.FormClosed += (s, agrs) =>
            {
                frmQuanLiDiem_Load(sender, e);
                this.Show();
            };
            fThemDiem.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (SelectRowIndex_MaDiem_QuanLiDiem == null)
            {
                MessageBox.Show("Vui chọn điểm cần sửa", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                frmSuaDiem fSuaDiem = new frmSuaDiem();
                this.Hide();
                fSuaDiem.MaDiemCanSua = SelectRowIndex_MaDiem_QuanLiDiem;
                fSuaDiem.MaHSCanSua = SelectRowIndex_MaHS_QuanLiDiem;
                fSuaDiem.MaMonCanSua = SelectRowIndex_MaMon_QuanLiDiem;
                fSuaDiem.MaGVCanSua = SelectRowIndex_MaGV_QuanLiDiem;
                fSuaDiem.MaLopCanSua = SelectRowIndex_MaLop_QuanLiDiem;
                fSuaDiem.Diem15pCanSua = SelectRowIndex_Diem15p_QuanLiDiem;
                fSuaDiem.DiemGiuaKiCanSua = SelectRowIndex_DiemGiuaKi_QuanLiDiem;
                fSuaDiem.DiemCuoiKiCanSua = SelectRowIndex_DiemCuoiKi_QuanLiDiem;
                fSuaDiem.HocKiCanSua = SelectRowIndex_HocKi_QuanLiDiem;
                fSuaDiem.FormClosed += (s, agrs) =>
                {
                    
                    this.Show();
                    frmQuanLiDiem_Load(sender, e);
                };
                fSuaDiem.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (SelectRowIndex_MaDiem_QuanLiDiem == null)
            {
                MessageBox.Show("Vui lòng chọn điểm cần xóa", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa điểm này?", "Thông Báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            string maDiem = SelectRowIndex_MaDiem_QuanLiDiem.Trim();
                            ketNoi.Open();
                            string sqlSua = string.Format("delete DiemSo where MaDiem = '{0}'", maDiem);
                            using (SqlCommand cmdXoa = new SqlCommand(sqlSua, ketNoi))
                            {
                                cmdXoa.ExecuteNonQuery();
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                                frmQuanLiDiem_Load(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Thất Bại","Thông Báo",MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (SelectRowIndex_MaDiem_QuanLiDiem == null)
            {
                MessageBox.Show("Vui lòng chọn điểm cần xem chi tiết","Thông Báo",MessageBoxButtons.OK);
            }
            else
            {
                frmXemChiTietDiem fXemDiem = new frmXemChiTietDiem();
                this.Hide();
                fXemDiem.MaDiemCanXem = SelectRowIndex_MaDiem_QuanLiDiem;
                fXemDiem.MaHSCanXem = SelectRowIndex_MaHS_QuanLiDiem;
                fXemDiem.MaGVCanXem = SelectRowIndex_MaGV_QuanLiDiem;
                fXemDiem.FormClosed += (s, agrs) =>
                {
                    this.Show();
                };
                fXemDiem.ShowDialog();
            }
        }
    }
}
