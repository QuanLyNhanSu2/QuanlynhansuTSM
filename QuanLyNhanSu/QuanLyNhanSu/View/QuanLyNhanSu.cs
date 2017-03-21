using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class QuanLyNhanSu : UserControl
    {
        ThongTinNhanVien thongTin = new ThongTinNhanVien();
        public QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            thongTin.ShowDialog();
        }
    }
}
