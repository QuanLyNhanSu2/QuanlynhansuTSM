namespace Quanlynhansu.View
{
    partial class HuongDanSuDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Thêm");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Sửa");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Xóa");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Khác", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Chức năng admin", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Chức năng người dùng ", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35});
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(332, 12);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(367, 21);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Hướng dẫn sử dụng phần mềm quản lý nhân sự ";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 46);
            this.treeView1.Name = "treeView1";
            treeNode25.Name = "Node2";
            treeNode25.Text = "Thêm";
            treeNode26.Name = "Node3";
            treeNode26.Text = "Sửa";
            treeNode27.Name = "Node4";
            treeNode27.Text = "Xóa";
            treeNode28.Name = "Node9";
            treeNode28.Text = "Node9";
            treeNode29.Name = "Node10";
            treeNode29.Text = "Node10";
            treeNode30.Name = "Node11";
            treeNode30.Text = "Node11";
            treeNode31.Name = "Node8";
            treeNode31.Text = "Khác";
            treeNode32.Name = "Node0";
            treeNode32.Text = "Chức năng admin";
            treeNode33.Name = "Node5";
            treeNode33.Text = "Node5";
            treeNode34.Name = "Node6";
            treeNode34.Text = "Node6";
            treeNode35.Name = "Node7";
            treeNode35.Text = "Node7";
            treeNode36.Name = "Node1";
            treeNode36.Text = "Chức năng người dùng ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode36});
            this.treeView1.Size = new System.Drawing.Size(168, 400);
            this.treeView1.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(200, 46);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(841, 400);
            this.webBrowser1.TabIndex = 2;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(913, 475);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // HuongDanSuDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "HuongDanSuDung";
            this.Size = new System.Drawing.Size(1066, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btThoat;
    }
}
