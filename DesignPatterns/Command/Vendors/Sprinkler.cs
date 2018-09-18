using System;

namespace DesignPatterns.Command.Vendors
{
    public class Sprinkler
    {
        public void WaterOn()
        {
            Console.WriteLine("Sprinkler is on.");
        }

        public void WaterOff()
        {
            Console.WriteLine("Sprinkler is off.");
        }
    }
}
