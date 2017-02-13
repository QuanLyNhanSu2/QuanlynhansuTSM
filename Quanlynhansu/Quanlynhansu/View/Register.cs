using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlynhansu.Helper;
using System.Data.SqlClient;
using Quanlynhansu.Model;

namespace Quanlynhansu.View
{
    public partial class Register : Form
    {
        public static bool registerOK = false;
        public static User user = new User();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Username = txtRegisterUsername.Text;
            string Password = txtRegisterPassword.Text;
            user = new User(Username, Password);
            //DataAccess.NonQuery("RegisterUser",
            //                    new SqlParameter("Username", Username),
            //                    new SqlParameter("Password", Password)
            //                );
            registerOK = true;
            this.Close();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
