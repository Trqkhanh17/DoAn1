using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh.QuanLiHocSinh
{
    public partial class frmSuaHocSinh : Form
    {
        public frmSuaHocSinh()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void txtMaHocSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtTenHocSinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtSoDienThoai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtNamHoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        public string MaHocSinhCanSua { get; set; }
        public string TenHocSinhCanSua { get; set; }
        public string GioiTinhHocSinhCanSua { get; set; }
        public string SoDienThoaiHocSinhCanSua { get; set; }
        public string DiaChiHocSinhCanSua { get; set; }
        public string MaLopCanSua { get; set; }
        public string NamHocCanSua { get; set; }
        public string NgaySinhCanSua { get; set; }

        private void frmSuaHocSinh_Load(object sender, EventArgs e)
        {
            frmSuaHocSinh_Load(sender, e, cbxMaLop);
        }
        private void frmSuaHocSinh_Load(object sender, EventArgs e, ComboBox cbxMaLop)
        {
            string[] gioiTinh = { "Nam", "Nữ" };
            cbxGioiTinh.DataSource = gioiTinh;
            txtMaHocSinh.Text = MaHocSinhCanSua.Trim();
            txtTenHocSinh.Text = TenHocSinhCanSua.Trim();
            txtDiaChi.Text = DiaChiHocSinhCanSua.Trim();
            txtSoDienThoai.Text = SoDienThoaiHocSinhCanSua.Trim();
            txtNamHoc.Text = NamHocCanSua.Trim();
            cbxGioiTinh.Text = GioiTinhHocSinhCanSua.Trim();
            cbxMaLop.Text = MaHocSinhCanSua.Trim();
            txtMaHocSinh.Enabled = false;
            DateTime dateTime;
            if (DateTime.TryParse(NgaySinhCanSua, out dateTime))
            {
                dtpNgaySinh.Value = dateTime;
            }
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string duLieuDanhSachLop = string.Format("SELECT MaLop FROM Lop");
                    using (SqlCommand cmd = new SqlCommand(duLieuDanhSachLop, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable danhSachLop = new DataTable();
                            danhSachLop.Load(ds);
                            cbxMaLop.DataSource = danhSachLop;
                            cbxMaLop.DisplayMember = "MaLop";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi", "Thông báo", MessageBoxButtons.OK);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnSua);
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
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
                MessageBox.Show("Số điện thoại chỉ có 10 số", "Thông báo", MessageBoxButtons.OK);
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
                        int namHoc = Convert.ToInt32(NamHoc);
                        ketNoi.Open();
                        string sqlSua = string.Format("update HocSinh set TenHS = N'{0}',NgaySinh = '{1}',SDT = '{2}',GioiTinh = '{3}',DiaChi = '{4}',MaLop = '{5}',NamHoc = {6} where MaHS = '{7}'", tenHocSinh, ngaySinhSQL, soDienThoai, gioiTinh, diaChi, maLop, namHoc, maHocSinh);
                        using (SqlCommand lenhSua = new SqlCommand(sqlSua, ketNoi))
                        {
                            lenhSua.ExecuteNonQuery();
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
