using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISPRefactor
{
    public class ToyotaAltis : ICar, IFuelFillable, IControllable
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

        public void Control()
        {
            this.StartEngine();
            this.Move();
            this.FillUpFuel();
        }

    }

}
