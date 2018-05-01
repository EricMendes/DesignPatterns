using System;

namespace DesignPatterns.Strategy
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I'm squeaking.");
        }
    }
}
