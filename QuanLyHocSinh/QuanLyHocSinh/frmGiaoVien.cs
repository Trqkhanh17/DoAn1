using QuanLyHocSinh.QuanLiGiaoVien;
using QuanLyHocSinh.QuanLiTaiKhoan;
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

namespace QuanLyHocSinh
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        public string maGV { get;set; }
        public string TaiKhoan { get; set; }
        public string Matkhau { get; set; }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmXemChiTietGiaoVien fXemChiTiet = new frmXemChiTietGiaoVien();
            this.Hide();
            fXemChiTiet.MaGiaoVienCanXem = maGV;
            fXemChiTiet.FormClosed += (s, agrs) =>
            {
                this.Show();
            };
            fXemChiTiet.ShowDialog();
        }

        private void quảnLíĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiDiem fQLDiem = new frmQuanLiDiem();
            this.Hide();
            fQLDiem.FormClosed += (s, agrs) =>
            {
                this.Show();
            };
            fQLDiem.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuaTaiKhoan fSuaTK = new frmSuaTaiKhoan();
            this.Hide();
            fSuaTK.TaiKhoanCanSua = TaiKhoan.Trim();
            fSuaTK.MatKhauCanSua = Matkhau.Trim();
            fSuaTK.FormClosed += (s, agrs) =>
            {
                this.Show();
            };
            fSuaTK.ShowDialog();
        }
        private bool autoYesformClosing = false;
        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            autoYesformClosing = true;
            // Mở lại form đăng nhập
            frmDangNhap fDangNhap = new frmDangNhap();
            this.Hide();
            fDangNhap.ShowDialog();
            this.Close();
        }
        
        private void frmGiaoVien_FormClosing(object sender, FormClosingEventArgs e)
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

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoVien_Load_1(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}
