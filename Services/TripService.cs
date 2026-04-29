using MongoDB.Driver;
using System;
using System.Linq;
using Midproject.Models;
using Midproject.Data;

namespace Midproject.Services
{
    public class TripService
    {
        private IMongoCollection<Trip> trips;

        public TripService()
        {
            var db = new MongoDbContext().GetDatabase();
            trips = db.GetCollection<Trip>("Trips");
        }

        public void CreateTrip()
        {
            Trip t = new Trip();

            Console.Write("Vehicle Number: ");
            t.VehicleNumber = Console.ReadLine();

            Console.Write("Driver Name: ");
            t.DriverName = Console.ReadLine();

            Console.Write("Destination: ");
            t.Destination = Console.ReadLine();

            t.Status = "Started";

            trips.InsertOne(t);

            Console.WriteLine("✅ Trip Saved!");
        }

        public void ShowTrips()
        {
            var list = trips.Find(_ => true).ToList();

            foreach (var t in list)
            {
                Console.WriteLine($"{t.VehicleNumber} | {t.DriverName} | {t.Destination} | {t.Status}");
            }
        }

        public void UpdateTripStatus()
        {
            Console.Write("Vehicle Number: ");
            string number = Console.ReadLine();

            var filter = Builders<Trip>.Filter.Eq(x => x.VehicleNumber, number);

            var trip = trips.Find(filter).FirstOrDefault();

            if (trip != null)
            {
                Console.Write("New Status: ");
                string status = Console.ReadLine();

                var update = Builders<Trip>.Update.Set(x => x.Status, status);
                trips.UpdateOne(filter, update);

                Console.WriteLine("✅ Updated!");
            }
            else
            {
                Console.WriteLine("❌ Not found!");
            }
        }
    }
}