using System;

namespace DesignPatterns.AbstractFactory.NY
{
    public class MozzarellaCheese : ICheese
    {
        public void Create()
        {
            Console.WriteLine("Creating Mozzarella Cheese.");
        }
    }
}
