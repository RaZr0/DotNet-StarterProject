using DotDet_StarterProject.Application.Interfaces;
using DotDet_StarterProject.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DotDet_StarterProject.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IWeatherForecastService weatherForecastService
            )
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public ActionResult<WeatherForecastDto> Get()
        {
            return Ok(_weatherForecastService.Get());
        }
    }
}