using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Rhibhus.Reports.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStringLocalizer<MultilingualData.Resources.WeatherForecastController> _localizer;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStringLocalizer<MultilingualData.Resources.WeatherForecastController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var greeting = _localizer["Greeting"];

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                ResourceMessage = greeting
            })
            .ToArray();
        }
    }
}
