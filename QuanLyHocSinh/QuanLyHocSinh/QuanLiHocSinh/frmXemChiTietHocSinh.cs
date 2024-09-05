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

namespace QuanLyHocSinh.QuanLiHocSinh
{
    public partial class frmXemChiTietHocSinh : Form
    {
        public frmXemChiTietHocSinh()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaHocSinhCanXem { get; set; }

        private void frmXemChiTietHocSinh_Load(object sender, EventArgs e)
        {
            string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string tryVanDuLieuHocSinh = string.Format("select *from HocSinh where MaHS = '{0}'", MaHocSinhCanXem.Trim());
                    using (SqlCommand cmd = new SqlCommand(tryVanDuLieuHocSinh, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable ttHocSinh = new DataTable();
                            ttHocSinh.Load(ds);
                            lblMaHS.Text = "Mã Học Sinh: " + ttHocSinh.Rows[0]["MaHS"].ToString().Trim();
                            lblTenHS.Text = "Tên Học Sinh: " + ttHocSinh.Rows[0]["TenHS"].ToString().Trim();
                            lblGioiTinh.Text = "Giới Tính: " + ttHocSinh.Rows[0]["GioiTinh"].ToString().Trim();
                            lblDiaChi.Text = "Địa Chỉ: " + ttHocSinh.Rows[0]["DiaChi"].ToString().Trim();
                            lblSDT.Text = "Số Điện Thoại: " + ttHocSinh.Rows[0]["SDT"].ToString().Trim();
                            lblLop.Text = "Lớp: " + ttHocSinh.Rows[0]["MaLop"].ToString().Trim();
                            lblNamHoc.Text = "Năm Học: " + ttHocSinh.Rows[0]["NamHoc"].ToString().Trim();
                            DateTime ngaySinh = (DateTime)ttHocSinh.Rows[0]["NgaySinh"];
                            lblNgaySinh.Text = "Ngày Sinh: "+ngaySinh.ToString("dd/MM/yyyy");
                        }
                    }
                    string duLieuTaiKhoan = string.Format("SELECT TKDangNhap FROM TaiKhoan WHERE MaHS = '{0}'", MaHocSinhCanXem.Trim());
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
