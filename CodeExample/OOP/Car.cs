using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class Car
    {
        public virtual string Name
        {
            get
            {
                return "Car";
            }
        }

        public virtual int NumberOfWheels
        {
            get
            {
                if (this is Bus)
                {
                    return 6;
                }

                return 4;
            }
        }

        public virtual void Move()
        {
            Console.WriteLine(this.Name + "move");
        }
    }

    public class Sedan : Car
    {
        public override string Name
        {
            get
            {
                return "Sedan";
            }
        }
    }

    public class Cabriolet : Car
    {
        public override string Name
        {
            get
            {
                return "Cabriolet";
            }
        }
    }

    public class Truck : Car
    {
        public override string Name
        {
            get
            {
                return "Truck";
            }
        }
    }

    public class Bus : Car
    {
        public override string Name
        {
            get
            {
                return "Bus";
            }
        }
    }
}
