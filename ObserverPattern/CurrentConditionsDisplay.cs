using System;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private IObservable _observable;
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(IObservable weatherData)
        {
            _observable = weatherData;
            _observable.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
        }

        public void Update(IObservable obs, object arg)
        {
            SetTemperature(obs, arg);
            SetHumidity(obs, arg);
            Display();
        }

        private void SetTemperature(IObservable obs, object arg)
        {
            if (arg != null)
            {
                _temperature = ((WeatherDataEntity)arg).Temperature;
            }
            else
            {
                _temperature = ((WeatherDataEntity)((WeatherData)obs).GetWeatherData()).Temperature;
            }
        }

        private void SetHumidity(IObservable obs, object arg)
        {
            if (arg != null)
            {
                _humidity = ((WeatherDataEntity)arg).Humidity;
            }
            else
            {
                _humidity = ((WeatherDataEntity)((WeatherData)obs).GetWeatherData()).Humidity;
            }
        }
    }
}
