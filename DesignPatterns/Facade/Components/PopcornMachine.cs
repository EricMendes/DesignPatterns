
using System;

namespace DesignPatterns.Facade.Components
{
    public class PopcornMachine
    {
        private bool isOn;

        public PopcornMachine()
        {
            isOn = false;
        }

        public void On()
        {
            isOn = true;
            Console.WriteLine("Popcorn machine is on.");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine("Popcorn machine is off.");
        }

        public void Pop()
        {
            if (isOn)
            {
                Console.WriteLine("Popcorn machine is making popcorn.");
            }
            else
            {
                Console.WriteLine("Popcorn is off! Please turn it on.");
            }
        }
    }
}
