using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    public class NYStyleCheesePizza: Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings = new List<string>();
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
