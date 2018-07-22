using System;

namespace DesignPatterns.AbstractFactory.Chicago
{
    public class MarinaraSauce : ISauce
    {
        public void Create()
        {
            Console.WriteLine("Creating Marinara Sauce.");
        }
    }
}
