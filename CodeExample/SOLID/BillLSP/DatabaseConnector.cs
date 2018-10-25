using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class DatabaseConnector
    {
        private DatabaseConnection Connection { get; set; }

        public DatabaseConnector(DatabaseConnection connection)
        {
            this.Connection = connection;
        }

        public DatabaseConnection GetConnection()
        {
            return this.Connection;
        }
    }
}
