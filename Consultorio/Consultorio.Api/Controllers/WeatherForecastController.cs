using Consultorio.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Api.Controllers
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
        private readonly ClienteService _clienteService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ClienteService clienteService)
        {
            _logger = logger;
            _clienteService = clienteService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });

            _logger.LogInformation("Consulta de clima-Data: {@data}", result.ToArray());

            return result;
        }
    }
}