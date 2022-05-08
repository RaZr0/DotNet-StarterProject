using DotDet_StarterProject.Application.Interfaces;
using DotDet_StarterProject.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDet_StarterProject.Application
{
    public static class DependencyRegister
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
