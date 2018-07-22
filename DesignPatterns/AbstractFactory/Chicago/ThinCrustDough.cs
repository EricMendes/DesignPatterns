using System;

namespace DesignPatterns.AbstractFactory.Chicago
{
    public class ThinCrustDough : IDough
    {
        public void Create()
        {
            Console.WriteLine("Creating Thin Crust Dough.");
        }
    }
}
