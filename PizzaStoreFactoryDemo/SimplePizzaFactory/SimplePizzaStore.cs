using System;
using PizzaClass;

namespace SimplePizzaFactory
{
    public class SimplePizzaStore
    {

        public SimplePizzaStore()
        {
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = SimplePizzaFactory.CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
