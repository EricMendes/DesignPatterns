namespace DesignPatterns.Decorator
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            Description = beverage.Description + ", Mocha";
            _beverage = beverage;
        }
        public override double Cost()
        {
            return _beverage.Cost() + 0.2;
        }
    }
}
