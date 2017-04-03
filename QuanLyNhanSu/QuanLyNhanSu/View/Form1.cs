using QuanLyNhanSu.Controller;
using QuanLyNhanSu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.View
{
    public partial class frmQuanLyNhanSu : Form
    {
        NhanvienController nvControl = new NhanvienController();
        ThongTinNhanVien frmThongTinNhanVien = new ThongTinNhanVien();
        frmThongTinNguoiDung frmThongTinNguoiDung = new frmThongTinNguoiDung();
        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox || control is RichTextBox)
                    control.Text = "";
            }
        }

        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien.ShowDialog();
        }

        private void btThemNguoiDung_Click(object sender, EventArgs e)
        {
            frmThongTinNguoiDung.ShowDialog();
        }

        private void LoadDSNhanvien()
        {
            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.DataSource = nvControl.Load();
        }
        private void LoadDSChucvu()
        {
            DataTable dt = nvControl.Query("Chucvu_Load", null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbChucvu.Items.Add(dr[0]);
                }
            }
        }
        private void LoadDSPhongban()
        {
            DataTable dt = nvControl.Query("Phongban_Load", null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbPhongban.Items.Add(dr[0]);
                }
            }
        }
        private void LoadDSNguoidung()
        {
            dgvDanhSachNguoiDung.DataSource = null;
            dgvDanhSachNguoiDung.DataSource = nvControl.Query("Nguoidung_Load", null);
        }
        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            LoadDSNhanvien();
            LoadDSChucvu();
            LoadDSPhongban();
            LoadDSNguoidung();
            cbbGioiTinh.SelectedIndex = 0;
            cbbDanToc.SelectedIndex = 0;
            cbChucvu.SelectedIndex = 0;
            cbPhongban.SelectedIndex = 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvien nv = new Nhanvien();
                nv.nhanvienID = int.Parse(txtNhanVienID.Text);
                nv.tenchucvu = cbChucvu.Text;
                nv.tennhanvien = txtHoTen.Text;
                nv.gioitinh = cbbGioiTinh.Text == "Nam" ? 1 : 0;
                nv.soCMND = int.Parse(txtSoCMND.Text);
                nv.ngaysinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
                nv.noisinh = txtNoiSinh.Text;
                nv.dienthoai = txtDienThoai.Text;
                nv.tongiao = txtTonGiao.Text;
                nv.ghichu = rtbGhiChu.Text;
                nv.dantoc = cbbDanToc.Text;
                nv.tenphongban = cbPhongban.Text;

                nvControl.Insert(nv);
                LoadDSNhanvien();
            }
            catch
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Nhanvien nv = new Nhanvien();
                nv.nhanvienID = int.Parse(txtNhanVienID.Text);
                nv.tenchucvu = cbChucvu.Text;
                nv.tennhanvien = txtHoTen.Text;
                nv.gioitinh = cbbGioiTinh.Text == "Nam" ? 1 : 0;
                nv.soCMND = int.Parse(txtSoCMND.Text);
                nv.ngaysinh = DateTime.Parse(dtpNgaySinh.Value.ToShortDateString());
                nv.noisinh = txtNoiSinh.Text;
                nv.dienthoai = txtDienThoai.Text;
                nv.tongiao = txtTonGiao.Text;
                nv.ghichu = rtbGhiChu.Text;
                nv.dantoc = cbbDanToc.Text;
                nv.tenphongban = cbPhongban.Text;

                nvControl.Update(nv);
                LoadDSNhanvien();
            }
            catch
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.nhanvienID = int.Parse(txtNhanVienID.Text);
            nvControl.Delete(nv);
            LoadDSNhanvien();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool ok = int.TryParse(txtTimKiem.Text, out id);
            if (txtTimKiem.Text == "" || !ok)
            {
                LoadDSNhanvien();
                return;
            }
            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.DataSource = nvControl.Search(id);
        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtNhanVienID.Text = dgvDanhSachNhanVien.Rows[row].Cells[0].Value.ToString();
            txtHoTen.Text = dgvDanhSachNhanVien.Rows[row].Cells[1].Value.ToString();
            cbbGioiTinh.SelectedIndex = dgvDanhSachNhanVien.Rows[row].Cells[2].Value.ToString() == "True" ? 0 : 1;
            txtSoCMND.Text = dgvDanhSachNhanVien.Rows[row].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvDanhSachNhanVien.Rows[row].Cells[4].Value.ToString();
            txtNoiSinh.Text = dgvDanhSachNhanVien.Rows[row].Cells[5].Value.ToString();
            txtDienThoai.Text = dgvDanhSachNhanVien.Rows[row].Cells[6].Value.ToString();
            cbbDanToc.Text = dgvDanhSachNhanVien.Rows[row].Cells[7].Value.ToString();
            txtTonGiao.Text = dgvDanhSachNhanVien.Rows[row].Cells[8].Value.ToString();
            rtbGhiChu.Text = dgvDanhSachNhanVien.Rows[row].Cells[9].Value.ToString();
            cbPhongban.SelectedIndex = int.Parse(dgvDanhSachNhanVien.Rows[row].Cells[10].Value.ToString()) - 1;
            cbChucvu.SelectedIndex = int.Parse(dgvDanhSachNhanVien.Rows[row].Cells[11].Value.ToString()) - 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            int id = 0;
            bool ok = int.TryParse(txtTimKiem.Text, out id);
            if (txtTimKiem.Text == "" || !ok)
            {
                LoadDSNhanvien();
                return;
            }
            dgvDanhSachNhanVien.DataSource = null;
            dgvDanhSachNhanVien.DataSource = nvControl.Search(id);
        }
    }
}
