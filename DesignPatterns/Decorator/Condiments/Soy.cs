namespace DesignPatterns.Decorator
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            Description = beverage.Description + ", Soy";
            _beverage = beverage;
        }


        public override double Cost()
        {
            return _beverage.Cost() + 0.15;
        }
    }
}
