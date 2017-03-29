namespace QuanLySinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thống kê theo lớp");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thống kê theo giáo viên");
            this.tbcQuanLiSinhVien = new System.Windows.Forms.TabControl();
            this.tpStudentInformation = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvThongTinSinhVien = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.tpCoachInformation = new System.Windows.Forms.TabPage();
            this.grbDanhSachGiaoVien = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoaGV = new System.Windows.Forms.Button();
            this.btSuaGV = new System.Windows.Forms.Button();
            this.btThemGiaoVien = new System.Windows.Forms.Button();
            this.tpThongTinGiangDay = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbpHuongDanSuDung = new System.Windows.Forms.TabPage();
            this.gbHuongDanSuDung = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.trvHuongDanSuDung = new System.Windows.Forms.TreeView();
            this.tbcQuanLiSinhVien.SuspendLayout();
            this.tpStudentInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).BeginInit();
            this.tpCoachInformation.SuspendLayout();
            this.grbDanhSachGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpThongTinGiangDay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tbpHuongDanSuDung.SuspendLayout();
            this.gbHuongDanSuDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcQuanLiSinhVien
            // 
            this.tbcQuanLiSinhVien.Controls.Add(this.tpStudentInformation);
            this.tbcQuanLiSinhVien.Controls.Add(this.tpCoachInformation);
            this.tbcQuanLiSinhVien.Controls.Add(this.tpThongTinGiangDay);
            this.tbcQuanLiSinhVien.Controls.Add(this.tbpHuongDanSuDung);
            this.tbcQuanLiSinhVien.Location = new System.Drawing.Point(0, 1);
            this.tbcQuanLiSinhVien.Name = "tbcQuanLiSinhVien";
            this.tbcQuanLiSinhVien.SelectedIndex = 0;
            this.tbcQuanLiSinhVien.Size = new System.Drawing.Size(805, 473);
            this.tbcQuanLiSinhVien.TabIndex = 0;
            // 
            // tpStudentInformation
            // 
            this.tpStudentInformation.BackColor = System.Drawing.Color.Transparent;
            this.tpStudentInformation.Controls.Add(this.button2);
            this.tpStudentInformation.Controls.Add(this.button3);
            this.tpStudentInformation.Controls.Add(this.button4);
            this.tpStudentInformation.Controls.Add(this.button1);
            this.tpStudentInformation.Controls.Add(this.groupBox1);
            this.tpStudentInformation.Controls.Add(this.txtTimKiem);
            this.tpStudentInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpStudentInformation.Location = new System.Drawing.Point(4, 22);
            this.tpStudentInformation.Name = "tpStudentInformation";
            this.tpStudentInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentInformation.Size = new System.Drawing.Size(797, 447);
            this.tpStudentInformation.TabIndex = 0;
            this.tpStudentInformation.Text = "Thông tin học sinh";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(23, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "&Xóa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(23, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 35);
            this.button3.TabIndex = 17;
            this.button3.Text = "&Sửa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(23, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 35);
            this.button4.TabIndex = 16;
            this.button4.Text = "&Thêm";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(705, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tìm Kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThongTinSinhVien);
            this.groupBox1.Location = new System.Drawing.Point(123, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 405);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học sinh";
            // 
            // dgvThongTinSinhVien
            // 
            this.dgvThongTinSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hoten,
            this.dateofbirth,
            this.nameclass,
            this.classid});
            this.dgvThongTinSinhVien.Location = new System.Drawing.Point(9, 19);
            this.dgvThongTinSinhVien.Name = "dgvThongTinSinhVien";
            this.dgvThongTinSinhVien.Size = new System.Drawing.Size(656, 380);
            this.dgvThongTinSinhVien.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.Name = "hoten";
            // 
            // dateofbirth
            // 
            this.dateofbirth.HeaderText = "Ngày sinh";
            this.dateofbirth.Name = "dateofbirth";
            // 
            // nameclass
            // 
            this.nameclass.HeaderText = "Tên lớp";
            this.nameclass.Name = "nameclass";
            // 
            // classid
            // 
            this.classid.HeaderText = "ID Class";
            this.classid.Name = "classid";
            this.classid.Visible = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(441, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // tpCoachInformation
            // 
            this.tpCoachInformation.Controls.Add(this.grbDanhSachGiaoVien);
            this.tpCoachInformation.Controls.Add(this.btTimKiem);
            this.tpCoachInformation.Controls.Add(this.textBox1);
            this.tpCoachInformation.Controls.Add(this.label1);
            this.tpCoachInformation.Controls.Add(this.btXoaGV);
            this.tpCoachInformation.Controls.Add(this.btSuaGV);
            this.tpCoachInformation.Controls.Add(this.btThemGiaoVien);
            this.tpCoachInformation.Location = new System.Drawing.Point(4, 22);
            this.tpCoachInformation.Name = "tpCoachInformation";
            this.tpCoachInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpCoachInformation.Size = new System.Drawing.Size(797, 447);
            this.tpCoachInformation.TabIndex = 1;
            this.tpCoachInformation.Text = "Thông tin giáo viên";
            // 
            // grbDanhSachGiaoVien
            // 
            this.grbDanhSachGiaoVien.Controls.Add(this.dataGridView1);
            this.grbDanhSachGiaoVien.Location = new System.Drawing.Point(120, 42);
            this.grbDanhSachGiaoVien.Name = "grbDanhSachGiaoVien";
            this.grbDanhSachGiaoVien.Size = new System.Drawing.Size(671, 402);
            this.grbDanhSachGiaoVien.TabIndex = 13;
            this.grbDanhSachGiaoVien.TabStop = false;
            this.grbDanhSachGiaoVien.Text = "Danh sách giáo viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.email,
            this.phone,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.Location = new System.Drawing.Point(9, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 381);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên lớp";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Class";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(707, 13);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // btXoaGV
            // 
            this.btXoaGV.Image = ((System.Drawing.Image)(resources.GetObject("btXoaGV.Image")));
            this.btXoaGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaGV.Location = new System.Drawing.Point(23, 390);
            this.btXoaGV.Name = "btXoaGV";
            this.btXoaGV.Size = new System.Drawing.Size(78, 35);
            this.btXoaGV.TabIndex = 9;
            this.btXoaGV.Text = "&Xóa";
            this.btXoaGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaGV.UseVisualStyleBackColor = true;
            // 
            // btSuaGV
            // 
            this.btSuaGV.Image = ((System.Drawing.Image)(resources.GetObject("btSuaGV.Image")));
            this.btSuaGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaGV.Location = new System.Drawing.Point(23, 326);
            this.btSuaGV.Name = "btSuaGV";
            this.btSuaGV.Size = new System.Drawing.Size(78, 35);
            this.btSuaGV.TabIndex = 8;
            this.btSuaGV.Text = "&Sửa";
            this.btSuaGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaGV.UseVisualStyleBackColor = true;
            // 
            // btThemGiaoVien
            // 
            this.btThemGiaoVien.BackColor = System.Drawing.Color.Gainsboro;
            this.btThemGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btThemGiaoVien.Image")));
            this.btThemGiaoVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemGiaoVien.Location = new System.Drawing.Point(23, 260);
            this.btThemGiaoVien.Name = "btThemGiaoVien";
            this.btThemGiaoVien.Size = new System.Drawing.Size(78, 35);
            this.btThemGiaoVien.TabIndex = 7;
            this.btThemGiaoVien.Text = "&Thêm";
            this.btThemGiaoVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemGiaoVien.UseVisualStyleBackColor = false;
            // 
            // tpThongTinGiangDay
            // 
            this.tpThongTinGiangDay.BackColor = System.Drawing.SystemColors.Menu;
            this.tpThongTinGiangDay.Controls.Add(this.groupBox2);
            this.tpThongTinGiangDay.Controls.Add(this.treeView1);
            this.tpThongTinGiangDay.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinGiangDay.Name = "tpThongTinGiangDay";
            this.tpThongTinGiangDay.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinGiangDay.Size = new System.Drawing.Size(797, 447);
            this.tpThongTinGiangDay.TabIndex = 2;
            this.tpThongTinGiangDay.Text = "Thông tin giảng dạy ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(164, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 441);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê danh sách";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(621, 422);
            this.dataGridView2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.Location = new System.Drawing.Point(8, 8);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeTKTheoLop";
            treeNode1.Text = "Thống kê theo lớp";
            treeNode2.Name = "nodeTKTheoGiaoVien";
            treeNode2.Text = "Thống kê theo giáo viên";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(155, 433);
            this.treeView1.TabIndex = 0;
            // 
            // tbpHuongDanSuDung
            // 
            this.tbpHuongDanSuDung.BackColor = System.Drawing.SystemColors.Control;
            this.tbpHuongDanSuDung.Controls.Add(this.gbHuongDanSuDung);
            this.tbpHuongDanSuDung.Location = new System.Drawing.Point(4, 22);
            this.tbpHuongDanSuDung.Name = "tbpHuongDanSuDung";
            this.tbpHuongDanSuDung.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHuongDanSuDung.Size = new System.Drawing.Size(797, 447);
            this.tbpHuongDanSuDung.TabIndex = 3;
            this.tbpHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // gbHuongDanSuDung
            // 
            this.gbHuongDanSuDung.Controls.Add(this.webBrowser1);
            this.gbHuongDanSuDung.Controls.Add(this.trvHuongDanSuDung);
            this.gbHuongDanSuDung.Location = new System.Drawing.Point(8, 6);
            this.gbHuongDanSuDung.Name = "gbHuongDanSuDung";
            this.gbHuongDanSuDung.Size = new System.Drawing.Size(778, 428);
            this.gbHuongDanSuDung.TabIndex = 0;
            this.gbHuongDanSuDung.TabStop = false;
            this.gbHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(169, 19);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(603, 403);
            this.webBrowser1.TabIndex = 3;
            // 
            // trvHuongDanSuDung
            // 
            this.trvHuongDanSuDung.Location = new System.Drawing.Point(11, 19);
            this.trvHuongDanSuDung.Name = "trvHuongDanSuDung";
            this.trvHuongDanSuDung.Size = new System.Drawing.Size(155, 404);
            this.trvHuongDanSuDung.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 469);
            this.Controls.Add(this.tbcQuanLiSinhVien);
            this.Name = "Form1";
            this.Text = "Quản Lí Sinh Viên";
            this.tbcQuanLiSinhVien.ResumeLayout(false);
            this.tpStudentInformation.ResumeLayout(false);
            this.tpStudentInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).EndInit();
            this.tpCoachInformation.ResumeLayout(false);
            this.tpCoachInformation.PerformLayout();
            this.grbDanhSachGiaoVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpThongTinGiangDay.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tbpHuongDanSuDung.ResumeLayout(false);
            this.gbHuongDanSuDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcQuanLiSinhVien;
        private System.Windows.Forms.TabPage tpStudentInformation;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TabPage tpCoachInformation;
        private System.Windows.Forms.TabPage tpThongTinGiangDay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoaGV;
        private System.Windows.Forms.Button btSuaGV;
        private System.Windows.Forms.Button btThemGiaoVien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvThongTinSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn classid;
        private System.Windows.Forms.GroupBox grbDanhSachGiaoVien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tbpHuongDanSuDung;
        private System.Windows.Forms.GroupBox gbHuongDanSuDung;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView trvHuongDanSuDung;
    }
}

