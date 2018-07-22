using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.NY
{
    public class FrozenClams : IClams
    {
        public void Create()
        {
            Console.WriteLine("Creating Frozen Clams.");
        }
    }
}
