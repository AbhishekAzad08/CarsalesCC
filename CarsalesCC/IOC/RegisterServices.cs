using CarsalesCC.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsalesCC.IOC
{
    public static class RegisterServices
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();           
        }
    }
}
