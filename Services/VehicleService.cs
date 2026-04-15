using System;
using System.Collections.Generic;
using Mid_project.Models;

namespace Mid_project.Services
{
    public class VehicleService
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle()
        {
            var v = new Vehicle();

            Console.Write("Model: ");
            v.Model = Console.ReadLine();

            Console.Write("Number: ");
            v.Number = Console.ReadLine();

            Console.Write("Type: ");
            v.Type = Console.ReadLine();

            Console.Write("Fuel Type: ");
            v.FuelType = Console.ReadLine();

            v.Status = "Available";

            vehicles.Add(v);
            Console.WriteLine("Vehicle Added!");
        }

        public void ViewVehicles()
        {
            foreach (var v in vehicles)
            {
                Console.WriteLine($"{v.Number} - {v.Model} - {v.Status}");
            }
        }
    }
}