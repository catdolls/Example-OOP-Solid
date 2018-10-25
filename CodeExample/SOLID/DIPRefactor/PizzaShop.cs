using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIPRefactor
{
    public class PizzaShop
    {
        private IMakePizza pizzaChef;
        private IDeliverPizza pizzaBoy;
 
        public PizzaShop(IMakePizza pizzaChef, IDeliverPizza pizzaBoy)
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

    public class PizzaShopSetup
    {
        public PizzaShopSetup()
        {
            PizzaShop pizzaShop = new PizzaShop(new ItalianChef(), new ThailandPost());
            pizzaShop.TakeOrder();

        }
    }

}
