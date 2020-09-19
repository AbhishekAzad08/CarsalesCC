using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarsalesCC.Data
{
    public class CarEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string VehicleType { get; set; }
        [Required]
        public string Engine { get; set; }
        [Required]
        public string Doors { get; set; }
        [Required]
        public string Wheels { get; set; }
        [Required]
        public string BodyType { get; set; }
    }
}
