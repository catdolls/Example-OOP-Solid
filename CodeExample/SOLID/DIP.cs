using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public interface ILogger
    {
        void Handle(string error);
    }

    public class FileLogger : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
    public class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }
    public class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }


    public class Customer
    {
        private ILogger obj;

        public Customer(ILogger i)
        {
            obj = i;
        }
    }

}
