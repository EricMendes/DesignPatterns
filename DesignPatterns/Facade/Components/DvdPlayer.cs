using System;

namespace DesignPatterns.Facade.Components
{
    public class DvdPlayer
    {
        public void On()
        {
            Console.WriteLine("Dvd player is on.");
        }

        public void Off()
        {
            Console.WriteLine("Dvd player is off.");
        }

        public void Eject()
        {
            Console.WriteLine("Ejecting the Dvd.");
        }

        public void Play(string movieName)
        {
            Console.WriteLine("Now playing {0}", movieName);
        }

        public void Pause()
        {
            Console.WriteLine("Dvd is paused.");
        }

        public void Stop()
        {
            Console.WriteLine("Dvd is stopped.");
        }
    }
}
