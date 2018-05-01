
namespace DesignPatterns.Strategy
{
    public abstract class Duck
    {
        private IFlyBehavior FlyBehavior { get; set; }
        private IQuackBehavior QuackBehavior { get; set; }

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public abstract void Display();

        public void Fly()
        {
            FlyBehavior.Fly();
        }

        public void Quack()
        {
            QuackBehavior.Quack();
        }
    }
}
