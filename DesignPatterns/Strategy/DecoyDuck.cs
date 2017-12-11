using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new FlyNoWay(), new Quack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
