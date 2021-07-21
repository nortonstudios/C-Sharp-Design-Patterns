using System;
namespace StarbuzzLibrary.Beverages
{
    public class DarkRoast : Beverage
    {
      
        public DarkRoast()
        {
            description = "Dark roast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
