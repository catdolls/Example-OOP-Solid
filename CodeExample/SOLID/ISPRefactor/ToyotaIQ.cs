using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.ISPRefactor
{
    public class ToyotaIQ : ICar, IBatteryChargeable, IControllable
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine starting.");
        }

        public void Move()
        {
            Console.WriteLine("Car moving.");
        }
        
        public void ChargeBattery()
        {
            Console.WriteLine("Charging battery");
        }

        public void Control()
        {
            this.StartEngine();
            this.Move();
            this.ChargeBattery();
        }

    }

}
