using Microsoft.AspNetCore.Mvc;

namespace WebAPIEX01.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "ObterDados")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }



    [HttpPost(Name = "CriarDadosNovos")]
    public IEnumerable<WeatherForecast> Post(List<WeatherForecast> valores)
    {
       return valores;
    }


    [HttpPut(Name = "AutualizarDados")]
    public IEnumerable<WeatherForecast> Put(List<WeatherForecast> valores)
    {
       return valores;
    }

    [HttpPatch(Name = "AutualizarDadosParcialmente")]
    public IEnumerable<WeatherForecast> Patch(List<WeatherForecast> valores)
    {
       return valores;
    }

    [HttpDelete(Name = "ApagarDados")]
    public IEnumerable<WeatherForecast> Delete(List<WeatherForecast> valores)
    {
       return valores;
    }

}
