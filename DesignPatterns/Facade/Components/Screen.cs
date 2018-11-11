using System;

namespace DesignPatterns.Facade.Components
{
    public class Screen
    {
        public void Up()
        {
            Console.WriteLine("Screen is up.");
        }

        public void Down()
        {
            Console.WriteLine("Screen is down.");
        }
    }
}
