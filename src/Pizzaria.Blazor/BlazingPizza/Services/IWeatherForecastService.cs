namespace BlazingPizza.Services;

using System;
using System.Threading.Tasks;
using BlazingPizza.Model.Samples;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}
