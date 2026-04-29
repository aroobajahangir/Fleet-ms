using System;
using Midproject.Services;

namespace Midproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Fleet Management System ===");

            UserService userService = new UserService();

            Console.Write("Username: ");
            string u = Console.ReadLine();

            Console.Write("Password: ");
            string p = Console.ReadLine();

            if (userService.Login(u, p))
            {
                Console.WriteLine("✅ Login Successful");

                DriverService driver = new DriverService();
                VehicleService vehicle = new VehicleService();
                TripService trip = new TripService();
                FuelService fuel = new FuelService();
                MaintenanceService maintenance = new MaintenanceService();

                while (true)
                {
                    Console.WriteLine("\n--- MENU ---");
                    Console.WriteLine("1. Add Driver");
                    Console.WriteLine("2. View Drivers");
                    Console.WriteLine("3. Add Vehicle");
                    Console.WriteLine("4. View Vehicles");
                    Console.WriteLine("5. Create Trip");
                    Console.WriteLine("6. View Trips");
                    Console.WriteLine("7. Add Fuel");
                    Console.WriteLine("8. Add Maintenance");
                    Console.WriteLine("0. Exit");

                    Console.Write("Choose: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1": driver.AddDriver(); break;
                        case "2": driver.ViewDrivers(); break;
                        case "3": vehicle.AddVehicle(); break;
                        case "4": vehicle.ViewVehicles(); break;
                        case "5": trip.CreateTrip(); break;
                        case "6": trip.ShowTrips(); break;
                        case "7": fuel.AddFuelRecord(); break;
                        case "8": maintenance.ScheduleMaintenance(); break;
                        case "0": return;
                        default: Console.WriteLine("Invalid choice"); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("❌ Invalid Login");
            }

            Console.ReadKey();
        }
    }
}