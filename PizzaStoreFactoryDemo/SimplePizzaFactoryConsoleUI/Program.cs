using System;
using PizzaClass;
using SimplePizzaFactory;

namespace SimplePizzaFactoryConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaStore store = new SimplePizzaStore();

            Pizza pizza = store.OrderPizza("cheese");

            Console.ReadLine();

        }
    }
}
