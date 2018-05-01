using System;

namespace DesignPatterns.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck() 
            : base(new FlyWithWings(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a mallard duck");
        }
    }
}
