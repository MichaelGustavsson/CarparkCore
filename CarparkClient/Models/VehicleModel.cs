using System;
using System.Collections.Generic;
using System.Text;

namespace CarparkClient.Models
{
    public class VehicleModel
    {
        public int VehicleId { get; set; }
        public string RegNo { get; set; }
        public string VinNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public int Mileage { get; set; }
    }
}
