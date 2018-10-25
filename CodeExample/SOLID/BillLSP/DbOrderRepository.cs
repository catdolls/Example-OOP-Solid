using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class DbOrderRepository : IOrderRepository
    {
        //private DatabaseConnection Connection { get; set; }

        //public void Connect(string userName, string password)
        //{
        //    Console.WriteLine("Create database connection");
        //    this.Connection = new DatabaseConnection(userName, password);
        //}

        private DatabaseConnector Connector { get; set; }

        public DbOrderRepository(DatabaseConnector connector)
        {
            this.Connector = connector;
        }

        public void LogOrder(int userId, Order order, double amountPaid)
        {
            //this.Connect("db_user01", "password");
            this.Connector.GetConnection();

            Console.WriteLine(string.Format(@"Insert into Orders Table:\n 
                user_id: {0},\n 
                order_id: {1},\n
                final_price: {2}\n", userId, order.Id, amountPaid));
        }
    }
}
