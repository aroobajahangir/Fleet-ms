using System;

namespace Mid_project.Services
{
    public class TripService
    {
        public void CreateTrip()
        {
            Console.Write("Vehicle Number: ");
            string vehicle = Console.ReadLine();

            Console.Write("Driver Name: ");
            string driver = Console.ReadLine();

            Console.Write("Destination: ");
            string destination = Console.ReadLine();

            Console.WriteLine($"Trip Created: {vehicle} -> {destination} (Driver: {driver})");
        }
    }
}