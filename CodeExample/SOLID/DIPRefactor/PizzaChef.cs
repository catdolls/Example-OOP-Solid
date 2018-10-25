using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIPRefactor
{
    public class PizzaChef : IMakePizza
    {
        public void MakePizza()
        {
            Console.WriteLine("Making a pizza...");
        }

    }
}
