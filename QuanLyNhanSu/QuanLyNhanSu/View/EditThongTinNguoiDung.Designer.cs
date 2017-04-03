namespace QuanLyNhanSu.View
{
    partial class EditThongTinNguoiDung
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
            this.grbThongTinNguoiDung = new System.Windows.Forms.GroupBox();
            this.cbbNhomQuyen = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbNhomQuyen = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btGhiNhan = new System.Windows.Forms.Button();
            this.grbThongTinNguoiDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThongTinNguoiDung
            // 
            this.grbThongTinNguoiDung.Controls.Add(this.cbbNhomQuyen);
            this.grbThongTinNguoiDung.Controls.Add(this.txtPassword);
            this.grbThongTinNguoiDung.Controls.Add(this.txtUserName);
            this.grbThongTinNguoiDung.Controls.Add(this.lbNhomQuyen);
            this.grbThongTinNguoiDung.Controls.Add(this.lbPassword);
            this.grbThongTinNguoiDung.Controls.Add(this.lbUserName);
            this.grbThongTinNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinNguoiDung.Name = "grbThongTinNguoiDung";
            this.grbThongTinNguoiDung.Size = new System.Drawing.Size(387, 167);
            this.grbThongTinNguoiDung.TabIndex = 5;
            this.grbThongTinNguoiDung.TabStop = false;
            this.grbThongTinNguoiDung.Text = "Thông Tin Người Dùng";
            // 
            // cbbNhomQuyen
            // 
            this.cbbNhomQuyen.FormattingEnabled = true;
            this.cbbNhomQuyen.Location = new System.Drawing.Point(88, 117);
            this.cbbNhomQuyen.Name = "cbbNhomQuyen";
            this.cbbNhomQuyen.Size = new System.Drawing.Size(276, 21);
            this.cbbNhomQuyen.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(88, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(276, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(88, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(276, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lbNhomQuyen
            // 
            this.lbNhomQuyen.AutoSize = true;
            this.lbNhomQuyen.Location = new System.Drawing.Point(15, 120);
            this.lbNhomQuyen.Name = "lbNhomQuyen";
            this.lbNhomQuyen.Size = new System.Drawing.Size(67, 13);
            this.lbNhomQuyen.TabIndex = 2;
            this.lbNhomQuyen.Text = "Nhóm quyền";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(15, 76);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(15, 31);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(58, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Username ";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(324, 185);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btGhiNhan
            // 
            this.btGhiNhan.Location = new System.Drawing.Point(234, 185);
            this.btGhiNhan.Name = "btGhiNhan";
            this.btGhiNhan.Size = new System.Drawing.Size(75, 23);
            this.btGhiNhan.TabIndex = 3;
            this.btGhiNhan.Text = "&Ghi Nhận";
            this.btGhiNhan.UseVisualStyleBackColor = true;
            // 
            // frmEditThongTinNguoiDungcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 223);
            this.Controls.Add(this.grbThongTinNguoiDung);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btGhiNhan);
            this.Name = "frmEditThongTinNguoiDungcs";
            this.Text = "Sửa thông tin người dùng";
            this.grbThongTinNguoiDung.ResumeLayout(false);
            this.grbThongTinNguoiDung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinNguoiDung;
        private System.Windows.Forms.ComboBox cbbNhomQuyen;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbNhomQuyen;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btGhiNhan;
    }
}