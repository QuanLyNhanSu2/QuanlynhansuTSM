namespace QuanLySinhVien.View
{
    partial class frmResetPassword
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
            this.grbThayDoiMatKhau = new System.Windows.Forms.GroupBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbMatKhauCu = new System.Windows.Forms.Label();
            this.btGhiNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.grbThayDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThayDoiMatKhau
            // 
            this.grbThayDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.grbThayDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.grbThayDoiMatKhau.Controls.Add(this.lbMatKhauMoi);
            this.grbThayDoiMatKhau.Controls.Add(this.lbMatKhauCu);
            this.grbThayDoiMatKhau.Location = new System.Drawing.Point(12, 12);
            this.grbThayDoiMatKhau.Name = "grbThayDoiMatKhau";
            this.grbThayDoiMatKhau.Size = new System.Drawing.Size(366, 129);
            this.grbThayDoiMatKhau.TabIndex = 6;
            this.grbThayDoiMatKhau.TabStop = false;
            this.grbThayDoiMatKhau.Text = "Thay đổi mật khẩu";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(108, 74);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(227, 20);
            this.txtMatKhauMoi.TabIndex = 4;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(108, 36);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(227, 20);
            this.txtMatKhauCu.TabIndex = 3;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(15, 74);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(71, 13);
            this.lbMatKhauMoi.TabIndex = 2;
            this.lbMatKhauMoi.Text = "Mật khẩu mới";
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.Location = new System.Drawing.Point(15, 39);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(70, 13);
            this.lbMatKhauCu.TabIndex = 1;
            this.lbMatKhauCu.Text = "Mật khẩu cũ ";
            // 
            // btGhiNhan
            // 
            this.btGhiNhan.Location = new System.Drawing.Point(205, 149);
            this.btGhiNhan.Name = "btGhiNhan";
            this.btGhiNhan.Size = new System.Drawing.Size(75, 23);
            this.btGhiNhan.TabIndex = 8;
            this.btGhiNhan.Text = "Ghi nhận";
            this.btGhiNhan.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(303, 149);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 192);
            this.Controls.Add(this.grbThayDoiMatKhau);
            this.Controls.Add(this.btGhiNhan);
            this.Controls.Add(this.btThoat);
            this.Name = "frmResetPassword";
            this.Text = "Reset Password";
            this.grbThayDoiMatKhau.ResumeLayout(false);
            this.grbThayDoiMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThayDoiMatKhau;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbMatKhauCu;
        private System.Windows.Forms.Button btGhiNhan;
        private System.Windows.Forms.Button btThoat;
    }
}