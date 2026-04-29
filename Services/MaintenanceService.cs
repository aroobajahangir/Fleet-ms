using MongoDB.Driver;
using System;
using System.Linq;
using Midproject.Models;
using Midproject.Data;

namespace Midproject.Services
{
    public class MaintenanceService
    {
        private IMongoCollection<Maintenance> maintenance;

        public MaintenanceService()
        {
            var db = new MongoDbContext().GetDatabase();
            maintenance = db.GetCollection<Maintenance>("Maintenance");
        }

        public void ScheduleMaintenance()
        {
            Maintenance m = new Maintenance();

            Console.Write("Vehicle Number: ");
            m.VehicleNumber = Console.ReadLine();

            Console.Write("Description: ");
            m.Description = Console.ReadLine();

            Console.Write("Cost: ");
            m.Cost = Convert.ToDouble(Console.ReadLine());

            m.Date = DateTime.Now;

            maintenance.InsertOne(m);

            Console.WriteLine("✅ Maintenance saved!");
        }

        public void ShowMaintenanceHistory()
        {
            var list = maintenance.Find(_ => true).ToList();

            foreach (var m in list)
            {
                Console.WriteLine($"{m.VehicleNumber} | {m.Description} | {m.Cost} | {m.Date}");
            }
        }
    }
}