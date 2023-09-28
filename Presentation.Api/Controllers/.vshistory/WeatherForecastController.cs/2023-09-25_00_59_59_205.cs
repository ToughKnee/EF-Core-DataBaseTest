using CleanArchitectureWorkshop.Domain.Core;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureWorkshop.Presentation.Api.Controllers;

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

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<int> Get()
    {
        var returnValue = new List<int> { 1, 2, 3, 4, 5 };
        return returnValue.AsEnumerable();
    }

    public List<Book> presetData()
    {

    }
}
