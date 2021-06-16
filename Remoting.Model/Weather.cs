using System;

namespace Remoting.Model
{
    public class Weather : MarshalByRefObject
    {
        public string GetWeather(string city)
        {
            var client = new OpenWeatherAPI.API("ae27d47b28aeb52b51b119d944db0646");
            var results = client.Query(city);
            return $"The temperature in {city} is {results.Main.Temperature.CelsiusCurrent}C";
        }
    }
}