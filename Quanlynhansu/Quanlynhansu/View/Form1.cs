using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmQuanLyNhanSu : Form
    {
        View.ThongTinNhanVien frmThongTinNhanVien = new View.ThongTinNhanVien();
        View.frmThongTinNguoiDung frmThongTinNguoiDung = new View.frmThongTinNguoiDung();
        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien.ShowDialog();
        }

        private void btThemNguoiDung_Click(object sender, EventArgs e)
        {
            frmThongTinNguoiDung.ShowDialog();
        }

        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {

        }
    }
}
