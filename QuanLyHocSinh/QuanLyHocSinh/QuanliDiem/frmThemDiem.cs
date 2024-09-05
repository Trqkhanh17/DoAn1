using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.QuanliDiem
{
    public partial class frmThemDiem : Form
    {
        public frmThemDiem()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private string TaoMaDiem()
        {
            string maMoi = "";

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
            {
                ketNoi.Open();
                // Truy vấn để lấy ra mã học sinh lớn nhất
                string sql = "SELECT MaDiem FROM DiemSo";
                using (SqlCommand cmd = new SqlCommand(sql, ketNoi))
                {
                    using (SqlDataReader ds = cmd.ExecuteReader())
                    {
                        if (ds.HasRows)
                        {
                            DataTable dsMaHS = new DataTable();
                            dsMaHS.Load(ds);
                            string chuoiSo = "";
                            int maxId = 0;
                            foreach (DataRow row in dsMaHS.Rows)
                            {
                                string maHS = row["MaDiem"].ToString();
                                chuoiSo = maHS.Substring(2);
                                if (int.TryParse(chuoiSo, out int so))
                                {
                                    if (so > maxId)
                                    {
                                        maxId = so;
                                    }
                                }
                            }
                            maMoi = "MD" + (maxId + 1);
                        }
                        else
                        {
                            maMoi = "MD1";
                        }
                    }
                }
            }

            return maMoi;
        }
        private void DSHocSinh()
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanMaHS = string.Format("SELECT MaHS FROM HocSinh ORDER BY CAST(SUBSTRING(MaHS, 8, LEN(MaHS) - 7) AS INT) DESC");
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
                    string truyVanMaGV = string.Format("SELECT MaGV FROM GV ORDER BY CAST(SUBSTRING(MaGV, 8, LEN(MaGV) - 7) AS INT) DESC");
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

        private void frmThemDiem_Load(object sender, EventArgs e)
        {
            txtMaDiem.Text = TaoMaDiem();
            DSGiaoVien();
            DSHocSinh();
            DSLop();
            DSMonHoc();
            string[] HocKi = { "I", "II" };
            cbxHocKi.DataSource = HocKi;
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnThem);
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
        }
        
        private void btnThem_Click(object sender, EventArgs e)
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
                MessageBox.Show("Điểm chỉ lớn hơn hoặc bằng 0");
                txtDiem15.Focus();
            }
            else if (Convert.ToInt32(txtDiemGiuaKi.Text) < 0 || Convert.ToInt32(txtDiemGiuaKi.Text) > 10)
            {
                MessageBox.Show("Điểm chỉ lớn hơn hoặc bằng 0");
                txtDiemGiuaKi.Focus();
            }
            else if (Convert.ToInt32(txtDiemCuoiKi.Text) < 0 || Convert.ToInt32(txtDiemCuoiKi.Text) > 10)
            {
                MessageBox.Show("Điểm chỉ lớn hơn hoặc bằng 0");
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
                        string sqlThem = string.Format("insert into DiemSo values('{0}','{1}','{2}','{3}','{4}',{5},{6},{7},'{8}')", maDiem, maHS, maMon, maGV, maLop, diem15p, diemGiuaKi, diemCuoiKi, hocKi);
                        using (SqlCommand cmdThem = new SqlCommand(sqlThem,ketNoi))
                        {
                            cmdThem.ExecuteNonQuery();
                            frmThemDiem_Load(sender, e);
                            MessageBox.Show("Thêm Thành Công","Thông Báo",MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm Thất Bại" + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
