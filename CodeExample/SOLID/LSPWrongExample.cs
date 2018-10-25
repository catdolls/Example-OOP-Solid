using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    //public abstract class Customer
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

    //public class SilverCustomer : Customer
    //{
    //    public override double GetDiscount(double totalSales)
    //    {
    //        return base.GetDiscount(totalSales) - 50;
    //    }
    //}

    //public class GoldCustomer : Customer
    //{
    //    public override double GetDiscount(double totalSales)
    //    {
    //        return base.GetDiscount(totalSales) - 100;
    //    }
    //}

    //public class Enquiry : Customer
    //{
    //    public override double GetDiscount(double TotalSales)
    //    {
    //        return base.GetDiscount(TotalSales) - 5;
    //    }

    //    public override void Add()
    //    {
    //        throw new Exception("Not allowed");
    //    }
    //}

    //public class CustomerSetup
    //{
    //    public CustomerSetup()
    //    {
    //        IList<Customer> Customers = new List<Customer>();
    //        Customers.Add(new SilverCustomer());
    //        Customers.Add(new GoldCustomer());
    //        Customers.Add(new Enquiry());

    //        foreach (Customer o in Customers)
    //        {
    //            o.Add();
    //        }
    //    }
    //}
}
