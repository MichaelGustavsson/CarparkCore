using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarparkApi.Models
{
    [Table("Vehicle",Schema = "Vehicles")]
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string RegNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string VinNumber { get; set; }
        public int ModelYear { get; set; }
        public int Mileage { get; set; }
    }
}
