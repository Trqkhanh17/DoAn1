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
    public partial class frmSuaMonHoc : Form
    {
        public frmSuaMonHoc()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaMonHocCanSua {  get; set; }     
        public string TenMonHocCanSua { get;set; }

        private void frmSuaMonHoc_Load(object sender, EventArgs e)
        {
            txtMaMon.Enabled = false;
            txtMaMon.Text = MaMonHocCanSua;
            txtTenMon.Text = TenMonHocCanSua;
            this.FormBorderStyle = FormBorderStyle.None;
            function fc = new function();
            fc.CustomTextBox(txtMaMon);
            fc.CustomTextBox(txtTenMon);
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnSua);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    string maMonHoc = txtMaMon.Text;
                    string tenMonHoc = txtTenMon.Text;
                    ketNoi.Open();
                    string lenhSua = string.Format("update MonHoc set TenMon = N'{0}' where MaMon = '{1}'", tenMonHoc, maMonHoc);
                    using (SqlCommand cmdSua = new SqlCommand(lenhSua, ketNoi))
                    {
                        cmdSua.ExecuteNonQuery();
                        MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void txtMaMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtTenMon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSua_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
