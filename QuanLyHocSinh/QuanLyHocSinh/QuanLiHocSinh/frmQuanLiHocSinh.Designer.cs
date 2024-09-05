namespace QuanLyHocSinh
{
    partial class frmQuanLiHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiHocSinh));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.chkMaSo = new System.Windows.Forms.CheckBox();
            this.chkLop = new System.Windows.Forms.CheckBox();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThangNamSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLopCuaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamDangHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(169, 24);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(371, 30);
            this.txtTim.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(546, 24);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(86, 32);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // chkMaSo
            // 
            this.chkMaSo.AutoSize = true;
            this.chkMaSo.ForeColor = System.Drawing.Color.Navy;
            this.chkMaSo.Location = new System.Drawing.Point(67, 60);
            this.chkMaSo.Name = "chkMaSo";
            this.chkMaSo.Size = new System.Drawing.Size(161, 27);
            this.chkMaSo.TabIndex = 1;
            this.chkMaSo.Text = "Tìm theo mã số";
            this.chkMaSo.UseVisualStyleBackColor = true;
            this.chkMaSo.CheckedChanged += new System.EventHandler(this.chkMaSo_CheckedChanged);
            // 
            // chkLop
            // 
            this.chkLop.AutoSize = true;
            this.chkLop.ForeColor = System.Drawing.Color.Navy;
            this.chkLop.Location = new System.Drawing.Point(67, 93);
            this.chkLop.Name = "chkLop";
            this.chkLop.Size = new System.Drawing.Size(139, 27);
            this.chkLop.TabIndex = 3;
            this.chkLop.Text = "Tìm theo lớp";
            this.chkLop.UseVisualStyleBackColor = true;
            this.chkLop.CheckedChanged += new System.EventHandler(this.chkLop_CheckedChanged);
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.ForeColor = System.Drawing.Color.Navy;
            this.chkTen.Location = new System.Drawing.Point(234, 60);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(139, 27);
            this.chkTen.TabIndex = 2;
            this.chkTen.Text = "Tìm theo tên";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.chkTen_CheckedChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(557, 231);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 56);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa học sinh";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(557, 348);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 56);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa học sinh";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(557, 461);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(107, 56);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(557, 557);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 56);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.TenHocSinh,
            this.NgayThangNamSinh,
            this.GioiTinhHocSinh,
            this.SoDienThoai,
            this.DiaChiHocSinh,
            this.MaLopCuaHocSinh,
            this.NamDangHoc});
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(1, 137);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(539, 476);
            this.dgvDanhSachHocSinh.TabIndex = 10;
            this.dgvDanhSachHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHocSinh_CellContentClick);
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHS";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.MinimumWidth = 6;
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Width = 125;
            // 
            // TenHocSinh
            // 
            this.TenHocSinh.DataPropertyName = "TenHS";
            this.TenHocSinh.HeaderText = "Tên Học Sinh";
            this.TenHocSinh.MinimumWidth = 6;
            this.TenHocSinh.Name = "TenHocSinh";
            this.TenHocSinh.Width = 125;
            // 
            // NgayThangNamSinh
            // 
            this.NgayThangNamSinh.DataPropertyName = "NgaySinh";
            this.NgayThangNamSinh.HeaderText = "Ngày Sinh";
            this.NgayThangNamSinh.MinimumWidth = 6;
            this.NgayThangNamSinh.Name = "NgayThangNamSinh";
            this.NgayThangNamSinh.Width = 125;
            // 
            // GioiTinhHocSinh
            // 
            this.GioiTinhHocSinh.DataPropertyName = "GioiTinh";
            this.GioiTinhHocSinh.HeaderText = "Giới Tính";
            this.GioiTinhHocSinh.MinimumWidth = 6;
            this.GioiTinhHocSinh.Name = "GioiTinhHocSinh";
            this.GioiTinhHocSinh.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SDT";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // DiaChiHocSinh
            // 
            this.DiaChiHocSinh.DataPropertyName = "DiaChi";
            this.DiaChiHocSinh.HeaderText = "Địa Chỉ";
            this.DiaChiHocSinh.MinimumWidth = 6;
            this.DiaChiHocSinh.Name = "DiaChiHocSinh";
            this.DiaChiHocSinh.Width = 125;
            // 
            // MaLopCuaHocSinh
            // 
            this.MaLopCuaHocSinh.DataPropertyName = "MaLop";
            this.MaLopCuaHocSinh.HeaderText = "Mã Lớp";
            this.MaLopCuaHocSinh.MinimumWidth = 6;
            this.MaLopCuaHocSinh.Name = "MaLopCuaHocSinh";
            this.MaLopCuaHocSinh.Width = 125;
            // 
            // NamDangHoc
            // 
            this.NamDangHoc.DataPropertyName = "NamHoc";
            this.NamDangHoc.HeaderText = "Năm Học";
            this.NamDangHoc.MinimumWidth = 6;
            this.NamDangHoc.Name = "NamDangHoc";
            this.NamDangHoc.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(557, 137);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 57);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Học Sinh";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // frmQuanLiHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 625);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Controls.Add(this.chkLop);
            this.Controls.Add(this.chkTen);
            this.Controls.Add(this.chkMaSo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Học Sinh";
            this.Load += new System.EventHandler(this.frmQuanLiHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.CheckBox chkMaSo;
        private System.Windows.Forms.CheckBox chkLop;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThangNamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopCuaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamDangHoc;
        private System.Windows.Forms.Button btnThem;
    }
}