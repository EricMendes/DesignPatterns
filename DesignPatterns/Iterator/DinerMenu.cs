using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Iterator
{
    public class DinerMenu: IEnumerable<MenuItem>
    {
        private readonly int MAX_ITENS = 4;
        private MenuItem[] menuItens;

        public DinerMenu()
        {
            menuItens = new MenuItem[MAX_ITENS];
            menuItens[0] = new MenuItem("Vegetarian BLT", "(Fakin) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            menuItens[1] = new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            menuItens[2] = new MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            menuItens[3] = new MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
        }


        public IEnumerator<MenuItem> GetEnumerator()
        {
            return new DinerMenuIterator(menuItens);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new DinerMenuIterator(menuItens);
        }
    }
}
