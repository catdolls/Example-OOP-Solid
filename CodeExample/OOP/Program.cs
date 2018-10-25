using System;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Flyable f = new Flyable();
            f.Fly();

            f = new Bird();
            f.Fly();
            //f.Eat(); -- error

            BaseClass baseClass = new BaseClass();
            Console.WriteLine(baseClass.ToString());
            BaseClass subClassA = new SubClassA();
            Console.WriteLine(subClassA.ToString());
            BaseClass subClassB = new SubClassB();
            Console.WriteLine(subClassB.ToString());
            SubClassB subClassB2 = new SubClassB();
            Console.WriteLine(subClassB2.ToString());

            RepositorySetup repositorySetup = new RepositorySetup();
            repositorySetup.TestRepository();

            Console.ReadKey();
        }
    }
}
