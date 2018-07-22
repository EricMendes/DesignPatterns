using System;

namespace DesignPatterns.AbstractFactory.NY
{
    public class ThickCrustDough : IDough
    {
        public void Create()
        {
            Console.WriteLine("Creating Thick Crust Dough.");
        }
    }
}
