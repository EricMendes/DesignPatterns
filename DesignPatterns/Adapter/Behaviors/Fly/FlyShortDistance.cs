using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class FlyShortDistance : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance.");
        }
    }
}
