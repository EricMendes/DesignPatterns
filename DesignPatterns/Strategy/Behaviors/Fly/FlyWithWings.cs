
using System;

namespace DesignPatterns.Strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying.");
        }
    }
}
