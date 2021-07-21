using System;
using PizzaClass;
using SimplePizzaFactory;

using Xunit;

namespace SimplePizzaFactory
{
    public class SimplePizzaStoreTests
    {
        [Theory]
        [InlineData("cheese")]
        [InlineData("pepperoni")]
        [InlineData("clam")]
        [InlineData("veggie")]
        public void OrderPizza_ShouldReturnCorrectPizzaObject(string type)
        {
            //Arrange
            Pizza expected = null;
            if (type == "cheese")
            {
                expected = new CheesePizza();
            }
            if (type == "pepperoni")
            {
                expected = new PepperoniPizza();
            }
            if (type == "clam")
            {
                expected = new ClamPizza();
            }
            if (type == "veggie")
            {
                expected = new VeggiePizza();
            }

            SimplePizzaStore store = new SimplePizzaStore();
            Pizza actual;
            //Act
            actual = store.OrderPizza(type);
            //Assert
            Assert.Equal(expected.GetType(), actual.GetType());
        }
    }
}
