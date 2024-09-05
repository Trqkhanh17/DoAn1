namespace QuanLyHocSinh.QuanLiLopHoc
{
    partial class frmXemChiTietLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemChiTietLop));
            this.dgvDanhSachHocSinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachHocSinh
            // 
            this.dgvDanhSachHocSinh.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDanhSachHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHocSinh.Location = new System.Drawing.Point(-8, 133);
            this.dgvDanhSachHocSinh.Name = "dgvDanhSachHocSinh";
            this.dgvDanhSachHocSinh.RowHeadersWidth = 51;
            this.dgvDanhSachHocSinh.RowTemplate.Height = 24;
            this.dgvDanhSachHocSinh.Size = new System.Drawing.Size(908, 501);
            this.dgvDanhSachHocSinh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HỌC SINH CỦA LỚP:";
            // 
            // frmXemChiTietLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachHocSinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemChiTietLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem Chi Tiết";
            this.Load += new System.EventHandler(this.frmXemChiTietLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachHocSinh;
        private System.Windows.Forms.Label label1;
    }
}