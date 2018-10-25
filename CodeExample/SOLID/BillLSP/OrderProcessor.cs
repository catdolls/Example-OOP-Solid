using System;
using System.Collections.Generic;

namespace SOLID.BillLSP
{
    public class OrderProcessor
    {
        private PaypalBiller Biller { get; set; }
        private IOrderRepository OrderRepo { get; set; } 
        private IList<IDiscounter> Discounters { get; set; }
        
        public OrderProcessor(PaypalBiller biller, IOrderRepository orderRepo, IList<IDiscounter> discounters)
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

            IOrderRepository orderRepository = new OrderRepository();
            IOrderRepository csvRepo = new CsvOrderRepository();

            CategoryRepository categoryRepository = new CategoryRepository();
 
            IList<IDiscounter> discounters = new List<IDiscounter>() {
                new CategoryDiscounter(categoryRepository),
                new ValentineDiscounter(),
            };

            OrderProcessor processor = new OrderProcessor(
                paypalBiller,
                csvRepo,
                discounters
            );
            
            processor.Process(order, 5);
        }
    }

}
    
