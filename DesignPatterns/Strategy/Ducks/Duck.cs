
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

        public virtual void Fly()
        {
            FlyBehavior.Fly();
        }

        public virtual void Quack()
        {
            QuackBehavior.Quack();
        }
    }
}
