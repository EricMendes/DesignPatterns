using System.Collections;

namespace DesignPatterns.Iterator
{
    public class PancakeHouseMenu: IEnumerable
    {
        ArrayList menuItens;

        public PancakeHouseMenu()
        {
            menuItens = new ArrayList();
            menuItens.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
            menuItens.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            menuItens.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            menuItens.Add(new MenuItem("Waffles", "Waffles of your choice with blueberries or strawberries", true, 3.59));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return menuItens.GetEnumerator();
        }
    }
}
