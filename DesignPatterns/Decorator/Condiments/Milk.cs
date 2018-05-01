namespace DesignPatterns.Decorator
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
            Description = beverage.Description + ", Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.1;
        }
    }
}
