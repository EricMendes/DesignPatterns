using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Chicago;
using DesignPatterns.AbstractFactory.NY;
using DesignPatterns.Adapter;
using DesignPatterns.Command;
using DesignPatterns.Command.Commands;
using DesignPatterns.Command.Vendors;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Facade.Components;
using DesignPatterns.Factory;
using DesignPatterns.Iterator;
using DesignPatterns.Observer;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using DesignPatterns.TemplateMethod;
using System;
using System.Collections;
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
            Console.WriteLine("10 - Template Method");
            Console.WriteLine("11 - Iterator");
            Console.WriteLine("12 - Composite");
            Console.WriteLine("0 - Sair");
            Console.Write("Selecione uma opção: ");
            var opt = Console.ReadLine();
            Console.Clear();
            switch (opt)
            {
                case "1":
                    TestStrategy();
                    break;
                case "2":
                    TestObserver();
                    break;
                case "3":
                    TestDecorator();
                    break;
                case "4":
                    TestFactory();
                    break;
                case "5":
                    TestAbstractFactory();
                    break;
                case "6":
                    TestSingleton();
                    break;
                case "7":
                    TestCommand();
                    break;
                case "8":
                    TestAdapter();
                    break;
                case "9":
                    TestFacade();
                    break;
                case "10":
                    TestTemplateMethod();
                    break;
                case "11":
                    TestIterator();
                    break;
                case "12":
                    TestComposite();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            if (opt != "0")
            {
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar.");
                Console.ReadKey();
                ShowMenu();
            }
        }

        private static void TestComposite()
        {
            Menu dinerMenu = new Menu("Diner", "Lunch");
            dinerMenu.AddItem(new Composite.MenuItem("Vegetarian BLT", "(Fakin) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            dinerMenu.AddItem(new Composite.MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            dinerMenu.AddItem(new Composite.MenuItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29));
            dinerMenu.AddItem(new Composite.MenuItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05));

            Menu pancakeMenu = new Menu("Pancake", "Breakfast");
            pancakeMenu.AddItem(new Composite.MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99));
            pancakeMenu.AddItem(new Composite.MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99));
            pancakeMenu.AddItem(new Composite.MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49));
            pancakeMenu.AddItem(new Composite.MenuItem("Waffles", "Waffles of your choice with blueberries or strawberries", true, 3.59));

            Menu dessertMenu = new Menu("Dessert", "Dessert, of course");
            dessertMenu.AddItem(new Composite.MenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun", true, 3.99));
            dessertMenu.AddItem(new Composite.MenuItem("Cheesecake", "Creamy New York Cheesecake, with chocolate graham crust", false, 1.89));
            dinerMenu.AddItem(dessertMenu);

            var items = new IMenuComponent[2];
            items[0] = dinerMenu;
            items[1] = pancakeMenu;

            var iterator = new MenuIterator(items);
            iterator.PrintMenu();
        }

        /// <summary>
        /// O padrão Iterator fornece uma maneira de acessar sequenacialmente os elementos de um objeto agregado sem expor sua representação subjacente.
        /// </summary>
        private static void TestIterator()
        {
            PancakeHouseMenu pancakeMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            foreach (var item in pancakeMenu)
            {
                var menuItem = (Iterator.MenuItem)item;
                Console.WriteLine(string.Format("{0},{1} -- {2}", menuItem.Name, menuItem.Price, menuItem.Description));
            }

            Console.WriteLine("---------------------------------------");
            foreach (var item in dinerMenu)
            {
                Console.WriteLine(string.Format("{0},{1} -- {2}", item.Name, item.Price, item.Description));
            }
        }

        /// <summary>
        /// O padrão Template Method define o esqueleto de um algoritmo dentro de um método, transferindo alguns de seus passos para as subclasses. 
        /// O Template Method permite que as subclasses redefinam certos passos de um algoritmo sem alterar a estrutura do próprio algoritmo.
        /// </summary>
        private static void TestTemplateMethod()
        {
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
            Console.WriteLine("----------------------");
            Tea tea = new Tea();
            tea.PrepareRecipe();
        }

        /// <summary>
        /// O padrão facade fornece uma interface simplificada para um conjunto de interfaces em um subsistema. Ele define uma interface de nível mais 
        /// alto que facilita a utilização do subsistema.
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
        /// O padrão Adapter converte a interface de uma classe para outra interface que o cliente espera encontrar. Ele permite que classes com interfaces
        /// incompatíveis trabalhem juntas.
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


        /// <summary>
        /// O padrão Command encapsula uma solicitação como um objeto, o que lhe permite parametrizar outros objetos com diferentes solicitações,
        /// enfileirar ou registrar solicitações e implementar recursos de cancelamento de operações.
        /// </summary>
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

        /// <summary>
        /// O padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela.
        /// </summary>
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

        /// <summary>
        /// O padrão Abstract Factory fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.
        /// </summary>
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


        /// <summary>
        /// O padrão Strategy define uma família de algoritmos , encapsula cada um deles e os torna intercambiáveis. Ele deixa o algoritmo variar 
        /// independente dos clientes que o utilizam.
        /// </summary>
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

        /// <summary>
        /// O padrão Observer define a dependência um-para-muitos entre objetos para que quando um objeto mude de estado todos os seus dependentes
        /// sejam avisados e atualizados automaticamente.
        /// </summary>
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

        /// <summary>
        /// O padrão Decorator anexa responsabilidades adicionais a um objeto dinamicamente. Os decoradores fornecem uma alternativa mais flexível de
        /// subclasses para estender a funcionalidade.
        /// </summary>
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

        /// <summary>
        /// O padrão Factory Method define uma interface para criar um objeto, mas permite às classes decidir qual classe instanciar.
        /// Ele permite a uma classe deferir a instanciação para subclasses.
        /// </summary>
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
