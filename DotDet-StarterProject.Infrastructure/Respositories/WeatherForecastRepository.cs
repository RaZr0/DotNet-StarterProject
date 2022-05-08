using DotDet_StarterProject.Application.Interfaces;
using DotDet_StarterProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDet_StarterProject.Infrastructure.Respositories
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        public List<WeatherForecastEntity> Get()
        {
            var summeries =  new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };

            return Enumerable.Range(1, 5).Select(index => new WeatherForecastEntity
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summeries[Random.Shared.Next(summeries.Count())]
            }).ToList();
        }
    }
}
