using DesignPatterns.Decorator;
using DesignPatterns.Factory;
using DesignPatterns.Observer;
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
            Console.WriteLine("9 - Sair");
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
                case ConsoleKey.D9:
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            if (opt != ConsoleKey.D9)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar.");
                Console.ReadKey();
                ShowMenu();
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

            Console.WriteLine("Adding statistics and general display and setting temperature.");
            weatherData.AddObserver(statisticsDisplay);
            weatherData.AddObserver(generalDisplay);
            weatherData.Humidity = 8.3f;
            Console.WriteLine();

            Console.WriteLine("Removing statistics display and setting temperature.");
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
            chicagoStore.OrderPizza(PizzaType.Cheese);
        }
    }
}
