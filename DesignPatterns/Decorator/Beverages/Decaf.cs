namespace DesignPatterns.Decorator
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
