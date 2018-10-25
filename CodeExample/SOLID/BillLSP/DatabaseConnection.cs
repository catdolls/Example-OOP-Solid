using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class DatabaseConnection
    {
        public DatabaseConnection(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }
    }
}
