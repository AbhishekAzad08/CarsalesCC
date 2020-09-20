using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Services
{
    public class CarGetResponseDto
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public string VehicleType { get; set; }

        public string Engine { get; set; }

        public string BodyType { get; set; }

        public int Wheels { get; set; }
    }
}
