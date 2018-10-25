using System;
using System.Collections.Generic;

namespace SOLID.BillOCP
{
    public class OrderProcessor
    {
        private PaypalBiller Biller { get; set; }
        private OrderRepository OrderRepo { get; set; } 

        private IList<IDiscounter> Discounters { get; set; }
        
        //public OrderProcessor(PaypalBiller biller, OrderRepository orderRepo)
        //{
        //    this.Biller = biller;
        //    this.OrderRepo = orderRepo;
        //}

        //public void Process(Order order, int userId)
        //{
        //    double percentage = this.OrderRepo.GetCategoryDiscountPercentage(order);
        //    order.Price = order.Price * (1 - percentage);

        //    DateTime now = DateTime.UtcNow;

        //    if (now.Month == 2 && now.Day == 14)
        //    {
        //        order.Price = order.Price * (1 - 0.15);
        //    }

        //    this.Biller.Bill(userId, order.Price);
        //    this.OrderRepo.LogOrder(userId, order, order.Price);
        //}

        public OrderProcessor(PaypalBiller biller, OrderRepository orderRepo, IList<IDiscounter> discounters)
        {
            this.Biller = biller;
            this.OrderRepo = orderRepo;
            this.Discounters = discounters;
        }

        public void Process(Order order, int userId)
        {
            foreach (IDiscounter discounter in this.Discounters)
            {
                discounter.Discount(order);
            }

            this.Biller.Bill(userId, order.Price);
            this.OrderRepo.LogOrder(userId, order, order.Price);
        }
    }

    public class OCPSetup
    {
        public OCPSetup()
        {
            Order order = new Order();
            order.Id = 56;
            order.Price = 25000;
            order.Category = CategoryType.book;
 
            PaypalBiller paypalBiller = new PaypalBiller();
            OrderRepository orderRepository = new OrderRepository();
 
            IList<IDiscounter> discounters = new List<IDiscounter>() {
                new CategoryDiscounter(orderRepository),
                new ValentineDiscounter(),
            };

            OrderProcessor processor = new OrderProcessor(
                paypalBiller,
                orderRepository,
                discounters
            );
            
            processor.Process(order, 5);
        }
    }

}
    
