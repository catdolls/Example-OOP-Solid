using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP
{
    public class PizzaShop
    {
        private PizzaChef pizzaChef;
        private PizzaBoy pizzaBoy;
 
        public PizzaShop(PizzaChef pizzaChef, PizzaBoy pizzaBoy)
        {
            this.pizzaChef = pizzaChef;
            this.pizzaBoy = pizzaBoy;
        }

        public void TakeOrder()
        {
            this.pizzaChef.MakePizza();
            this.pizzaBoy.DeliverPizza();
        }
    }

}
