using System;

namespace Midproject.Models
{
    public class Fuel
    {
        public string VehicleNumber { get; set; }
        public double Liters { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}