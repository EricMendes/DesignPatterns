using System;

namespace DesignPatterns.Composite
{
    public class MenuItem : IMenuComponent
    {
        public string Description { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public bool IsVegetarian { get; private set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public ComponentType GetComponentType()
        {
            return ComponentType.MenuItem;
        }

        public void Print()
        {
            Console.WriteLine(Name + " - " + Description + ", " + Price);
        }
    }
}
