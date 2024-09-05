namespace QuanLyHocSinh.QuanLiTaiKhoan
{
    partial class frmThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTKDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLoaiTK = new System.Windows.Forms.ComboBox();
            this.lblThongTinLienKet = new System.Windows.Forms.Label();
            this.cbxThongTinLienKet = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản:";
            // 
            // txtTKDangNhap
            // 
            this.txtTKDangNhap.Location = new System.Drawing.Point(183, 37);
            this.txtTKDangNhap.MaxLength = 30;
            this.txtTKDangNhap.Name = "txtTKDangNhap";
            this.txtTKDangNhap.Size = new System.Drawing.Size(198, 30);
            this.txtTKDangNhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(85, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(183, 121);
            this.txtMatKhau.MaxLength = 30;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(198, 30);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(85, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Tài Khoản:";
            // 
            // cbxLoaiTK
            // 
            this.cbxLoaiTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiTK.FormattingEnabled = true;
            this.cbxLoaiTK.Location = new System.Drawing.Point(260, 180);
            this.cbxLoaiTK.Name = "cbxLoaiTK";
            this.cbxLoaiTK.Size = new System.Drawing.Size(121, 31);
            this.cbxLoaiTK.TabIndex = 2;
            this.cbxLoaiTK.SelectedIndexChanged += new System.EventHandler(this.cbxLoaiTK_SelectedIndexChanged);
            // 
            // lblThongTinLienKet
            // 
            this.lblThongTinLienKet.AutoSize = true;
            this.lblThongTinLienKet.ForeColor = System.Drawing.Color.Navy;
            this.lblThongTinLienKet.Location = new System.Drawing.Point(85, 262);
            this.lblThongTinLienKet.Name = "lblThongTinLienKet";
            this.lblThongTinLienKet.Size = new System.Drawing.Size(60, 23);
            this.lblThongTinLienKet.TabIndex = 4;
            this.lblThongTinLienKet.Text = "label4";
            // 
            // cbxThongTinLienKet
            // 
            this.cbxThongTinLienKet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThongTinLienKet.FormattingEnabled = true;
            this.cbxThongTinLienKet.Location = new System.Drawing.Point(260, 259);
            this.cbxThongTinLienKet.Name = "cbxThongTinLienKet";
            this.cbxThongTinLienKet.Size = new System.Drawing.Size(121, 31);
            this.cbxThongTinLienKet.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(89, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 48);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(284, 348);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 408);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxThongTinLienKet);
            this.Controls.Add(this.lblThongTinLienKet);
            this.Controls.Add(this.cbxLoaiTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTKDangNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Tài Khoản";
            this.Load += new System.EventHandler(this.frmThemTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTKDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLoaiTK;
        private System.Windows.Forms.Label lblThongTinLienKet;
        private System.Windows.Forms.ComboBox cbxThongTinLienKet;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}