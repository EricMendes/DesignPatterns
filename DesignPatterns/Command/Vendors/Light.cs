using System;

namespace DesignPatterns.Command.Vendors
{
    public class Light
    {
        private readonly string _room;
        public Light(string room)
        {
            _room = room;
        }

        public void On()
        {
            Console.WriteLine("{0} light is on.", _room);
        }

        public void Off()
        {
            Console.WriteLine("{0} light is off.", _room);
        }
    }
}
