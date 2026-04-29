using MongoDB.Driver;
using System;
using System.Linq;
using Midproject.Models;
using Midproject.Data;

namespace Midproject.Services
{
    public class FuelService
    {
        private IMongoCollection<Fuel> fuels;

        public FuelService()
        {
            var db = new MongoDbContext().GetDatabase();
            fuels = db.GetCollection<Fuel>("FuelRecords");
        }

        public void AddFuelRecord()
        {
            Fuel f = new Fuel();

            Console.Write("Vehicle Number: ");
            f.VehicleNumber = Console.ReadLine();

            Console.Write("Liters: ");
            f.Liters = Convert.ToDouble(Console.ReadLine());

            f.Date = DateTime.Now;

            fuels.InsertOne(f);

            Console.WriteLine("✅ Fuel record saved!");
        }

        public void ViewFuelRecords()
        {
            var list = fuels.Find(_ => true).ToList();

            foreach (var f in list)
            {
                Console.WriteLine($"{f.VehicleNumber} | {f.Liters} | {f.Date}");
            }
        }
    }
}