namespace QuanLyHocSinh
{
    partial class frmQuanLiLoaiTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiLoaiTaiKhoan));
            this.dgvDanhSachLoaiTK = new System.Windows.Forms.DataGridView();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemLoaiTK = new System.Windows.Forms.Button();
            this.btnXoaLoaiTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachLoaiTK
            // 
            this.dgvDanhSachLoaiTK.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachLoaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLoaiTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiTaiKhoan});
            this.dgvDanhSachLoaiTK.Location = new System.Drawing.Point(0, 6);
            this.dgvDanhSachLoaiTK.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDanhSachLoaiTK.Name = "dgvDanhSachLoaiTK";
            this.dgvDanhSachLoaiTK.RowHeadersWidth = 51;
            this.dgvDanhSachLoaiTK.RowTemplate.Height = 24;
            this.dgvDanhSachLoaiTK.Size = new System.Drawing.Size(293, 586);
            this.dgvDanhSachLoaiTK.TabIndex = 3;
            this.dgvDanhSachLoaiTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLoaiTK_CellContentClick);
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTK";
            this.LoaiTaiKhoan.HeaderText = "Loại Tài Khoản";
            this.LoaiTaiKhoan.MinimumWidth = 6;
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.Width = 125;
            // 
            // btnThemLoaiTK
            // 
            this.btnThemLoaiTK.Location = new System.Drawing.Point(331, 38);
            this.btnThemLoaiTK.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemLoaiTK.Name = "btnThemLoaiTK";
            this.btnThemLoaiTK.Size = new System.Drawing.Size(149, 67);
            this.btnThemLoaiTK.TabIndex = 0;
            this.btnThemLoaiTK.Text = "Thêm";
            this.btnThemLoaiTK.UseVisualStyleBackColor = true;
            this.btnThemLoaiTK.Click += new System.EventHandler(this.btnThemLoaiTK_Click);
            // 
            // btnXoaLoaiTK
            // 
            this.btnXoaLoaiTK.Location = new System.Drawing.Point(331, 138);
            this.btnXoaLoaiTK.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaLoaiTK.Name = "btnXoaLoaiTK";
            this.btnXoaLoaiTK.Size = new System.Drawing.Size(149, 67);
            this.btnXoaLoaiTK.TabIndex = 1;
            this.btnXoaLoaiTK.Text = "Xóa";
            this.btnXoaLoaiTK.UseVisualStyleBackColor = true;
            this.btnXoaLoaiTK.Click += new System.EventHandler(this.btnXoaLoaiTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(331, 515);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 67);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLiLoaiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 594);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaLoaiTK);
            this.Controls.Add(this.btnThemLoaiTK);
            this.Controls.Add(this.dgvDanhSachLoaiTK);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmQuanLiLoaiTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lí Loại Tài Khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLiLoaiTaiKhoan_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLiLoaiTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLoaiTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachLoaiTK;
        private System.Windows.Forms.Button btnThemLoaiTK;
        private System.Windows.Forms.Button btnXoaLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
    }
}