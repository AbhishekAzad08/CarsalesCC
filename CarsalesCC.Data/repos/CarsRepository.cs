using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Data
{
    public class CarsRepository:ICarsRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger _logger;
        public CarsRepository( AppDbContext appContext, ILoggerFactory loggerFactory)
        {
            _appDbContext = appContext;
            _logger = loggerFactory.CreateLogger("CarRepository");
        }

        public CarsRepository()
        {

        }
        public string Create(CarEntity car)
        {
            _appDbContext.Cars.Add(car);

            _appDbContext.SaveChanges();
            _logger.LogInformation($"New car Added: {car.Id}");

            return car.Id.ToString();///This needs to change. Ideal way to do is to create a proper response and return. 
        }
    }
}
