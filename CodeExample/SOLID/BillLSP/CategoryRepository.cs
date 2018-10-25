using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillLSP
{
    public class CategoryRepository
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
    }
}
