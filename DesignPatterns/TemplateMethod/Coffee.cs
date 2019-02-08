using System;

namespace DesignPatterns.TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk.");
        }

        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee through filter.");
        }

        protected override bool CustomerWantsCondiments()
        {
            string answer = getUserInput();
            if (answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            return false;
        }

        private string getUserInput()
        {
            Console.WriteLine("Would you lite milk and sugar with your coffee? (y/n): ");
            return Console.ReadLine();
        }
    }
}
