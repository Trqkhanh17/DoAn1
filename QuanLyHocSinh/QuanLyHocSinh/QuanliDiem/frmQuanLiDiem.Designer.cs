namespace QuanLyHocSinh
{
    partial class frmQuanLiDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiDiem));
            this.label2 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvDanhSachDiem = new System.Windows.Forms.DataGridView();
            this.MaDiemSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15Phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGiuaHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKiDangHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMaDiem = new System.Windows.Forms.CheckBox();
            this.chkMaHS = new System.Windows.Forms.CheckBox();
            this.chkMaLop = new System.Windows.Forms.CheckBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chkMaMonHoc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(215, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quản Lí Điểm Học Sinh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(276, 111);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(449, 30);
            this.txtTim.TabIndex = 0;
            // 
            // dgvDanhSachDiem
            // 
            this.dgvDanhSachDiem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDiemSo,
            this.MaHocSinh,
            this.MaMonHoc,
            this.MaLopHoc,
            this.MaGiaoVien,
            this.Diem15Phut,
            this.DiemGiuaHocKi,
            this.DiemCuoiHocKi,
            this.HocKiDangHoc});
            this.dgvDanhSachDiem.Location = new System.Drawing.Point(3, 211);
            this.dgvDanhSachDiem.Name = "dgvDanhSachDiem";
            this.dgvDanhSachDiem.RowHeadersWidth = 51;
            this.dgvDanhSachDiem.RowTemplate.Height = 24;
            this.dgvDanhSachDiem.Size = new System.Drawing.Size(722, 560);
            this.dgvDanhSachDiem.TabIndex = 2;
            this.dgvDanhSachDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDiem_CellContentClick);
            // 
            // MaDiemSo
            // 
            this.MaDiemSo.DataPropertyName = "MaDiem";
            this.MaDiemSo.HeaderText = "Mã Điểm";
            this.MaDiemSo.MinimumWidth = 6;
            this.MaDiemSo.Name = "MaDiemSo";
            this.MaDiemSo.Width = 125;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHS";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.MinimumWidth = 6;
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Width = 125;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMon";
            this.MaMonHoc.HeaderText = "Mã Môn Học";
            this.MaMonHoc.MinimumWidth = 6;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Width = 125;
            // 
            // MaLopHoc
            // 
            this.MaLopHoc.DataPropertyName = "MaLop";
            this.MaLopHoc.HeaderText = "Mã Lớp";
            this.MaLopHoc.MinimumWidth = 6;
            this.MaLopHoc.Name = "MaLopHoc";
            this.MaLopHoc.Width = 125;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGV";
            this.MaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.MaGiaoVien.MinimumWidth = 6;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Width = 125;
            // 
            // Diem15Phut
            // 
            this.Diem15Phut.DataPropertyName = "Diem15p";
            this.Diem15Phut.HeaderText = "Điểm 15p";
            this.Diem15Phut.MinimumWidth = 6;
            this.Diem15Phut.Name = "Diem15Phut";
            this.Diem15Phut.Width = 125;
            // 
            // DiemGiuaHocKi
            // 
            this.DiemGiuaHocKi.DataPropertyName = "DiemGiuaKi";
            this.DiemGiuaHocKi.HeaderText = "Điểm Giữa Kì";
            this.DiemGiuaHocKi.MinimumWidth = 6;
            this.DiemGiuaHocKi.Name = "DiemGiuaHocKi";
            this.DiemGiuaHocKi.Width = 125;
            // 
            // DiemCuoiHocKi
            // 
            this.DiemCuoiHocKi.DataPropertyName = "DiemCuoiKi";
            this.DiemCuoiHocKi.HeaderText = "Điểm Cuối Kì";
            this.DiemCuoiHocKi.MinimumWidth = 6;
            this.DiemCuoiHocKi.Name = "DiemCuoiHocKi";
            this.DiemCuoiHocKi.Width = 125;
            // 
            // HocKiDangHoc
            // 
            this.HocKiDangHoc.DataPropertyName = "HocKi";
            this.HocKiDangHoc.HeaderText = "Học Kì";
            this.HocKiDangHoc.MinimumWidth = 6;
            this.HocKiDangHoc.Name = "HocKiDangHoc";
            this.HocKiDangHoc.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(171, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm";
            // 
            // chkMaDiem
            // 
            this.chkMaDiem.AutoSize = true;
            this.chkMaDiem.ForeColor = System.Drawing.Color.Navy;
            this.chkMaDiem.Location = new System.Drawing.Point(276, 147);
            this.chkMaDiem.Name = "chkMaDiem";
            this.chkMaDiem.Size = new System.Drawing.Size(196, 27);
            this.chkMaDiem.TabIndex = 1;
            this.chkMaDiem.Text = "Tìm Theo Mã Điểm";
            this.chkMaDiem.UseVisualStyleBackColor = true;
            this.chkMaDiem.CheckedChanged += new System.EventHandler(this.chkMaDiem_CheckedChanged);
            // 
            // chkMaHS
            // 
            this.chkMaHS.AutoSize = true;
            this.chkMaHS.ForeColor = System.Drawing.Color.Navy;
            this.chkMaHS.Location = new System.Drawing.Point(478, 147);
            this.chkMaHS.Name = "chkMaHS";
            this.chkMaHS.Size = new System.Drawing.Size(227, 27);
            this.chkMaHS.TabIndex = 2;
            this.chkMaHS.Text = "Tìm Theo Mã Học Sinh";
            this.chkMaHS.UseVisualStyleBackColor = true;
            this.chkMaHS.CheckedChanged += new System.EventHandler(this.chkMaHS_CheckedChanged);
            // 
            // chkMaLop
            // 
            this.chkMaLop.AutoSize = true;
            this.chkMaLop.ForeColor = System.Drawing.Color.Navy;
            this.chkMaLop.Location = new System.Drawing.Point(276, 180);
            this.chkMaLop.Name = "chkMaLop";
            this.chkMaLop.Size = new System.Drawing.Size(153, 27);
            this.chkMaLop.TabIndex = 3;
            this.chkMaLop.Text = "Tìm Theo Lớp";
            this.chkMaLop.UseVisualStyleBackColor = true;
            this.chkMaLop.CheckedChanged += new System.EventHandler(this.chkMaLop_CheckedChanged);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTim.Location = new System.Drawing.Point(731, 111);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 37);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Location = new System.Drawing.Point(742, 211);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 59);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm Điểm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSua.Location = new System.Drawing.Point(742, 344);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 59);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa Điểm";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Location = new System.Drawing.Point(742, 455);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 59);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa Điểm";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXem.Location = new System.Drawing.Point(742, 589);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(135, 59);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Location = new System.Drawing.Point(742, 703);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 59);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chkMaMonHoc
            // 
            this.chkMaMonHoc.AutoSize = true;
            this.chkMaMonHoc.ForeColor = System.Drawing.Color.Navy;
            this.chkMaMonHoc.Location = new System.Drawing.Point(478, 180);
            this.chkMaMonHoc.Name = "chkMaMonHoc";
            this.chkMaMonHoc.Size = new System.Drawing.Size(181, 27);
            this.chkMaMonHoc.TabIndex = 4;
            this.chkMaMonHoc.Text = "Tìm Mã Môn Học";
            this.chkMaMonHoc.UseVisualStyleBackColor = true;
            this.chkMaMonHoc.CheckedChanged += new System.EventHandler(this.chkMaMonHoc_CheckedChanged);
            // 
            // frmQuanLiDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 774);
            this.Controls.Add(this.chkMaMonHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.chkMaLop);
            this.Controls.Add(this.chkMaHS);
            this.Controls.Add(this.chkMaDiem);
            this.Controls.Add(this.dgvDanhSachDiem);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Điểm";
            this.Load += new System.EventHandler(this.frmQuanLiDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvDanhSachDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMaDiem;
        private System.Windows.Forms.CheckBox chkMaHS;
        private System.Windows.Forms.CheckBox chkMaLop;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkMaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiemSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15Phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGiuaHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKiDangHoc;
    }
}