using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Customer
    {
        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }
    
    //public class Customer
    //{
    //    private FileLogger obj = new FileLogger();

    //    public virtual void Add()
    //    {
    //        try
    //        {
    //            // Database code goes here
    //        }
    //        catch (Exception ex)
    //        {
    //            obj.Handle(ex.ToString());
    //        }
    //    }
    //}

    //public class FileLogger
    //{
    //    public void Handle(string error)
    //    {
    //        System.IO.File.WriteAllText(@"c:\Error.txt", error);
    //    }
    //}
}
