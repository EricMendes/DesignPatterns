using System;

namespace DesignPatterns.Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
