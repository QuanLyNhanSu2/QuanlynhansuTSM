namespace QuanLySinhVien.View
{
    partial class ThongTinSinhVien
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
            this.lbHoten = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btGhiNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Location = new System.Drawing.Point(22, 20);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(54, 13);
            this.lbHoten.TabIndex = 0;
            this.lbHoten.Text = "Họ và tên";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Location = new System.Drawing.Point(22, 173);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(39, 13);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "Mã lớp";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(22, 119);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 2;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(22, 72);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(67, 13);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "Mã sinh viên";
            // 
            // btGhiNhan
            // 
            this.btGhiNhan.Location = new System.Drawing.Point(155, 227);
            this.btGhiNhan.Name = "btGhiNhan";
            this.btGhiNhan.Size = new System.Drawing.Size(75, 23);
            this.btGhiNhan.TabIndex = 4;
            this.btGhiNhan.Text = "&Ghi nhận";
            this.btGhiNhan.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(236, 227);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(95, 20);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(216, 20);
            this.txtHoten.TabIndex = 6;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(95, 166);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(216, 20);
            this.txtMaLop.TabIndex = 8;
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(95, 65);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(216, 20);
            this.txtMaSinhVien.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(95, 112);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(216, 20);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // ThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 279);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGhiNhan);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.lbHoten);
            this.Name = "ThongTinSinhVien";
            this.Text = "Thông tin sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btGhiNhan;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}