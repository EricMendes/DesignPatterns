using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class WeatherData: IObservable
    {
        private float temperature;

        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; NotifyObservers(); }
        }

        private float humidity;

        public float Humidity
        {
            get { return humidity; }
            set { humidity = value; NotifyObservers(); }
        }

        private float pressure;

        public float Pressure
        {
            get { return pressure; }
            set { pressure = value; NotifyObservers(); }
        }

        private List<IObserver> observers { get; set; }

        public void AddObserver(IObserver observer)
        {
            OnDataChange += observer.Update;
        }

        protected delegate void UpdateObserverEventHandler(float temperature, float humidity, float pressure);

        protected event UpdateObserverEventHandler OnDataChange;

        public void DeleteObserver(IObserver observer)
        {
            OnDataChange -= observer.Update;
        }

        public void NotifyObservers()
        {
            OnDataChange?.Invoke(Temperature, Humidity, Pressure);
        }
    }
}
