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
    public partial class frmThemHocSinh : Form
    {
        public frmThemHocSinh()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void txtMaHocSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtTenHocSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtSoDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
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
        private void txtNamHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void frmThemHocSinh_Load(object sender, EventArgs e)
        {
            string[] danhSachGioiTinh = { "Nam", "Nữ" };
            cbxGioiTinh.DataSource = danhSachGioiTinh;
            try
            {
                SqlConnection ketNoi = new SqlConnection(chuoiKN);
                ketNoi.Open();
                string duLieuDanhSachLop = string.Format("select MaLop from Lop");
                SqlCommand cmd = new SqlCommand(duLieuDanhSachLop, ketNoi);
                SqlDataReader ds = cmd.ExecuteReader();
                DataTable danhSachLop = new DataTable();
                danhSachLop.Load(ds);
                cbxMaLop.DataSource = danhSachLop;
                cbxMaLop.DisplayMember = "MaLop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }
            txtMaHocSinh.Text = TaoMaHocSinh();
            txtMaHocSinh.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnThem);
            fc.CustomButton(btnThoat);
            fc.CustomTextBox(txtDiaChi);
            fc.CustomTextBox(txtMaHocSinh);
            fc.CustomTextBox(txtSoDienThoai);
            fc.CustomTextBox(txtTenHocSinh);
            fc.CustomTextBox(txtNamHoc);
            fc.CustomComboBox(cbxGioiTinh);
            fc.CustomComboBox(cbxMaLop);
            fc.CustomeDateTimePicker(dtpNgaySinh);
        }
        private string TaoMaHocSinh()
        {
            string maMoi = "";

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
            {
                ketNoi.Open();
                // Truy vấn để lấy ra mã học sinh lớn nhất
                string sql = "SELECT MaHS FROM HocSinh";
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
                                string maHS = row["MaHS"].ToString();
                                    chuoiSo = maHS.Substring(7);
                                    if (int.TryParse(chuoiSo, out int so))
                                    {
                                        if (so > maxId)
                                        {
                                            maxId = so;
                                        }
                                    }
                            }
                            maMoi = "student" + (maxId + 1);
                        }
                        else
                        {
                            maMoi = "student1";
                        }
                    }
                }
            }

            return maMoi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            function fc = new function();
            string maHocSinh = txtMaHocSinh.Text.Trim();
            string tenHocSinh = txtTenHocSinh.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string gioiTinh = cbxGioiTinh.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;
            string ngaySinhSQL = ngaySinh.ToString("yyyy-MM-dd");
            string maLop = cbxMaLop.Text.Trim();
            string NamHoc = txtNamHoc.Text.Trim();
            if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text == "" && txtDiaChi.Text == "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống bất cứ thông tin của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text != "" && txtDiaChi.Text != "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tên của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text == "" && txtDiaChi.Text != "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtSoDienThoai.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text != "" && txtDiaChi.Text == "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text != "" && txtDiaChi.Text != "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm học", "Thông Báo", MessageBoxButtons.OK);
                txtNamHoc.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text == "" && txtDiaChi.Text != "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text != "" && txtDiaChi.Text == "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tên và địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text != "" && txtDiaChi.Text != "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên và năm học của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text == "" && txtDiaChi.Text == "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại và địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtSoDienThoai.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text == "" && txtDiaChi.Text != "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại và năm học của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtSoDienThoai.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text != "" && txtDiaChi.Text == "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm học và địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
            }
            else if (txtTenHocSinh.Text != "" && txtSoDienThoai.Text == "" && txtDiaChi.Text == "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm học,số điện thoại và địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtSoDienThoai.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text != "" && txtDiaChi.Text == "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm học,tên và địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text == "" && txtDiaChi.Text != "" && txtNamHoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm học,số điện thoại và tên của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (txtTenHocSinh.Text == "" && txtSoDienThoai.Text == "" && txtDiaChi.Text == "" && txtNamHoc.Text != "")
            {
                MessageBox.Show("Vui lòng nhập tên,số điện thoại và địa chỉ của học sinh", "Thông Báo", MessageBoxButtons.OK);
                txtTenHocSinh.Focus();
            }
            else if (fc.checkKiTuDatBiet_Ten(txtTenHocSinh.Text) == true)
            {
                MessageBox.Show("Tên học sinh không được chứa kí tự đặt biệt", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (fc.checkNum(soDienThoai) == false)
            {
                MessageBox.Show("Số điện thoại chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
            }
            else if (soDienThoai.Length != 10)
            {
                MessageBox.Show("Số điện thoại chỉ có thể là 10 số", "Thông báo", MessageBoxButtons.OK);
            }
            else if (fc.checkStart(soDienThoai) == false)
            {
                MessageBox.Show("Số điện thoại phải bắt đầu từ 0", "Thông báo", MessageBoxButtons.OK);
            }
            else if (fc.checkStartStudent(maHocSinh) == false)
            {
                MessageBox.Show("Mã học sinh phải bắt đầu là student ví dụ student001,...", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (ngaySinh.Year >= DateTime.Now.Year)
            {
                MessageBox.Show("Năm sinh phải bé hơn năm hiện tại", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (fc.checkNum(NamHoc) == false)
            {
                MessageBox.Show("Năm sinh phải là một số", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (Convert.ToInt32(txtNamHoc.Text) > Convert.ToInt32(DateTime.Now.Year.ToString()))
            {
                MessageBox.Show("Năm học phải nhỏ hơn hoặc bằng năm hiện tại", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        int namHoc = Convert.ToInt32(txtNamHoc.Text.Trim());
                        ketNoi.Open();
                        string sqlThem = string.Format("insert into HocSinh values('{0}',N'{1}','{2}','{3}',N'{4}','{5}','{6}','{7}')", maHocSinh, tenHocSinh, ngaySinhSQL, gioiTinh, soDienThoai, diaChi, maLop, namHoc);
                        using (SqlCommand lenhThemHS = new SqlCommand(sqlThem, ketNoi))
                        {
                            lenhThemHS.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                            frmThemHocSinh_Load(sender, e);
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
