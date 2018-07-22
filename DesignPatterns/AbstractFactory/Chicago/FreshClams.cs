using System;

namespace DesignPatterns.AbstractFactory.Chicago
{
    public class FreshClams : IClams
    {
        public void Create()
        {
            Console.WriteLine("Creating Fresh Clams.");
        }
    }
}
