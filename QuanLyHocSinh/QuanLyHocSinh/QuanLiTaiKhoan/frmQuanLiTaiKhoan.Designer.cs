namespace QuanLyHocSinh
{
    partial class frmQuanLiTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachTaiKhoan = new System.Windows.Forms.DataGridView();
            this.TaiKhoanDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.btnTimTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(159, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Tài Khoản";
            // 
            // dgvDanhSachTaiKhoan
            // 
            this.dgvDanhSachTaiKhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoanDangNhap,
            this.MaGiaoVien,
            this.MaHocSinh,
            this.mkhau,
            this.LoaiTaiKhoan});
            this.dgvDanhSachTaiKhoan.Location = new System.Drawing.Point(12, 134);
            this.dgvDanhSachTaiKhoan.Name = "dgvDanhSachTaiKhoan";
            this.dgvDanhSachTaiKhoan.ReadOnly = true;
            this.dgvDanhSachTaiKhoan.RowHeadersWidth = 51;
            this.dgvDanhSachTaiKhoan.RowTemplate.Height = 24;
            this.dgvDanhSachTaiKhoan.Size = new System.Drawing.Size(545, 578);
            this.dgvDanhSachTaiKhoan.TabIndex = 6;
            this.dgvDanhSachTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachTaiKhoan_CellContentClick);
            // 
            // TaiKhoanDangNhap
            // 
            this.TaiKhoanDangNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TaiKhoanDangNhap.DataPropertyName = "TKDangNhap";
            this.TaiKhoanDangNhap.HeaderText = "Tài Khoản";
            this.TaiKhoanDangNhap.MinimumWidth = 6;
            this.TaiKhoanDangNhap.Name = "TaiKhoanDangNhap";
            this.TaiKhoanDangNhap.ReadOnly = true;
            this.TaiKhoanDangNhap.Width = 125;
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGV";
            this.MaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.MaGiaoVien.MinimumWidth = 6;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.ReadOnly = true;
            this.MaGiaoVien.Width = 125;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHS";
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.MinimumWidth = 6;
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            this.MaHocSinh.Width = 125;
            // 
            // mkhau
            // 
            this.mkhau.DataPropertyName = "MatKhau";
            this.mkhau.HeaderText = "Mật Khẩu";
            this.mkhau.MinimumWidth = 6;
            this.mkhau.Name = "mkhau";
            this.mkhau.ReadOnly = true;
            this.mkhau.Width = 125;
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTK";
            this.LoaiTaiKhoan.HeaderText = "Loại Tài Khoản";
            this.LoaiTaiKhoan.MinimumWidth = 6;
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.ReadOnly = true;
            this.LoaiTaiKhoan.Width = 125;
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Location = new System.Drawing.Point(563, 341);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(130, 76);
            this.btnSuaTK.TabIndex = 3;
            this.btnSuaTK.Text = "Sửa Tài Khoản";
            this.btnSuaTK.UseVisualStyleBackColor = true;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // btnTimTK
            // 
            this.btnTimTK.Location = new System.Drawing.Point(563, 84);
            this.btnTimTK.Name = "btnTimTK";
            this.btnTimTK.Size = new System.Drawing.Size(130, 56);
            this.btnTimTK.TabIndex = 1;
            this.btnTimTK.Text = "Tìm Tài Khoản";
            this.btnTimTK.UseVisualStyleBackColor = true;
            this.btnTimTK.Click += new System.EventHandler(this.btnTimTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(563, 484);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(130, 76);
            this.btnXoaTK.TabIndex = 4;
            this.btnXoaTK.Text = "Xóa Tài Khoản";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(333, 95);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(224, 30);
            this.txtTim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(120, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập tài khoản cần tìm:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(563, 637);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 75);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.AutoEllipsis = true;
            this.btnThemTK.Location = new System.Drawing.Point(563, 202);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(130, 74);
            this.btnThemTK.TabIndex = 2;
            this.btnThemTK.Text = "Thêm Tài Khoản";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // frmQuanLiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 713);
            this.Controls.Add(this.btnThemTK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnXoaTK);
            this.Controls.Add(this.btnTimTK);
            this.Controls.Add(this.btnSuaTK);
            this.Controls.Add(this.dgvDanhSachTaiKhoan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Tài Khoản";
            this.Load += new System.EventHandler(this.frmQuanLiTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachTaiKhoan;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Button btnTimTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn mkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.Button btnThemTK;
    }
}