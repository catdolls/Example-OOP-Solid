using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillOCP
{
    public interface IDiscounter
    {
        void Discount(Order order);
    }
}
