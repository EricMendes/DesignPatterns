﻿using DesignPatterns.Observer;
using DesignPatterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("9 - Sair");
            Console.Write("Selecione uma opção: ");
            var opt = Console.ReadKey().Key;
            Console.WriteLine();
            switch (opt)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    TestStrategy();
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    ShowMenu();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    TestObserver();
                    Console.WriteLine();
                    Console.WriteLine("Pressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    ShowMenu();
                    break;
                case ConsoleKey.D9:
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.ReadKey();
                    ShowMenu();
                    break;
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
    }
}