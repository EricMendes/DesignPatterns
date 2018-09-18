using System;

namespace DesignPatterns.Command.Vendors
{
    public class CeilingLight
    {
        public int Dimmer { get; private set; }

        public CeilingLight()
        {
            Dimmer = 100;
        }
        public void On()
        {
            Console.WriteLine("Ceiling light is on at {0}%.", Dimmer);
        }

        public void Off()
        {
            Console.WriteLine("Ceiling light is off.");
        }

        public void SetDimmer(int percent)
        {
            if(percent < 0 || percent > 100)
            {
                throw new ArgumentException("The dimmer must be between 0 and 100.");
            }
            Dimmer = percent;
        }
    }
}
