namespace QuanLyNhanSu.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.llbQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 91);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(10, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(10, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkCyan;
            this.linkLabel1.Location = new System.Drawing.Point(235, 151);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Chưa có tài khoản ";
            // 
            // llbQuenMatKhau
            // 
            this.llbQuenMatKhau.AutoSize = true;
            this.llbQuenMatKhau.LinkColor = System.Drawing.Color.Red;
            this.llbQuenMatKhau.Location = new System.Drawing.Point(15, 151);
            this.llbQuenMatKhau.Name = "llbQuenMatKhau";
            this.llbQuenMatKhau.Size = new System.Drawing.Size(80, 13);
            this.llbQuenMatKhau.TabIndex = 16;
            this.llbQuenMatKhau.TabStop = true;
            this.llbQuenMatKhau.Text = "Quên mật khẩu";
            this.llbQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQuenMatKhau_LinkClicked);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Azure;
            this.btLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btLogin.Location = new System.Drawing.Point(18, 109);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(314, 30);
            this.btLogin.TabIndex = 15;
            this.btLogin.Text = "Sign In";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 185);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.llbQuenMatKhau);
            this.Controls.Add(this.btLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel llbQuenMatKhau;
        private System.Windows.Forms.Button btLogin;
    }
}