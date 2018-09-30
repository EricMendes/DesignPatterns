
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns.Adapter
{
    public class TurkeyAdapter : Duck
    {

        public TurkeyAdapter(Turkey turkey)
            :base(turkey.FlyBehavior, new GobbleAdapter(turkey.GobbleBehavior))
        {

        }

        public override void Display()
        {
            Console.WriteLine("I'm a turkey acting like a duck.");
        }
    }
}
