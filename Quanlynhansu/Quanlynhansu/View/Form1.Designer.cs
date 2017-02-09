namespace Quanlynhansu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 93);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 328);
            this.panel2.TabIndex = 2;
            // 
            // pnlmain
            // 
            this.pnlmain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(210, 117);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(988, 328);
            this.pnlmain.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 445);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlmain;
    }
}

