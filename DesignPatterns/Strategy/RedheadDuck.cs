using System;

namespace DesignPatterns.Strategy
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
            : base(new FlyNoWay(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a redhead duck");
        }
    }
}
