using System;

namespace DesignPatterns.Observer
{
    public class GeneralDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine("General display notified. Temperature:{0}, Humidity:{1}, Pressure:{2}", temperature, humidity, pressure);
        }
    }
}
