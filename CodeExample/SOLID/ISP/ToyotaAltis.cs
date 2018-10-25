using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISP
{
    public class ToyotaAltis : ICar
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
            Console.WriteLine("Filling up gas.");
        }

        public void ChargeBattery()
        {
            throw new Exception("Not use battery");
        }

    }

}
