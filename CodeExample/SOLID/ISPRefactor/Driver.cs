using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISPRefactor
{
    public class Driver
    {
        public void Control(IControllable car)
        {
            car.Control();
        }
    }

}
