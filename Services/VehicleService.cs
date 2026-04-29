using MongoDB.Driver;
using System.Linq;
using Midproject.Models;
using Midproject.Data;

namespace Midproject.Services
{
    public class VehicleService
    {
        private IMongoCollection<Vehicle> vehicles;

        public VehicleService()
        {
            var db = new MongoDbContext().GetDatabase();
            vehicles = db.GetCollection<Vehicle>("Vehicles");
        }

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

            vehicles.InsertOne(v);

            Console.WriteLine("✅ Vehicle Added!");
        }

        public void ViewVehicles()
        {
            var list = vehicles.Find(_ => true).ToList();

            foreach (var v in list)
            {
                Console.WriteLine($"{v.Number} - {v.Model} - {v.Type} - {v.FuelType} - {v.Status}");
            }
        }
    }
}