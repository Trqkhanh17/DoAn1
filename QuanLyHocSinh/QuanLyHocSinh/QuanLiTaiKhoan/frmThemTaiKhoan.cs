using QuanLyHocSinh.QuanLiGiaoVien;
using QuanLyHocSinh.QuanLiHocSinh;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHocSinh.QuanLiTaiKhoan
{
    public partial class frmThemTaiKhoan : Form
    {
        public frmThemTaiKhoan()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
            {
                ketNoi.Open();
                string duLieuDanhSachLoaiTK = string.Format("SELECT LoaiTK FROM LoaiTaiKhoan where LoaiTK != 'admin'");
                using (SqlCommand cmd = new SqlCommand(duLieuDanhSachLoaiTK, ketNoi))
                {
                    using (SqlDataReader ds = cmd.ExecuteReader())
                    {
                        DataTable danhSachLoaiTK = new DataTable();
                        danhSachLoaiTK.Load(ds);
                        cbxLoaiTK.DataSource = danhSachLoaiTK;
                        cbxLoaiTK.DisplayMember = "LoaiTK";
                    }
                }
            }
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnThem);
            fc.CustomButton(btnThoat);
            fc.CustomTextBox(txtMatKhau);
            fc.CustomTextBox(txtTKDangNhap);
            fc.CustomComboBox(cbxLoaiTK);
            fc.CustomComboBox(cbxThongTinLienKet);
        }

        private void cbxLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
            {
                ketNoi.Open();
                if (cbxLoaiTK.Text.Trim() == "teacher")
                {
                    lblThongTinLienKet.Text = "Giáo Viên Liên Kết: ";
                    string duLieuDanhSachGiaoVien = string.Format("SELECT GV.MaGV FROM GV LEFT JOIN TaiKhoan ON GV.MaGV = TaiKhoan.MaGV WHERE TaiKhoan.MaGV IS NULL ORDER BY CAST(SUBSTRING((GV.MaGV), 8, LEN(GV.MaGV) - 7) AS INT) DESC");
                    using (SqlCommand cmd = new SqlCommand(duLieuDanhSachGiaoVien, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            if (ds.HasRows)
                            {
                                DataTable danhSachSachGiaoVien = new DataTable();
                                danhSachSachGiaoVien.Load(ds);
                                cbxThongTinLienKet.DataSource = danhSachSachGiaoVien;
                                cbxThongTinLienKet.DisplayMember = "MaGV";
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng tạo thêm giáo viên mới", "Thông Báo", MessageBoxButtons.OK);
                                frmThemGiaoVien fThemGV = new frmThemGiaoVien();
                                this.Hide();
                                fThemGV.FormClosed += (s, agrs) =>
                                {
                                    frmThemTaiKhoan_Load(sender, e);
                                    this.Show();
                                };
                                fThemGV.ShowDialog();
                            }
                        }
                    }
                }
                else if (cbxLoaiTK.Text.Trim() == "student")
                {
                    lblThongTinLienKet.Text = "Học Sinh Liên Kết: ";
                    string duLieuDanhSachHocSinh = string.Format("SELECT HocSinh.MaHS FROM HocSinh LEFT JOIN TaiKhoan ON HocSinh.MaHS = TaiKhoan.MaHS WHERE TaiKhoan.MaHS IS NULL ORDER BY CAST(SUBSTRING((HocSinh.MaHS), 8, LEN(HocSinh.MaHS) - 7) AS INT) DESC");
                    using (SqlCommand cmd = new SqlCommand(duLieuDanhSachHocSinh, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            if (ds.HasRows)
                            {
                                DataTable danhSachSachHocSinh = new DataTable();
                                danhSachSachHocSinh.Load(ds);
                                cbxThongTinLienKet.DataSource = danhSachSachHocSinh;
                                cbxThongTinLienKet.DisplayMember = "MaHS";
                            }
                            else
                            {

                                MessageBox.Show("Vui lòng tạo thêm học sinh mới", "Thông Báo", MessageBoxButtons.OK);
                                frmThemHocSinh fThemHS = new frmThemHocSinh();
                                this.Hide();
                                fThemHS.FormClosed += (s, agrs) =>
                                {
                                    frmThemTaiKhoan_Load(sender, e);
                                    this.Show();
                                };
                                fThemHS.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "" && txtTKDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu", "Thông Báo", MessageBoxButtons.OK);
                txtTKDangNhap.Focus();
            }
            else if (txtTKDangNhap.Text == "" && txtMatKhau.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông Báo", MessageBoxButtons.OK);
                txtTKDangNhap.Focus();
            }
            else if (txtTKDangNhap.Text != "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông Báo", MessageBoxButtons.OK);
                txtMatKhau.Focus();
            }
            else
            {
                try
                {
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();

                        string taiKhoan = txtTKDangNhap.Text.Trim();
                        string matKhau = txtMatKhau.Text.Trim();
                        string LoaiTK = cbxLoaiTK.Text.Trim();
                        string thongTinCanThem = "";
                        string maCanThem = cbxThongTinLienKet.Text.Trim();
                        if (cbxLoaiTK.Text.Trim() == "teacher")
                        {
                            thongTinCanThem = "MaGV";
                        }
                        else if (cbxLoaiTK.Text.Trim() == "student")
                        {
                            thongTinCanThem = "MaHS";
                        }
                        string themTaiKhoan = string.Format("insert into TaiKhoan(TKDangNhap,MatKhau,LoaiTK,{0}) values('{1}','{2}','{3}','{4}')", thongTinCanThem, taiKhoan, matKhau, LoaiTK, maCanThem);
                        using (SqlCommand lenhThem = new SqlCommand(themTaiKhoan, ketNoi))
                        {
                            lenhThem.ExecuteNonQuery();
                            frmThemTaiKhoan_Load(sender, e);
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
