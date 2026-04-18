using System;

namespace Mid_project.Services
{
    public class MaintenanceService
    {
        private object date;

        public void ScheduleMaintenance()
        {
            Console.Write("Vehicle Number: ");
            string vehicle = Console.ReadLine();

            Console.Write("Service Date: ");
            string input = Console.ReadLine() ?? "";

            Console.WriteLine($"Maintenance Scheduled for {vehicle} on {date}");
        }
    }
}