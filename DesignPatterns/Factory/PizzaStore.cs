namespace DesignPatterns.Factory
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(PizzaType type);

        public Pizza OrderPizza(PizzaType type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
