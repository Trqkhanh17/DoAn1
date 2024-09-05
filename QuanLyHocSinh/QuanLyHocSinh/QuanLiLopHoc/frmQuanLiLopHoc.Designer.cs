namespace QuanLyHocSinh.QuanLiLopHoc
{
    partial class frmQuanLiLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiLopHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.dgvDanhSachLopHoc = new System.Windows.Forms.DataGridView();
            this.MaLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVienChuNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(134, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(240, 9);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(152, 30);
            this.txtTim.TabIndex = 0;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // 
            // dgvDanhSachLopHoc
            // 
            this.dgvDanhSachLopHoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLopHoc,
            this.SoLuongHocSinh,
            this.GiaoVienChuNhiem});
            this.dgvDanhSachLopHoc.Location = new System.Drawing.Point(1, 45);
            this.dgvDanhSachLopHoc.Name = "dgvDanhSachLopHoc";
            this.dgvDanhSachLopHoc.RowHeadersWidth = 51;
            this.dgvDanhSachLopHoc.RowTemplate.Height = 24;
            this.dgvDanhSachLopHoc.Size = new System.Drawing.Size(496, 365);
            this.dgvDanhSachLopHoc.TabIndex = 7;
            this.dgvDanhSachLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLopHoc_CellContentClick);
            // 
            // MaLopHoc
            // 
            this.MaLopHoc.DataPropertyName = "MaLop";
            this.MaLopHoc.HeaderText = "Mã Lớp";
            this.MaLopHoc.MinimumWidth = 6;
            this.MaLopHoc.Name = "MaLopHoc";
            this.MaLopHoc.Width = 125;
            // 
            // SoLuongHocSinh
            // 
            this.SoLuongHocSinh.DataPropertyName = "SiSo";
            this.SoLuongHocSinh.HeaderText = "Sỉ Số";
            this.SoLuongHocSinh.MinimumWidth = 6;
            this.SoLuongHocSinh.Name = "SoLuongHocSinh";
            this.SoLuongHocSinh.Width = 125;
            // 
            // GiaoVienChuNhiem
            // 
            this.GiaoVienChuNhiem.DataPropertyName = "MaGVCN";
            this.GiaoVienChuNhiem.HeaderText = "Giáo Viên Chủ Nhiệm";
            this.GiaoVienChuNhiem.MinimumWidth = 6;
            this.GiaoVienChuNhiem.Name = "GiaoVienChuNhiem";
            this.GiaoVienChuNhiem.Width = 125;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(408, 7);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 34);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(514, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 45);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm lớp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(514, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 45);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa lớp";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(514, 143);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 45);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa lớp";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(514, 283);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(102, 61);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem chi tiết";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(514, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 45);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLiLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 418);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dgvDanhSachLopHoc);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Lớp Học";
            this.Load += new System.EventHandler(this.frmQuanLiLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.DataGridView dgvDanhSachLopHoc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVienChuNhiem;
    }
}