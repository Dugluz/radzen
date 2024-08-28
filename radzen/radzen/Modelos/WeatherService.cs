namespace radzen.Modelos
{
    public class WeatherService
    {
        public Task<List<WeatherInfo>> GetWeatherDataAsync()
        {
            // Datos simulados para 5 países
            var data = new List<WeatherInfo>
        {
            new WeatherInfo { Country = "USA", City = "New York", Temperature = 25.5, Humidity = 65, WindSpeed = 12.3 },
            new WeatherInfo { Country = "Canada", City = "Toronto", Temperature = 20.1, Humidity = 70, WindSpeed = 9.8 },
            new WeatherInfo { Country = "UK", City = "London", Temperature = 18.2, Humidity = 75, WindSpeed = 15.4 },
            new WeatherInfo { Country = "Germany", City = "Berlin", Temperature = 22.8, Humidity = 60, WindSpeed = 10.6 },
            new WeatherInfo { Country = "Australia", City = "Sydney", Temperature = 28.9, Humidity = 55, WindSpeed = 11.2 }
        };

            return Task.FromResult(data);
        }
    }
}
