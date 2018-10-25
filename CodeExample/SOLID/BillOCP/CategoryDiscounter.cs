using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillOCP
{
    public class CategoryDiscounter : IDiscounter
    {
        private OrderRepository OrderRepo { get; set; }
 
        public CategoryDiscounter(OrderRepository orderRepo)
        {
            this.OrderRepo = orderRepo;
        }

        public void Discount(Order order)
        {
            double percentage = this.OrderRepo.GetCategoryDiscountPercentage(order);
            order.Price = order.Price * (1 - percentage);
        }
    }

}
