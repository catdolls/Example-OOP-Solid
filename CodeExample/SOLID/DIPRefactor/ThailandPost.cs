using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIPRefactor
{
    public class ThailandPost : IDeliverPizza
    {
        public void DeliverPizza()
        {
            Console.WriteLine("Delivering a pizza...");
        }
    }

}
