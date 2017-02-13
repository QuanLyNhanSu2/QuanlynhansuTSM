using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlynhansu.Model;
using Quanlynhansu.Helper;
using System.Data.SqlClient;

namespace Quanlynhansu.Controller
{
    class UserController
    {
        public bool Login(User user)
        {
            // return DataAccess.Query("Login", new SqlParameter("Username", user.Username), new SqlParameter("Username", user.Username)) != null;
            return true;
        }

        public void Register(User user)
        {
            //DataAccess.Query("Register",
            //            new SqlParameter("Username", user.Username),
            //            new SqlParameter("Password", user.Password)
            //    );
        }
    }
}
