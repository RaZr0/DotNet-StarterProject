using DotDet_StarterProject.Application.Interfaces;
using DotDet_StarterProject.Application.Services;
using DotDet_StarterProject.Infrastructure.Respositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDet_StarterProject.Infrastructure
{
    public static class DependencyRegister
    {
        public static void RegisterInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();
        }
    }
}
