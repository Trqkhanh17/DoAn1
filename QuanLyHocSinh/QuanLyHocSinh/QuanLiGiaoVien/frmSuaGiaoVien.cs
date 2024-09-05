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
    public partial class frmSuaGiaoVien : Form
    {
        public frmSuaGiaoVien()
        {
            InitializeComponent();
            txtDiaChi.KeyDown += new KeyEventHandler(txtDiaChi_KeyDown);
            txtMaGV.KeyDown += new KeyEventHandler(txtMaGV_KeyDown);
            txtSDT.KeyDown += new KeyEventHandler(txtSDT_KeyDown);
            txtTenGV.KeyDown += new KeyEventHandler(txtTenGV_KeyDown);
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaGiaoVienCanSua { get; set; }
        public string TenGiaoVienCanSua { get; set; }
        public string SoDienThoaiGiaoVienCanSua { get; set; }
        public string DiaChiGiaoVienCanSua { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtMaGV_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtTenGV_KeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender,e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void frmSuaGiaoVien_Load(object sender, EventArgs e)
        {
            string[] danhSachGioiTinh = { "Nam", "Nữ" };
            cbxGioiTinh.DataSource = danhSachGioiTinh;
            txtMaGV.Text = MaGiaoVienCanSua.ToString().Trim();
            txtTenGV.Text = TenGiaoVienCanSua.ToString().Trim();
            txtDiaChi.Text = DiaChiGiaoVienCanSua.ToString().Trim();
            txtSDT.Text = SoDienThoaiGiaoVienCanSua.ToString().Trim();
            txtMaGV.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomTextBox(txtMaGV);
            fc.CustomTextBox(txtSDT);
            fc.CustomTextBox(txtTenGV);
            fc.CustomTextBox(txtDiaChi);
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnSua);
            fc.CustomComboBox(cbxGioiTinh);

        }

        function fc = new function();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maGiaoVien = txtMaGV.Text.Trim();
            string newTenGiaoVien = txtTenGV.Text.Trim();
            string newGioiTinh = cbxGioiTinh.Text.Trim();
            string newSoDienThoai = txtSDT.Text.Trim();
            string newDiaChi = txtDiaChi.Text.Trim();
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
                    string sqlSuaTK = string.Format("update GV set TenGV = N'{0}', GioiTinh = N'{1}', SDT = '{2}', DiaChi = N'{3}' where MaGV = '{4}'", newTenGiaoVien, newGioiTinh, newSoDienThoai, newDiaChi, maGiaoVien);
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        using (SqlCommand lenhSua = new SqlCommand(sqlSuaTK, ketNoi))
                        {
                            lenhSua.ExecuteNonQuery();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
