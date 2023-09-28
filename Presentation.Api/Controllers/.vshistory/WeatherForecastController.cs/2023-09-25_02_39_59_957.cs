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
    public IEnumerable<string> Get()
    {
        var db = Functions.createDatabase();
        var authors = Functions.createFakeData();
        var returnValue = new List<string>();
        authors.ForEach(a => returnValue.Add(a.ToString() + " works " + Functions.BooksToString(a.Books)));
        db.Authors.AddRange(authors);
        db.Dispose();
        return returnValue.AsEnumerable();
    }

}
