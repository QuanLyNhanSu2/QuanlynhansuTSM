using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.View
{
    public partial class frmLogin : Form
    {
        private View.frmResetPassword frmReset = new frmResetPassword();
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReset.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
            this.Hide();
        }
    }
}
