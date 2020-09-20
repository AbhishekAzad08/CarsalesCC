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
        [MaxLength(25)]
        public string Make { get; set; }
        [Required]
        [MaxLength(25)]
        public string Model { get; set; }
        [Required]
        public string VehicleType { get; set; }
        [Required]
        [MaxLength(25)]
        public string Engine { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numbers")]
        public int Doors { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Only numbers")]
        public int Wheels { get; set; }
        [Required]
        [MaxLength(25)]
        public string BodyType { get; set; }
    }
}
