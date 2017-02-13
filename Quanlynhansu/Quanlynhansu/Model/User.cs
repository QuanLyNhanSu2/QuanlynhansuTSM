using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlynhansu.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }
    }
}
