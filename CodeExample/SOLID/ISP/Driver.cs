using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public class Driver
    {
        public void Control(ICar car)
        {
            car.StartEngine();
            car.Move();
            car.FillUpFuel();
        }
    }

}
