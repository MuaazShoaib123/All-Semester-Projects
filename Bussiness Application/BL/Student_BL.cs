using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Application.BL
{
    class Muser_BL
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public Muser_BL(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public Muser_BL()
        {

        }
    }
}
