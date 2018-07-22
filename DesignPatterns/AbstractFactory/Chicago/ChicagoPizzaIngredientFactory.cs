using System;

namespace DesignPatterns.AbstractFactory.Chicago
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ChicagoPizzaIngredientFactory() 
            : base(new ThinCrustDough(), new MarinaraSauce(), new FreshClams(), new ReggianoCheese())
        {
        }
    }
}
