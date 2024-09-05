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

namespace QuanLyHocSinh.QuanLiLopHoc
{
    public partial class frmSuaLopHoc : Form
    {
        public frmSuaLopHoc()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string maLop { get; set; }
        public string SiSo { get; set; }
        public string giaoVienCN { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmSuaLopHoc_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string duLieuDanhSachGiaoVien = string.Format("SELECT MaGV FROM GV");
                    using (SqlCommand cmd = new SqlCommand(duLieuDanhSachGiaoVien, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable danhSachGiaoVien = new DataTable();
                            danhSachGiaoVien.Load(ds);
                            cbxMaGiaoVienCN.DataSource = danhSachGiaoVien;
                            cbxMaGiaoVienCN.DisplayMember = "MaGV";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông Báo", MessageBoxButtons.OK);
            }
            cbxMaGiaoVienCN.Text = giaoVienCN.ToString().Trim();
            txtMaLop.Text = maLop.ToString().Trim();
            txtSiSo.Text = SiSo.ToString().Trim();
            txtMaLop.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnSua);
            fc.CustomButton(btnThoat);
            fc.CustomComboBox(cbxMaGiaoVienCN);
            fc.CustomTextBox(txtMaLop);
            fc.CustomTextBox(txtSiSo);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maLopHoc = txtMaLop.Text.Trim();
            string siSo = txtSiSo.Text.Trim();
            string giaoVienChuNhiem = cbxMaGiaoVienCN.Text.Trim();
            function fc = new function();
            if (txtMaLop.Text == "" && txtSiSo.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin nào", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtSiSo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sỉ số lớp", "Thông báo", MessageBoxButtons.OK);
            }
            else if (fc.checkNum(siSo) == false)
            {
                MessageBox.Show("Sỉ số chỉ có thể là số", "Thông báo", MessageBoxButtons.OK);
            }
            else if (fc.checkStart(siSo) == true && siSo.Length > 1)
            {
                MessageBox.Show("Vui lòng không nhập 0 ở đầu sỉ số", "Thông báo", MessageBoxButtons.OK);
            }
            else if (Convert.ToInt32(siSo) < 0)
            {
                MessageBox.Show("Sỉ số phải lớn hơn hoặc bằng 0","Thông Báo",MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int SiSo = Convert.ToInt32(siSo);
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        string sqlSua = string.Format("UPDATE Lop SET SiSo = {0},MaGVCN = '{1}' WHERE MaLop = '{2}'", SiSo, giaoVienChuNhiem, maLopHoc);
                        using (SqlCommand lenhSua = new SqlCommand(sqlSua, ketNoi))
                        {
                            lenhSua.ExecuteNonQuery();
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSiSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
