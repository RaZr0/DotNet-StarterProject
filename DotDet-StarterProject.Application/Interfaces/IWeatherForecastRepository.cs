using DotDet_StarterProject.Domain;
using DotDet_StarterProject.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDet_StarterProject.Application.Interfaces
{
    public interface IWeatherForecastRepository
    {
        List<WeatherForecastEntity> Get();
    }
}
