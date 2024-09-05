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

namespace QuanLyHocSinh.QuanLiGiaoVien
{
    public partial class frmXemChiTietGiaoVien : Form
    {
        public frmXemChiTietGiaoVien()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaGiaoVienCanXem { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmXemChiTietGiaoVien_Load(object sender, EventArgs e)
        {
            string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string tryVanDuLieuGiaoVien = string.Format("select *from GV where MaGV = '{0}'", MaGiaoVienCanXem.Trim());
                    using (SqlCommand cmd = new SqlCommand(tryVanDuLieuGiaoVien, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable ttGiaoVien = new DataTable();
                            ttGiaoVien.Load(ds);

                            lblMaGV.Text = "Mã Giáo Viên: " + ttGiaoVien.Rows[0]["MaGV"].ToString().Trim();
                            lblTenGV.Text = "Tên Giáo Viên: " + ttGiaoVien.Rows[0]["TenGV"].ToString().Trim();
                            lblGioiTinh.Text = "Giới Tính: " + ttGiaoVien.Rows[0]["GioiTinh"].ToString().Trim();
                            lblDiaChi.Text = "Địa Chỉ: " + ttGiaoVien.Rows[0]["DiaChi"].ToString().Trim();
                            lblSDT.Text = "Số Điện Thoại: " + ttGiaoVien.Rows[0]["SDT"].ToString().Trim();
                        }
                    }
                    string duLieuMonHoc = string.Format("select MaLop from Lop where MaGVCN = '{0}'", MaGiaoVienCanXem.Trim());
                    using (SqlCommand DSMonHoc = new SqlCommand(duLieuMonHoc, ketNoi))
                    {
                        object result = DSMonHoc.ExecuteScalar();
                        if (result != null)
                        {
                            lblLop.Text = "Chủ Nhiệm Lớp: " + result.ToString();
                        }
                        else
                        {
                            lblLop.Text = "";
                        }
                    }
                    string duLieuTaiKhoan = string.Format("SELECT TKDangNhap FROM TaiKhoan WHERE MaGV = '{0}'", MaGiaoVienCanXem.Trim());
                    using (SqlCommand DSTaiKhoan = new SqlCommand(duLieuTaiKhoan, ketNoi))
                    {
                        object result = DSTaiKhoan.ExecuteScalar();
                        if (result != null)
                        {
                            lblTaiKhoan.Text = "Tài Khoản Liên Kết: " + result.ToString();
                        }
                        else
                        {
                            lblTaiKhoan.Text = "Tài Khoản Liên Kết: ";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
