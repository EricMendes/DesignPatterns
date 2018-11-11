using System;

namespace DesignPatterns.Facade.Components
{
    public class Projector
    {
        private bool isOn;

        public Projector()
        {
            isOn = false;
        }

        public void On()
        {
            isOn = true;
            Console.WriteLine("Projector is on.");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine("Projector is off."); 
        }

        public void TvMode()
        {
            if (isOn)
            {
                Console.WriteLine("Projector is on tv mode.");
            }
            else
            {
                Console.WriteLine("Projector is off! Please turn it on.");
            }
        }

        public void WideScreenMode()
        {
            if (isOn)
            {
                Console.WriteLine("Projector is on widescreen mode.");
            }
            else
            {
                Console.WriteLine("Projector is off! Please turn it on.");
            }
        }
    }
}
