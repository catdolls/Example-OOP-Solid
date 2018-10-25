using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class CategoryDiscounter : IDiscounter
    {
        private CategoryRepository CategoryRepository { get; set; }
 
        public CategoryDiscounter(CategoryRepository categoryRepository)
        {
            this.CategoryRepository = categoryRepository;
        }

        public void Discount(Order order)
        {
            double percentage = this.CategoryRepository.GetCategoryDiscountPercentage(order);
            order.Price = order.Price * (1 - percentage);
        }
    }

}
