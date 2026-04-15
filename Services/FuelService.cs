using System;

namespace Mid_project.Services
{
    public class FuelService
    {
        public void AddFuelRecord()
        {
            Console.Write("Vehicle Number: ");
            string vehicle = Console.ReadLine();

            Console.Write("Liters: ");
            double liters = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Fuel Added: {liters}L to {vehicle}");
        }
    }
}