using System;

namespace DesignPatterns.Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new FlyNoWay(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
