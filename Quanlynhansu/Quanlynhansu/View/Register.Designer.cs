namespace Quanlynhansu.View
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterUsername = new System.Windows.Forms.TextBox();
            this.errUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.errPassword = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegisterRepassword = new System.Windows.Forms.TextBox();
            this.errRepassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // txtRegisterUsername
            // 
            this.txtRegisterUsername.Location = new System.Drawing.Point(99, 28);
            this.txtRegisterUsername.Name = "txtRegisterUsername";
            this.txtRegisterUsername.Size = new System.Drawing.Size(204, 20);
            this.txtRegisterUsername.TabIndex = 0;
            // 
            // errUsername
            // 
            this.errUsername.AutoSize = true;
            this.errUsername.Location = new System.Drawing.Point(96, 51);
            this.errUsername.Name = "errUsername";
            this.errUsername.Size = new System.Drawing.Size(35, 13);
            this.errUsername.TabIndex = 2;
            this.errUsername.Text = "label2";
            this.errUsername.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(99, 77);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(204, 20);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // errPassword
            // 
            this.errPassword.AutoSize = true;
            this.errPassword.Location = new System.Drawing.Point(96, 100);
            this.errPassword.Name = "errPassword";
            this.errPassword.Size = new System.Drawing.Size(35, 13);
            this.errPassword.TabIndex = 2;
            this.errPassword.Text = "label2";
            this.errPassword.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Repassword";
            // 
            // txtRegisterRepassword
            // 
            this.txtRegisterRepassword.Location = new System.Drawing.Point(99, 125);
            this.txtRegisterRepassword.Name = "txtRegisterRepassword";
            this.txtRegisterRepassword.Size = new System.Drawing.Size(204, 20);
            this.txtRegisterRepassword.TabIndex = 2;
            // 
            // errRepassword
            // 
            this.errRepassword.AutoSize = true;
            this.errRepassword.Location = new System.Drawing.Point(96, 148);
            this.errRepassword.Name = "errRepassword";
            this.errRepassword.Size = new System.Drawing.Size(35, 13);
            this.errRepassword.TabIndex = 2;
            this.errRepassword.Text = "label2";
            this.errRepassword.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errRepassword);
            this.Controls.Add(this.errPassword);
            this.Controls.Add(this.errUsername);
            this.Controls.Add(this.txtRegisterRepassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegisterUsername);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterUsername;
        private System.Windows.Forms.Label errUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label errPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegisterRepassword;
        private System.Windows.Forms.Label errRepassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}