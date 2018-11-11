
using System;

namespace DesignPatterns.Facade.Components
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner is on.");
        }

        public void Off()
        {
            Console.WriteLine("Tuner is off.");
        }

        public void SetAm()
        {
            Console.WriteLine("Tuner is on am mode.");
        }

        public void SetFm()
        {
            Console.WriteLine("Tuner is on fm mode.");
        }

        public void SetFrequency(decimal frequency)
        {
            Console.WriteLine("Tuner is on {0} frequency.", frequency);
        }
    }
}
