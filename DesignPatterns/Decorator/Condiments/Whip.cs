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
