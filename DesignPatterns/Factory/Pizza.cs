using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    public abstract class Pizza
    {
        public string Name { get;protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; }


        public virtual void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Console.WriteLine("Tossing {0}.", Dough);
            Console.WriteLine("Adding {0}.", Sauce);
            Console.WriteLine("Adding toppings...");
            foreach (var topping in Toppings)
            {
                Console.WriteLine("Adding topping {0}.", topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official store box.");
        }
    }
}