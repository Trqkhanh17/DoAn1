using QuanLyHocSinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyHocSinh
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.KeyDown += new KeyEventHandler(txtMatKhau_KeyDown);
            txtTaiKhoan.KeyDown += new KeyEventHandler(txtTaiKhoan_KeyDown);
            txtTaiKhoan.Text = "Usename...";
            txtTaiKhoan.ForeColor = Color.Gray;
            txtMatKhau.Text = "Password...";
            txtMatKhau.ForeColor = Color.Gray;
            txtTaiKhoan.Enter += txtTaiKhoan_Enter;
            txtTaiKhoan.Leave += txtTaiKhoan_Leave;
            txtMatKhau.Enter += txtMatKhau_Enter;
            txtMatKhau.Leave += txtMatKhau_Leave;
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Password...")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.PasswordChar = '*';
        
            }
        }
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Password...";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.PasswordChar = '\0';
            }
        }
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Usename...")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }
        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                txtTaiKhoan.Text = "Usename...";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }
        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //đường dẫn kết nối csdl
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        //biến cờ dùng để xử lí khi đăng nhập vào trang khác form tự đóng mà không cần phải phải hỏi ý kiến ng dùng ở sự kiện formclosing
        private bool autoYesFormClosing = false;
        //sự kiện click nút đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {   //kết nối với csdl 
            string tk = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text.Trim();
            //Ràng buộc người dùng nhập thông tin
            if (txtTaiKhoan.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tài Khoản Và Mật Khẩu");
            }
            else if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tài Khoản");
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
            }
            else
            {   //Đăng Nhập 
                try
                {
                    string sql = string.Format("select *from TaiKhoan where TKDangNhap = '{0}'and MatKhau = '{1}'", tk, mk);
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, ketNoi))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read() == true)
                                {   //kiểm tra quyền khi đăng nhập thành công
                                    reader.Close();
                                    string phanQuyen = string.Format("select LoaiTK from TaiKhoan where TKDangNhap = '{0}'", tk);
                                    SqlCommand phanQuyenCmd = new SqlCommand(phanQuyen, ketNoi);
                                    object result = phanQuyenCmd.ExecuteScalar();
                                    if (result != null)
                                    {
                                        string LoaiTK = result.ToString();
                                        if (LoaiTK.Trim().ToString() == "admin")
                                        {
                                            autoYesFormClosing = true;
                                            frmAdmin fAdmin = new frmAdmin();
                                            this.Hide();
                                            fAdmin.ShowDialog();
                                            this.Close();
                                        }
                                        else if (LoaiTK.ToString().Trim() == "student")
                                        {
                                            string hienThiThongtin = string.Format("select MaHS from TaiKhoan where TKDangNhap = '{0}'",tk);
                                            using (SqlCommand cmdhienThiHocSinh = new SqlCommand(hienThiThongtin,ketNoi))
                                            {
                                                object maHienThi = cmdhienThiHocSinh.ExecuteScalar();
                                                autoYesFormClosing = true;
                                                frmHocSinh fHocSinh = new frmHocSinh();
                                                fHocSinh.taiKhoan = tk;
                                                fHocSinh.matKhau = mk;
                                                fHocSinh.maHS = maHienThi.ToString().Trim();
                                                this.Hide();
                                                fHocSinh.ShowDialog();
                                                this.Close();
                                            }
                                        }
                                        else if (LoaiTK.ToString().Trim() == "teacher")
                                        {
                                            string hienThiThongtin = string.Format("select MaGV from TaiKhoan where TKDangNhap = '{0}'", tk);
                                            using (SqlCommand cmdHienThiGiaoVien = new SqlCommand(hienThiThongtin, ketNoi))
                                            {
                                                object maHienThi = cmdHienThiGiaoVien.ExecuteScalar();
                                                autoYesFormClosing = true;
                                                frmGiaoVien fGiaoVien = new frmGiaoVien();
                                                fGiaoVien.maGV = maHienThi.ToString().Trim();
                                                fGiaoVien.TaiKhoan = tk;
                                                fGiaoVien.Matkhau = mk;
                                                this.Hide();
                                                fGiaoVien.ShowDialog();
                                                this.Close();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Tài Khoản Hoặc Mật Khẩu Không Chính Xác");
                                    txtMatKhau.Clear();
                                    txtMatKhau.Focus();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!autoYesFormClosing)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            autoYesFormClosing = false;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            /*using (SoundPlayer player = new SoundPlayer("D:\\do_an1\\sound\\tiengdanhram.wav"))
            {
                player.PlaySync();
            }*/
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "Usename...";
            txtMatKhau.Text = "Password...";
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}

