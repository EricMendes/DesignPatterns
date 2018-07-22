using System;

namespace DesignPatterns.AbstractFactory.NY
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public NYPizzaIngredientFactory()
            : base(new ThickCrustDough(), new PlumTomatoSauce(), new FrozenClams(), new MozzarellaCheese())
        {            
        }
    }
}
