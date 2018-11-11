using System;

namespace DesignPatterns.Facade.Components
{
    public class CdPlayer
    {
        public void On()
        {
            Console.WriteLine("Cd Player is on.");
        }

        public void Off()
        {
            Console.WriteLine("Cd Player is off.");
        }

        public void Eject()
        {
            Console.WriteLine("Ejecting the Cd.");
        }

        public void Play()
        {
            Console.WriteLine("Playing the Cd.");
        }

        public void Pause()
        {
            Console.WriteLine("Cd is paused.");
        }

        public void Stop()
        {
            Console.WriteLine("Cd is stopped.");
        }
    }
}
