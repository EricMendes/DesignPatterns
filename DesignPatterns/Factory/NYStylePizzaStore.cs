using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new NYStyleCheesePizza();
                default:
                    throw new Exception("Invalid Pizza Type");
            }
        }
    }
}
