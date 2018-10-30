using System.Collections;

namespace ObserverPattern
{
    public class WeatherData : IObservable
    {
        private ArrayList _observers;
        private WeatherDataEntity _weatherDate;

        public WeatherData()
        {
            _observers = new ArrayList();
            _weatherDate = new WeatherDataEntity();
        }

        public void NotifyObserver()
        {
            NotifyObserver(null);
        }

        public void NotifyObserver(object arg)
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this, arg);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (_observers.Contains(o))
            {
                _observers.Remove(o);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _weatherDate.Temperature = temperature;
            _weatherDate.Humidity = humidity;
            _weatherDate.Pressure = pressure;
            MeasurementsChanged();
        }

        public object GetWeatherData()
        {
            return _weatherDate;
        }
    }
}
