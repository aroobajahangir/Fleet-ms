using MongoDB.Driver;
using System;
using System.Linq;
using Midproject.Models;
using Midproject.Data;

namespace Midproject.Services
{
    public class DriverService
    {
        private IMongoCollection<Driver> drivers;

        public DriverService()
        {
            var db = new MongoDbContext().GetDatabase();
            drivers = db.GetCollection<Driver>("Drivers");
        }

        public void AddDriver()
        {
            var d = new Driver();

            Console.Write("Name: ");
            d.Name = Console.ReadLine();

            Console.Write("License: ");
            d.LicenseNumber = Console.ReadLine();

            Console.Write("Contact: ");
            d.Contact = Console.ReadLine();

            drivers.InsertOne(d);

            Console.WriteLine("✅ Driver Added to MongoDB!");
        }

        public void ViewDrivers()
        {
            var list = drivers.Find(_ => true).ToList();

            foreach (var d in list)
            {
                Console.WriteLine($"{d.Name} - {d.LicenseNumber} - {d.Contact}");
            }
        }
    }
}