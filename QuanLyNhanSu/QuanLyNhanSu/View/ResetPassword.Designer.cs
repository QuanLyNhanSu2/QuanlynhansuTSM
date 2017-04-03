namespace QuanLyNhanSu.View
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThayDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThayDoiMatKhau
            // 
            this.grbThayDoiMatKhau.Controls.Add(this.textBox1);
            this.grbThayDoiMatKhau.Controls.Add(this.label1);
            this.grbThayDoiMatKhau.Controls.Add(this.txtMatKhauMoi);
            this.grbThayDoiMatKhau.Controls.Add(this.txtMatKhauCu);
            this.grbThayDoiMatKhau.Controls.Add(this.lbMatKhauMoi);
            this.grbThayDoiMatKhau.Controls.Add(this.lbMatKhauCu);
            this.grbThayDoiMatKhau.Location = new System.Drawing.Point(11, 12);
            this.grbThayDoiMatKhau.Name = "grbThayDoiMatKhau";
            this.grbThayDoiMatKhau.Size = new System.Drawing.Size(366, 129);
            this.grbThayDoiMatKhau.TabIndex = 3;
            this.grbThayDoiMatKhau.TabStop = false;
            this.grbThayDoiMatKhau.Text = "Thay đổi mật khẩu";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(108, 91);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(227, 20);
            this.txtMatKhauMoi.TabIndex = 2;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(108, 56);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(227, 20);
            this.txtMatKhauCu.TabIndex = 1;
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(9, 94);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(93, 13);
            this.lbMatKhauMoi.TabIndex = 2;
            this.lbMatKhauMoi.Text = "Nhập lại mật khẩu";
            // 
            // lbMatKhauCu
            // 
            this.lbMatKhauCu.AutoSize = true;
            this.lbMatKhauCu.Location = new System.Drawing.Point(9, 59);
            this.lbMatKhauCu.Name = "lbMatKhauCu";
            this.lbMatKhauCu.Size = new System.Drawing.Size(52, 13);
            this.lbMatKhauCu.TabIndex = 1;
            this.lbMatKhauCu.Text = "Mật khẩu";
            // 
            // btGhiNhan
            // 
            this.btGhiNhan.Location = new System.Drawing.Point(204, 149);
            this.btGhiNhan.Name = "btGhiNhan";
            this.btGhiNhan.Size = new System.Drawing.Size(75, 23);
            this.btGhiNhan.TabIndex = 0;
            this.btGhiNhan.Text = "Đăng ký";
            this.btGhiNhan.UseVisualStyleBackColor = true;
            this.btGhiNhan.Click += new System.EventHandler(this.btGhiNhan_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(302, 149);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 192);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}