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
            this.tbcQuanLiSinhVien = new System.Windows.Forms.TabControl();
            this.tpStudentInformation = new System.Windows.Forms.TabPage();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvThongTinSinhVien = new System.Windows.Forms.DataGridView();
            this.tpCoachInformation = new System.Windows.Forms.TabPage();
            this.tpThongTinGiangDay = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoaGV = new System.Windows.Forms.Button();
            this.btSuaGV = new System.Windows.Forms.Button();
            this.btThemGiaoVien = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcQuanLiSinhVien.SuspendLayout();
            this.tpStudentInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).BeginInit();
            this.tpCoachInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcQuanLiSinhVien
            // 
            this.tbcQuanLiSinhVien.Controls.Add(this.tpStudentInformation);
            this.tbcQuanLiSinhVien.Controls.Add(this.tpCoachInformation);
            this.tbcQuanLiSinhVien.Controls.Add(this.tpThongTinGiangDay);
            this.tbcQuanLiSinhVien.Location = new System.Drawing.Point(0, 1);
            this.tbcQuanLiSinhVien.Name = "tbcQuanLiSinhVien";
            this.tbcQuanLiSinhVien.SelectedIndex = 0;
            this.tbcQuanLiSinhVien.Size = new System.Drawing.Size(805, 431);
            this.tbcQuanLiSinhVien.TabIndex = 0;
            // 
            // tpStudentInformation
            // 
            this.tpStudentInformation.Controls.Add(this.txtTimKiem);
            this.tpStudentInformation.Controls.Add(this.lbTimKiem);
            this.tpStudentInformation.Controls.Add(this.btXoa);
            this.tpStudentInformation.Controls.Add(this.btSua);
            this.tpStudentInformation.Controls.Add(this.btThem);
            this.tpStudentInformation.Controls.Add(this.dgvThongTinSinhVien);
            this.tpStudentInformation.Location = new System.Drawing.Point(4, 22);
            this.tpStudentInformation.Name = "tpStudentInformation";
            this.tpStudentInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudentInformation.Size = new System.Drawing.Size(797, 405);
            this.tpStudentInformation.TabIndex = 0;
            this.tpStudentInformation.Text = "Thông tin học sinh";
            this.tpStudentInformation.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(528, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(258, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(461, 28);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(50, 13);
            this.lbTimKiem.TabIndex = 4;
            this.lbTimKiem.Text = "Tìm Kiếm";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(29, 357);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 35);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(29, 293);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 35);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(29, 227);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 35);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
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
            this.dgvThongTinSinhVien.Location = new System.Drawing.Point(146, 61);
            this.dgvThongTinSinhVien.Name = "dgvThongTinSinhVien";
            this.dgvThongTinSinhVien.Size = new System.Drawing.Size(651, 344);
            this.dgvThongTinSinhVien.TabIndex = 0;
            // 
            // tpCoachInformation
            // 
            this.tpCoachInformation.Controls.Add(this.textBox1);
            this.tpCoachInformation.Controls.Add(this.label1);
            this.tpCoachInformation.Controls.Add(this.btXoaGV);
            this.tpCoachInformation.Controls.Add(this.btSuaGV);
            this.tpCoachInformation.Controls.Add(this.btThemGiaoVien);
            this.tpCoachInformation.Controls.Add(this.dataGridView1);
            this.tpCoachInformation.Location = new System.Drawing.Point(4, 22);
            this.tpCoachInformation.Name = "tpCoachInformation";
            this.tpCoachInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpCoachInformation.Size = new System.Drawing.Size(797, 405);
            this.tpCoachInformation.TabIndex = 1;
            this.tpCoachInformation.Text = "Thông tin giáo viên";
            this.tpCoachInformation.UseVisualStyleBackColor = true;
            // 
            // tpThongTinGiangDay
            // 
            this.tpThongTinGiangDay.Location = new System.Drawing.Point(4, 22);
            this.tpThongTinGiangDay.Name = "tpThongTinGiangDay";
            this.tpThongTinGiangDay.Padding = new System.Windows.Forms.Padding(3);
            this.tpThongTinGiangDay.Size = new System.Drawing.Size(797, 405);
            this.tpThongTinGiangDay.TabIndex = 2;
            this.tpThongTinGiangDay.Text = "Thông tin giảng dạy ";
            this.tpThongTinGiangDay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm Kiếm";
            // 
            // btXoaGV
            // 
            this.btXoaGV.Location = new System.Drawing.Point(14, 344);
            this.btXoaGV.Name = "btXoaGV";
            this.btXoaGV.Size = new System.Drawing.Size(75, 35);
            this.btXoaGV.TabIndex = 9;
            this.btXoaGV.Text = "&Xóa";
            this.btXoaGV.UseVisualStyleBackColor = true;
            // 
            // btSuaGV
            // 
            this.btSuaGV.Location = new System.Drawing.Point(14, 280);
            this.btSuaGV.Name = "btSuaGV";
            this.btSuaGV.Size = new System.Drawing.Size(75, 35);
            this.btSuaGV.TabIndex = 8;
            this.btSuaGV.Text = "&Sửa";
            this.btSuaGV.UseVisualStyleBackColor = true;
            // 
            // btThemGiaoVien
            // 
            this.btThemGiaoVien.Location = new System.Drawing.Point(14, 214);
            this.btThemGiaoVien.Name = "btThemGiaoVien";
            this.btThemGiaoVien.Size = new System.Drawing.Size(75, 35);
            this.btThemGiaoVien.TabIndex = 7;
            this.btThemGiaoVien.Text = "&Thêm";
            this.btThemGiaoVien.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(131, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 344);
            this.dataGridView1.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbcQuanLiSinhVien);
            this.Name = "Form1";
            this.Text = "Quản Lí Sinh Viên";
            this.tbcQuanLiSinhVien.ResumeLayout(false);
            this.tpStudentInformation.ResumeLayout(false);
            this.tpStudentInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSinhVien)).EndInit();
            this.tpCoachInformation.ResumeLayout(false);
            this.tpCoachInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcQuanLiSinhVien;
        private System.Windows.Forms.TabPage tpStudentInformation;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvThongTinSinhVien;
        private System.Windows.Forms.TabPage tpCoachInformation;
        private System.Windows.Forms.TabPage tpThongTinGiangDay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn classid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoaGV;
        private System.Windows.Forms.Button btSuaGV;
        private System.Windows.Forms.Button btThemGiaoVien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

