using IntroBlazor.Data.Model;

namespace IntroBlazor.Data.Services
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}