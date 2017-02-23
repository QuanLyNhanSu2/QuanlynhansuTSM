using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlynhansu.Controller;
using Quanlynhansu.Model;

namespace Quanlynhansu.View
{
    public partial class Danhmuc : UserControl
    {
        NhanvienController nvController = new NhanvienController();
        public Danhmuc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien(
                                    int.Parse(txtManhanvien.Text),
                                    txtHoten.Text,
                                    cmbGioitinh.Text,
                                    dtpNgaysinh.Text,
                                    txtNoisinh.Text,
                                    int.Parse(txtDienthoai.Text),
                                    txtHoKhau.Text,
                                    txtChoohiennay.Text,
                                    int.Parse(txtSoBHYT.Text),
                                    int.Parse(txtSotheATM.Text),
                                    cmbDantoc.Text,
                                    cmbTongiao.Text,
                                    int.Parse(txtMaphongban.Text),
                                    txtChucvu.Text,
                                    int.Parse(txtSoCMND.Text),
                                    rtbGhichu.Text
                                    );
            nvController.ThemNhanvien(nv);
            MessageBox.Show("Them Thanh Cong Hoc Sinh Moi");
        }
    }
}
