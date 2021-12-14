using Microsoft.AspNetCore.Mvc;

namespace petshop.Controllers;
// identifies to DotNet that this is an api controller
[ApiController]
// Translation: super
// The [controller] adds the name of the class before the word 'controller'
// ie: WeatherForecast
[Route("api/[controller]")]
// ':' translation: extends
public class WeatherForecastController : ControllerBase
{
    // THIS IS JUNK DEMO CODE BAD DON'T DO
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecastController()
    {
    }

    // HTTP(REQUEST)
    [HttpGet]
    // IEnumerable is any itterable type (array, list, queue)
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
}
