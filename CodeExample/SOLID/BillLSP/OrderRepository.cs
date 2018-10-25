using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class OrderRepository: IOrderRepository
    {
        public void LogOrder(int userId, Order order, double amountPaid)
        {
            Console.WriteLine(string.Format(@"Insert into Orders:\n 
                user_id: {0},\n 
                order_id: {1},\n
                final_price: {2}\n", userId, order.Id, amountPaid));
        }
    }
}
