using DesignPatterns.Strategy;

namespace DesignPatterns.Adapter
{
    public abstract class Turkey
    {
        public readonly IFlyBehavior FlyBehavior;
        public readonly IGobbleBehavior GobbleBehavior;

        public Turkey(IFlyBehavior flyBehavior, IGobbleBehavior gobbleBehavior)
        {
            FlyBehavior = flyBehavior;
            GobbleBehavior = gobbleBehavior;
        }

        public abstract void Display();

        public virtual void Fly()
        {
            FlyBehavior.Fly();
        }

        public virtual void Gobble()
        {
            GobbleBehavior.Gobble();
        }
    }
}
