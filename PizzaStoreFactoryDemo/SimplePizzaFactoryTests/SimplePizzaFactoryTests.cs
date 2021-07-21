using System;
using PizzaClass;
using SimplePizzaFactory;
using Xunit;

namespace SimplePizzaFactory
{ 

    public class SimplePizzaFactoryTests
    {
        
        [Theory]
        [InlineData("cheese")]
        [InlineData("pepperoni")]
        [InlineData("clam")]
        [InlineData("veggie")]
        public void CreatePizza_ShouldReturnCorrectPizzaObject(string type)
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

            Pizza actual;
            //Act
            actual = SimplePizzaFactory.CreatePizza(type);
            //Assert
            Assert.Equal(expected.GetType(), actual.GetType());
        }
    }
}
