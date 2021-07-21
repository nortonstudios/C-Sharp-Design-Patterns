using System;
namespace StarbuzzLibrary.CondimentDecorators
{
    public class Whip : CondimentDecorator
    {
        Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", whip";
        }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }
    }
}
