using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlynhansu.Controller;
using Quanlynhansu.Helper;
using Quanlynhansu.Model;
using System;

namespace Quanlynhansu.View
{
    public partial class Nhansu : UserControl
    {
        UserController ucontrol = new UserController();
        public Nhansu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(txtTenNhansu.Text, txtTaikhoanNhansu.Text, txtMatkhauNhansu.Text, cmbChucvuNhansu.SelectedIndex + 1);
            ErrType err = ucontrol.ThemNguoidung(user);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}