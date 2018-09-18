using System;

namespace DesignPatterns.Command.Vendors
{
    public class TV
    {
        public int Channel { get; set; }
        public int Volume { get; set; }

        private readonly string _room;

        public TV(string room)
        {
            _room = room;
        }

        public void On()
        {
            Console.WriteLine("{0} TV is on at channel {1}. Volume {2}.",_room, Channel, Volume);
        }

        public void Off()
        {
            Console.WriteLine("{0} TV is off.", _room);
        }
    }
}
