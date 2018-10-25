using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Flyable
    {
        //virtual is used to modify a method, property, indexer, 
        //or event declaration and allow for it to be overridden in a derived class.
        public virtual void Fly()
        {
            Console.WriteLine("Fly ~");
        }
    }

    public class Bird : Flyable
    {
        public override void Fly()
        { 
            Console.WriteLine("Bird fly");
        }

        public void Eat()
        {
            Console.WriteLine("Bird eat");
        }

    }

    public class Airplane : Flyable
    {
        public override void Fly()
        {
            Console.WriteLine("Airplane fly");
        }
    }

    public class Drone : Flyable
    {
        public override void Fly()
        {
            Console.WriteLine("Drone fly");
        }
    }


}
