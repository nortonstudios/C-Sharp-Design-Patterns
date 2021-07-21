using System;
namespace PizzaClass
{
    public class Pizza
    {
        public Pizza()
        {
        }

        public void prepare()
        {
            Console.WriteLine("A pizza has been prepared.");
        }

        public void bake()
        {
            Console.WriteLine("A pizza has been baked.");
        }

        public void cut()
        {
            Console.WriteLine("A pizza has been cut.");
        }

        public void box()
        {
            Console.WriteLine("A pizza has been put into a box.");
        }

    }
}
