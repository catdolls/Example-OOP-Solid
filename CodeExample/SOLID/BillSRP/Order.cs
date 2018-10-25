using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.BillSRP
{
    public enum CategoryType
    {
        book = 1,
        doll = 2,
        flower = 3
    }

    public class Order
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public CategoryType Category { get; set; }
    }
}
