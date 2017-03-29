namespace QuanLyNhanSu
{
    partial class frmQuanLyNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyNhanSu));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thống kê theo phòng ban");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Thống kê theo chức vụ ");
            this.tbcHoSoNhanVien = new System.Windows.Forms.TabControl();
            this.tbpHoSoNhanVien = new System.Windows.Forms.TabPage();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNoiSinh = new System.Windows.Forms.Label();
            this.lbDanToc = new System.Windows.Forms.Label();
            this.lbSoCMND = new System.Windows.Forms.Label();
            this.lbChucVuID = new System.Windows.Forms.Label();
            this.lbNhanVienID = new System.Windows.Forms.Label();
            this.lbTonGiao = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lcPhongBanId = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txtTonGiao = new System.Windows.Forms.TextBox();
            this.txtPhongBanId = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.txtChucVuID = new System.Windows.Forms.TextBox();
            this.txtNhanVienID = new System.Windows.Forms.TextBox();
            this.cbbDanToc = new System.Windows.Forms.ComboBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tbpQuanLyNguoiDung = new System.Windows.Forms.TabPage();
            this.gbChucNangNguoiDung = new System.Windows.Forms.GroupBox();
            this.btXoaNguoiDung = new System.Windows.Forms.Button();
            this.btSuaNguoiDung = new System.Windows.Forms.Button();
            this.btThemNguoiDung = new System.Windows.Forms.Button();
            this.grbDanhSachNguoiDung = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNguoiDung = new System.Windows.Forms.DataGridView();
            this.tbpThongKeNhanVien = new System.Windows.Forms.TabPage();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btXoaNhanVien = new System.Windows.Forms.Button();
            this.btSuaNhanVien = new System.Windows.Forms.Button();
            this.btThemNhanVien = new System.Windows.Forms.Button();
            this.gbThongKeNhanVien = new System.Windows.Forms.GroupBox();
            this.dgvThongKeNhanVien = new System.Windows.Forms.DataGridView();
            this.trvThongKeNhanVie = new System.Windows.Forms.TreeView();
            this.tbpHuongDanSuDung = new System.Windows.Forms.TabPage();
            this.trvHuongDanSuDung = new System.Windows.Forms.TreeView();
            this.wbbHuongDanSuDung = new System.Windows.Forms.WebBrowser();
            this.tbcHoSoNhanVien.SuspendLayout();
            this.tbpHoSoNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbpQuanLyNguoiDung.SuspendLayout();
            this.gbChucNangNguoiDung.SuspendLayout();
            this.grbDanhSachNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNguoiDung)).BeginInit();
            this.tbpThongKeNhanVien.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.gbThongKeNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNhanVien)).BeginInit();
            this.tbpHuongDanSuDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcHoSoNhanVien
            // 
            this.tbcHoSoNhanVien.Controls.Add(this.tbpHoSoNhanVien);
            this.tbcHoSoNhanVien.Controls.Add(this.tbpQuanLyNguoiDung);
            this.tbcHoSoNhanVien.Controls.Add(this.tbpThongKeNhanVien);
            this.tbcHoSoNhanVien.Controls.Add(this.tbpHuongDanSuDung);
            this.tbcHoSoNhanVien.Location = new System.Drawing.Point(-5, -1);
            this.tbcHoSoNhanVien.Name = "tbcHoSoNhanVien";
            this.tbcHoSoNhanVien.SelectedIndex = 0;
            this.tbcHoSoNhanVien.Size = new System.Drawing.Size(1064, 498);
            this.tbcHoSoNhanVien.TabIndex = 1;
            // 
            // tbpHoSoNhanVien
            // 
            this.tbpHoSoNhanVien.Controls.Add(this.dgvDanhSachNhanVien);
            this.tbpHoSoNhanVien.Controls.Add(this.panel1);
            this.tbpHoSoNhanVien.Controls.Add(this.groupBox1);
            this.tbpHoSoNhanVien.Controls.Add(this.toolStrip1);
            this.tbpHoSoNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tbpHoSoNhanVien.Name = "tbpHoSoNhanVien";
            this.tbpHoSoNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHoSoNhanVien.Size = new System.Drawing.Size(1056, 472);
            this.tbpHoSoNhanVien.TabIndex = 0;
            this.tbpHoSoNhanVien.Text = "Hồ sơ nhân viên";
            this.tbpHoSoNhanVien.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(3, 311);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(1050, 158);
            this.dgvDanhSachNhanVien.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 57);
            this.panel1.TabIndex = 4;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(301, 20);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btTimKiem.TabIndex = 7;
            this.btTimKiem.Text = "Search";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(24, 22);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(271, 20);
            this.txtTimKiem.TabIndex = 6;
            // 
            // btDelete
            // 
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDelete.Location = new System.Drawing.Point(856, 16);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(70, 24);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "&Delete";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEdit.Location = new System.Drawing.Point(780, 16);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(70, 24);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "&Edit";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btAdd.Location = new System.Drawing.Point(701, 16);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(73, 24);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "&Add";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(932, 16);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDienThoai);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.rtbGhiChu);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.lbNgaySinh);
            this.groupBox1.Controls.Add(this.lbGioiTinh);
            this.groupBox1.Controls.Add(this.lbNoiSinh);
            this.groupBox1.Controls.Add(this.lbDanToc);
            this.groupBox1.Controls.Add(this.lbSoCMND);
            this.groupBox1.Controls.Add(this.lbChucVuID);
            this.groupBox1.Controls.Add(this.lbNhanVienID);
            this.groupBox1.Controls.Add(this.lbTonGiao);
            this.groupBox1.Controls.Add(this.lbGhiChu);
            this.groupBox1.Controls.Add(this.lcPhongBanId);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.txtTonGiao);
            this.groupBox1.Controls.Add(this.txtPhongBanId);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtNoiSinh);
            this.groupBox1.Controls.Add(this.txtSoCMND);
            this.groupBox1.Controls.Add(this.txtChucVuID);
            this.groupBox1.Controls.Add(this.txtNhanVienID);
            this.groupBox1.Controls.Add(this.cbbDanToc);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 221);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // lbDienThoai
            // 
            this.lbDienThoai.AutoSize = true;
            this.lbDienThoai.Location = new System.Drawing.Point(702, 30);
            this.lbDienThoai.Name = "lbDienThoai";
            this.lbDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbDienThoai.TabIndex = 9;
            this.lbDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(781, 30);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(186, 20);
            this.txtDienThoai.TabIndex = 8;
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(781, 63);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(186, 115);
            this.rtbGhiChu.TabIndex = 7;
            this.rtbGhiChu.Text = "";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(104, 129);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(186, 20);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(22, 132);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lbNgaySinh.TabIndex = 4;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(22, 99);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // lbNoiSinh
            // 
            this.lbNoiSinh.AutoSize = true;
            this.lbNoiSinh.Location = new System.Drawing.Point(22, 165);
            this.lbNoiSinh.Name = "lbNoiSinh";
            this.lbNoiSinh.Size = new System.Drawing.Size(45, 13);
            this.lbNoiSinh.TabIndex = 4;
            this.lbNoiSinh.Text = "Nơi sinh";
            // 
            // lbDanToc
            // 
            this.lbDanToc.AutoSize = true;
            this.lbDanToc.Location = new System.Drawing.Point(361, 62);
            this.lbDanToc.Name = "lbDanToc";
            this.lbDanToc.Size = new System.Drawing.Size(45, 13);
            this.lbDanToc.TabIndex = 4;
            this.lbDanToc.Text = "Dân tộc";
            // 
            // lbSoCMND
            // 
            this.lbSoCMND.AutoSize = true;
            this.lbSoCMND.Location = new System.Drawing.Point(363, 28);
            this.lbSoCMND.Name = "lbSoCMND";
            this.lbSoCMND.Size = new System.Drawing.Size(55, 13);
            this.lbSoCMND.TabIndex = 4;
            this.lbSoCMND.Text = "Số CMND";
            // 
            // lbChucVuID
            // 
            this.lbChucVuID.AutoSize = true;
            this.lbChucVuID.Location = new System.Drawing.Point(360, 159);
            this.lbChucVuID.Name = "lbChucVuID";
            this.lbChucVuID.Size = new System.Drawing.Size(47, 13);
            this.lbChucVuID.TabIndex = 4;
            this.lbChucVuID.Text = "Chức vụ";
            // 
            // lbNhanVienID
            // 
            this.lbNhanVienID.AutoSize = true;
            this.lbNhanVienID.Location = new System.Drawing.Point(22, 32);
            this.lbNhanVienID.Name = "lbNhanVienID";
            this.lbNhanVienID.Size = new System.Drawing.Size(72, 13);
            this.lbNhanVienID.TabIndex = 4;
            this.lbNhanVienID.Text = "Mã nhân viên";
            // 
            // lbTonGiao
            // 
            this.lbTonGiao.AutoSize = true;
            this.lbTonGiao.Location = new System.Drawing.Point(361, 95);
            this.lbTonGiao.Name = "lbTonGiao";
            this.lbTonGiao.Size = new System.Drawing.Size(49, 13);
            this.lbTonGiao.TabIndex = 4;
            this.lbTonGiao.Text = "Tôn giáo";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(702, 63);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lbGhiChu.TabIndex = 4;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lcPhongBanId
            // 
            this.lcPhongBanId.AutoSize = true;
            this.lcPhongBanId.Location = new System.Drawing.Point(360, 125);
            this.lcPhongBanId.Name = "lcPhongBanId";
            this.lcPhongBanId.Size = new System.Drawing.Size(76, 13);
            this.lcPhongBanId.TabIndex = 4;
            this.lcPhongBanId.Text = "Mã phòng ban";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(22, 65);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(39, 13);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ tên";
            // 
            // txtTonGiao
            // 
            this.txtTonGiao.Location = new System.Drawing.Point(442, 93);
            this.txtTonGiao.Name = "txtTonGiao";
            this.txtTonGiao.Size = new System.Drawing.Size(186, 20);
            this.txtTonGiao.TabIndex = 1;
            // 
            // txtPhongBanId
            // 
            this.txtPhongBanId.Location = new System.Drawing.Point(442, 125);
            this.txtPhongBanId.Name = "txtPhongBanId";
            this.txtPhongBanId.Size = new System.Drawing.Size(186, 20);
            this.txtPhongBanId.TabIndex = 1;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(104, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(186, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(104, 162);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(186, 20);
            this.txtNoiSinh.TabIndex = 1;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(442, 26);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(186, 20);
            this.txtSoCMND.TabIndex = 1;
            // 
            // txtChucVuID
            // 
            this.txtChucVuID.Location = new System.Drawing.Point(442, 158);
            this.txtChucVuID.Name = "txtChucVuID";
            this.txtChucVuID.Size = new System.Drawing.Size(186, 20);
            this.txtChucVuID.TabIndex = 1;
            // 
            // txtNhanVienID
            // 
            this.txtNhanVienID.Location = new System.Drawing.Point(104, 29);
            this.txtNhanVienID.Name = "txtNhanVienID";
            this.txtNhanVienID.Size = new System.Drawing.Size(186, 20);
            this.txtNhanVienID.TabIndex = 1;
            // 
            // cbbDanToc
            // 
            this.cbbDanToc.FormattingEnabled = true;
            this.cbbDanToc.Location = new System.Drawing.Point(442, 59);
            this.cbbDanToc.Name = "cbbDanToc";
            this.cbbDanToc.Size = new System.Drawing.Size(186, 21);
            this.cbbDanToc.TabIndex = 0;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(104, 95);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(186, 21);
            this.cbbGioiTinh.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 27);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 27);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 27);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tbpQuanLyNguoiDung
            // 
            this.tbpQuanLyNguoiDung.Controls.Add(this.gbChucNangNguoiDung);
            this.tbpQuanLyNguoiDung.Controls.Add(this.grbDanhSachNguoiDung);
            this.tbpQuanLyNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.tbpQuanLyNguoiDung.Name = "tbpQuanLyNguoiDung";
            this.tbpQuanLyNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tbpQuanLyNguoiDung.Size = new System.Drawing.Size(1056, 472);
            this.tbpQuanLyNguoiDung.TabIndex = 1;
            this.tbpQuanLyNguoiDung.Text = "Quản Lý Người Dùng";
            this.tbpQuanLyNguoiDung.UseVisualStyleBackColor = true;
            // 
            // gbChucNangNguoiDung
            // 
            this.gbChucNangNguoiDung.Controls.Add(this.btXoaNguoiDung);
            this.gbChucNangNguoiDung.Controls.Add(this.btSuaNguoiDung);
            this.gbChucNangNguoiDung.Controls.Add(this.btThemNguoiDung);
            this.gbChucNangNguoiDung.Location = new System.Drawing.Point(3, 408);
            this.gbChucNangNguoiDung.Name = "gbChucNangNguoiDung";
            this.gbChucNangNguoiDung.Size = new System.Drawing.Size(1047, 61);
            this.gbChucNangNguoiDung.TabIndex = 1;
            this.gbChucNangNguoiDung.TabStop = false;
            this.gbChucNangNguoiDung.Text = "Chức năng";
            // 
            // btXoaNguoiDung
            // 
            this.btXoaNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btXoaNguoiDung.Image")));
            this.btXoaNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaNguoiDung.Location = new System.Drawing.Point(940, 19);
            this.btXoaNguoiDung.Name = "btXoaNguoiDung";
            this.btXoaNguoiDung.Size = new System.Drawing.Size(70, 24);
            this.btXoaNguoiDung.TabIndex = 5;
            this.btXoaNguoiDung.Text = "&Xóa";
            this.btXoaNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btSuaNguoiDung
            // 
            this.btSuaNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btSuaNguoiDung.Image")));
            this.btSuaNguoiDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaNguoiDung.Location = new System.Drawing.Point(864, 19);
            this.btSuaNguoiDung.Name = "btSuaNguoiDung";
            this.btSuaNguoiDung.Size = new System.Drawing.Size(70, 24);
            this.btSuaNguoiDung.TabIndex = 4;
            this.btSuaNguoiDung.Text = "&Sửa";
            this.btSuaNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btThemNguoiDung
            // 
            this.btThemNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("btThemNguoiDung.Image")));
            this.btThemNguoiDung.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btThemNguoiDung.Location = new System.Drawing.Point(785, 19);
            this.btThemNguoiDung.Name = "btThemNguoiDung";
            this.btThemNguoiDung.Size = new System.Drawing.Size(73, 24);
            this.btThemNguoiDung.TabIndex = 3;
            this.btThemNguoiDung.Text = "&Thêm ";
            this.btThemNguoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemNguoiDung.UseVisualStyleBackColor = true;
            this.btThemNguoiDung.Click += new System.EventHandler(this.btThemNguoiDung_Click);
            // 
            // grbDanhSachNguoiDung
            // 
            this.grbDanhSachNguoiDung.Controls.Add(this.dgvDanhSachNguoiDung);
            this.grbDanhSachNguoiDung.Location = new System.Drawing.Point(6, 6);
            this.grbDanhSachNguoiDung.Name = "grbDanhSachNguoiDung";
            this.grbDanhSachNguoiDung.Size = new System.Drawing.Size(1044, 396);
            this.grbDanhSachNguoiDung.TabIndex = 0;
            this.grbDanhSachNguoiDung.TabStop = false;
            this.grbDanhSachNguoiDung.Text = "Danh sách người dùng";
            // 
            // dgvDanhSachNguoiDung
            // 
            this.dgvDanhSachNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNguoiDung.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachNguoiDung.Name = "dgvDanhSachNguoiDung";
            this.dgvDanhSachNguoiDung.Size = new System.Drawing.Size(1038, 377);
            this.dgvDanhSachNguoiDung.TabIndex = 0;
            // 
            // tbpThongKeNhanVien
            // 
            this.tbpThongKeNhanVien.Controls.Add(this.grbChucNang);
            this.tbpThongKeNhanVien.Controls.Add(this.gbThongKeNhanVien);
            this.tbpThongKeNhanVien.Controls.Add(this.trvThongKeNhanVie);
            this.tbpThongKeNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tbpThongKeNhanVien.Name = "tbpThongKeNhanVien";
            this.tbpThongKeNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tbpThongKeNhanVien.Size = new System.Drawing.Size(1056, 472);
            this.tbpThongKeNhanVien.TabIndex = 2;
            this.tbpThongKeNhanVien.Text = "Thống Kê Danh Sách Nhân Viên ";
            this.tbpThongKeNhanVien.UseVisualStyleBackColor = true;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btXoaNhanVien);
            this.grbChucNang.Controls.Add(this.btSuaNhanVien);
            this.grbChucNang.Controls.Add(this.btThemNhanVien);
            this.grbChucNang.Location = new System.Drawing.Point(175, 408);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(875, 58);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btXoaNhanVien
            // 
            this.btXoaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btXoaNhanVien.Image")));
            this.btXoaNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaNhanVien.Location = new System.Drawing.Point(768, 19);
            this.btXoaNhanVien.Name = "btXoaNhanVien";
            this.btXoaNhanVien.Size = new System.Drawing.Size(70, 24);
            this.btXoaNhanVien.TabIndex = 2;
            this.btXoaNhanVien.Text = "&Xóa";
            this.btXoaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btSuaNhanVien
            // 
            this.btSuaNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btSuaNhanVien.Image")));
            this.btSuaNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaNhanVien.Location = new System.Drawing.Point(692, 19);
            this.btSuaNhanVien.Name = "btSuaNhanVien";
            this.btSuaNhanVien.Size = new System.Drawing.Size(70, 24);
            this.btSuaNhanVien.TabIndex = 1;
            this.btSuaNhanVien.Text = "&Sửa";
            this.btSuaNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // btThemNhanVien
            // 
            this.btThemNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btThemNhanVien.Image")));
            this.btThemNhanVien.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btThemNhanVien.Location = new System.Drawing.Point(613, 19);
            this.btThemNhanVien.Name = "btThemNhanVien";
            this.btThemNhanVien.Size = new System.Drawing.Size(73, 24);
            this.btThemNhanVien.TabIndex = 0;
            this.btThemNhanVien.Text = "&Thêm ";
            this.btThemNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemNhanVien.UseVisualStyleBackColor = true;
            this.btThemNhanVien.Click += new System.EventHandler(this.btThemNhanVien_Click);
            // 
            // gbThongKeNhanVien
            // 
            this.gbThongKeNhanVien.Controls.Add(this.dgvThongKeNhanVien);
            this.gbThongKeNhanVien.Location = new System.Drawing.Point(175, 6);
            this.gbThongKeNhanVien.Name = "gbThongKeNhanVien";
            this.gbThongKeNhanVien.Size = new System.Drawing.Size(875, 396);
            this.gbThongKeNhanVien.TabIndex = 1;
            this.gbThongKeNhanVien.TabStop = false;
            this.gbThongKeNhanVien.Text = "Thông kê nhân viên ";
            // 
            // dgvThongKeNhanVien
            // 
            this.dgvThongKeNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongKeNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dgvThongKeNhanVien.Name = "dgvThongKeNhanVien";
            this.dgvThongKeNhanVien.Size = new System.Drawing.Size(869, 377);
            this.dgvThongKeNhanVien.TabIndex = 0;
            // 
            // trvThongKeNhanVie
            // 
            this.trvThongKeNhanVie.Location = new System.Drawing.Point(0, 0);
            this.trvThongKeNhanVie.Name = "trvThongKeNhanVie";
            treeNode1.Name = "nodePhongBan";
            treeNode1.Text = "Thống kê theo phòng ban";
            treeNode2.Name = "nodeChucVu";
            treeNode2.Text = "Thống kê theo chức vụ ";
            this.trvThongKeNhanVie.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.trvThongKeNhanVie.Size = new System.Drawing.Size(169, 476);
            this.trvThongKeNhanVie.TabIndex = 0;
            // 
            // tbpHuongDanSuDung
            // 
            this.tbpHuongDanSuDung.Controls.Add(this.wbbHuongDanSuDung);
            this.tbpHuongDanSuDung.Controls.Add(this.trvHuongDanSuDung);
            this.tbpHuongDanSuDung.Location = new System.Drawing.Point(4, 22);
            this.tbpHuongDanSuDung.Name = "tbpHuongDanSuDung";
            this.tbpHuongDanSuDung.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHuongDanSuDung.Size = new System.Drawing.Size(1056, 472);
            this.tbpHuongDanSuDung.TabIndex = 3;
            this.tbpHuongDanSuDung.Text = "Hướng Dẫn Sử Dụng";
            this.tbpHuongDanSuDung.UseVisualStyleBackColor = true;
            // 
            // trvHuongDanSuDung
            // 
            this.trvHuongDanSuDung.Location = new System.Drawing.Point(3, 0);
            this.trvHuongDanSuDung.Name = "trvHuongDanSuDung";
            this.trvHuongDanSuDung.Size = new System.Drawing.Size(248, 472);
            this.trvHuongDanSuDung.TabIndex = 0;
            // 
            // wbbHuongDanSuDung
            // 
            this.wbbHuongDanSuDung.Location = new System.Drawing.Point(257, 3);
            this.wbbHuongDanSuDung.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbHuongDanSuDung.Name = "wbbHuongDanSuDung";
            this.wbbHuongDanSuDung.Size = new System.Drawing.Size(796, 466);
            this.wbbHuongDanSuDung.TabIndex = 1;
            // 
            // frmQuanLyNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 497);
            this.Controls.Add(this.tbcHoSoNhanVien);
            this.Name = "frmQuanLyNhanSu";
            this.Text = "Quản Lý Nhân Sự";
            this.Load += new System.EventHandler(this.frmQuanLyNhanSu_Load);
            this.tbcHoSoNhanVien.ResumeLayout(false);
            this.tbpHoSoNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbpQuanLyNguoiDung.ResumeLayout(false);
            this.gbChucNangNguoiDung.ResumeLayout(false);
            this.grbDanhSachNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNguoiDung)).EndInit();
            this.tbpThongKeNhanVien.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.gbThongKeNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeNhanVien)).EndInit();
            this.tbpHuongDanSuDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcHoSoNhanVien;
        private System.Windows.Forms.TabPage tbpHoSoNhanVien;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNoiSinh;
        private System.Windows.Forms.Label lbDanToc;
        private System.Windows.Forms.Label lbSoCMND;
        private System.Windows.Forms.Label lbChucVuID;
        private System.Windows.Forms.Label lbNhanVienID;
        private System.Windows.Forms.Label lbTonGiao;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lcPhongBanId;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txtTonGiao;
        private System.Windows.Forms.TextBox txtPhongBanId;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.TextBox txtChucVuID;
        private System.Windows.Forms.TextBox txtNhanVienID;
        private System.Windows.Forms.ComboBox cbbDanToc;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabPage tbpQuanLyNguoiDung;
        private System.Windows.Forms.GroupBox gbChucNangNguoiDung;
        private System.Windows.Forms.Button btXoaNguoiDung;
        private System.Windows.Forms.Button btSuaNguoiDung;
        private System.Windows.Forms.Button btThemNguoiDung;
        private System.Windows.Forms.GroupBox grbDanhSachNguoiDung;
        private System.Windows.Forms.DataGridView dgvDanhSachNguoiDung;
        private System.Windows.Forms.TabPage tbpThongKeNhanVien;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btXoaNhanVien;
        private System.Windows.Forms.Button btSuaNhanVien;
        private System.Windows.Forms.Button btThemNhanVien;
        private System.Windows.Forms.GroupBox gbThongKeNhanVien;
        private System.Windows.Forms.DataGridView dgvThongKeNhanVien;
        private System.Windows.Forms.TreeView trvThongKeNhanVie;
        private System.Windows.Forms.TabPage tbpHuongDanSuDung;
        private System.Windows.Forms.WebBrowser wbbHuongDanSuDung;
        private System.Windows.Forms.TreeView trvHuongDanSuDung;
    }
}

