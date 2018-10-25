using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public class ToyotaIQ : ICar
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine starting.");
        }

        public void Move()
        {
            Console.WriteLine("Car moving.");
        }

        public void FillUpFuel()
        {
            throw new Exception("Not use gas");
        }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging battery");
        }

    }

}
