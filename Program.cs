using System;
using Mid_project.Services;

namespace Mid_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleService vehicleService = new VehicleService();
            DriverService driverService = new DriverService();
            TripService tripService = new TripService();
            FuelService fuelService = new FuelService();
            MaintenanceService maintenanceService = new MaintenanceService();

            while (true)
            {
                Console.WriteLine("\n===== FLEET MANAGEMENT SYSTEM =====");
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. View Vehicles");
                Console.WriteLine("3. Add Driver");
                Console.WriteLine("4. View Drivers");
                Console.WriteLine("5. Create Trip");
                Console.WriteLine("6. Add Fuel Record");
                Console.WriteLine("7. Schedule Maintenance");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        vehicleService.AddVehicle();
                        break;

                    case 2:
                        vehicleService.ViewVehicles();
                        break;

                    case 3:
                        driverService.AddDriver();
                        break;

                    case 4:
                        driverService.ViewDrivers();
                        break;

                    case 5:
                        tripService.CreateTrip();
                        break;

                    case 6:
                        fuelService.AddFuelRecord();
                        break;

                    case 7:
                        maintenanceService.ScheduleMaintenance();
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}