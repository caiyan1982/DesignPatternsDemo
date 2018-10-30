﻿using System;

namespace ObserverPattern
{
    class WeatherStation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);

            Console.Read();
        }
    }
}
