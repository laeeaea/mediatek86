using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    public class Responsable
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public Responsable(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }
}
