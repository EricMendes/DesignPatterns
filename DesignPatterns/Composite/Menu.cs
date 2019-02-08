using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Menu : IMenuComponent
    {
        public List<IMenuComponent> Items { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<IMenuComponent>();
        }

        public ComponentType GetComponentType()
        {
            return ComponentType.Menu;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine(Name + "," + Description);
            Console.WriteLine("------------------------");

        }

        public void AddItem(IMenuComponent item)
        {
            Items.Add(item);
        }

        public void RemoveItem(IMenuComponent item)
        {
            Items.Remove(item);
        }
    }
}
