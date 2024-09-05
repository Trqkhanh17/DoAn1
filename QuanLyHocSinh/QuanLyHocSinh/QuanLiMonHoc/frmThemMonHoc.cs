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

namespace QuanLyHocSinh.QuanLiMonHoc
{
    public partial class frmThemMonHoc : Form
    {
        public frmThemMonHoc()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
            string maMonHoc = txtMaMon.Text.Trim();
            string tenMonHoc = txtTenMon.Text.Trim();
            if (maMonHoc == "" && tenMonHoc == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống thông tin", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (maMonHoc == "" && tenMonHoc != "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học", "Thông Báo", MessageBoxButtons.OK);
            }
            else if (maMonHoc != "" && tenMonHoc == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                    {
                        ketNoi.Open();
                        string sqlThem = string.Format("insert into MonHoc values('{0}',N'{1}')",maMonHoc,tenMonHoc);
                        using (SqlCommand cmdThem = new SqlCommand(sqlThem, ketNoi))
                        {
                            cmdThem.ExecuteNonQuery();
                            MessageBox.Show("Thêm Thành Công","Thông Báo",MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm Thất Bại","Thông Báo",MessageBoxButtons.OK);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtTenMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomTextBox(txtMaMon);
            fc.CustomTextBox(txtTenMon);
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnThem);
        }
    }
}
