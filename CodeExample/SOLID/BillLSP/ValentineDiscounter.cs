using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class ValentineDiscounter : IDiscounter
    {
        public void Discount(Order order)
        {
            DateTime now = DateTime.UtcNow;

            if (now.Month == 2 && now.Day == 14)
            {
                order.Price = order.Price * (1 - 0.15);
            }
        }
    }
}
