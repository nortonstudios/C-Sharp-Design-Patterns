using System;
namespace StarbuzzLibrary.CondimentDecorators
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", soy";
        }

        public override double Cost()
        {

            string size = _beverage.GetSize();

            if (size == "Medium")
            {
                return 0.15 + _beverage.Cost();
            }

            if (size == "Large")
            {
                return 0.20 + _beverage.Cost();
            }

            return 0.10 + _beverage.Cost();
        }
    }
}
