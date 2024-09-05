using QuanLyHocSinh.QuanLiLoaiTK;
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
namespace QuanLyHocSinh
{
    public partial class frmQuanLiLoaiTaiKhoan : Form
    {
        public frmQuanLiLoaiTaiKhoan()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
        private void btnThemLoaiTK_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            fThemLoaiTk.ShowDialog();*/
            /*if (Application.OpenForms["frmThemLoaiTaiKhoan"] == null)
            {
                frmThemLoaiTaiKhoan fThemLoaiTK = new frmThemLoaiTaiKhoan();
                fThemLoaiTK.ShowDialog();
            }
            else
            {
                Application.OpenForms["frmThemLoaiTaiKhoan"].BringToFront();
            }
            this.Hide();*/
            frmThemLoaiTaiKhoan fThemLoaiTK = new frmThemLoaiTaiKhoan();
            this.Hide();
            fThemLoaiTK.FormClosed += (s, args) =>
            {
                frmQuanLiLoaiTaiKhoan_Load(sender, e);
                this.Show();
            };
            fThemLoaiTK.ShowDialog();
        }
        private void frmQuanLiLoaiTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*frmAdmin fAdmin = new frmAdmin();
            this.Hide();
            fAdmin.ShowDialog();
            this.Close();*/
            /* List<Form> FormClose = new List<Form>();
             foreach (Form form in Application.OpenForms)
             {
                 if (form != Application.OpenForms["frmAdmin"])
                 {
                     FormClose.Add(form);
                 }
             }
             //Duyệt lấy form bên trong List để đóng form
             foreach (Form form in FormClose)
             {
                 form.Close();
             }*/
        }
        private void frmQuanLiLoaiTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string DSLoaiTK = string.Format("select *from LoaiTaiKhoan");
                    using (SqlCommand cmd = new SqlCommand(DSLoaiTK, ketNoi))
                    {
                        using (SqlDataReader ds = cmd.ExecuteReader())
                        {
                            DataTable dsLoaiTK = new DataTable();
                            dsLoaiTK.Load(ds);
                            ds.Close();
                            dgvDanhSachLoaiTK.DataSource = dsLoaiTK;
                        }
                    }
                }
                this.FormBorderStyle = FormBorderStyle.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            function fc = new function();
            fc.CustomButton(btnThoat);
            fc.CustomButton(btnThemLoaiTK);
            fc.CustomButton(btnXoaLoaiTK);
            fc.CustomizeDataGridView(dgvDanhSachLoaiTK);
        }
        string selectedRowIndex;
        private void dgvDanhSachLoaiTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ mục hàng hợp lệ
            {
                var row = dgvDanhSachLoaiTK.Rows[e.RowIndex];

                // Sử dụng ? để tránh lỗi NullReferenceException nếu ô có giá trị null
                selectedRowIndex = row.Cells["LoaiTaiKhoan"].Value?.ToString();
            }
        }
        private void btnXoaLoaiTK_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == "" || selectedRowIndex == null)
            {
                MessageBox.Show("Vui Lòng Chọn Dòng Cần Xóa");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                        {
                            ketNoi.Open();
                            string sqlXoaLoaiTK = string.Format("delete from LoaiTaiKhoan where LoaiTK = '{0}'", selectedRowIndex.Trim().ToString());
                            using (SqlCommand cmdXoaLoaiTK = new SqlCommand(sqlXoaLoaiTK, ketNoi))
                            {
                                cmdXoaLoaiTK.ExecuteNonQuery();
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK);
                                frmQuanLiLoaiTaiKhoan_Load(sender, e);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                selectedRowIndex = null;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

