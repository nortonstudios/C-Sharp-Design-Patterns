using System;
namespace StarbuzzLibrary.CondimentDecorators
{
    public class SteamedMilk : CondimentDecorator
    {
        Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", steamed milk";
        }


        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
