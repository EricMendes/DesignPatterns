namespace DesignPatterns.Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
