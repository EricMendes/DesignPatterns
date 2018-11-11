using System;

namespace DesignPatterns.Facade.Components
{
    public class Amplifier
    {
        public Tuner Tuner { get; set; }
        public DvdPlayer DvdPlayer { get; set; }
        public CdPlayer CdPlayer { get; set; }

        public void On()
        {
            Console.WriteLine("Amplifier is on.");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is off.");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("Volume is {0}.", volume);
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier is on Stereo Mode.");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier is on Surround Mode.");
        }
    }
}
