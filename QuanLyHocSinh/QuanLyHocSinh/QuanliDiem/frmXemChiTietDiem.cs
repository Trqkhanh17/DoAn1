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

namespace QuanLyHocSinh.QuanliDiem
{
    public partial class frmXemChiTietDiem : Form
    {
        public frmXemChiTietDiem()
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue;
        }
        public string MaDiemCanXem { get; set; }
        public string MaHSCanXem { get; set; }
        public string MaGVCanXem { get; set; }
        string chuoiKN = global::QuanLyHocSinh.Properties.Settings.Default.QLHSConnectionString2;

        private void HienThiTen(string loaiThongTinCanHienThi, string maHocSinhHoacGiaoVienCanHienThi)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    string TenCanHienThi = "";
                    string thongTinCanHienThi = "";
                    if (loaiThongTinCanHienThi == "GV")
                    {
                        TenCanHienThi = "TenGV";
                        thongTinCanHienThi = "MaGV";
                    }
                    else if (loaiThongTinCanHienThi == "HocSinh")
                    {
                        TenCanHienThi = "TenHS";
                        thongTinCanHienThi = "MaHS";
                    }
                    ketNoi.Open();
                    string truyVanTen = string.Format("select {0} from {1} where {2} = '{3}'", TenCanHienThi, loaiThongTinCanHienThi, thongTinCanHienThi, maHocSinhHoacGiaoVienCanHienThi);
                    using (SqlCommand cmdTen = new SqlCommand(truyVanTen, ketNoi))
                    {
                        using (SqlDataReader ds = cmdTen.ExecuteReader())
                        {
                            DataTable Ten = new DataTable();
                            Ten.Load(ds);
                            if (loaiThongTinCanHienThi == "GV")
                            {
                                lblTenGV.Text = "Tên Giáo Viên: " + Ten.Rows[0]["TenGV"].ToString().Trim();
                            }
                            else if (loaiThongTinCanHienThi == "HocSinh")
                            {
                                lblTenHS.Text = "Tên Học Sinh: " + Ten.Rows[0]["TenHS"].ToString().Trim();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK);
                return;
            }
        }
        private void frmXemChiTietDiem_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ketNoi = new SqlConnection(chuoiKN))
                {
                    ketNoi.Open();
                    string truyVanDuLieuDiemCanXem = string.Format("select *from DiemSo Where MaDiem = '{0}'", MaDiemCanXem.Trim());
                    using (SqlCommand cmdDiem = new SqlCommand(truyVanDuLieuDiemCanXem, ketNoi))
                    {
                        using (SqlDataReader ds = cmdDiem.ExecuteReader())
                        {
                            DataTable ttDiemSo = new DataTable();
                            ttDiemSo.Load(ds);
                            lblMaDiem.Text = "Mã Điềm: " + ttDiemSo.Rows[0]["MaDiem"].ToString().Trim();
                            lblMaHS.Text = "Mã Học Sinh: " + ttDiemSo.Rows[0]["MaHS"].ToString().Trim();
                            lblMaMon.Text = "Mã Môn Học: " + ttDiemSo.Rows[0]["MaMon"].ToString().Trim();
                            lblMaGV.Text = "Mã Giáo Viên: " + ttDiemSo.Rows[0]["MaGV"].ToString().Trim();
                            lblLop.Text = "Lớp: " + ttDiemSo.Rows[0]["MaLop"].ToString().Trim();
                            lblDiem15p.Text = "Điểm 15 Phút: " + ttDiemSo.Rows[0]["Diem15p"].ToString().Trim();
                            lblDiemGiuaKi.Text = "Điểm Giữa Kì: " + ttDiemSo.Rows[0]["DiemGiuaKi"].ToString().Trim();
                            lblDiemCuoiKi.Text = "Điểm Cuối Kì: " + ttDiemSo.Rows[0]["DiemCuoiKi"].ToString().Trim();
                            lblHocKi.Text = "Học Kì: " + ttDiemSo.Rows[0]["HocKi"].ToString().Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã Xảy Ra Lỗi", "Thông Báo", MessageBoxButtons.OK);
            }
            HienThiTen("GV", MaGVCanXem.Trim());
            HienThiTen("HocSinh", MaHSCanXem.Trim());
        }
    }
}
