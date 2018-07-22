using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler uniqueInstance;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        public void Fill()
        {
            if(empty)
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Boiler filled");
            }
            else
            {
                Console.WriteLine("Boiler isn't empty!");
            }
        }

        public void Boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
                Console.WriteLine("Mix is Boiling");
            }
            else
            {
                if (empty)
                {
                    Console.WriteLine("Boiler is empty!");
                }
                if (boiled)
                {
                    Console.WriteLine("Mix is already boiled!");
                }
            }
        }

        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
                boiled = false;
                Console.WriteLine("Mix is drained");
            }
            else
            {
                if (empty)
                {
                    Console.WriteLine("Boiler is already empty!");
                }
                if (!boiled)
                {
                    Console.WriteLine("Mix isn't boiled!");
                }
            }
        }
    }
}
