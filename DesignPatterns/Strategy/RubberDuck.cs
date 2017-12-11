using System;

namespace DesignPatterns.Strategy
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
            : base(new FlyNoWay(), new MuteQuack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
