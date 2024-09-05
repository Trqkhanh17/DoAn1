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

namespace QuanLyHocSinh.QuanliDiem
{
    public partial class frmSuaDiem : Form
    {
        public frmSuaDiem()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaDiemCanSua { get; set; }
        public string MaHSCanSua { get; set; }
        public string MaMonCanSua { get; set; }
        public string MaGVCanSua { get; set; }
        public string MaLopCanSua { get; set; }
        public string Diem15pCanSua { get; set; }
        public string DiemGiuaKiCanSua { get; set; }
        public string DiemCuoiKiCanSua { get; set; }
        public string HocKiCanSua { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void DSHocSinh()
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanMaHS = string.Format("select MaHS from HocSinh");
                    using (SqlCommand cmdDSHocSinh = new SqlCommand(truyVanMaHS, ketNoi))
                    {
                        using (SqlDataReader ds = cmdDSHocSinh.ExecuteReader())
                        {
                            DataTable dsHocSinh = new DataTable();
                            dsHocSinh.Load(ds);
                            cbxMaHS.DataSource = dsHocSinh;
                            cbxMaHS.DisplayMember = "MaHS";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void DSMonHoc()
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanMaMonHoc = string.Format("select MaMon from MonHoc");
                    using (SqlCommand cmdDSMonHoc = new SqlCommand(truyVanMaMonHoc, ketNoi))
                    {
                        using (SqlDataReader ds = cmdDSMonHoc.ExecuteReader())
                        {
                            DataTable dsMonHoc = new DataTable();
                            dsMonHoc.Load(ds);
                            cbxMaMonHoc.DataSource = dsMonHoc;
                            cbxMaMonHoc.DisplayMember = "MaMon";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void DSGiaoVien()
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanMaGV = string.Format("select MaGV from GV");
                    using (SqlCommand cmdDSGiaoVien = new SqlCommand(truyVanMaGV, ketNoi))
                    {
                        using (SqlDataReader ds = cmdDSGiaoVien.ExecuteReader())
                        {
                            DataTable dsGiaoVien = new DataTable();
                            dsGiaoVien.Load(ds);
                            cbxMaGiaoVien.DataSource = dsGiaoVien;
                            cbxMaGiaoVien.DisplayMember = "MaGV";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void DSLop()
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanMaLop = string.Format("select MaLop from Lop");
                    using (SqlCommand cmdDSLop = new SqlCommand(truyVanMaLop, ketNoi))
                    {
                        using (SqlDataReader ds = cmdDSLop.ExecuteReader())
                        {
                            DataTable dsLop = new DataTable();
                            dsLop.Load(ds);
                            cbxMaLop.DataSource = dsLop;
                            cbxMaLop.DisplayMember = "MaLop";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void frmSuaDiem_Load(object sender, EventArgs e)
        {
            DSGiaoVien();
            DSHocSinh();
            DSLop();
            DSMonHoc();
            string[] hocKi = { "I", "II" };
            cbxHocKi.DataSource = hocKi;
            txtMaDiem.Text = MaDiemCanSua;
            cbxMaHS.Text = MaHSCanSua;
            cbxMaMonHoc.Text = MaMonCanSua;
            cbxMaGiaoVien.Text = MaGVCanSua;
            cbxMaLop.Text = MaLopCanSua;
            txtDiem15.Text = Diem15pCanSua;
            txtDiemGiuaKi.Text = DiemGiuaKiCanSua;
            txtDiemCuoiKi.Text = DiemCuoiKiCanSua;
            cbxHocKi.Text = HocKiCanSua;
            function fc = new function();
            fc.CustomButton(btnSua);
            fc.CustomButton(btnThoat);
            fc.CustomTextBox(txtDiem15);
            fc.CustomTextBox(txtDiemCuoiKi);
            fc.CustomTextBox(txtDiemGiuaKi);
            fc.CustomTextBox(txtMaDiem);
            fc.CustomComboBox(cbxHocKi);
            fc.CustomComboBox(cbxMaGiaoVien);
            fc.CustomComboBox(cbxMaHS);
            fc.CustomComboBox(cbxMaLop);
            fc.CustomComboBox(cbxMaMonHoc);
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            function fc = new function();
            if (txtDiem15.Text == "" && txtDiemCuoiKi.Text == "" && txtDiemGiuaKi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các điểm cần thêm", "Thông Báo", MessageBoxButtons.OK);
                txtDiem15.Focus();
            }
            else if (txtDiem15.Text == "" && txtDiemCuoiKi.Text != "" && txtDiemGiuaKi.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm 15 phút");
                txtDiem15.Focus();
            }
            else if (txtDiem15.Text != "" && txtDiemCuoiKi.Text != "" && txtDiemGiuaKi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm giữa kì");
                txtDiemGiuaKi.Focus();
            }
            else if (txtDiem15.Text != "" && txtDiemCuoiKi.Text == "" && txtDiemGiuaKi.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm cuối kì");
                txtDiemCuoiKi.Focus();
            }
            else if (txtDiem15.Text == "" && txtDiemCuoiKi.Text != "" && txtDiemGiuaKi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm 15 phút và giữa kì");
                txtDiem15.Focus();
            }
            else if (txtDiem15.Text == "" && txtDiemCuoiKi.Text == "" && txtDiemGiuaKi.Text != "")
            {
                MessageBox.Show("Vui lòng nhập điểm 15 phút và cuối kì");
                txtDiem15.Focus();
            }
            else if (txtDiem15.Text != "" && txtDiemCuoiKi.Text == "" && txtDiemGiuaKi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm giữa kì và cuối kì");
                txtDiemGiuaKi.Focus();
            }
            else if (fc.checkNum(txtDiem15.Text) == false)
            {
                MessageBox.Show("Điểm chỉ có thể là số");
                txtDiem15.Clear();
                txtDiem15.Focus();
            }
            else if (fc.checkNum(txtDiemGiuaKi.Text) == false)
            {
                MessageBox.Show("Điểm chỉ có thể là số");
                txtDiemGiuaKi.Clear();
                txtDiemGiuaKi.Focus();
            }
            else if (fc.checkNum(txtDiemCuoiKi.Text) == false)
            {
                MessageBox.Show("Điểm chỉ có thể là số");
                txtDiemCuoiKi.Clear();
                txtDiemCuoiKi.Focus();
            }
            else if (Convert.ToInt32(txtDiem15.Text) < 0 || Convert.ToInt32(txtDiem15.Text) > 10)
            {
                MessageBox.Show("Điểm chỉ lớn hơn hoặc bằng 0 và tối đa là 10");
                txtDiem15.Focus();
            }
            else if (Convert.ToInt32(txtDiemGiuaKi.Text) < 0 || Convert.ToInt32(txtDiemGiuaKi.Text) > 10)
            {
                MessageBox.Show("Điểm chỉ lớn hơn hoặc bằng 0 và tối đa là 10");
                txtDiemGiuaKi.Focus();
            }
            else if (Convert.ToInt32(txtDiemCuoiKi.Text) < 0 || Convert.ToInt32(txtDiemCuoiKi.Text) > 10)
            {
                MessageBox.Show("Điểm chỉ lớn hơn hoặc bằng 0 và tối đa là 10");
                txtDiemCuoiKi.Focus();
            }
            else
            {
                try
                {
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        string maDiem = txtMaDiem.Text.Trim();
                        string maHS = cbxMaHS.Text.Trim();
                        string maMon = cbxMaMonHoc.Text.Trim();
                        string maGV = cbxMaGiaoVien.Text.Trim();
                        string maLop = cbxMaLop.Text.Trim();
                        int diem15p = Convert.ToInt32(txtDiem15.Text.Trim());
                        int diemGiuaKi = Convert.ToInt32(txtDiemGiuaKi.Text.Trim());
                        int diemCuoiKi = Convert.ToInt32(txtDiemCuoiKi.Text.Trim());
                        string hocKi = cbxHocKi.Text.Trim();
                        ketNoi.Open();
                        string sqlSua = string.Format("UPDATE DiemSo SET MaHS = '{0}',MaMon = '{1}',MaGV = '{2}',MaLop = '{3}',Diem15p = {4},DiemGiuaKi = {5},DiemCuoiKi = {6},HocKi = '{7}' where MaDiem = '{8}'", maHS, maMon, maGV, maLop, diem15p, diemGiuaKi, diemCuoiKi, hocKi, maDiem);
                        using (SqlCommand cmdSua = new SqlCommand(sqlSua, ketNoi))
                        {
                            cmdSua.ExecuteNonQuery();
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
