
using System;

namespace DesignPatterns.Observer
{
    public class ForecastDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine("Forecast display notified. Temperature:{0}, Humidity:{1}, Pressure:{2}", temperature, humidity, pressure);
        }
    }
}
