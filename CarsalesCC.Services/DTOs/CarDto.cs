using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Services
{
    public class CarCreateRequestDto:BaseVehicleCreateDto
    {
        public int doors { get; set; }

        public string engine { get; set; }

        public string bodytype { get; set; }

        public int wheels { get; set; }
    }
}
