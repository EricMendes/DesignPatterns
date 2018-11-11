using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Chicago;
using DesignPatterns.AbstractFactory.NY;
using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Command.Commands;
using DesignPatterns.Command.Vendors;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Facade.Components;
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
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Adapter");
            Console.WriteLine("9 - Facade");
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
                case ConsoleKey.D7:
                    TestCommand();
                    break;
                case ConsoleKey.D8:
                    TestAdapter();
                    break;
                case ConsoleKey.D9:
                    TestFacade();
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

        /// <summary>
        /// O padrã facade fornece uma interface simplificada para um subsistema.
        /// </summary>
        private static void TestFacade()
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(
                new Amplifier(),
                new Tuner(),
                new DvdPlayer(),
                new CdPlayer(),
                new Projector(),
                new EnvironmentLight(),
                new Screen(),
                new PopcornMachine()
                );
            homeTheater.WatchMovie("Fight Club");
        }

        /// <summary>
        /// O padrão adapter altera uma interface para torná-la compatível com
        /// o que o cliente está esperando.
        /// </summary>
        private static void TestAdapter()
        {
            List<Duck> Ducks = new List<Duck>();
            Ducks.Add(new MallardDuck());
            Ducks.Add(new RedheadDuck());
            Ducks.Add(new RubberDuck());
            Ducks.Add(new DecoyDuck());

            var turkey = new WildTurkey();
            var adapter = new TurkeyAdapter(turkey);

            Ducks.Add(adapter);

            foreach (var duck in Ducks)
            {
                duck.Display();
                duck.Fly();
                duck.Quack();
                Console.WriteLine();
            }
        }

        private static void TestCommand()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            TV livingRoomTV = new TV("Living Room");
            CeilingFan livingRoomFan = new CeilingFan("Living Room");
            Stereo stereo = new Stereo();
            GardenLight gardenLight = new GardenLight();

            remoteControl.onCommands[0] = new LightOnCommand(kitchenLight);
            remoteControl.offCommands[0] = new LightOffCommand(kitchenLight);
            remoteControl.onCommands[1] = new LightOnCommand(livingRoomLight);
            remoteControl.offCommands[1] = new LightOffCommand(livingRoomLight);
            remoteControl.onCommands[2] = new GardenLightOnCommand(gardenLight);
            remoteControl.offCommands[2] = new GardenLightOffCommand(gardenLight);
            remoteControl.onCommands[3] = new CeilingFanOnCommand(livingRoomFan);
            remoteControl.offCommands[3] = new CeilingFanOffCommand(livingRoomFan);
            remoteControl.onCommands[4] = new StereoOnCommand(stereo);
            remoteControl.offCommands[4] = new StereoOffCommand(stereo);
            remoteControl.onCommands[5] = new MacroCommand(new ICommand[] {
                    new TVOnCommand(livingRoomTV),
                    new StereoOnCommand(stereo),
                    new CeilingFanOnCommand(livingRoomFan),
                    new LightOffCommand(livingRoomLight)
                }
            );
            remoteControl.offCommands[5] = new MacroCommand(new ICommand[] {
                    new TVOffCommand(livingRoomTV),
                    new StereoOffCommand(stereo),
                    new CeilingFanOffCommand(livingRoomFan),
                    new LightOnCommand(livingRoomLight)
                }
            );

            remoteControl.ExecuteOnCommand(2);
            Console.WriteLine("-----------------------");
            remoteControl.ExecuteOffCommand(2);
            Console.WriteLine("-----------------------");
            remoteControl.ExecuteOnCommand(0);
            Console.WriteLine("-----------------------");
            remoteControl.ExecuteOnCommand(6);
            Console.WriteLine("-----------------------");
            remoteControl.ExecuteOffCommand(0);
            Console.WriteLine("-----------------------");
            remoteControl.ExecuteOnCommand(5);
            Console.WriteLine("-----------------------");
            remoteControl.UndoCommand();
            Console.WriteLine("-----------------------");
            remoteControl.UndoCommand();
            Console.WriteLine("-----------------------");

            remoteControl.onCommands[2] = new GardenLightSummerTimeCommand(gardenLight);
            remoteControl.offCommands[2] = new GardenLightStandardTimeCommand(gardenLight);

            remoteControl.ExecuteOnCommand(2);
            Console.WriteLine("-----------------------");
            remoteControl.ExecuteOffCommand(2);
            Console.WriteLine("-----------------------");
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
            List<PizzaIngredientFactory> listFactories = new List<PizzaIngredientFactory>();
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
