using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIPRefactor
{
    public class ItalianChef : IMakePizza
    {
        public void MakePizza()
        {
            Console.WriteLine("Making a Italian pizza");
        }

    }
}
