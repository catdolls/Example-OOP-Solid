using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class CsvOrderRepository : IOrderRepository
    {
        public void LogOrder(int userId, Order order, double amountPaid)
        {
            Console.WriteLine("Save as CSV");
        }
    }
}
