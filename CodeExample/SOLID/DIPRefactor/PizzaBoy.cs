using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIPRefactor
{
    public class PizzaBoy : IDeliverPizza
    {
        public void DeliverPizza()
        {
            Console.WriteLine("Delivering a pizza...");
        }

    }
}
