namespace DesignPatterns.AbstractFactory
{
    public abstract class IPizzaIngredientFactory
    {
        protected IDough Dough;
        protected ISauce Sauce;
        protected IClams Clams;
        protected ICheese Cheese;

        protected IPizzaIngredientFactory(IDough dough, ISauce sauce, IClams clams, ICheese cheese)
        {
            Dough = dough;
            Sauce = sauce;
            Clams = clams;
            Cheese = cheese;
        }

        public void CreateDough()
        {
            Dough.Create();
        }
        public void CreateSauce()
        {
            Sauce.Create();
        }
        public void CreateCheese()
        {
            Cheese.Create();
        }
        public void CreateClams()
        {
            Clams.Create();
        }
    }
}
