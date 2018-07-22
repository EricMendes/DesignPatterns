using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Chicago;
using DesignPatterns.AbstractFactory.NY;
using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.Observer;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Strategy");
            Console.WriteLine("2 - Observer");
            Console.WriteLine("3 - Decorator");
            Console.WriteLine("4 - Factory");
            Console.WriteLine("5 - Abstract Factory");
            Console.WriteLine("6 - Singleton");
            Console.WriteLine("0 - Sair");
            Console.Write("Selecione uma opção: ");
            var opt = Console.ReadKey().Key;
            Console.Clear();
            switch (opt)
            {
                case ConsoleKey.D1:
                    TestStrategy();
                    break;
                case ConsoleKey.D2:
                    TestObserver();
                    break;
                case ConsoleKey.D3:
                    TestDecorator();
                    break;
                case ConsoleKey.D4:
                    TestFactory();
                    break;
                case ConsoleKey.D5:
                    TestAbstractFactory();
                    break;
                case ConsoleKey.D6:
                    TestSingleton();
                    break;
                case ConsoleKey.D0:
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            if (opt != ConsoleKey.D0)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar.");
                Console.ReadKey();
                ShowMenu();
            }
        }

        private static void TestSingleton()
        {
            ChocolateBoiler boilerReference1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boilerReference2 = ChocolateBoiler.GetInstance();

            boilerReference1.Fill();
            boilerReference2.Fill();

            boilerReference1.Drain();

            boilerReference2.Boil();

            boilerReference1.Drain();

        }

        private static void TestAbstractFactory()
        {
            List<IPizzaIngredientFactory> listFactories = new List<IPizzaIngredientFactory>();
            listFactories.Add(new NYPizzaIngredientFactory());
            listFactories.Add(new ChicagoPizzaIngredientFactory());

            foreach (var factory in listFactories)
            {
                Console.WriteLine(factory.ToString());
                factory.CreateDough();
                factory.CreateClams();
                factory.CreateSauce();
                factory.CreateCheese();
                Console.WriteLine();
            }

        }

        public static void TestStrategy()
        {
            List<Duck> Ducks = new List<Duck>();
            Ducks.Add(new MallardDuck());
            Ducks.Add(new RedheadDuck());
            Ducks.Add(new RubberDuck());
            Ducks.Add(new DecoyDuck());

            foreach (var duck in Ducks)
            {
                duck.Display();
                duck.Fly();
                duck.Quack();
                Console.WriteLine();
            }
        }

        public static void TestObserver()
        {
            WeatherData weatherData = new WeatherData();
            ForecastDisplay forecastDisplay = new ForecastDisplay();
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay();
            GeneralDisplay generalDisplay = new GeneralDisplay();

            Console.WriteLine("Adding forecast display and setting temperature.");
            weatherData.AddObserver(forecastDisplay);
            weatherData.Temperature = 18.1f;
            Console.WriteLine();

            Console.WriteLine("Adding statistics and general display and setting humidity.");
            weatherData.AddObserver(statisticsDisplay);
            weatherData.AddObserver(generalDisplay);
            weatherData.Humidity = 8.3f;
            Console.WriteLine();

            Console.WriteLine("Removing statistics display and setting pressure.");
            weatherData.DeleteObserver(statisticsDisplay);
            weatherData.Pressure = 3.6f;
        }

        private static void TestDecorator()
        {
            Beverage beverage = new Espresso();
            Console.WriteLine("{0}: {1}", beverage.Description, beverage.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine("{0}: {1}", beverage2.Description, beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine("{0}: {1}", beverage3.Description, beverage3.Cost());
        }

        private static void TestFactory()
        {
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            nyStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine();

            chicagoStore.OrderPizza(PizzaType.Cheese);
        }
    }
}
