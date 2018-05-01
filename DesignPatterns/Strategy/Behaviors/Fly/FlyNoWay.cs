using System;
namespace DesignPatterns.Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly.");
        }
    }
}
