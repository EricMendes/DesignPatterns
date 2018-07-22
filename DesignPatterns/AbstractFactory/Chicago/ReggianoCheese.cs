using System;

namespace DesignPatterns.AbstractFactory.Chicago
{
    public class ReggianoCheese : ICheese
    {
        public void Create()
        {
            Console.WriteLine("Creating Reggiano Cheese.");
        }
    }
}
