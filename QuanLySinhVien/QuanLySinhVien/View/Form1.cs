using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.frmLogin frm = new View.frmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
            this.Hide();
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
