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

        private void button4_Click(object sender, EventArgs e)
        {
           //reset all of the control textbox,...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            //nv..... = .....
            nvController.ThemNhanvien(nv);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            //nv..... = .....
            nvController.SuaNhanvien(nv);
        }
        //....
    }
}
