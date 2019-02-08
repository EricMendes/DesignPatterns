namespace DesignPatterns.Composite
{
    public class MenuIterator
    {
        private readonly IMenuComponent[] _menuComponent;
        public MenuIterator(IMenuComponent[] menuComponent)
        {
            _menuComponent = menuComponent;
        }

        public void PrintMenu()
        {
            foreach (var item in _menuComponent)
            {
                PrintMenu(item);
            }
        }

        private void PrintMenu(IMenuComponent component)
        {
            switch (component.GetComponentType())
            {
                case ComponentType.Menu:
                    var menu = (Menu)component;
                    menu.Print();
                    foreach (var item in menu.Items)
                    {
                        PrintMenu(item);
                    }
                    break;
                case ComponentType.MenuItem:
                    component.Print();
                    break;
                default:
                    break;
            }
        }
    }
}
