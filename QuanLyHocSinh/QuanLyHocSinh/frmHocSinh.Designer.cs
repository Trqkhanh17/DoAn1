namespace QuanLyHocSinh
{
    partial class frmHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.dgvDiemSo = new System.Windows.Forms.DataGridView();
            this.TenMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGiuaHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTrungBinhMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuaHocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(207, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "THÔNG TIN HỌC SINH";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Navy;
            this.lblTaiKhoan.Location = new System.Drawing.Point(570, 367);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(60, 23);
            this.lblTaiKhoan.TabIndex = 39;
            this.lblTaiKhoan.Text = "label7";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.ForeColor = System.Drawing.Color.Navy;
            this.lblNamHoc.Location = new System.Drawing.Point(263, 367);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(70, 23);
            this.lblNamHoc.TabIndex = 37;
            this.lblNamHoc.Text = "label13";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.ForeColor = System.Drawing.Color.Navy;
            this.lblDiaChi.Location = new System.Drawing.Point(12, 367);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(70, 23);
            this.lblDiaChi.TabIndex = 38;
            this.lblDiaChi.Text = "label13";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.Color.Navy;
            this.lblSDT.Location = new System.Drawing.Point(263, 262);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(60, 23);
            this.lblSDT.TabIndex = 31;
            this.lblSDT.Text = "label1";
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.ForeColor = System.Drawing.Color.Navy;
            this.lblTenHS.Location = new System.Drawing.Point(263, 153);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(60, 23);
            this.lblTenHS.TabIndex = 32;
            this.lblTenHS.Text = "label1";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Navy;
            this.lblGioiTinh.Location = new System.Drawing.Point(570, 153);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 23);
            this.lblGioiTinh.TabIndex = 35;
            this.lblGioiTinh.Text = "label1";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.ForeColor = System.Drawing.Color.Navy;
            this.lblLop.Location = new System.Drawing.Point(570, 262);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(60, 23);
            this.lblLop.TabIndex = 34;
            this.lblLop.Text = "label1";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Navy;
            this.lblNgaySinh.Location = new System.Drawing.Point(12, 262);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 23);
            this.lblNgaySinh.TabIndex = 33;
            this.lblNgaySinh.Text = "label1";
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.ForeColor = System.Drawing.Color.Navy;
            this.lblMaHS.Location = new System.Drawing.Point(12, 153);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(60, 23);
            this.lblMaHS.TabIndex = 36;
            this.lblMaHS.Text = "label1";
            // 
            // dgvDiemSo
            // 
            this.dgvDiemSo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDiemSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMonHoc,
            this.Diem15phut,
            this.DiemGiuaHocKi,
            this.DiemCuoiHocKi,
            this.DiemTrungBinhMon,
            this.DiemCuaHocKi});
            this.dgvDiemSo.Location = new System.Drawing.Point(0, 393);
            this.dgvDiemSo.Name = "dgvDiemSo";
            this.dgvDiemSo.RowHeadersWidth = 51;
            this.dgvDiemSo.RowTemplate.Height = 24;
            this.dgvDiemSo.Size = new System.Drawing.Size(934, 335);
            this.dgvDiemSo.TabIndex = 41;
            // 
            // TenMonHoc
            // 
            this.TenMonHoc.DataPropertyName = "TenMon";
            this.TenMonHoc.HeaderText = "Tên Môn Học";
            this.TenMonHoc.MinimumWidth = 6;
            this.TenMonHoc.Name = "TenMonHoc";
            this.TenMonHoc.Width = 125;
            // 
            // Diem15phut
            // 
            this.Diem15phut.DataPropertyName = "Diem15p";
            this.Diem15phut.HeaderText = "Điểm 15 Phút";
            this.Diem15phut.MinimumWidth = 6;
            this.Diem15phut.Name = "Diem15phut";
            this.Diem15phut.Width = 125;
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
            this.DiemCuoiHocKi.HeaderText = "Điểm Cuối Học Kì";
            this.DiemCuoiHocKi.MinimumWidth = 6;
            this.DiemCuoiHocKi.Name = "DiemCuoiHocKi";
            this.DiemCuoiHocKi.Width = 125;
            // 
            // DiemTrungBinhMon
            // 
            this.DiemTrungBinhMon.DataPropertyName = "DiemTrungBinh";
            this.DiemTrungBinhMon.HeaderText = "Điểm Trung Bình";
            this.DiemTrungBinhMon.MinimumWidth = 6;
            this.DiemTrungBinhMon.Name = "DiemTrungBinhMon";
            this.DiemTrungBinhMon.Width = 125;
            // 
            // DiemCuaHocKi
            // 
            this.DiemCuaHocKi.DataPropertyName = "HocKi";
            this.DiemCuaHocKi.HeaderText = "Học Kì";
            this.DiemCuaHocKi.MinimumWidth = 6;
            this.DiemCuaHocKi.Name = "DiemCuaHocKi";
            this.DiemCuaHocKi.Width = 125;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 718);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTenHS);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvDiemSo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHocSinh_FormClosing);
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.DataGridView dgvDiemSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGiuaHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiHocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTrungBinhMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuaHocKi;
    }
}