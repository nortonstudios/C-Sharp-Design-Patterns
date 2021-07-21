using System;
namespace StarbuzzLibrary.CondimentDecorators
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", mocha";
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}
