using System;

namespace SOLID.BillSRP
{
    public class OrderProcessor
    {
        private PaypalBiller Biller { get; set; }
        //private OrderRepository OrderRepo { get; set; }

        public OrderProcessor(PaypalBiller biller)
        {
            this.Biller = biller;
        }

        public void Process(Order order, int userId)
        {
            double percentage = this.GetCategoryDiscountPercentage(order);
            order.Price = order.Price * (1 - percentage);
            this.Biller.Bill(userId, order.Price);
            this.LogOrder(userId, order, order.Price);
        }

        public double GetCategoryDiscountPercentage(Order order)
        {
            double discountPercent = 0;

            switch (order.Category)
            {
                case CategoryType.book:
                    discountPercent = 0.15;
                    break;
                case CategoryType.doll:
                    discountPercent = 0.2;
                    break;
                case CategoryType.flower:
                    discountPercent = 0.3;
                    break;
                default:
                    discountPercent = 0.1;
                    break;
            }

            return discountPercent;
        }

        public void LogOrder(int userId, Order order, double amountPaid)
        {
            Console.WriteLine(string.Format(@"Insert into Orders:\n 
                user_id: {0},\n 
                order_id: {1},\n
                final_price: {2}\n", userId, order.Id, amountPaid));
        }

        //public OrderProcessor(PaypalBiller biller, OrderRepository orderRepo)
        //{
        //    this.Biller = biller;
        //    this.OrderRepo = orderRepo;
        //}

        //public void Process(Order order, int userId)
        //{
        //    double percentage = this.OrderRepo.GetCategoryDiscountPercentage(order);
        //    order.Price = order.Price * (1 - percentage);
        //    this.Biller.Bill(userId, order.Price);
        //    this.OrderRepo.LogOrder(userId, order, order.Price);
        //}
    }
    
    public class OrderRepository
    {
        public double GetCategoryDiscountPercentage(Order order)
        {
            double discountPercent = 0;

            switch (order.Category)
            {
                case CategoryType.book:
                    discountPercent = 0.15;
                    break;
                case CategoryType.doll:
                    discountPercent = 0.2;
                    break;
                case CategoryType.flower:
                    discountPercent = 0.3;
                    break;
                default:
                    discountPercent = 0.1;
                    break;
            }

            return discountPercent;
        }

        public void LogOrder(int userId, Order order, double amountPaid)
        {
            Console.WriteLine(string.Format(@"Insert into Orders:\n 
                user_id: {0},\n 
                order_id: {1},\n
                final_price: {2}\n", userId, order.Id, amountPaid));
        }
    }

}
