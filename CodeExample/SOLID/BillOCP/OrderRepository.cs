using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillOCP
{
    public class OrderRepository
    {
        public double GetCategoryDiscountPercentage(Order order)
        {
            double discountPercent = 0;

            switch (order.Category)
            {
                case CategoryType.book:
                    discountPercent = 0.15;
                    break;
                case CategoryType.doll:
                    discountPercent = 0.2;
                    break;
                case CategoryType.flower:
                    discountPercent = 0.3;
                    break;
                default:
                    discountPercent = 0.1;
                    break;
            }

            return discountPercent;
        }

        public void LogOrder(int userId, Order order, double amountPaid)
        {
            Console.WriteLine(string.Format(@"Insert into Orders:\n 
                user_id: {0},\n 
                order_id: {1},\n
                final_price: {2}\n", userId, order.Id, amountPaid));
        }
    }
}
