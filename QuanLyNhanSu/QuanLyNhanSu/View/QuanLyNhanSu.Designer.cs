namespace QuanLyNhanSu
{
    partial class QuanLyNhanSu
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
            this.tbcTKNhanVien = new System.Windows.Forms.TabControl();
            this.tbpThongTinNhanVien = new System.Windows.Forms.TabPage();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.tbcTKNhanVien.SuspendLayout();
            this.tbpThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTKNhanVien
            // 
            this.tbcTKNhanVien.Controls.Add(this.tbpThongTinNhanVien);
            this.tbcTKNhanVien.Location = new System.Drawing.Point(0, 3);
            this.tbcTKNhanVien.Name = "tbcTKNhanVien";
            this.tbcTKNhanVien.SelectedIndex = 0;
            this.tbcTKNhanVien.Size = new System.Drawing.Size(747, 432);
            this.tbcTKNhanVien.TabIndex = 0;
            // 
            // tbpThongTinNhanVien
            // 
            this.tbpThongTinNhanVien.Controls.Add(this.btXoa);
            this.tbpThongTinNhanVien.Controls.Add(this.btSua);
            this.tbpThongTinNhanVien.Controls.Add(this.btThem);
            this.tbpThongTinNhanVien.Controls.Add(this.dgvThongTinNhanVien);
            this.tbpThongTinNhanVien.Controls.Add(this.tabControl2);
            this.tbpThongTinNhanVien.Controls.Add(this.txtTimKiem);
            this.tbpThongTinNhanVien.Controls.Add(this.lbTimKiem);
            this.tbpThongTinNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tbpThongTinNhanVien.Name = "tbpThongTinNhanVien";
            this.tbpThongTinNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tbpThongTinNhanVien.Size = new System.Drawing.Size(739, 406);
            this.tbpThongTinNhanVien.TabIndex = 0;
            this.tbpThongTinNhanVien.Text = "Thông tin nhân viên ";
            this.tbpThongTinNhanVien.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(633, 366);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "&Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(505, 366);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "&Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(367, 366);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "&Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvThongTinNhanVien
            // 
            this.dgvThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNhanVien.Location = new System.Drawing.Point(0, 59);
            this.dgvThongTinNhanVien.Name = "dgvThongTinNhanVien";
            this.dgvThongTinNhanVien.Size = new System.Drawing.Size(743, 294);
            this.dgvThongTinNhanVien.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(1408, 54);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(200, 100);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 74);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(458, 21);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Location = new System.Drawing.Point(389, 28);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(52, 13);
            this.lbTimKiem.TabIndex = 0;
            this.lbTimKiem.Text = "Tìm kiếm ";
            // 
            // QuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcTKNhanVien);
            this.Name = "QuanLyNhanSu";
            this.Size = new System.Drawing.Size(747, 438);
            this.tbcTKNhanVien.ResumeLayout(false);
            this.tbpThongTinNhanVien.ResumeLayout(false);
            this.tbpThongTinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNhanVien)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTKNhanVien;
        private System.Windows.Forms.TabPage tbpThongTinNhanVien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbTimKiem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvThongTinNhanVien;
    }
}
