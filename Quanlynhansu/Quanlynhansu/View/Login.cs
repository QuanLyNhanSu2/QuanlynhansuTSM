using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlynhansu.View;
using Quanlynhansu.Model;
using Quanlynhansu.Controller;
namespace Quanlynhansu.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        UserController userController = new UserController();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            if (userController.Login(new User(Username, Password)))
            {
                Form1 frm = new Form1();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.FormClosed += Frm_FormClosed;
                frm.Show();
                this.Hide();
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
