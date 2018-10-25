using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public interface IOrderRepository
    {
        void LogOrder(int userId, Order order, double amountPaid);
    }
}
