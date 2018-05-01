using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Dough";
            Sauce = "Plum Tomato Sauce";
            Toppings = new List<string>();
            Toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }
    }
}
