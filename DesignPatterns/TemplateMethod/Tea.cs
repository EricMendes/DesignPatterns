using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon.");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea.");
        }
    }
}
