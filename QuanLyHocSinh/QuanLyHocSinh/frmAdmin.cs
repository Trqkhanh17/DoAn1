using QuanLyHocSinh.QuanLiLopHoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        //biến cờ dùng để xử lí khi đăng nhập vào trang khác form tự đóng mà không cần phải phải hỏi ý kiến ng dùng ở sự kiện formclosing
        private bool autoYesformClosing = false;
        private void quảnLíLoạiTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiLoaiTaiKhoan fQLLoaiTK = new frmQuanLiLoaiTaiKhoan();
            this.Hide(); // Ẩn form Admin
            fQLLoaiTK.FormClosed += (s, args) => this.Show(); // Hiển thị lại form Admin khi form QuanLiLoaiTK đóng
            fQLLoaiTK.ShowDialog();
        }
        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiTaiKhoan fQLTK = new frmQuanLiTaiKhoan();
            this.Hide();
            fQLTK.FormClosed += (s, args) => this.Show();
            fQLTK.ShowDialog();
        }

        private void quảnLíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiMonHoc fQLMH = new frmQuanLiMonHoc();
            this.Hide();
            fQLMH.FormClosing += (s, args) => this.Show();
            fQLMH.ShowDialog();
        }

        private void quảnLíGiáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiGiaoVien fQLGV = new frmQuanLiGiaoVien();
            this.Hide();
            fQLGV.FormClosing += (s, args) => this.Show();
            fQLGV.ShowDialog();
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiHocSinh fQLHS = new frmQuanLiHocSinh();
            this.Hide();
            fQLHS.FormClosing += (s, args) => this.Show();
            fQLHS.ShowDialog();
        }

        private void quảnLíĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiDiem fQLDiem = new frmQuanLiDiem();
            this.Hide();
            fQLDiem.FormClosing += (s, args) => this.Show();
            fQLDiem.ShowDialog();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo list để lưu các form đang mở 
            /*List<Form> FormClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    FormClose.Add(form);
                }
            }
            //Duyệt lấy form bên trong List để đóng form
            foreach (Form form in FormClose)
            {
                form.Close();
            }
            //đóng form đang mở
            this.Close();*/
            Application.Exit();
        }
        /*private void OpenFormAndCloseOthers(Form formToOpen)
        {
            // Đóng tất cả các form hiện tại
            foreach (Form form in Application.OpenForms)
            {
                if (form != formToOpen)
                {
                    form.Close();
                }
            }

            // Mở form mới
            formToOpen.Show();
        }*/
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoYesformClosing = true;
            // Mở lại form đăng nhập
            frmDangNhap fDangNhap = new frmDangNhap();
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!autoYesformClosing)
            {
                DialogResult Result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            /*    else
                 {
                     ktraformClosing = true ;
                     this.Close ();
                 }*/
            autoYesformClosing = false;
        }

        private void quảnLíLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiLopHoc fQlLop = new frmQuanLiLopHoc();
            this.Hide();
            fQlLop.FormClosed += (s, args) =>
            {
                this.Show();
            };
            fQlLop.ShowDialog();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

    }
}
