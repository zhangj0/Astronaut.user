using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Astronaut.user.api.Controllers
{
    [ApiController]
    [Route("WeatherForecast")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _iMediator;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger
           )
        {
            _logger = logger;
        }

        [HttpGet("GetUserList")]
        public IEnumerable<WeatherForecast> Get()
        {
            var weatherForecast = new List<WeatherForecast>();
            weatherForecast.Add(new WeatherForecast() { Date = DateTime.Now });
            return weatherForecast;
        }
    }
}