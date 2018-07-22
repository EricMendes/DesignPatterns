using System;

namespace DesignPatterns.AbstractFactory.NY
{
    class PlumTomatoSauce : ISauce
    {
        public void Create()
        {
            Console.WriteLine("Creating Plum Tomato Sauce.");
        }
    }
}
