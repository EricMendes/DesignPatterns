using System;

namespace DesignPatterns.Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new ChicagoStyleCheesePizza();
                default:
                    throw new Exception("Invalid Pizza Type");
            }
        }
    }
}
