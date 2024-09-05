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
    public partial class frmXemChiTietLop : Form
    {
        public frmXemChiTietLop()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaLop { get; set; }

        private void frmXemChiTietLop_Load(object sender, EventArgs e)
        {
            string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanDSHocSinh = string.Format("select *from HocSinh where MaLop = '{0}'", MaLop.Trim());
                    using (SqlCommand DSHocSinh = new SqlCommand(truyVanDSHocSinh, ketNoi))
                    {
                        using (SqlDataReader ds = DSHocSinh.ExecuteReader())
                        {
                            DataTable dsHocSinh = new DataTable();
                            dsHocSinh.Load(ds);
                            dgvDanhSachHocSinh.DataSource = dsHocSinh;
                        }
                    }
                    label1.ForeColor = Color.Navy;
                    function fc = new function();
                    fc.CustomizeDataGridView(dgvDanhSachHocSinh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
