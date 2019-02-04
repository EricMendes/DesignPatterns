using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Vegetarian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }
    }
}
