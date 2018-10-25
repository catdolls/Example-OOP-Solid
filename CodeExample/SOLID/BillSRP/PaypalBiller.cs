using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillSRP
{
    public class PaypalBiller
    {
        public void Bill(int userId, double amount)
        {
            Console.WriteLine("Bill the customer");
        }
    }
}
