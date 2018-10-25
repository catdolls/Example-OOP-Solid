using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    //public interface IDatabase
    //{
    //    void Add(); // old client are happy with these.
    //    //void Read(); // Added for new clients.
    //}

    //public interface IDatabaseV1 : IDatabase // Gets the Add method
    //{
    //    void Read();
    //}

    //public interface IDiscount
    //{
    //    double GetDiscount(double totalSales);
    //}

    //public class Customer : IDiscount, IDatabase
    //{
    //    public virtual double GetDiscount(double totalSales)
    //    {
    //        return totalSales;
    //    }

    //    public virtual void Add()
    //    {
    //        Console.WriteLine("Add customer");
    //    }
    //}

    //public class CustomerwithRead : IDatabase, IDatabaseV1
    //{

    //    public void Add()
    //    {
    //        Customer obj = new Customer();
    //        obj.Add();
    //    }

    //    public void Read()
    //    {
    //        // Implements  logic for read
    //    }
    //}

    //public class ISPSetup
    //{
    //    public ISPSetup()
    //    {
    //        IDatabase customer = new Customer(); // 1000 happy old clients not touched
    //        customer.Add();

    //        IDatabaseV1 customerWithRead = new CustomerwithRead(); // new clients
    //        customerWithRead.Add();
    //        customerWithRead.Read();
    //    }
    //}
}
