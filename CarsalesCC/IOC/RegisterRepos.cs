using CarsalesCC.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsalesCC.IOC
{
    public static class RegisterRepos
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICarsRepository, CarsRepository>();
          
        }
    }
}
