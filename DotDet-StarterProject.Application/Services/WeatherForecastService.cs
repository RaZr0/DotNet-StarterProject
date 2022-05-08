using AutoMapper;
using DotDet_StarterProject.Application.Interfaces;
using DotDet_StarterProject.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDet_StarterProject.Application.Services
{
    internal class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepo;
        private readonly IMapper _mapper;

        public WeatherForecastService(
            IWeatherForecastRepository weatherForecastRepo,
            IMapper mapper
            )
        {
            _weatherForecastRepo = weatherForecastRepo;
            _mapper = mapper;
        }
        public IEnumerable<WeatherForecastDto> Get()
        {
            var weatherForcasts = _mapper.Map<List<WeatherForecastDto>>(_weatherForecastRepo.Get());
            weatherForcasts.ForEach(x => x.TemperatureF = 32 + (int)(x.TemperatureC / 0.5556));
            return weatherForcasts;
        }
    }
}
