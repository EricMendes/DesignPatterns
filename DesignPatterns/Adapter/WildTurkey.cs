using System;

namespace DesignPatterns.Adapter
{
    public class WildTurkey : Turkey
    {
        public WildTurkey()
            :base(new FlyShortDistance(), new Gobble())
        {

        }

        public override void Display()
        {
            Console.WriteLine("I'm wild turkey.");
        }
    }
}
