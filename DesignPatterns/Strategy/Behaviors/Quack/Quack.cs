using System;

namespace DesignPatterns.Strategy
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("I'm quacking.");
        }
    }
}
