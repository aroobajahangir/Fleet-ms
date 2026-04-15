using System;

namespace Mid_project.Services
{
    public class MaintenanceService
    {
        public void ScheduleMaintenance()
        {
            Console.Write("Vehicle Number: ");
            string vehicle = Console.ReadLine();

            Console.Write("Service Date: ");
            string date = Console.ReadLine();

            Console.WriteLine($"Maintenance Scheduled for {vehicle} on {date}");
        }
    }
}