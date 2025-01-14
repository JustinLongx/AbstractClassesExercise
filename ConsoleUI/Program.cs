using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles







            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, 
             * 
             * Set the properties values with object initializer syntax
             */

            Car car1 = new Car()
            {
                Year = 1980,
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true,
            };

            Motorcycle motorcycle1 = new Motorcycle()
            {
                Year = 2500,
                Make = "Super",
                Model = "Go Fast",
                HasSideCar = true,
            };

            //and then 2 instances of type Vehicle(use explicit typing) but use constuctors from derived classes

            Vehicle vehicle1 = new Car
            {
                Year = 1750,
                Make = "Stage Coach",
                Model = "Premium",
                HasTrunk = false,
            };

            Vehicle vehicle2 = new Motorcycle
            {
                Year = 3000,
                Make = "TwoWheel",
                Model = "Monster",
                HasSideCar = false,
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>() { car1, motorcycle1, vehicle1, vehicle2 };
            // Iterate through the list and display each of the properties
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");

                // Check if the vehicle is a Car and display its unique property
                if (vehicle is Car car)
                {
                    Console.WriteLine($"Has Trunk: {car.HasTrunk}");
                }
                // Check if the vehicle is a Motorcycle and display its unique property
                if (vehicle is Motorcycle motorcycle)
                {
                    Console.WriteLine($"Has SideCart: {motorcycle.HasSideCar}");
                }

                // Call each of the drive methods for one car and one motorcycle
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();

            }
                #endregion
                Console.ReadLine();
        }
    }
}
