
using System;

namespace DesignPatterns.Facade.Components
{
    public class EnvironmentLight
    {
        private bool isOn;


        public EnvironmentLight()
        {
            isOn = false;
        }

        public void On()
        {
            isOn = true;
            Console.WriteLine("Enviroment Light is on.");
        }

        public void Off()
        {
            isOn = false;
            Console.WriteLine("Enviroment Light is off.");
        }

        public void Dim(int percentage)
        {
            if (isOn)
            {
                Console.WriteLine("Enviroment Light is on {0} percent.", percentage);
            }
            else
            {
                Console.WriteLine("Enviroment Light is off! Please turn it on.");
            }
        }


    }
}
