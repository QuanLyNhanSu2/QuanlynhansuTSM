namespace Quanlynhansu.View
{
    partial class HDSD
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thêm");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sửa");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Xóa");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Khác", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Chức năng admin", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Chức năng người dùng");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.wbrChucnang = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Thêm";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Sửa";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Xóa";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Node8";
            treeNode5.Name = "Node9";
            treeNode5.Text = "Node9";
            treeNode6.Name = "Node7";
            treeNode6.Text = "Khác";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Chức năng admin";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Chức năng người dùng";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(158, 384);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // wbrChucnang
            // 
            this.wbrChucnang.Location = new System.Drawing.Point(176, 12);
            this.wbrChucnang.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrChucnang.Name = "wbrChucnang";
            this.wbrChucnang.Size = new System.Drawing.Size(509, 384);
            this.wbrChucnang.TabIndex = 1;
            // 
            // HDSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 408);
            this.Controls.Add(this.wbrChucnang);
            this.Controls.Add(this.treeView1);
            this.Name = "HDSD";
            this.Text = "Hướng đẫn sử dụng ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser wbrChucnang;
    }
}