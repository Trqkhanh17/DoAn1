namespace QuanLyHocSinh
{
    partial class frmQuanLiMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvDanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chkTen = new System.Windows.Forms.CheckBox();
            this.chkMa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(119, 38);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(243, 30);
            this.txtTim.TabIndex = 0;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(368, 41);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 27);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvDanhSachMonHoc
            // 
            this.dgvDanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH});
            this.dgvDanhSachMonHoc.Location = new System.Drawing.Point(3, 115);
            this.dgvDanhSachMonHoc.Name = "dgvDanhSachMonHoc";
            this.dgvDanhSachMonHoc.RowHeadersWidth = 51;
            this.dgvDanhSachMonHoc.RowTemplate.Height = 24;
            this.dgvDanhSachMonHoc.Size = new System.Drawing.Size(424, 397);
            this.dgvDanhSachMonHoc.TabIndex = 8;
            this.dgvDanhSachMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMonHoc_CellContentClick);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMon";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 125;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMon";
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(433, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 58);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm Môn Học";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(433, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 58);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa Môn Học";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(433, 347);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 58);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa Môn Học";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(433, 446);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 58);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chkTen
            // 
            this.chkTen.AutoSize = true;
            this.chkTen.ForeColor = System.Drawing.Color.Navy;
            this.chkTen.Location = new System.Drawing.Point(211, 74);
            this.chkTen.Name = "chkTen";
            this.chkTen.Size = new System.Drawing.Size(151, 27);
            this.chkTen.TabIndex = 2;
            this.chkTen.Text = "Tìm Theo Tên";
            this.chkTen.UseVisualStyleBackColor = true;
            this.chkTen.CheckedChanged += new System.EventHandler(this.chkTen_CheckedChanged);
            // 
            // chkMa
            // 
            this.chkMa.AutoSize = true;
            this.chkMa.ForeColor = System.Drawing.Color.Navy;
            this.chkMa.Location = new System.Drawing.Point(81, 74);
            this.chkMa.Name = "chkMa";
            this.chkMa.Size = new System.Drawing.Size(147, 27);
            this.chkMa.TabIndex = 1;
            this.chkMa.Text = "Tìm Theo Mã";
            this.chkMa.UseVisualStyleBackColor = true;
            this.chkMa.CheckedChanged += new System.EventHandler(this.chkMa_CheckedChanged);
            // 
            // frmQuanLiMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 516);
            this.Controls.Add(this.chkMa);
            this.Controls.Add(this.chkTen);
            this.Controls.Add(this.dgvDanhSachMonHoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Môn Học";
            this.Load += new System.EventHandler(this.frmQuanLiMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvDanhSachMonHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chkTen;
        private System.Windows.Forms.CheckBox chkMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
    }
}