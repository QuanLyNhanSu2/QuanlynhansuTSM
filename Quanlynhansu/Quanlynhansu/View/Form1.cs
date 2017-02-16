using Quanlynhansu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlynhansu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Danhmuc dm = new Danhmuc();
            dm.Dock = DockStyle.Fill;
            pnl_danhmuc.Controls.Add(dm);

            Thongtintaikhoan tttk = new Thongtintaikhoan();
            tttk.Dock = DockStyle.Fill;
            pnl_Quanlynguoidung.Controls.Add(tttk);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl_Quanlynguoidung.Controls.Clear();
            Nhansu ns = new Nhansu();
            ns.Dock = DockStyle.Fill;
            pnl_Quanlynguoidung.Controls.Add(ns);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnl_Quanlynguoidung.Controls.Clear();
            Doimatkhau dmk = new Doimatkhau();
            dmk.Dock = DockStyle.Fill;
            pnl_Quanlynguoidung.Controls.Add(dmk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_Quanlynguoidung.Controls.Clear();
            Thongtintaikhoan tttk = new Thongtintaikhoan();
            tttk.Dock = DockStyle.Fill;
            pnl_Quanlynguoidung.Controls.Add(tttk);
        }
    }
}
