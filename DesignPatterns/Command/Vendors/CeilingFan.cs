using System;

namespace DesignPatterns
{
    public class CeilingFan
    {
        public CeilingSpeed Speed { get; set; }
        private readonly string _room;

        public CeilingFan(string room)
        {
            _room = room;
        }

        public void On()
        {
            Console.WriteLine("{0} Ceiling fan is on at {1}.", _room, Speed);
        }

        public void Off()
        {
            Console.WriteLine("{0} Ceiling fan is off.", _room);
        }

        public void Low()
        {
            Speed = CeilingSpeed.Low;
            On();
        }

        public void Medium()
        {
            Speed = CeilingSpeed.Medium;
            On();
        }

        public void High()
        {
            Speed = CeilingSpeed.High;
            On();
        }
    }

    public enum CeilingSpeed
    {
        Low = 1,
        Medium = 2,
        High = 3
    }
}
