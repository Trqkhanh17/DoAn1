using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
namespace QuanLyHocSinh.QuanLiLoaiTK
{
    public partial class frmThemLoaiTaiKhoan : Form
    {
        public frmThemLoaiTaiKhoan()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtLoaiTK.Text == "" || txtLoaiTK.Text.Contains(" "))
            {
                if (txtLoaiTK.Text == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Loại Tài Khoản Cần Thêm", "Thông Báo", MessageBoxButtons.OK);
                }
                else if (txtLoaiTK.Text.Contains(" ") == true)
                {
                    MessageBox.Show("Vui lòng không nhập khoản trắng", "Thông Báo", MessageBoxButtons.OK);
                }

            }
            else
            {
                try
                {
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        string sqlThemLoaiTK = string.Format("insert into LoaiTaiKhoan values('{0}')", txtLoaiTK.Text.Trim());
                        using (SqlCommand lenhThem = new SqlCommand(sqlThemLoaiTK, ketNoi))
                        {
                            lenhThem.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK);
                        }
                    }
                    /*if (Application.OpenForms["frmQuanLiLoaiTaiKhoan"] == null)
                    {
                        frmQuanLiLoaiTaiKhoan fQLLoaiTK = new frmQuanLiLoaiTaiKhoan();
                        this.Hide();
                        fQLLoaiTK.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Application.OpenForms["frmQuanLiLoaiTaiKhoan"].BringToFront();
                    }*/
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm Thất Bại ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void frmThemLoaiTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*frmQuanLiLoaiTaiKhoan fQLLoaiTK = new frmQuanLiLoaiTaiKhoan();
            this.Hide();
         *//*   fQLLoaiTK.ShowDialog();*//*
            if (Application.OpenForms["frmQuanLiLoaiTaiKhoan"] == null)
            {
                frmQuanLiLoaiTaiKhoan fQLLoaiTK = new frmQuanLiLoaiTaiKhoan();
                this.Hide();
                fQLLoaiTK.ShowDialog();
            }
            else
            {
                Application.OpenForms["frmQuanLiLoaiTaiKhoan"].BringToFront();
            }*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoaiTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void frmThemLoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnThem);
            fc.CustomTextBox(txtLoaiTK);
            
        }
    }
}
