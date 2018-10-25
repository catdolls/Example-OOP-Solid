using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public interface IDiscounter
    {
        void Discount(Order order);
    }
}
