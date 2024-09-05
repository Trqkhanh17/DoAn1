using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.QuanLiGiaoVien
{
    public partial class frmThemGiaoVien : Form
    {
        public frmThemGiaoVien()
        {
            InitializeComponent();
            txtDiaChi.KeyDown += new KeyEventHandler(txtDiaChi_KeyDown);
            txtMaGV.KeyDown += new KeyEventHandler(txtMaGV_KeyDown);
            txtSDT.KeyDown += new KeyEventHandler(txtSDT_KeyDown);
            txtTenGV.KeyDown += new KeyEventHandler(txtTenGV_KeyDown);
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        function fc = new function();
        private string TaoMaGiaoVien()
        {
            string maMoi = "";

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
            {
                ketNoi.Open();
                // Truy vấn để lấy ra mã học sinh lớn nhất
                string sql = "SELECT MaGV FROM GV";
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
                                string maHS = row["MaGV"].ToString();
                                chuoiSo = maHS.Substring(7);
                                if (int.TryParse(chuoiSo, out int so))
                                {
                                    if (so > maxId)
                                    {
                                        maxId = so;
                                    }
                                }
                            }
                            maMoi = "teacher" + (maxId + 1);
                        }
                        else
                        {
                            maMoi = "teacher1";
                        }
                    }
                }
            }

            return maMoi;
        }
        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtMaGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtTenGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        // Hàm tạo mã mới cho giáo viên
        

        private void frmThemGiaoVien_Load(object sender, EventArgs e)
        {
            string[] danhSachGioiTinh = { "Nam", "Nữ" };
            cbxGioiTinh.DataSource = danhSachGioiTinh;
            txtMaGV.Text = TaoMaGiaoVien();
            this.FormBorderStyle = FormBorderStyle.None;
            txtMaGV.Enabled = false;
            function fc = new function();
            fc.CustomTextBox(txtMaGV);
            fc.CustomTextBox(txtSDT);
            fc.CustomTextBox(txtTenGV);
            fc.CustomTextBox(txtDiaChi);
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnThem);
            fc.CustomComboBox(cbxGioiTinh);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenGV.Text == "" && txtDiaChi.Text == "" && txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống các thông tin của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtTenGV.Focus();
            }
            else if (txtTenGV.Text == "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                MessageBox.Show("Vui lòng điền tên của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtTenGV.Focus();
            }
            else if (txtTenGV.Text != "" && txtDiaChi.Text == "" && txtSDT.Text != "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else if (txtTenGV.Text != "" && txtDiaChi.Text != "" && txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (txtTenGV.Text == "" && txtDiaChi.Text == "" && txtSDT.Text != "")
            {
                MessageBox.Show("Vui lòng điền tên và địa chỉ của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtTenGV.Focus();
            }
            else if (txtTenGV.Text == "" && txtDiaChi.Text != "" && txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên và số điện thoại của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtTenGV.Focus();
            }
            else if (txtTenGV.Text != "" && txtDiaChi.Text == "" && txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng điền địa chỉ và số điện thoại của giáo viên", "Thông Báo", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (fc.checkKiTuDatBiet_Ten(txtTenGV.Text) == true)
            {
                MessageBox.Show("Tên giáo viên không được chứa kí tự đặt biệt", "Thông Báo", MessageBoxButtons.OK);
                txtMaGV.Focus();
            }
            else if (fc.checkNum(txtSDT.Text.Trim()) == false)
            {
                MessageBox.Show("Số điện thoại phải là các con số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (fc.checkNum(txtSDT.Text) == false)
            {
                MessageBox.Show("Số điện thoại chỉ có thể là số");
                txtSDT.Focus();
            }
            else if (txtSDT.Text.Trim().Contains(" ") == true)
            {
                MessageBox.Show("Vui lòng không nhập khoảng trắng vào số điện thoại", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("Số điện thoại chỉ có thể là 10 số", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (fc.checkStart(txtSDT.Text.Trim()) == false)
            {
                MessageBox.Show("Số điện thoại phải bắt đầu là 0", "Thông báo", MessageBoxButtons.OK);
                txtSDT.Focus();
            }
            else if (fc.checkStartTeacher(txtMaGV.Text.Trim()) == false)
            {
                MessageBox.Show("Mã giáo viên phải bắt đầu từ Teacher", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        txtMaGV.Text = TaoMaGiaoVien().ToString().Trim();
                        string maGiaoVien = txtMaGV.Text.Trim();
                        string tenGiaoVien = txtTenGV.Text.Trim();
                        string diaChi = txtDiaChi.Text.Trim();
                        string SDT = txtSDT.Text.Trim();
                        string gioiTinh = cbxGioiTinh.Text.Trim();
                        ketNoi.Open();
                        //them giao vien
                        string sqlThem = string.Format("insert into GV values('{0}',N'{1}',N'{2}','{3}',N'{4}')", maGiaoVien, tenGiaoVien, SDT, gioiTinh, diaChi);
                        using (SqlCommand lenhThemGV = new SqlCommand(sqlThem, ketNoi))
                        {
                            lenhThemGV.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                            frmThemGiaoVien_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
