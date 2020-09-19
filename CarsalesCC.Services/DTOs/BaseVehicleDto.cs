using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Services
{
    public abstract class BaseVehicleCreateDto
    {
        public string make { get; set; }

        public string model { get; set; }

        public string vehicletype { get; set; }
    }
}
