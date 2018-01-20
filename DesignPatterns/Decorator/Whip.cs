using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Whip: CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            Description = beverage.Description + ", Whip";
            _beverage = beverage;
        }


        public override double Cost()
        {
            return _beverage.Cost() + 0.1;
        }
    }
}
