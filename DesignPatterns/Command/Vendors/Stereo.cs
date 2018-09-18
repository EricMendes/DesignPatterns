using System;

namespace DesignPatterns.Command.Vendors
{
    public class Stereo
    {
        public StereoMode Mode { get; set; }
        public int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("Stereo is on at mode {0}. Volume {1}", Mode, Volume);
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off.");
        }


    }

    public enum StereoMode
    {
        CD = 1,
        BluRay = 2,
        Radio = 3
    }
}
