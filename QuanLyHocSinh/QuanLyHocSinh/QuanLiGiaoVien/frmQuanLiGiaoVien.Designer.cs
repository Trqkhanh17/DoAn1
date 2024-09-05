namespace QuanLyHocSinh
{
    partial class frmQuanLiGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiGiaoVien));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkTenGV = new System.Windows.Forms.CheckBox();
            this.chkMaGV = new System.Windows.Forms.CheckBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbPhuongThucTimKiem = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.grbPhuongThucTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(169, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(272, 125);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(302, 30);
            this.txtTim.TabIndex = 0;
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.TenGiaoVien,
            this.GioiTinhGiaoVien,
            this.SoDienThoai,
            this.DiaChiGiaoVien});
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 253);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 24;
            this.dgvGiaoVien.Size = new System.Drawing.Size(724, 536);
            this.dgvGiaoVien.TabIndex = 8;
            this.dgvGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellContentClick);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGV";
            this.MaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.MaGiaoVien.MinimumWidth = 6;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Width = 125;
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.DataPropertyName = "TenGV";
            this.TenGiaoVien.HeaderText = "Tên Giáo Viên";
            this.TenGiaoVien.MinimumWidth = 6;
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.Width = 125;
            // 
            // GioiTinhGiaoVien
            // 
            this.GioiTinhGiaoVien.DataPropertyName = "GioiTinh";
            this.GioiTinhGiaoVien.HeaderText = "Giới Tính";
            this.GioiTinhGiaoVien.MinimumWidth = 6;
            this.GioiTinhGiaoVien.Name = "GioiTinhGiaoVien";
            this.GioiTinhGiaoVien.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SDT";
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // DiaChiGiaoVien
            // 
            this.DiaChiGiaoVien.DataPropertyName = "DiaChi";
            this.DiaChiGiaoVien.HeaderText = "Địa Chỉ";
            this.DiaChiGiaoVien.MinimumWidth = 6;
            this.DiaChiGiaoVien.Name = "DiaChiGiaoVien";
            this.DiaChiGiaoVien.Width = 125;
            // 
            // chkTenGV
            // 
            this.chkTenGV.AutoSize = true;
            this.chkTenGV.Location = new System.Drawing.Point(5, 59);
            this.chkTenGV.Name = "chkTenGV";
            this.chkTenGV.Size = new System.Drawing.Size(218, 27);
            this.chkTenGV.TabIndex = 1;
            this.chkTenGV.Text = "Tìm theo tên giáo viên";
            this.chkTenGV.UseVisualStyleBackColor = true;
            this.chkTenGV.CheckedChanged += new System.EventHandler(this.chkTenGV_CheckedChanged);
            // 
            // chkMaGV
            // 
            this.chkMaGV.AutoSize = true;
            this.chkMaGV.Location = new System.Drawing.Point(6, 26);
            this.chkMaGV.Name = "chkMaGV";
            this.chkMaGV.Size = new System.Drawing.Size(217, 27);
            this.chkMaGV.TabIndex = 0;
            this.chkMaGV.Text = "Tìm theo mã giáo viên";
            this.chkMaGV.UseVisualStyleBackColor = true;
            this.chkMaGV.CheckedChanged += new System.EventHandler(this.chkMaGV_CheckedChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(590, 125);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(91, 35);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(760, 368);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 59);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa giáo viên";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(760, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 59);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa giáo viên";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(760, 594);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(107, 59);
            this.btnXem.TabIndex = 6;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(760, 701);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 59);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbPhuongThucTimKiem
            // 
            this.grbPhuongThucTimKiem.Controls.Add(this.chkMaGV);
            this.grbPhuongThucTimKiem.Controls.Add(this.chkTenGV);
            this.grbPhuongThucTimKiem.ForeColor = System.Drawing.Color.Navy;
            this.grbPhuongThucTimKiem.Location = new System.Drawing.Point(173, 161);
            this.grbPhuongThucTimKiem.Name = "grbPhuongThucTimKiem";
            this.grbPhuongThucTimKiem.Size = new System.Drawing.Size(265, 90);
            this.grbPhuongThucTimKiem.TabIndex = 1;
            this.grbPhuongThucTimKiem.TabStop = false;
            this.grbPhuongThucTimKiem.Text = "Chọn phương thức tìm kiếm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(760, 253);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 59);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm Giáo Viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(306, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quản Lí Giáo Viên";
            // 
            // frmQuanLiGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 790);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbPhuongThucTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Giáo Viên";
            this.Load += new System.EventHandler(this.frmQuanLiGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.grbPhuongThucTimKiem.ResumeLayout(false);
            this.grbPhuongThucTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvGiaoVien;
        private System.Windows.Forms.CheckBox chkTenGV;
        private System.Windows.Forms.CheckBox chkMaGV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grbPhuongThucTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiGiaoVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
    }
}