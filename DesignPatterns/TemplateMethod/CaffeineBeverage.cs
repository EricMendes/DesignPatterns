using System;

namespace DesignPatterns.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }

        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling Water.");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring into cup.");
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
