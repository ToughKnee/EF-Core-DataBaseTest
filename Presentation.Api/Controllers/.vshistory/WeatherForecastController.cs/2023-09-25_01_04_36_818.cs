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

    public List<Author> createFakeData()
    {
        var authors = new List<Author>
        {
            new Author
            {
                Name = "AAA", Books = new List<Book>
                {
                    new Book {Title = "AAAAAAAAA", PublicationYear = 1821},
                    new Book {Title = "AAA Batteries", PublicationYear = 219},
                    new Book {Title = "A Dub", PublicationYear = 1}
                }
            },
            new Author
            {
                Name = "CCC", Books = new List<Book>
                {
                    new Book {Title = "C", PublicationYear = 981},
                    new Book {Title = "C++", PublicationYear = 2000},
                    new Book {Title = "C#", PublicationYear = 3200}
                }
            }
        };
        return authors;

    }
}
