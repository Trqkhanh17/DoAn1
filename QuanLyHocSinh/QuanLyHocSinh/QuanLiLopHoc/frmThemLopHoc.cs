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
    public partial class frmThemLopHoc : Form
    {
        public frmThemLopHoc()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmThemLopHoc_Load(object sender, EventArgs e)
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
                MessageBox.Show("Lỗi ", "Thông Báo", MessageBoxButtons.OK);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnThem);
            fc.CustomButton(btnThoat);
            fc.CustomComboBox(cbxMaGiaoVienCN);
            fc.CustomTextBox(txtMaLop);
            fc.CustomTextBox(txtSiSo);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();
            string siSo = txtSiSo.Text.Trim();
            string giaoVienChuNhiem = cbxMaGiaoVienCN.Text.Trim();
            function fc = new function();
            if (txtMaLop.Text == "" && txtSiSo.Text == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin nào", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtMaLop.Text == "" && txtSiSo.Text != "")
            {
                MessageBox.Show("Vui lòng nhập mã lớp", "Thông báo", MessageBoxButtons.OK);
            }
            else if (txtMaLop.Text != "" && txtSiSo.Text == "")
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
                MessageBox.Show("Sỉ số phải lớn hơn hoặc bằng 0", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    int SiSo = Convert.ToInt32(siSo);
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        string sqlThem = string.Format("insert into Lop values('{0}',{1},'{2}')", maLop, SiSo, giaoVienChuNhiem);
                        using (SqlCommand lenhThem = new SqlCommand(sqlThem, ketNoi))
                        {
                            lenhThem.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                            ketNoi.Close();
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

        private void txtMaLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSiSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
