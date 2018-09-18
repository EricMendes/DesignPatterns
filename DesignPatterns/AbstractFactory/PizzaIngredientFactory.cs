namespace DesignPatterns.AbstractFactory
{
    public abstract class PizzaIngredientFactory
    {
        protected IDough Dough;
        protected ISauce Sauce;
        protected IClams Clams;
        protected ICheese Cheese;

        protected PizzaIngredientFactory(IDough dough, ISauce sauce, IClams clams, ICheese cheese)
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
