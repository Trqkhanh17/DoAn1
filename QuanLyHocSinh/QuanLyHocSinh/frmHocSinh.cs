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

namespace QuanLyHocSinh
{
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        public string maHS { get; set; }
        public string taiKhoan { get; set; }
        public string matKhau { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string tryVanDuLieuHocSinh = string.Format("select *from HocSinh where MaHS = '{0}'", maHS.Trim());
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
                            lblNgaySinh.Text = "Ngày Sinh: " + ngaySinh.ToString("dd/MM/yyyy");
                        }
                    }
                    string duLieuTaiKhoan = string.Format("SELECT TKDangNhap FROM TaiKhoan WHERE MaHS = '{0}'", maHS.Trim());
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
                    string sqlDanhSachDiemSo = string.Format("select MonHoc.TenMon,Diem15p,DiemGiuaKi,DiemCuoiKi,(Diem15p + DiemGiuaKi + (DiemCuoiKi*2))/4 AS DiemTrungBinh," +
                        "HocKi from DiemSo,MonHoc where DiemSo.MaHS = '{0}' and MonHoc.MaMon = DiemSo.MaMon", maHS.Trim());
                    using (SqlCommand cmdDanhSach = new SqlCommand(sqlDanhSachDiemSo, ketNoi))
                    {
                        SqlDataReader ds = cmdDanhSach.ExecuteReader();
                        if (ds.HasRows)
                        {
                            DataTable dsDiemSo = new DataTable();
                            dsDiemSo.Load(ds);
                            dgvDiemSo.DataSource = dsDiemSo;
                        }
                        else
                        {
                            dgvDiemSo.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomizeDataGridView(dgvDiemSo);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuaTaiKhoan fSuaTK = new frmSuaTaiKhoan();
            this.Hide();
            fSuaTK.TaiKhoanCanSua = taiKhoan.Trim();
            fSuaTK.MatKhauCanSua = matKhau.Trim();
            fSuaTK.FormClosed += (s, agrs) =>
            {
                this.Show();
            };
            fSuaTK.ShowDialog();
        }
        private bool autoYesformClosing = false;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoYesformClosing = true;
            // Mở lại form đăng nhập
            frmDangNhap fDangNhap = new frmDangNhap();
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHocSinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!autoYesformClosing)
            {
                DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            /*    else
                 {
                     ktraformClosing = true ;
                     this.Close ();
                 }*/
            autoYesformClosing = false;
        }
    }
}
