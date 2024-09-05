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

namespace QuanLyHocSinh.QuanLiTaiKhoan
{
    public partial class frmSuaTaiKhoan : Form
    {
        public frmSuaTaiKhoan()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string TaiKhoanCanSua { get; set; }
        public string MatKhauCanSua { get; set; }
        public string LoaiTaiKhoan { get; set; }
        //public string LoaiTaiKhoan { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void frmSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = TaiKhoanCanSua.ToString().Trim();
            txtMatKhau.Text = MatKhauCanSua.ToString().Trim();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text = TaiKhoanCanSua.ToString().Trim();
            string newPassword = txtMatKhau.Text.Trim();
            if (txtMatKhau.Text == "" || txtMatKhau.Text == null)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (txtMatKhau.Text.Contains(" ") == true)
            {
                MessageBox.Show("Vui lòng không nhập khoản trắng ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn Có Chắc Chắc Muốn Thay Đổi Mật Khẩu Này Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            //update lai mat khau moi
                            string sqlSuaTK = string.Format("update TaiKhoan set MatKhau = '{0}' where TKDangNhap = '{1}'", newPassword, tk);
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
                else
                {
                    return;
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
