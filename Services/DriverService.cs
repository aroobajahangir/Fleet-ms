using System;
using System.Collections.Generic;
using Mid_project.Models;

namespace Mid_project.Services
{
    public class DriverService
    {
        private List<Driver> drivers = new List<Driver>();

        public void AddDriver()
        {
            var d = new Driver();

            Console.Write("Name: ");
            d.Name = Console.ReadLine();

            Console.Write("License: ");
            d.LicenseNumber = Console.ReadLine();

            Console.Write("Contact: ");
            d.Contact = Console.ReadLine();

            drivers.Add(d);
            Console.WriteLine("Driver Added!");
        }

        public void ViewDrivers()
        {
            foreach (var d in drivers)
            {
                Console.WriteLine($"{d.Name} - {d.LicenseNumber}");
            }
        }
    }
}