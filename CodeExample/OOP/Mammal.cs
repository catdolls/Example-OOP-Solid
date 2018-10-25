using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public interface IPettable
    {
        IList<Trick> Tricks { get; set; }
        void Bathe();
        void Train(Trick t);
    }

    public class Trick
    {
    }

    public abstract class Mammal
    {
        public void Feed() { }
        public void Mate() { }
    }

    public class Dog : Mammal, IPettable
    {
        public IList<Trick> Tricks { get; set; }

        public void Bathe()
        {
            throw new NotImplementedException();
        }

        public void Train(Trick t)
        {
            throw new NotImplementedException();
        }
    }
    public class Cat : Mammal, IPettable
    {
        public IList<Trick> Tricks { get; set; }

        public void Bathe()
        {
            throw new NotImplementedException();
        }

        public void Train(Trick t)
        {
            throw new NotImplementedException();
        }
    }

    public class Giraffe : Mammal
    {
    }
    public class Rhinoceros : Mammal
    {

    }
    public class Hippopotamus : Mammal
    {

    }


}
